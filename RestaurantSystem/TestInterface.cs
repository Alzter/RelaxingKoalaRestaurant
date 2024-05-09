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
    public partial class TestInterface : Form
    {
        private WaitStaffInterface _waitStaffI;
        private KitchenInterface _kitchenI;
        private DeliveryInterface _deliveryI;
        private CustomerInterface _customerI;

        public TestInterface()
        {
            InitializeComponent();
            _waitStaffI = new WaitStaffInterface();
            _kitchenI = new KitchenInterface();
            _deliveryI = new DeliveryInterface();
            _customerI = new CustomerInterface();
        }

        private void WaitStaffInterface_Click(object sender, EventArgs e)
        {
            this.Hide();
            _waitStaffI.Show();
        }

        private void CustomerInterface_Click(object sender, EventArgs e)
        {
            this.Hide();
            _customerI.Show();
        }

        private void DeliveryInterface_Click(object sender, EventArgs e)
        {
            this.Hide();
            _deliveryI.Show();
        }

        private void KitchenInterface_Click(object sender, EventArgs e)
        {
            this.Hide();
            _kitchenI.Show();
        }
    }
}
