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
    public partial class DeliveryInterface : Form
    {
        private TestInterface _testI;

        public DeliveryInterface(TestInterface testI)
        {
            InitializeComponent();
            _testI = testI;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            _testI.Show();
        }
    }
}
