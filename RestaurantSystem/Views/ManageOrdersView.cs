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
            // To get the item selected:
            //_orderSelected = ListBOrders.SelectedItem;

            // Update TextBox to show order ID selected:
            //TxtBSelected.Text = _orderSelected.ID.ToString();

            // Update the ListBox to show the MenuItems in the Order
            //ListBOrderDetails.Items.AddRange(_orderSelected.MenuItems); 

            // Update TextBox to show Order Status
            //TxtBStatus.Text = _orderSelected.Status.ToString();

            // Update TextBox to show Order Price Total
            //TxtBTotal.Text = _orderSelected.Price.ToString();
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
    }
}
