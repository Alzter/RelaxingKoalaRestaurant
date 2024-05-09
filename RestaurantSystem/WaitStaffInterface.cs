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

        public WaitStaffInterface(TestInterface testI)
        {
            _testI = testI;
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            _testI.Show();
        }
    }
}
