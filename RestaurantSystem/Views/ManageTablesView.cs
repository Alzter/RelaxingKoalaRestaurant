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
    public partial class ManageTablesView : Form
    {
        private UserInterface _userInterface;

        public ManageTablesView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        // Return to WaitStaff Interface
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        private void ListBTables_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnEmpty_Click(object sender, EventArgs e)
        {

        }

        private void BtnOccupied_Click(object sender, EventArgs e)
        {

        }

        private void BtnNeedsCleaning_Click(object sender, EventArgs e)
        {

        }

        private void BtnReserved_Click(object sender, EventArgs e)
        {

        }
    }
}
