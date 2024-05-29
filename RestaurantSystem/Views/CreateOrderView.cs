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
    public partial class CreateOrderView : Form
    {
        private UserInterface _userInterface;

        public CreateOrderView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        // Return to WaitStaff Interface
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
