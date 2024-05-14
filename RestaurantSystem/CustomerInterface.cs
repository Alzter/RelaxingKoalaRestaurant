﻿using System;
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
    public partial class CustomerInterface : Form
    {
        private TestInterface _testI;

        public CustomerInterface(TestInterface testI)
        {
            InitializeComponent();
            _testI = testI;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            _testI.Show();
        }

        private void Menu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddToOrder_Click(object sender, EventArgs e)
        {
            ListBOrder.Items.Add(ListBMenu.SelectedItem);
        }

        private void BtnRemoveFromOrder_Click(object sender, EventArgs e)
        {
            ListBOrder.Items.Remove(ListBOrder.SelectedItem);
        }
    }
}
