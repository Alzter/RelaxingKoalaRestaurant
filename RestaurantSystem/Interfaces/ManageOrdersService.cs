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
    public partial class ManageOrdersService : Form
    {
        private UserInterface _userInterface;
        private string _order; // TEST

        public ManageOrdersService(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        public string Order
        {
            get { return _order; }
            set
            {
                _order = value;
                ListBMenuItems.Items.Clear();
                ListBMenuItems.Items.Add(_order);
            }
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
            _userInterface.StateMachine.PushState(_userInterface.StateFactory.OrderPaymentService);
        }
    }
}
