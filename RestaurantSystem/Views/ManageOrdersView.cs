using System;
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

        public ManageOrdersView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
            this.Activated += ManageOrdersView_Shown;

            OrderStatusBox.DataSource = OrderStatusStrings;
            //this.Deactivate += CreateOrderView_Hidden;
        }

        private List<Order> Orders
        {
            get
            {
                return WaitStaffServiceInterface.Orders;
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
                return Orders[ListBOrders.SelectedIndex];
            }
        }

        private List<MenuItem> SelectedOrderItems { get { return SelectedOrder.Items; } }
        private List<String> SelectedOrderItemStrings
        {
            get
            {
                List<String> strings = new List<String>();
                foreach (MenuItem m in SelectedOrderItems)
                {
                    strings.Add(m.ToString());
                }
                return strings;
            }
        }

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

        public void ManageOrdersView_Shown(object sender, EventArgs e)
        {
            UpdateListBOrders();
        }

        public void UpdateListBOrders()
        {
            ListBOrders.DataSource = OrderStrings;
        }

        // Go to previous View
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        // Go to PaymentView
        private void BtnHandlePayment_Click(object sender, EventArgs e)
        {
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

            // Update ComboBox to show Order Status
            //OrderStatusBox.

            // Update TextBox to show Order Price Total
        }

        // Change order selected's status to InProgress
        private void BtnInProgress_Click(object sender, EventArgs e)
        {
            //_orderSelected.Status = OrderStatus.InProgress;
        }

        // Change order selected's status to Waiting
        private void BtnWaiting_Click(object sender, EventArgs e)
        {
            //_orderSelected.Status = OrderStatus.Waiting;
        }

        // Change order selected's status to Ready
        private void BtnReady_Click(object sender, EventArgs e)
        {
            //_orderSelected.Status = OrderStatus.Ready;
        }

        // Change order selected's status to Served
        private void BtnServed_Click(object sender, EventArgs e)
        {
            //_orderSelected.Status = OrderStatus.Served;
        }

        private void TxtTotal_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
