namespace RestaurantSystem
{
    partial class DeliveryStaffView
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
            TxtReadyOrders = new Label();
            BtnManageOrders = new Button();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 445);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(81, 22);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // TxtReadyOrders
            // 
            TxtReadyOrders.AutoSize = true;
            TxtReadyOrders.Location = new Point(12, 22);
            TxtReadyOrders.Name = "TxtReadyOrders";
            TxtReadyOrders.Size = new Size(80, 15);
            TxtReadyOrders.TabIndex = 1;
            TxtReadyOrders.Text = "Ready Orders:";
            // 
            // BtnManageOrders
            // 
            BtnManageOrders.Location = new Point(186, 200);
            BtnManageOrders.Margin = new Padding(2, 1, 2, 1);
            BtnManageOrders.Name = "BtnManageOrders";
            BtnManageOrders.Size = new Size(205, 77);
            BtnManageOrders.TabIndex = 2;
            BtnManageOrders.Text = "Manage Orders";
            BtnManageOrders.UseVisualStyleBackColor = true;
            BtnManageOrders.Click += BtnManageOrders_Click;
            // 
            // DeliveryStaffService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 477);
            Controls.Add(BtnManageOrders);
            Controls.Add(TxtReadyOrders);
            Controls.Add(BtnBack);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DeliveryStaffService";
            Text = "DeliveryInterface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBack;
        private Label TxtReadyOrders;
        private Button BtnManageOrders;
    }
}