using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Interfaces
{
    public partial class OrderPaymentService : Form
    {
        private UserInterface _userInterface;

        public OrderPaymentService(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }
    }
}
