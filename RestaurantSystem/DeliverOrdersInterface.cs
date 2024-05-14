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
    public partial class DeliverOrdersInterface : Form
    {
        private WaitStaffInterface _waitStaffI;

        public DeliverOrdersInterface(WaitStaffInterface waitStaffI)
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
