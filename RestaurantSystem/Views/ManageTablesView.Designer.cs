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
            TxtStatus = new Label();
            TableStatusBox = new ComboBox();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(13, 472);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(85, 29);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // ListBTables
            // 
            ListBTables.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ListBTables.FormattingEnabled = true;
            ListBTables.ItemHeight = 20;
            ListBTables.Items.AddRange(new object[] { "Table 1 - Empty", "Table 2 - Needs Cleaning", "Table 3 - Reserved", "Table 4 - Occupied" });
            ListBTables.Location = new Point(14, 75);
            ListBTables.Margin = new Padding(3, 4, 3, 4);
            ListBTables.Name = "ListBTables";
            ListBTables.ScrollAlwaysVisible = true;
            ListBTables.Size = new Size(286, 364);
            ListBTables.TabIndex = 2;
            ListBTables.SelectedIndexChanged += ListBTables_SelectedIndexChanged;
            // 
            // TxtTables
            // 
            TxtTables.AutoSize = true;
            TxtTables.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTables.Location = new Point(107, 12);
            TxtTables.Name = "TxtTables";
            TxtTables.Size = new Size(100, 41);
            TxtTables.TabIndex = 3;
            TxtTables.Text = "Tables";
            // 
            // TxtSelected
            // 
            TxtSelected.AutoSize = true;
            TxtSelected.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSelected.Location = new Point(306, 75);
            TxtSelected.Name = "TxtSelected";
            TxtSelected.Size = new Size(215, 41);
            TxtSelected.TabIndex = 4;
            TxtSelected.Text = "Table Selected:";
            // 
            // TxtBSelected
            // 
            TxtBSelected.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBSelected.Location = new Point(543, 75);
            TxtBSelected.Margin = new Padding(3, 4, 3, 4);
            TxtBSelected.Name = "TxtBSelected";
            TxtBSelected.ReadOnly = true;
            TxtBSelected.Size = new Size(114, 47);
            TxtBSelected.TabIndex = 14;
            // 
            // TxtStatus
            // 
            TxtStatus.AutoSize = true;
            TxtStatus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtStatus.Location = new Point(306, 161);
            TxtStatus.Name = "TxtStatus";
            TxtStatus.Size = new Size(182, 41);
            TxtStatus.TabIndex = 27;
            TxtStatus.Text = "Table Status:";
            // 
            // TableStatusBox
            // 
            TableStatusBox.FormattingEnabled = true;
            TableStatusBox.Location = new Point(506, 171);
            TableStatusBox.Name = "TableStatusBox";
            TableStatusBox.Size = new Size(151, 28);
            TableStatusBox.TabIndex = 28;
            TableStatusBox.SelectedIndexChanged += TableStatusBox_SelectedIndexChanged;
            // 
            // ManageTablesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(705, 515);
            Controls.Add(TableStatusBox);
            Controls.Add(TxtStatus);
            Controls.Add(TxtBSelected);
            Controls.Add(TxtSelected);
            Controls.Add(TxtTables);
            Controls.Add(ListBTables);
            Controls.Add(BtnBack);
            Margin = new Padding(3, 4, 3, 4);
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
        private Label TxtStatus;
        private ComboBox TableStatusBox;
    }
}