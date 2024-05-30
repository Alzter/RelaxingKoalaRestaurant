﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class ManageTablesView : Form
    {
        private UserInterface _userInterface;

        private Table _table;

        private int? TableNumber {
            get {
                if (_table == null) return null;
                return _table.Number;
            }
        }

        private List<String> TableStrings
        {
            get
            {
                List<String> tableStrings = new List<String>();

                List<Table> tables = WaitStaffServiceInterface.Tables;

                foreach (Table t in tables)
                {
                    string status = t.Status.ToString();
                    string tableNum = t.Number.ToString();
                    tableStrings.Add($"{tableNum}: {status}");
                }

                return tableStrings;
            }
        }

        public ManageTablesView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
            ListBTables.DataSource = TableStrings;
        }

        // Return to WaitStaff Interface
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        // On Table selection change
        private void ListBTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ListBTables.SelectedIndex;
            _table = WaitStaffServiceInterface.Tables[index];

            UpdateSelectedTable();
            // Console.WriteLine(TableNumber);
            // Console.WriteLine(_table.Status);
        }

        private void UpdateSelectedTable()
        {
            if (_table != null)
            {
                TxtBSelected.Text = TableNumber.ToString();
                TxtBStatus.Text = _table.Status.ToString();
            }
        }

        // Update Table Status to Empty
        private void BtnEmpty_Click(object sender, EventArgs e)
        {
            UpdateTableStatus(TableNumber, TableStatus.Empty);
        }

        // Update Table Status to Occupied
        private void BtnOccupied_Click(object sender, EventArgs e)
        {
            UpdateTableStatus(TableNumber, TableStatus.Occupied);
        }

        // Update Table Status to NeedsCleaning
        private void BtnNeedsCleaning_Click(object sender, EventArgs e)
        {
            UpdateTableStatus(TableNumber, TableStatus.NeedsCleaning);
        }

        // Update Table Status to Reserved
        private void BtnReserved_Click(object sender, EventArgs e)
        {
            UpdateTableStatus(TableNumber, TableStatus.Reserved);
        }

        private void UpdateTableStatus(int? tableNumber, TableStatus status)
        {
            int index = ListBTables.SelectedIndex;
            if (tableNumber != null) { WaitStaffServiceInterface.UpdateTableStatus((int)tableNumber, status); }
            ListBTables.DataSource = TableStrings;
            ListBTables.SelectedIndex = index;
            UpdateSelectedTable();
        }
    }
}
