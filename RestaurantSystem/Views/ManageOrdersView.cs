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

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        private void BtnHandlePayment_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PushState(_userInterface.StateFactory.PaymentView);
        }

        private void ListBOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnInProgress_Click(object sender, EventArgs e)
        {

        }

        private void BtnWaiting_Click(object sender, EventArgs e)
        {

        }

        private void BtnReady_Click(object sender, EventArgs e)
        {

        }

        private void BtnServed_Click(object sender, EventArgs e)
        {

        }
    }
}
