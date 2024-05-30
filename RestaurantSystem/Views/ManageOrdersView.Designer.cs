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
            TxtOrders = new Label();
            TxtSelected = new Label();
            TxtBSelected = new TextBox();
            TxtUpdateStatus = new Label();
            ListBOrderItems = new ListBox();
            BtnBack = new Button();
            TxtStatus = new Label();
            TxtBTotal = new TextBox();
            OrderStatusBox = new ComboBox();
            TxtTotal = new Label();
            TxtOrderItems = new Label();
            SuspendLayout();
            // 
            // BtnHandlePayment
            // 
            BtnHandlePayment.Location = new Point(389, 866);
            BtnHandlePayment.Margin = new Padding(3, 4, 3, 4);
            BtnHandlePayment.Name = "BtnHandlePayment";
            BtnHandlePayment.Size = new Size(420, 75);
            BtnHandlePayment.TabIndex = 3;
            BtnHandlePayment.Text = "Process Payment";
            BtnHandlePayment.UseVisualStyleBackColor = true;
            BtnHandlePayment.Click += BtnHandlePayment_Click;
            // 
            // TxtCost
            // 
            TxtCost.AutoSize = true;
            TxtCost.Location = new Point(467, 427);
            TxtCost.Name = "TxtCost";
            TxtCost.Size = new Size(0, 20);
            TxtCost.TabIndex = 6;
            // 
            // ListBOrders
            // 
            ListBOrders.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBOrders.FormattingEnabled = true;
            ListBOrders.ItemHeight = 28;
            ListBOrders.Items.AddRange(new object[] { "Order 56 - Table 5 - Waiting", "Order 57 - Table 10 - Ready", "Order 58 - Table 3 - Served" });
            ListBOrders.Location = new Point(40, 91);
            ListBOrders.Margin = new Padding(3, 4, 3, 4);
            ListBOrders.Name = "ListBOrders";
            ListBOrders.ScrollAlwaysVisible = true;
            ListBOrders.Size = new Size(301, 704);
            ListBOrders.TabIndex = 7;
            ListBOrders.SelectedIndexChanged += ListBOrders_SelectedIndexChanged;
            // 
            // TxtOrders
            // 
            TxtOrders.AutoSize = true;
            TxtOrders.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOrders.Location = new Point(139, 29);
            TxtOrders.Name = "TxtOrders";
            TxtOrders.Size = new Size(108, 41);
            TxtOrders.TabIndex = 11;
            TxtOrders.Text = "Orders";
            // 
            // TxtSelected
            // 
            TxtSelected.AutoSize = true;
            TxtSelected.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSelected.Location = new Point(389, 29);
            TxtSelected.Name = "TxtSelected";
            TxtSelected.Size = new Size(223, 41);
            TxtSelected.TabIndex = 12;
            TxtSelected.Text = "Order Selected:";
            // 
            // TxtBSelected
            // 
            TxtBSelected.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBSelected.Location = new Point(639, 29);
            TxtBSelected.Margin = new Padding(3, 4, 3, 4);
            TxtBSelected.Name = "TxtBSelected";
            TxtBSelected.ReadOnly = true;
            TxtBSelected.Size = new Size(173, 47);
            TxtBSelected.TabIndex = 13;
            // 
            // TxtUpdateStatus
            // 
            TxtUpdateStatus.AutoSize = true;
            TxtUpdateStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUpdateStatus.Location = new Point(653, 565);
            TxtUpdateStatus.Name = "TxtUpdateStatus";
            TxtUpdateStatus.Size = new Size(0, 28);
            TxtUpdateStatus.TabIndex = 14;
            // 
            // ListBOrderItems
            // 
            ListBOrderItems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBOrderItems.FormattingEnabled = true;
            ListBOrderItems.ItemHeight = 28;
            ListBOrderItems.Items.AddRange(new object[] { "Pizza - $12", "Chips - $5", "Soda - $3" });
            ListBOrderItems.Location = new Point(389, 225);
            ListBOrderItems.Margin = new Padding(3, 4, 3, 4);
            ListBOrderItems.Name = "ListBOrderItems";
            ListBOrderItems.ScrollAlwaysVisible = true;
            ListBOrderItems.Size = new Size(420, 508);
            ListBOrderItems.TabIndex = 19;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(13, 912);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(93, 29);
            BtnBack.TabIndex = 20;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // TxtStatus
            // 
            TxtStatus.AutoSize = true;
            TxtStatus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtStatus.Location = new Point(389, 91);
            TxtStatus.Name = "TxtStatus";
            TxtStatus.Size = new Size(190, 41);
            TxtStatus.TabIndex = 21;
            TxtStatus.Text = "Order Status:";
            // 
            // TxtBTotal
            // 
            TxtBTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBTotal.Location = new Point(636, 765);
            TxtBTotal.Margin = new Padding(3, 4, 3, 4);
            TxtBTotal.Name = "TxtBTotal";
            TxtBTotal.ReadOnly = true;
            TxtBTotal.Size = new Size(173, 47);
            TxtBTotal.TabIndex = 24;
            // 
            // OrderStatusBox
            // 
            OrderStatusBox.FormattingEnabled = true;
            OrderStatusBox.Location = new Point(639, 105);
            OrderStatusBox.Name = "OrderStatusBox";
            OrderStatusBox.Size = new Size(170, 28);
            OrderStatusBox.TabIndex = 25;
            // 
            // TxtTotal
            // 
            TxtTotal.AutoSize = true;
            TxtTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotal.Location = new Point(389, 771);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(173, 41);
            TxtTotal.TabIndex = 26;
            TxtTotal.Text = "Order Total:";
            // 
            // TxtOrderItems
            // 
            TxtOrderItems.AutoSize = true;
            TxtOrderItems.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOrderItems.Location = new Point(504, 180);
            TxtOrderItems.Name = "TxtOrderItems";
            TxtOrderItems.Size = new Size(183, 41);
            TxtOrderItems.TabIndex = 27;
            TxtOrderItems.Text = "Order Items:";
            // 
            // ManageOrdersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 964);
            Controls.Add(TxtOrderItems);
            Controls.Add(TxtTotal);
            Controls.Add(OrderStatusBox);
            Controls.Add(TxtBTotal);
            Controls.Add(TxtStatus);
            Controls.Add(BtnBack);
            Controls.Add(ListBOrderItems);
            Controls.Add(TxtUpdateStatus);
            Controls.Add(TxtBSelected);
            Controls.Add(TxtSelected);
            Controls.Add(TxtOrders);
            Controls.Add(ListBOrders);
            Controls.Add(TxtCost);
            Controls.Add(BtnHandlePayment);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageOrdersView";
            Text = "Manage Orders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BtnHandlePayment;
        private Label TxtCost;
        private ListBox ListBOrders;
        private Label TxtOrders;
        private Label TxtSelected;
        private TextBox TxtBSelected;
        private Label TxtUpdateStatus;
        private ListBox ListBOrderItems;
        private Button BtnBack;
        private Label TxtStatus;
        private TextBox TxtBTotal;
        private ComboBox OrderStatusBox;
        private Label TxtTotal;
        private Label TxtOrderItems;
    }
}