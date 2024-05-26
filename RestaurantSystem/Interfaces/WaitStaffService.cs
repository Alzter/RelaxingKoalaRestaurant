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
    public partial class WaitStaffService : Form
    {
        private UserInterface _userInterface;

        public WaitStaffService(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        // Return to Restaurant UI
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.RestaurantService);
        }

        // Go to CreateOrder UI
        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CreateOrderService);
        }

        // Go to ManageOrders UI
        private void BtnManageOrders_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.ManageOrdersService);
        }

        // Go to CreateReservation UI
        private void BtnCreateReservation_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CreateReservationService);
        }

        // Go to ManageTables UI
        private void BtnManageTables_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.ManageTablesService);
        }
    }
}
