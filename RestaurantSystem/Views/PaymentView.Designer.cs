namespace RestaurantSystem.Interfaces
{
    partial class PaymentView
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
            ListBMenuItems = new ListBox();
            TxtMenuItems = new Label();
            TxtOrderDetails = new Label();
            TxtOrderID = new Label();
            TxtBOrderID = new TextBox();
            TxtBTotal = new TextBox();
            TxtTotal = new Label();
            TxtBDate = new TextBox();
            TxtDate = new Label();
            TxtBPaid = new TextBox();
            TxtPaid = new Label();
            BtnPay = new Button();
            BtnReceipt = new Button();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 336);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(62, 22);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // ListBMenuItems
            // 
            ListBMenuItems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBMenuItems.FormattingEnabled = true;
            ListBMenuItems.ItemHeight = 21;
            ListBMenuItems.Items.AddRange(new object[] { "Pizza - $16", "Soda - $3" });
            ListBMenuItems.Location = new Point(354, 68);
            ListBMenuItems.Name = "ListBMenuItems";
            ListBMenuItems.ScrollAlwaysVisible = true;
            ListBMenuItems.Size = new Size(262, 214);
            ListBMenuItems.TabIndex = 4;
            // 
            // TxtMenuItems
            // 
            TxtMenuItems.AutoSize = true;
            TxtMenuItems.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMenuItems.Location = new Point(365, 30);
            TxtMenuItems.Name = "TxtMenuItems";
            TxtMenuItems.Size = new Size(237, 32);
            TxtMenuItems.TabIndex = 5;
            TxtMenuItems.Text = "Menu Items Ordered";
            // 
            // TxtOrderDetails
            // 
            TxtOrderDetails.AutoSize = true;
            TxtOrderDetails.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOrderDetails.Location = new Point(76, 30);
            TxtOrderDetails.Name = "TxtOrderDetails";
            TxtOrderDetails.Size = new Size(154, 32);
            TxtOrderDetails.TabIndex = 6;
            TxtOrderDetails.Text = "Order Details";
            // 
            // TxtOrderID
            // 
            TxtOrderID.AutoSize = true;
            TxtOrderID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOrderID.Location = new Point(46, 90);
            TxtOrderID.Name = "TxtOrderID";
            TxtOrderID.Size = new Size(73, 21);
            TxtOrderID.TabIndex = 7;
            TxtOrderID.Text = "Order ID:";
            // 
            // TxtBOrderID
            // 
            TxtBOrderID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBOrderID.Location = new Point(150, 88);
            TxtBOrderID.Name = "TxtBOrderID";
            TxtBOrderID.ReadOnly = true;
            TxtBOrderID.Size = new Size(117, 29);
            TxtBOrderID.TabIndex = 8;
            // 
            // TxtBTotal
            // 
            TxtBTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBTotal.Location = new Point(150, 144);
            TxtBTotal.Name = "TxtBTotal";
            TxtBTotal.ReadOnly = true;
            TxtBTotal.Size = new Size(117, 29);
            TxtBTotal.TabIndex = 10;
            // 
            // TxtTotal
            // 
            TxtTotal.AutoSize = true;
            TxtTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotal.Location = new Point(46, 146);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(58, 21);
            TxtTotal.TabIndex = 9;
            TxtTotal.Text = "Total: $";
            // 
            // TxtBDate
            // 
            TxtBDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBDate.Location = new Point(150, 201);
            TxtBDate.Name = "TxtBDate";
            TxtBDate.ReadOnly = true;
            TxtBDate.Size = new Size(117, 29);
            TxtBDate.TabIndex = 12;
            // 
            // TxtDate
            // 
            TxtDate.AutoSize = true;
            TxtDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDate.Location = new Point(46, 203);
            TxtDate.Name = "TxtDate";
            TxtDate.Size = new Size(45, 21);
            TxtDate.TabIndex = 11;
            TxtDate.Text = "Date:";
            // 
            // TxtBPaid
            // 
            TxtBPaid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBPaid.Location = new Point(150, 259);
            TxtBPaid.Name = "TxtBPaid";
            TxtBPaid.ReadOnly = true;
            TxtBPaid.Size = new Size(117, 29);
            TxtBPaid.TabIndex = 14;
            // 
            // TxtPaid
            // 
            TxtPaid.AutoSize = true;
            TxtPaid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPaid.Location = new Point(46, 261);
            TxtPaid.Name = "TxtPaid";
            TxtPaid.Size = new Size(42, 21);
            TxtPaid.TabIndex = 13;
            TxtPaid.Text = "Paid:";
            // 
            // BtnPay
            // 
            BtnPay.Location = new Point(248, 308);
            BtnPay.Name = "BtnPay";
            BtnPay.Size = new Size(142, 48);
            BtnPay.TabIndex = 15;
            BtnPay.Text = "Pay";
            BtnPay.UseVisualStyleBackColor = true;
            BtnPay.Click += BtnPay_Click;
            // 
            // BtnReceipt
            // 
            BtnReceipt.Location = new Point(460, 308);
            BtnReceipt.Name = "BtnReceipt";
            BtnReceipt.Size = new Size(142, 48);
            BtnReceipt.TabIndex = 16;
            BtnReceipt.Text = "Receipt";
            BtnReceipt.UseVisualStyleBackColor = true;
            BtnReceipt.Click += BtnReceipt_Click;
            // 
            // PaymentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 368);
            Controls.Add(BtnReceipt);
            Controls.Add(BtnPay);
            Controls.Add(TxtBPaid);
            Controls.Add(TxtPaid);
            Controls.Add(TxtBDate);
            Controls.Add(TxtDate);
            Controls.Add(TxtBTotal);
            Controls.Add(TxtTotal);
            Controls.Add(TxtBOrderID);
            Controls.Add(TxtOrderID);
            Controls.Add(TxtOrderDetails);
            Controls.Add(TxtMenuItems);
            Controls.Add(ListBMenuItems);
            Controls.Add(BtnBack);
            Name = "PaymentView";
            Text = "OrderPaymentService";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBack;
        private ListBox ListBMenuItems;
        private Label TxtMenuItems;
        private Label TxtOrderDetails;
        private Label TxtOrderID;
        private TextBox TxtBOrderID;
        private TextBox TxtBTotal;
        private Label TxtTotal;
        private TextBox TxtBDate;
        private Label TxtDate;
        private TextBox TxtBPaid;
        private Label TxtPaid;
        private Button BtnPay;
        private Button BtnReceipt;
    }
}