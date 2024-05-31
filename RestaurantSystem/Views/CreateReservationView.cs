using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Interfaces
{
    public partial class CreateReservationView : Form
    {
        private UserInterface _userInterface;
        private string _name;
        private int _numGuests;
        private DateTime _dateTime;
        private DateTime _time;
        private DateTime _date;
        private int _tableNum;

        public CreateReservationView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
            _time = DateTimeSelection.Value;
            _date = CalendarBooking.SelectionStart;
            CombineDateTime();
            CalendarBooking.MinDate = DateTime.Now.Date;
            DateTimeSelection.MinDate = DateTime.Now;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        // Update booking name
        private void TxtBName_TextChanged(object sender, EventArgs e)
        {
            _name = TxtBName.Text;
        }

        // Update number of guests
        private void NumGuests_ValueChanged(object sender, EventArgs e)
        {
            // Cast from Decimal to Int
            _numGuests = (int)NumGuests.Value;
        }

        // Update time selected
        private void DateTimeSelection_ValueChanged(object sender, EventArgs e)
        {
            // This is just the time, date not included. Is a DateTime obj though
            _time = DateTimeSelection.Value;

            CombineDateTime();
        }

        // Update date selected
        private void CalendarBooking_DateChanged(object sender, DateRangeEventArgs e)
        {
            // This is just the date, time not included. Is a DateTime obj though
            _date = CalendarBooking.SelectionStart;

            CombineDateTime();
        }

        // Update table number selected (based on which table is free at that DateTime)
        private void CBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            _tableNum = (int)CBoxTable.SelectedItem;
        }

        private void CombineDateTime()
        {
            _dateTime = new DateTime(_date.Year, _date.Month, _date.Day, _time.Hour, _time.Minute, 0, 0);

            List<Table> tables = WaitStaffServiceInterface.GetFreeTables(_dateTime);
            
            List<int> tableNums = new List<int>();

            foreach (Table table in tables)
            {
                tableNums.Add(table.Number);
            }

            CBoxTable.DataSource = tableNums;

            // Disable create reservation button if booking is earlier than the current time
            BtnCreateReservation.Enabled = (DateTime.Compare(_dateTime, DateTime.Now) < 0) ? false : true;
        }

        // Create reservation with the details inputted
        private void BtnCreateReservation_Click(object sender, EventArgs e)
        {
            WaitStaffServiceInterface.AddReservation(_dateTime, 90, _tableNum, _name, _numGuests);
            _userInterface.StateMachine.PopState(); 
        }
    }
}
