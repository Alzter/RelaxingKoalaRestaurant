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
    public partial class WaitStaffInterface : Form
    {
        private TestInterface _testI;
        private ManageTablesInterface _manageTablesI;
        private DeliverOrdersInterface _deliveryOrdersI;
        private CreateOrdersInterface _createOrdersI;

        public WaitStaffInterface(TestInterface testI)
        {
            _testI = testI;
            InitializeComponent();
            _manageTablesI = new ManageTablesInterface(this);
            _deliveryOrdersI = new DeliverOrdersInterface(this);
            _createOrdersI = new CreateOrdersInterface(this);
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            _testI.Show();
        }

        private void BtnCreateOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            _createOrdersI.Show();
        }

        private void BtnDeliverOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            _deliveryOrdersI.Show();
        }

        private void BtnManageTables_Click(object sender, EventArgs e)
        {
            this.Hide();
            _manageTablesI.Show();
        }
    }
}
