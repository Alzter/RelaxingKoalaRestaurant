namespace RestaurantSystem
{
    partial class KitchenStaffService
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
            BtnManageOrders = new Button();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 318);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(81, 22);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnManageOrders
            // 
            BtnManageOrders.Location = new Point(191, 127);
            BtnManageOrders.Margin = new Padding(2, 1, 2, 1);
            BtnManageOrders.Name = "BtnManageOrders";
            BtnManageOrders.Size = new Size(205, 77);
            BtnManageOrders.TabIndex = 1;
            BtnManageOrders.Text = "Manage Orders";
            BtnManageOrders.UseVisualStyleBackColor = true;
            BtnManageOrders.Click += BtnManageOrders_Click;
            // 
            // KitchenStaffService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(586, 350);
            Controls.Add(BtnManageOrders);
            Controls.Add(BtnBack);
            Margin = new Padding(2, 1, 2, 1);
            Name = "KitchenStaffService";
            Text = "KitchenInterface";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
        private Button BtnManageOrders;
    }
}