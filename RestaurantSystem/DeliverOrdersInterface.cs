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
        private ManageOrdersInterface _manageOrdersI;

        public DeliverOrdersInterface(WaitStaffInterface waitStaffI)
        {
            InitializeComponent();
            _waitStaffI = waitStaffI;
            _manageOrdersI = new ManageOrdersInterface(this);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _waitStaffI.Show();
        }

        private void ListBOrdersReady_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Hide();
            _manageOrdersI.Show();
        }
    }
}
