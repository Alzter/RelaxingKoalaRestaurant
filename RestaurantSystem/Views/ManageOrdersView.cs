﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class ManageOrdersView : Form
    {
        private UserInterface _userInterface;
        private OrderStatus? _statusFilter;

        public ManageOrdersView(UserInterface userInterface)
        {
            _statusFilter = null;
            InitializeComponent();
            _userInterface = userInterface;
            this.Activated += ManageOrdersView_Shown;

            OrderStatusBox.DataSource = OrderStatusStrings;
            StatusFilterBox.DataSource = OrderFilterStatusStrings;
            //this.Deactivate += CreateOrderView_Hidden;
        }

        private List<Order> Orders
        {
            get
            {
                if (_statusFilter == null) { return WaitStaffServiceInterface.Orders; }
                else
                {
                    return WaitStaffServiceInterface.GetOrdersByStatus((OrderStatus)_statusFilter);
                }

            }
        }

        private List<String> OrderStrings
        {
            get
            {
                List<String> strings = new List<String>();

                foreach (Order o in Orders)
                {
                    strings.Add($"Order {o.ID} - Table {o.TableNumber} - {o.Status.ToString()}");
                }

                return strings;
            }
        }

        private Order SelectedOrder
        {
            get
            {
                if (ListBOrders.SelectedIndex == -1) return null;
                return Orders[ListBOrders.SelectedIndex];
            }
        }

        private List<MenuItem> SelectedOrderItems { get { return SelectedOrder == null ? null : SelectedOrder.Items; } }

        private MenuItem SelectedOrderItem { get { return SelectedOrderItems == null ? null : SelectedOrderItems[ListBOrderItems.SelectedIndex]; } }

        private List<String> SelectedOrderItemIngredients
        {
            get
            {
                if (SelectedOrderItem == null) return new List<String>();
                else
                {
                    List<String> ingredients = new List<String>();
                    foreach (Ingredient i in SelectedOrderItem.Ingredients)
                    {
                        ingredients.Add(i.Name);
                    }
                    return ingredients;
                }
            }
        }

        private List<String> SelectedOrderItemStrings
        {
            get
            {
                List<String> strings = new List<String>();
                foreach (MenuItem m in SelectedOrderItems)
                {
                    strings.Add($"{m.ToString()}: {m.Price.ToString("C")}");
                }
                return strings;
            }
        }

        private String SelectedOrderPrice { get { return SelectedOrder == null ? null : SelectedOrder.Price.ToString("C"); } }

        private List<String> OrderStatusStrings
        {
            get
            {
                List<OrderStatus> statuses = Enum.GetValues(typeof(OrderStatus)).Cast<OrderStatus>().ToList();
                List<String> strings = new List<String>();
                foreach (OrderStatus o in statuses)
                {
                    strings.Add(o.ToString());
                }
                return strings;
            }
        }

        private List<String> OrderFilterStatusStrings // Fuck you C#. Perish
        {
            get
            {
                List<OrderStatus> statuses = Enum.GetValues(typeof(OrderStatus)).Cast<OrderStatus>().ToList();
                List<String> strings = new List<String>() { "All" };
                foreach (OrderStatus o in statuses)
                {
                    strings.Add(o.ToString());
                }
                return strings;
            }
        }

        public void ManageOrdersView_Shown(object sender, EventArgs e)
        {
            UpdateListBOrders();
        }

        public void UpdateListBOrders()
        {
            int index = ListBOrders.SelectedIndex;
            ListBOrders.DataSource = OrderStrings;

            int newIndex = Math.Clamp(index, 0, Math.Max(0, ListBOrders.Items.Count - 1));

            if (ListBOrders.Items.Count != 0) ListBOrders.SelectedIndex = newIndex;

        }

        private void UpdateListBItemIngredients()
        {
            ListBItemIngredients.DataSource = SelectedOrderItemIngredients;
            ListBItemIngredients.SelectedItem = null;
        }

        // Go to previous View
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        // Go to PaymentView
        private void BtnHandlePayment_Click(object sender, EventArgs e)
        {
            _userInterface.StateFactory.PaymentView.ReceiveOrder(SelectedOrder);
            _userInterface.StateMachine.PushState(_userInterface.StateFactory.PaymentView);
            // Somehow need to make sure payment view has the order selected
        }

        // On order selected change event (when list item is clicked)
        private void ListBOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update TextBox to show order ID selected:
            TxtBSelected.Text = SelectedOrder.ID.ToString();

            // Update the ListBox to show the MenuItems in the Order
            ListBOrderItems.DataSource = SelectedOrderItemStrings;

            // Update Order Status Combo Box to have the selected Order's status.
            OrderStatusBox.SelectedIndex = (int)SelectedOrder.Status;

            // Update TextBox to show Order Price Total
            TxtBTotal.Text = SelectedOrderPrice;

            OrderStatusBox.Enabled = !SelectedOrder.IsPaid;
            BtnHandlePayment.Enabled = !SelectedOrder.IsPaid;

            TxtBCreationTime.Text = SelectedOrder.CreationTimeString;


            UpdateOrderETA();
            UpdateListBItemIngredients();
        }

        private void UpdateOrderETA()
        {

            if (SelectedOrder == null) return;

            int etaMins = SelectedOrder.EstimatedCompletionTimeInMinutes;

            ETABox.Enabled = SelectedOrder.Status == OrderStatus.InProgress && !SelectedOrder.IsPaid;
            ETABox.Value = Math.Clamp(etaMins, ETABox.Minimum, ETABox.Maximum);

            UpdateOrderCompletionTime();
        }

        private void UpdateOrderCompletionTime()
        {
            if (SelectedOrder == null) return;

            if (SelectedOrder.CompletionTime != null)
            {
                TxtCompletionTime.Text = "Completion Time:";
                TxtBCompletionTime.Text = SelectedOrder.CompletionTimeString;
            }
            else if (SelectedOrder.EstimatedCompletionTimeInMinutes > 0)
            {
                TxtCompletionTime.Text = "ETA:";
                TxtBCompletionTime.Text = SelectedOrder.EstimatedCompletionTimeString;
            }
            else
            {
                TxtCompletionTime.Text = "";
                TxtBCompletionTime.Text = "";
            }
        }


        private void OrderStatusBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedOrder == null) return;

            int index = OrderStatusBox.SelectedIndex;
            OrderStatus selectedStatus = (OrderStatus)index;

            // Do nothing if the Order Status of the Order is equal to the Order Status of the Combo Box.
            if (SelectedOrder.Status == selectedStatus) return;

            // Change the status of the order to the selected status.
            WaitStaffServiceInterface.SetOrderStatus(SelectedOrder, selectedStatus);
            UpdateListBOrders();
        }

        private void StatusFilterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = StatusFilterBox.SelectedIndex;

            if (index == 0) { _statusFilter = null; }
            else
            {
                _statusFilter = (OrderStatus)index - 1;
            }

            UpdateListBOrders();
        }

        private void BtnCancelOrder_Click(object sender, EventArgs e)
        {
            if (SelectedOrder != null)
            {
                WaitStaffServiceInterface.RemoveOrderFromQueue(SelectedOrder);
                UpdateListBOrders();
            }
        }

        private void ETABox_ValueChanged(object sender, EventArgs e)
        {

            if (SelectedOrder != null)
            {
                WaitStaffServiceInterface.SetOrderETA(SelectedOrder, (int)ETABox.Value);
                UpdateOrderETA();
            }
        }

        private void ListBOrderItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateListBItemIngredients();
        }

        private void TxtBTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotal_Click(object sender, EventArgs e)
        {
        }

        private void TxtCompletionTime_Click(object sender, EventArgs e)
        {
        }

        private void TxtCreationTime_Click(object sender, EventArgs e)
        {
        }
    }
}
