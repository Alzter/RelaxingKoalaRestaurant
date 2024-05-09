namespace RestaurantSystem
{
    partial class TestInterface
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
            WaitStaffInterface = new Button();
            CustomerInterface = new Button();
            DeliveryInterface = new Button();
            KitchenInterface = new Button();
            SuspendLayout();
            // 
            // WaitStaffInterface
            // 
            WaitStaffInterface.Location = new Point(73, 408);
            WaitStaffInterface.Name = "WaitStaffInterface";
            WaitStaffInterface.Size = new Size(240, 101);
            WaitStaffInterface.TabIndex = 0;
            WaitStaffInterface.Text = "WaitStaffInterface";
            WaitStaffInterface.UseVisualStyleBackColor = true;
            WaitStaffInterface.Click += WaitStaffInterface_Click;
            // 
            // CustomerInterface
            // 
            CustomerInterface.Location = new Point(402, 400);
            CustomerInterface.Name = "CustomerInterface";
            CustomerInterface.Size = new Size(250, 109);
            CustomerInterface.TabIndex = 1;
            CustomerInterface.Text = "CustomerInterface";
            CustomerInterface.UseVisualStyleBackColor = true;
            CustomerInterface.Click += CustomerInterface_Click;
            // 
            // DeliveryInterface
            // 
            DeliveryInterface.Location = new Point(778, 391);
            DeliveryInterface.Name = "DeliveryInterface";
            DeliveryInterface.Size = new Size(274, 127);
            DeliveryInterface.TabIndex = 2;
            DeliveryInterface.Text = "DeliveryInterface";
            DeliveryInterface.UseVisualStyleBackColor = true;
            DeliveryInterface.Click += DeliveryInterface_Click;
            // 
            // KitchenInterface
            // 
            KitchenInterface.Location = new Point(1144, 410);
            KitchenInterface.Name = "KitchenInterface";
            KitchenInterface.Size = new Size(241, 97);
            KitchenInterface.TabIndex = 3;
            KitchenInterface.Text = "KitchenInterface";
            KitchenInterface.UseVisualStyleBackColor = true;
            KitchenInterface.Click += KitchenInterface_Click;
            // 
            // TestInterface
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 934);
            Controls.Add(KitchenInterface);
            Controls.Add(DeliveryInterface);
            Controls.Add(CustomerInterface);
            Controls.Add(WaitStaffInterface);
            Name = "TestInterface";
            Text = "TestInterface";
            ResumeLayout(false);
        }

        #endregion

        private Button WaitStaffInterface;
        private Button CustomerInterface;
        private Button DeliveryInterface;
        private Button KitchenInterface;
    }
}