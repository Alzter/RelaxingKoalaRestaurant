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
    public partial class PaymentView : Form
    {
        private UserInterface _userInterface;

        public PaymentView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        // Go back to ManageOrders View
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        // Payment connection to a bank
        private void BtnPay_Click(object sender, EventArgs e)
        {

        }

        // Print receipt
        private void BtnReceipt_Click(object sender, EventArgs e)
        {

        }
    }
}
