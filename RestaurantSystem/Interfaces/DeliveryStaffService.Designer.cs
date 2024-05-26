namespace RestaurantSystem
{
    partial class DeliveryStaffService
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
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(470, 15);
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
            // DeliveryController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 477);
            Controls.Add(TxtReadyOrders);
            Controls.Add(BtnBack);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DeliveryController";
            Text = "DeliveryInterface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBack;
        private Label TxtReadyOrders;
    }
}