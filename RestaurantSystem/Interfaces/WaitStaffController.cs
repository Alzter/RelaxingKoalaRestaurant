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
    public partial class WaitStaffController : Form
    {
        private UserInterface _userInterface;

        public WaitStaffController(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        // Return to Restaurant Interface
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CRestaurant);
        }

        // Go to CreateOrders Interface
        private void BtnCreateOrders_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CCreateOrders);
        }

        // Go to DeliverOrders Interface
        private void BtnDeliverOrders_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CDeliverOrders);
        }

        // Go to ManageTables Interface
        private void BtnManageTables_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CManageTables);
        }
    }
}
