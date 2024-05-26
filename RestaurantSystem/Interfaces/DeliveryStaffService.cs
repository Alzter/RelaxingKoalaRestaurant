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
    public partial class DeliveryStaffService : Form
    {
        private UserInterface _userInterface;

        public DeliveryStaffService(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        // Return to Restaurant Interface
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.ChangeState(_userInterface.StateFactory.CRestaurant);
        }
    }
}
