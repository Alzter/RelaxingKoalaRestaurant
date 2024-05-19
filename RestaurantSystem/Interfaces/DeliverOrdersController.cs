using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class DeliverOrdersController : Form
    {
        private UserInterface _userInterface;

        public DeliverOrdersController(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        // Return to WaitStaff Interface
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CWaitStaff);
        }

        // Go to ManageOrders Interface of selected order
        private void ListBOrdersReady_SelectedIndexChanged(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CManageOrders);
        }
    }
}
