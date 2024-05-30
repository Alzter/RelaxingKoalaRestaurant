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

        public CreateReservationView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        // Update booking name
        private void TxtBName_TextChanged(object sender, EventArgs e)
        {
            //_name = TxtBName.Text;
        }

        // Update number of guests
        private void NumGuests_ValueChanged(object sender, EventArgs e)
        {
            // Cast from Decimal to Int
            //_numGuests = (int)NumGuests.Value;
        }

        // Update time selected
        private void DateTimeSelection_ValueChanged(object sender, EventArgs e)
        {
            // This is just the time, date not included. Is a DateTime obj though
            //_time = DateTimeSelection.Value;
        }

        // Update date selected
        private void CalendarBooking_DateChanged(object sender, DateRangeEventArgs e)
        {
            // This is just the date, time not included. Is a DateTime obj though
            //_date = CalendarBooking.SelectionStart;
        }
    }
}
