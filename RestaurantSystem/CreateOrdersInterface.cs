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
    public partial class CreateOrdersInterface : Form
    {
        private WaitStaffInterface _waitStaffI;

        public CreateOrdersInterface(WaitStaffInterface waitStaffI)
        {
            InitializeComponent();
            _waitStaffI = waitStaffI;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _waitStaffI.Show();
        }
    }
}
