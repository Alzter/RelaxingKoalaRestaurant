namespace RestaurantSystem.Interfaces
{
    partial class CreateReservationView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnBack = new Button();
            CalendarBooking = new MonthCalendar();
            DateTimeSelection = new DateTimePicker();
            BtnCreateReservation = new Button();
            NumGuests = new NumericUpDown();
            TxtGuests = new Label();
            TxtName = new Label();
            TxtBName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)NumGuests).BeginInit();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 400);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(70, 22);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // CalendarBooking
            // 
            CalendarBooking.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CalendarBooking.Location = new Point(126, 28);
            CalendarBooking.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            CalendarBooking.MaxSelectionCount = 1;
            CalendarBooking.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            CalendarBooking.Name = "CalendarBooking";
            CalendarBooking.TabIndex = 4;
            CalendarBooking.DateChanged += CalendarBooking_DateChanged;
            // 
            // DateTimeSelection
            // 
            DateTimeSelection.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimeSelection.Checked = false;
            DateTimeSelection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DateTimeSelection.Format = DateTimePickerFormat.Time;
            DateTimeSelection.Location = new Point(162, 202);
            DateTimeSelection.MaxDate = new DateTime(2050, 12, 31, 0, 0, 0, 0);
            DateTimeSelection.MinDate = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            DateTimeSelection.Name = "DateTimeSelection";
            DateTimeSelection.Size = new Size(163, 29);
            DateTimeSelection.TabIndex = 5;
            DateTimeSelection.ValueChanged += DateTimeSelection_ValueChanged;
            // 
            // BtnCreateReservation
            // 
            BtnCreateReservation.Location = new Point(180, 370);
            BtnCreateReservation.Name = "BtnCreateReservation";
            BtnCreateReservation.Size = new Size(120, 50);
            BtnCreateReservation.TabIndex = 6;
            BtnCreateReservation.Text = "Create Reservation";
            BtnCreateReservation.UseVisualStyleBackColor = true;
            // 
            // NumGuests
            // 
            NumGuests.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NumGuests.Location = new Point(233, 250);
            NumGuests.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            NumGuests.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            NumGuests.Name = "NumGuests";
            NumGuests.Size = new Size(120, 29);
            NumGuests.TabIndex = 7;
            NumGuests.Value = new decimal(new int[] { 1, 0, 0, 0 });
            NumGuests.ValueChanged += NumGuests_ValueChanged;
            // 
            // TxtGuests
            // 
            TxtGuests.AutoSize = true;
            TxtGuests.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtGuests.Location = new Point(126, 252);
            TxtGuests.Name = "TxtGuests";
            TxtGuests.Size = new Size(60, 21);
            TxtGuests.TabIndex = 8;
            TxtGuests.Text = "Guests:";
            // 
            // TxtName
            // 
            TxtName.AutoSize = true;
            TxtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtName.Location = new Point(86, 303);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(55, 21);
            TxtName.TabIndex = 9;
            TxtName.Text = "Name:";
            // 
            // TxtBName
            // 
            TxtBName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBName.Location = new Point(162, 300);
            TxtBName.Name = "TxtBName";
            TxtBName.Size = new Size(227, 29);
            TxtBName.TabIndex = 10;
            TxtBName.TextChanged += TxtBName_TextChanged;
            // 
            // CreateReservationView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 432);
            Controls.Add(TxtBName);
            Controls.Add(TxtName);
            Controls.Add(TxtGuests);
            Controls.Add(NumGuests);
            Controls.Add(BtnCreateReservation);
            Controls.Add(DateTimeSelection);
            Controls.Add(CalendarBooking);
            Controls.Add(BtnBack);
            Name = "CreateReservationView";
            Text = "Create Reservation";
            ((System.ComponentModel.ISupportInitialize)NumGuests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBack;
        private MonthCalendar CalendarBooking;
        private DateTimePicker DateTimeSelection;
        private Button BtnCreateReservation;
        private NumericUpDown NumGuests;
        private Label TxtGuests;
        private Label TxtName;
        private TextBox TxtBName;
    }
}