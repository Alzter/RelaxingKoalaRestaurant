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
    public partial class RestaurantService : Form
    {
        private UserInterface _userInterface;

        public RestaurantService(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        // Go to WaitStaff Interface
        private void WaitStaffInterface_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CWaitStaff);
        }

        // Go to Customer Interface
        private void CustomerInterface_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CCustomer);
        }

        // Go to Delivery Interface
        private void DeliveryInterface_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CDelivery);
        }

        // Go to Kitchen Interface
        private void KitchenInterface_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CKitchen);
        }
    }
}
