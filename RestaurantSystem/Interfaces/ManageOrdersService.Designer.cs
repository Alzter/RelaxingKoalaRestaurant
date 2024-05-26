namespace RestaurantSystem
{
    partial class ManageOrdersService
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
            TxtTableNum = new Label();
            TxtStatus = new Label();
            BtnMarkAsDelivered = new Button();
            BtnHandlePayment = new Button();
            ListBMenuItems = new ListBox();
            TxtTotalPrice = new Label();
            TxtCost = new Label();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // TxtTableNum
            // 
            TxtTableNum.AutoSize = true;
            TxtTableNum.Location = new Point(191, 19);
            TxtTableNum.Name = "TxtTableNum";
            TxtTableNum.Size = new Size(84, 15);
            TxtTableNum.TabIndex = 0;
            TxtTableNum.Text = "Table Number:";
            // 
            // TxtStatus
            // 
            TxtStatus.AutoSize = true;
            TxtStatus.Location = new Point(191, 53);
            TxtStatus.Name = "TxtStatus";
            TxtStatus.Size = new Size(42, 15);
            TxtStatus.TabIndex = 1;
            TxtStatus.Text = "Status:";
            // 
            // BtnMarkAsDelivered
            // 
            BtnMarkAsDelivered.Location = new Point(93, 105);
            BtnMarkAsDelivered.Name = "BtnMarkAsDelivered";
            BtnMarkAsDelivered.Size = new Size(129, 23);
            BtnMarkAsDelivered.TabIndex = 2;
            BtnMarkAsDelivered.Text = "Mark As Delivered";
            BtnMarkAsDelivered.UseVisualStyleBackColor = true;
            BtnMarkAsDelivered.Click += BtnMarkAsDelivered_Click;
            // 
            // BtnHandlePayment
            // 
            BtnHandlePayment.Location = new Point(261, 105);
            BtnHandlePayment.Name = "BtnHandlePayment";
            BtnHandlePayment.Size = new Size(129, 23);
            BtnHandlePayment.TabIndex = 3;
            BtnHandlePayment.Text = "Handle Payment";
            BtnHandlePayment.UseVisualStyleBackColor = true;
            BtnHandlePayment.Click += BtnHandlePayment_Click;
            // 
            // ListBMenuItems
            // 
            ListBMenuItems.FormattingEnabled = true;
            ListBMenuItems.ItemHeight = 15;
            ListBMenuItems.Items.AddRange(new object[] { "Coffee", "Caramel Slice" });
            ListBMenuItems.Location = new Point(24, 148);
            ListBMenuItems.Name = "ListBMenuItems";
            ListBMenuItems.ScrollAlwaysVisible = true;
            ListBMenuItems.Size = new Size(423, 169);
            ListBMenuItems.TabIndex = 4;
            ListBMenuItems.SelectedIndexChanged += ListBMenuItems_SelectedIndexChanged;
            // 
            // TxtTotalPrice
            // 
            TxtTotalPrice.AutoSize = true;
            TxtTotalPrice.Location = new Point(24, 320);
            TxtTotalPrice.Name = "TxtTotalPrice";
            TxtTotalPrice.Size = new Size(64, 15);
            TxtTotalPrice.TabIndex = 5;
            TxtTotalPrice.Text = "Total Price:";
            // 
            // TxtCost
            // 
            TxtCost.AutoSize = true;
            TxtCost.Location = new Point(409, 320);
            TxtCost.Name = "TxtCost";
            TxtCost.Size = new Size(13, 15);
            TxtCost.TabIndex = 6;
            TxtCost.Text = "$";
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 418);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(42, 22);
            BtnBack.TabIndex = 7;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // ManageOrdersService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 450);
            Controls.Add(BtnBack);
            Controls.Add(TxtCost);
            Controls.Add(TxtTotalPrice);
            Controls.Add(ListBMenuItems);
            Controls.Add(BtnHandlePayment);
            Controls.Add(BtnMarkAsDelivered);
            Controls.Add(TxtStatus);
            Controls.Add(TxtTableNum);
            Name = "ManageOrdersService";
            Text = "ManageOrdersInterface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TxtTableNum;
        private Label TxtStatus;
        private Button BtnMarkAsDelivered;
        private Button BtnHandlePayment;
        private ListBox ListBMenuItems;
        private Label TxtTotalPrice;
        private Label TxtCost;
        private Button BtnBack;
    }
}