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
            StatusFilterBox = new ComboBox();
            TxtFilter = new Label();
            BtnCancelOrder = new Button();
            TxtCreationTime = new Label();
            TxtBCreationTime = new TextBox();
            TxtCompletionTime = new Label();
            TxtBCompletionTime = new TextBox();
            label2 = new Label();
            ETABox = new NumericUpDown();
            label3 = new Label();
            TxtIngredients = new Label();
            ListBItemIngredients = new ListBox();
            TxtItems = new Label();
            ((System.ComponentModel.ISupportInitialize)ETABox).BeginInit();
            SuspendLayout();
            // 
            // BtnHandlePayment
            // 
            BtnHandlePayment.Location = new Point(389, 866);
            BtnHandlePayment.Margin = new Padding(3, 4, 3, 4);
            BtnHandlePayment.Name = "BtnHandlePayment";
            BtnHandlePayment.Size = new Size(539, 75);
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
            ListBOrders.Location = new Point(22, 147);
            ListBOrders.Margin = new Padding(3, 4, 3, 4);
            ListBOrders.Name = "ListBOrders";
            ListBOrders.ScrollAlwaysVisible = true;
            ListBOrders.Size = new Size(326, 508);
            ListBOrders.TabIndex = 7;
            ListBOrders.SelectedIndexChanged += ListBOrders_SelectedIndexChanged;
            // 
            // TxtOrders
            // 
            TxtOrders.AutoSize = true;
            TxtOrders.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOrders.Location = new Point(127, 32);
            TxtOrders.Name = "TxtOrders";
            TxtOrders.Size = new Size(108, 41);
            TxtOrders.TabIndex = 11;
            TxtOrders.Text = "Orders";
            // 
            // TxtSelected
            // 
            TxtSelected.AutoSize = true;
            TxtSelected.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSelected.Location = new Point(389, 32);
            TxtSelected.Name = "TxtSelected";
            TxtSelected.Size = new Size(223, 41);
            TxtSelected.TabIndex = 12;
            TxtSelected.Text = "Order Selected:";
            // 
            // TxtBSelected
            // 
            TxtBSelected.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBSelected.Location = new Point(653, 26);
            TxtBSelected.Margin = new Padding(3, 4, 3, 4);
            TxtBSelected.Name = "TxtBSelected";
            TxtBSelected.ReadOnly = true;
            TxtBSelected.Size = new Size(275, 47);
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
            ListBOrderItems.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ListBOrderItems.FormattingEnabled = true;
            ListBOrderItems.ItemHeight = 23;
            ListBOrderItems.Items.AddRange(new object[] { "Pizza - $12", "Chips - $5", "Soda - $3" });
            ListBOrderItems.Location = new Point(389, 231);
            ListBOrderItems.Margin = new Padding(3, 4, 3, 4);
            ListBOrderItems.Name = "ListBOrderItems";
            ListBOrderItems.ScrollAlwaysVisible = true;
            ListBOrderItems.Size = new Size(339, 418);
            ListBOrderItems.TabIndex = 19;
            ListBOrderItems.SelectedIndexChanged += ListBOrderItems_SelectedIndexChanged;
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
            TxtStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtStatus.Location = new Point(389, 84);
            TxtStatus.Name = "TxtStatus";
            TxtStatus.Size = new Size(125, 28);
            TxtStatus.TabIndex = 21;
            TxtStatus.Text = "Order Status:";
            // 
            // TxtBTotal
            // 
            TxtBTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBTotal.Location = new Point(585, 783);
            TxtBTotal.Margin = new Padding(3, 4, 3, 4);
            TxtBTotal.Name = "TxtBTotal";
            TxtBTotal.ReadOnly = true;
            TxtBTotal.Size = new Size(343, 47);
            TxtBTotal.TabIndex = 24;
            TxtBTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // OrderStatusBox
            // 
            OrderStatusBox.FormattingEnabled = true;
            OrderStatusBox.Location = new Point(653, 81);
            OrderStatusBox.Name = "OrderStatusBox";
            OrderStatusBox.Size = new Size(275, 28);
            OrderStatusBox.TabIndex = 25;
            OrderStatusBox.SelectedIndexChanged += OrderStatusBox_SelectedIndexChanged;
            // 
            // TxtTotal
            // 
            TxtTotal.AutoSize = true;
            TxtTotal.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotal.Location = new Point(389, 783);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(173, 41);
            TxtTotal.TabIndex = 26;
            TxtTotal.Text = "Order Total:";
            // 
            // StatusFilterBox
            // 
            StatusFilterBox.FormattingEnabled = true;
            StatusFilterBox.Location = new Point(173, 102);
            StatusFilterBox.Name = "StatusFilterBox";
            StatusFilterBox.Size = new Size(175, 28);
            StatusFilterBox.TabIndex = 28;
            StatusFilterBox.SelectedIndexChanged += StatusFilterBox_SelectedIndexChanged;
            // 
            // TxtFilter
            // 
            TxtFilter.AutoSize = true;
            TxtFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtFilter.Location = new Point(22, 102);
            TxtFilter.Name = "TxtFilter";
            TxtFilter.Size = new Size(145, 28);
            TxtFilter.TabIndex = 29;
            TxtFilter.Text = "Filter by Status:";
            // 
            // BtnCancelOrder
            // 
            BtnCancelOrder.Location = new Point(22, 669);
            BtnCancelOrder.Margin = new Padding(3, 4, 3, 4);
            BtnCancelOrder.Name = "BtnCancelOrder";
            BtnCancelOrder.Size = new Size(326, 47);
            BtnCancelOrder.TabIndex = 30;
            BtnCancelOrder.Text = "Cancel Order";
            BtnCancelOrder.UseVisualStyleBackColor = true;
            BtnCancelOrder.Click += BtnCancelOrder_Click;
            // 
            // TxtCreationTime
            // 
            TxtCreationTime.AutoSize = true;
            TxtCreationTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCreationTime.Location = new Point(389, 671);
            TxtCreationTime.Name = "TxtCreationTime";
            TxtCreationTime.Size = new Size(137, 28);
            TxtCreationTime.TabIndex = 31;
            TxtCreationTime.Text = "Creation Time:";
            // 
            // TxtBCreationTime
            // 
            TxtBCreationTime.BorderStyle = BorderStyle.None;
            TxtBCreationTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBCreationTime.Location = new Point(585, 669);
            TxtBCreationTime.Margin = new Padding(3, 4, 3, 4);
            TxtBCreationTime.Name = "TxtBCreationTime";
            TxtBCreationTime.ReadOnly = true;
            TxtBCreationTime.Size = new Size(343, 27);
            TxtBCreationTime.TabIndex = 32;
            TxtBCreationTime.TextAlign = HorizontalAlignment.Right;
            // 
            // TxtCompletionTime
            // 
            TxtCompletionTime.AutoSize = true;
            TxtCompletionTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtCompletionTime.Location = new Point(389, 705);
            TxtCompletionTime.Name = "TxtCompletionTime";
            TxtCompletionTime.Size = new Size(166, 28);
            TxtCompletionTime.TabIndex = 33;
            TxtCompletionTime.Text = "Completion Time:";
            // 
            // TxtBCompletionTime
            // 
            TxtBCompletionTime.BorderStyle = BorderStyle.None;
            TxtBCompletionTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBCompletionTime.Location = new Point(585, 703);
            TxtBCompletionTime.Margin = new Padding(3, 4, 3, 4);
            TxtBCompletionTime.Name = "TxtBCompletionTime";
            TxtBCompletionTime.ReadOnly = true;
            TxtBCompletionTime.Size = new Size(343, 27);
            TxtBCompletionTime.TabIndex = 34;
            TxtBCompletionTime.TextAlign = HorizontalAlignment.Right;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(389, 126);
            label2.Name = "label2";
            label2.Size = new Size(228, 28);
            label2.TabIndex = 35;
            label2.Text = "Estimated Cooking Time:";
            // 
            // ETABox
            // 
            ETABox.Enabled = false;
            ETABox.Increment = new decimal(new int[] { 5, 0, 0, 0 });
            ETABox.Location = new Point(653, 124);
            ETABox.Maximum = new decimal(new int[] { 60, 0, 0, 0 });
            ETABox.Name = "ETABox";
            ETABox.Size = new Size(208, 27);
            ETABox.TabIndex = 36;
            ETABox.ValueChanged += ETABox_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(867, 126);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 37;
            label3.Text = "minutes";
            // 
            // TxtIngredients
            // 
            TxtIngredients.AutoSize = true;
            TxtIngredients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtIngredients.Location = new Point(776, 190);
            TxtIngredients.Name = "TxtIngredients";
            TxtIngredients.Size = new Size(110, 28);
            TxtIngredients.TabIndex = 39;
            TxtIngredients.Text = "Ingredients";
            // 
            // ListBItemIngredients
            // 
            ListBItemIngredients.Enabled = false;
            ListBItemIngredients.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ListBItemIngredients.FormattingEnabled = true;
            ListBItemIngredients.ItemHeight = 23;
            ListBItemIngredients.Items.AddRange(new object[] { "Pizza - $12", "Chips - $5", "Soda - $3" });
            ListBItemIngredients.Location = new Point(734, 231);
            ListBItemIngredients.Margin = new Padding(3, 4, 3, 4);
            ListBItemIngredients.Name = "ListBItemIngredients";
            ListBItemIngredients.ScrollAlwaysVisible = true;
            ListBItemIngredients.Size = new Size(194, 418);
            ListBItemIngredients.TabIndex = 40;
            // 
            // TxtItems
            // 
            TxtItems.AutoSize = true;
            TxtItems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtItems.Location = new Point(509, 190);
            TxtItems.Name = "TxtItems";
            TxtItems.Size = new Size(114, 28);
            TxtItems.TabIndex = 41;
            TxtItems.Text = "Menu Items";
            // 
            // ManageOrdersView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 964);
            Controls.Add(TxtItems);
            Controls.Add(ListBItemIngredients);
            Controls.Add(TxtIngredients);
            Controls.Add(label3);
            Controls.Add(ETABox);
            Controls.Add(label2);
            Controls.Add(TxtBCompletionTime);
            Controls.Add(TxtCompletionTime);
            Controls.Add(TxtBCreationTime);
            Controls.Add(TxtCreationTime);
            Controls.Add(BtnCancelOrder);
            Controls.Add(TxtFilter);
            Controls.Add(StatusFilterBox);
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
            ((System.ComponentModel.ISupportInitialize)ETABox).EndInit();
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
        private ComboBox StatusFilterBox;
        private Label TxtFilter;
        private Button BtnCancelOrder;
        private Label TxtCreationTime;
        private TextBox TxtBCreationTime;
        private Label TxtCompletionTime;
        private TextBox TxtBCompletionTime;
        private Label label2;
        private NumericUpDown ETABox;
        private Label label3;
        private Label TxtIngredients;
        private ListBox ListBItemIngredients;
        private Label TxtItems;
    }
}