namespace RestaurantSystem
{
    partial class ManageOrdersView
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
            BtnHandlePayment = new Button();
            TxtCost = new Label();
            ListBOrders = new ListBox();
            BtnWaiting = new Button();
            TxtOrders = new Label();
            TxtSelected = new Label();
            TxtBSelected = new TextBox();
            TxtUpdateStatus = new Label();
            BtnInProgress = new Button();
            BtnReady = new Button();
            BtnServed = new Button();
            ListBOrderDetails = new ListBox();
            BtnBack = new Button();
            TxtBStatus = new TextBox();
            TxtStatus = new Label();
            TxtBTotal = new TextBox();
            TxtTotal = new Label();
            SuspendLayout();
            // 
            // BtnHandlePayment
            // 
            BtnHandlePayment.Location = new Point(455, 638);
            BtnHandlePayment.Name = "BtnHandlePayment";
            BtnHandlePayment.Size = new Size(129, 56);
            BtnHandlePayment.TabIndex = 3;
            BtnHandlePayment.Text = "Handle Payment";
            BtnHandlePayment.UseVisualStyleBackColor = true;
            BtnHandlePayment.Click += BtnHandlePayment_Click;
            // 
            // TxtCost
            // 
            TxtCost.AutoSize = true;
            TxtCost.Location = new Point(409, 320);
            TxtCost.Name = "TxtCost";
            TxtCost.Size = new Size(0, 15);
            TxtCost.TabIndex = 6;
            // 
            // ListBOrders
            // 
            ListBOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBOrders.FormattingEnabled = true;
            ListBOrders.ItemHeight = 21;
            ListBOrders.Items.AddRange(new object[] { "Order 56 - Table 5 - Waiting", "Order 57 - Table 10 - Ready", "Order 58 - Table 3 - Served" });
            ListBOrders.Location = new Point(35, 68);
            ListBOrders.Name = "ListBOrders";
            ListBOrders.ScrollAlwaysVisible = true;
            ListBOrders.Size = new Size(264, 550);
            ListBOrders.TabIndex = 7;
            ListBOrders.SelectedIndexChanged += ListBOrders_SelectedIndexChanged;
            // 
            // BtnWaiting
            // 
            BtnWaiting.Location = new Point(532, 425);
            BtnWaiting.Name = "BtnWaiting";
            BtnWaiting.Size = new Size(116, 51);
            BtnWaiting.TabIndex = 8;
            BtnWaiting.Text = "Waiting";
            BtnWaiting.UseVisualStyleBackColor = true;
            BtnWaiting.Click += BtnWaiting_Click;
            // 
            // TxtOrders
            // 
            TxtOrders.AutoSize = true;
            TxtOrders.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOrders.Location = new Point(121, 19);
            TxtOrders.Name = "TxtOrders";
            TxtOrders.Size = new Size(85, 32);
            TxtOrders.TabIndex = 11;
            TxtOrders.Text = "Orders";
            // 
            // TxtSelected
            // 
            TxtSelected.AutoSize = true;
            TxtSelected.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSelected.Location = new Point(371, 18);
            TxtSelected.Name = "TxtSelected";
            TxtSelected.Size = new Size(178, 32);
            TxtSelected.TabIndex = 12;
            TxtSelected.Text = "Order Selected:";
            // 
            // TxtBSelected
            // 
            TxtBSelected.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBSelected.Location = new Point(559, 17);
            TxtBSelected.Name = "TxtBSelected";
            TxtBSelected.ReadOnly = true;
            TxtBSelected.Size = new Size(100, 39);
            TxtBSelected.TabIndex = 13;
            // 
            // TxtUpdateStatus
            // 
            TxtUpdateStatus.AutoSize = true;
            TxtUpdateStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUpdateStatus.Location = new Point(520, 302);
            TxtUpdateStatus.Name = "TxtUpdateStatus";
            TxtUpdateStatus.Size = new Size(106, 21);
            TxtUpdateStatus.TabIndex = 14;
            TxtUpdateStatus.Text = "Update Status";
            // 
            // BtnInProgress
            // 
            BtnInProgress.Location = new Point(384, 425);
            BtnInProgress.Name = "BtnInProgress";
            BtnInProgress.Size = new Size(116, 51);
            BtnInProgress.TabIndex = 15;
            BtnInProgress.Text = "In Progress";
            BtnInProgress.UseVisualStyleBackColor = true;
            BtnInProgress.Click += BtnInProgress_Click;
            // 
            // BtnReady
            // 
            BtnReady.Location = new Point(386, 488);
            BtnReady.Name = "BtnReady";
            BtnReady.Size = new Size(114, 51);
            BtnReady.TabIndex = 16;
            BtnReady.Text = "Ready";
            BtnReady.UseVisualStyleBackColor = true;
            BtnReady.Click += BtnReady_Click;
            // 
            // BtnServed
            // 
            BtnServed.Location = new Point(532, 488);
            BtnServed.Name = "BtnServed";
            BtnServed.Size = new Size(116, 51);
            BtnServed.TabIndex = 17;
            BtnServed.Text = "Served";
            BtnServed.UseVisualStyleBackColor = true;
            BtnServed.Click += BtnServed_Click;
            // 
            // ListBOrderDetails
            // 
            ListBOrderDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBOrderDetails.FormattingEnabled = true;
            ListBOrderDetails.ItemHeight = 21;
            ListBOrderDetails.Items.AddRange(new object[] { "Pizza - $12", "Chips - $5", "Soda - $3" });
            ListBOrderDetails.Location = new Point(340, 68);
            ListBOrderDetails.Name = "ListBOrderDetails";
            ListBOrderDetails.ScrollAlwaysVisible = true;
            ListBOrderDetails.Size = new Size(368, 277);
            ListBOrderDetails.TabIndex = 19;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 684);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(81, 22);
            BtnBack.TabIndex = 20;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // TxtBStatus
            // 
            TxtBStatus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBStatus.Location = new Point(534, 366);
            TxtBStatus.Name = "TxtBStatus";
            TxtBStatus.ReadOnly = true;
            TxtBStatus.Size = new Size(135, 39);
            TxtBStatus.TabIndex = 22;
            // 
            // TxtStatus
            // 
            TxtStatus.AutoSize = true;
            TxtStatus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtStatus.Location = new Point(367, 369);
            TxtStatus.Name = "TxtStatus";
            TxtStatus.Size = new Size(151, 32);
            TxtStatus.TabIndex = 21;
            TxtStatus.Text = "Order Status:";
            // 
            // TxtBTotal
            // 
            TxtBTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBTotal.Location = new Point(520, 576);
            TxtBTotal.Name = "TxtBTotal";
            TxtBTotal.ReadOnly = true;
            TxtBTotal.Size = new Size(152, 39);
            TxtBTotal.TabIndex = 24;
            // 
            // TxtTotal
            // 
            TxtTotal.AutoSize = true;
            TxtTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotal.Location = new Point(367, 579);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(138, 32);
            TxtTotal.TabIndex = 23;
            TxtTotal.Text = "Order Total:";
            // 
            // ManageOrdersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 716);
            Controls.Add(TxtBTotal);
            Controls.Add(TxtTotal);
            Controls.Add(TxtBStatus);
            Controls.Add(TxtStatus);
            Controls.Add(BtnBack);
            Controls.Add(ListBOrderDetails);
            Controls.Add(BtnServed);
            Controls.Add(BtnReady);
            Controls.Add(BtnInProgress);
            Controls.Add(TxtUpdateStatus);
            Controls.Add(TxtBSelected);
            Controls.Add(TxtSelected);
            Controls.Add(TxtOrders);
            Controls.Add(BtnWaiting);
            Controls.Add(ListBOrders);
            Controls.Add(TxtCost);
            Controls.Add(BtnHandlePayment);
            Name = "ManageOrdersView";
            Text = "Manage Orders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnHandlePayment;
        private Label TxtCost;
        private ListBox ListBOrders;
        private Button BtnWaiting;
        private Label TxtOrders;
        private Label TxtSelected;
        private TextBox TxtBSelected;
        private Label TxtUpdateStatus;
        private Button BtnInProgress;
        private Button BtnReady;
        private Button BtnServed;
        private ListBox ListBOrderDetails;
        private Button BtnBack;
        private TextBox TxtBStatus;
        private Label TxtStatus;
        private TextBox TxtBTotal;
        private Label TxtTotal;
    }
}