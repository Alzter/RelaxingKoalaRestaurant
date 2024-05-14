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
        private string _order; // TEST

        public ManageOrdersInterface(DeliverOrdersInterface deliverOrdersI)
        {
            InitializeComponent();
            _deliverOrdersI = deliverOrdersI;
        }

        public string Order
        {
            get { return _order; }
            set
            { 
                _order = value;
                ListBMenuItems.Items.Clear();
                ListBMenuItems.Items.Add(_order);
            }
        }

        private void BtnMarkAsDelivered_Click(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            _deliverOrdersI.Show();
        }

        private void ListBMenuItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
