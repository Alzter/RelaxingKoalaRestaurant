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
    public partial class ManageOrdersInterface : Form
    {
        private DeliverOrdersInterface _deliverOrdersI;

        public ManageOrdersInterface(DeliverOrdersInterface deliverOrdersI)
        {
            InitializeComponent();
            _deliverOrdersI = deliverOrdersI;
        }

        private void BtnMarkAsDelivered_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _deliverOrdersI.Show();
        }
    }
}
