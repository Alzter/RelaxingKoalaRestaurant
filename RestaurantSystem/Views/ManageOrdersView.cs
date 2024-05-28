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

        private void BtnMarkAsDelivered_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        private void ListBMenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnHandlePayment_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PushState(_userInterface.StateFactory.PaymentView);
        }

        private void BtnInProgress_Click(object sender, EventArgs e)
        {

        }
    }
}
