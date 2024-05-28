namespace RestaurantSystem
{
    partial class ManageTablesView
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
            ListBTables = new ListBox();
            TxtTables = new Label();
            TxtSelected = new Label();
            TxtBSelected = new TextBox();
            TxtBStatus = new TextBox();
            TxtStatus = new Label();
            BtnReserved = new Button();
            BtnNeedsCleaning = new Button();
            BtnEmpty = new Button();
            BtnOccupied = new Button();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 354);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(74, 22);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // ListBTables
            // 
            ListBTables.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            ListBTables.FormattingEnabled = true;
            ListBTables.ItemHeight = 25;
            ListBTables.Items.AddRange(new object[] { "Table 1 - Empty", "Table 2 - Needs Cleaning", "Table 3 - Reserved", "Table 4 - Occupied" });
            ListBTables.Location = new Point(12, 56);
            ListBTables.Name = "ListBTables";
            ListBTables.ScrollAlwaysVisible = true;
            ListBTables.Size = new Size(251, 279);
            ListBTables.TabIndex = 2;
            // 
            // TxtTables
            // 
            TxtTables.AutoSize = true;
            TxtTables.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTables.Location = new Point(94, 9);
            TxtTables.Name = "TxtTables";
            TxtTables.Size = new Size(79, 32);
            TxtTables.TabIndex = 3;
            TxtTables.Text = "Tables";
            // 
            // TxtSelected
            // 
            TxtSelected.AutoSize = true;
            TxtSelected.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSelected.Location = new Point(285, 56);
            TxtSelected.Name = "TxtSelected";
            TxtSelected.Size = new Size(172, 32);
            TxtSelected.TabIndex = 4;
            TxtSelected.Text = "Table Selected:";
            // 
            // TxtBSelected
            // 
            TxtBSelected.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBSelected.Location = new Point(475, 56);
            TxtBSelected.Name = "TxtBSelected";
            TxtBSelected.Size = new Size(100, 39);
            TxtBSelected.TabIndex = 14;
            // 
            // TxtBStatus
            // 
            TxtBStatus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBStatus.Location = new Point(452, 141);
            TxtBStatus.Name = "TxtBStatus";
            TxtBStatus.Size = new Size(135, 39);
            TxtBStatus.TabIndex = 28;
            // 
            // TxtStatus
            // 
            TxtStatus.AutoSize = true;
            TxtStatus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtStatus.Location = new Point(285, 144);
            TxtStatus.Name = "TxtStatus";
            TxtStatus.Size = new Size(145, 32);
            TxtStatus.TabIndex = 27;
            TxtStatus.Text = "Table Status:";
            // 
            // BtnReserved
            // 
            BtnReserved.Location = new Point(452, 272);
            BtnReserved.Name = "BtnReserved";
            BtnReserved.Size = new Size(116, 51);
            BtnReserved.TabIndex = 26;
            BtnReserved.Text = "Reserved";
            BtnReserved.UseVisualStyleBackColor = true;
            // 
            // BtnNeedsCleaning
            // 
            BtnNeedsCleaning.Location = new Point(306, 272);
            BtnNeedsCleaning.Name = "BtnNeedsCleaning";
            BtnNeedsCleaning.Size = new Size(114, 51);
            BtnNeedsCleaning.TabIndex = 25;
            BtnNeedsCleaning.Text = "Needs Cleaning";
            BtnNeedsCleaning.UseVisualStyleBackColor = true;
            // 
            // BtnEmpty
            // 
            BtnEmpty.Location = new Point(304, 209);
            BtnEmpty.Name = "BtnEmpty";
            BtnEmpty.Size = new Size(116, 51);
            BtnEmpty.TabIndex = 24;
            BtnEmpty.Text = "Empty";
            BtnEmpty.UseVisualStyleBackColor = true;
            // 
            // BtnOccupied
            // 
            BtnOccupied.Location = new Point(452, 209);
            BtnOccupied.Name = "BtnOccupied";
            BtnOccupied.Size = new Size(116, 51);
            BtnOccupied.TabIndex = 23;
            BtnOccupied.Text = "Occupied";
            BtnOccupied.UseVisualStyleBackColor = true;
            // 
            // ManageTablesView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(617, 386);
            Controls.Add(TxtBStatus);
            Controls.Add(TxtStatus);
            Controls.Add(BtnReserved);
            Controls.Add(BtnNeedsCleaning);
            Controls.Add(BtnEmpty);
            Controls.Add(BtnOccupied);
            Controls.Add(TxtBSelected);
            Controls.Add(TxtSelected);
            Controls.Add(TxtTables);
            Controls.Add(ListBTables);
            Controls.Add(BtnBack);
            Name = "ManageTablesView";
            Text = "Manage Tables";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBack;
        private ListBox ListBTables;
        private Label TxtTables;
        private Label TxtSelected;
        private TextBox TxtBSelected;
        private TextBox TxtBStatus;
        private Label TxtStatus;
        private Button BtnReserved;
        private Button BtnNeedsCleaning;
        private Button BtnEmpty;
        private Button BtnOccupied;
    }
}