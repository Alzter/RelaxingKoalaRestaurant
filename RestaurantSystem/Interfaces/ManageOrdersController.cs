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
    public partial class ManageOrdersController : Form
    {
        private UserInterface _userInterface;
        private string _order; // TEST

        public ManageOrdersController(UserInterface userInterface)
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

        // Return to DeliverOrders Interface
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CDeliverOrders);
        }

        private void ListBMenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
