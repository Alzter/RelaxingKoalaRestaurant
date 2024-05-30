namespace RestaurantSystem
{
    partial class RestaurantView
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
            WaitStaffInterface.Location = new Point(28, 19);
            WaitStaffInterface.Margin = new Padding(2, 1, 2, 1);
            WaitStaffInterface.Name = "WaitStaffInterface";
            WaitStaffInterface.Size = new Size(316, 178);
            WaitStaffInterface.TabIndex = 0;
            WaitStaffInterface.Text = "WaitStaffInterface";
            WaitStaffInterface.UseVisualStyleBackColor = true;
            WaitStaffInterface.Click += WaitStaffInterface_Click;
            // 
            // CustomerInterface
            // 
            CustomerInterface.Enabled = false;
            CustomerInterface.ForeColor = SystemColors.AppWorkspace;
            CustomerInterface.Location = new Point(28, 231);
            CustomerInterface.Margin = new Padding(2, 1, 2, 1);
            CustomerInterface.Name = "CustomerInterface";
            CustomerInterface.Size = new Size(316, 188);
            CustomerInterface.TabIndex = 1;
            CustomerInterface.Text = "CustomerInterface";
            CustomerInterface.UseVisualStyleBackColor = true;
            CustomerInterface.Click += CustomerInterface_Click;
            // 
            // DeliveryInterface
            // 
            DeliveryInterface.Enabled = false;
            DeliveryInterface.ForeColor = SystemColors.AppWorkspace;
            DeliveryInterface.Location = new Point(442, 19);
            DeliveryInterface.Margin = new Padding(2, 1, 2, 1);
            DeliveryInterface.Name = "DeliveryInterface";
            DeliveryInterface.Size = new Size(319, 178);
            DeliveryInterface.TabIndex = 2;
            DeliveryInterface.Text = "DeliveryInterface";
            DeliveryInterface.UseVisualStyleBackColor = true;
            DeliveryInterface.Click += DeliveryInterface_Click;
            // 
            // KitchenInterface
            // 
            KitchenInterface.Location = new Point(442, 231);
            KitchenInterface.Margin = new Padding(2, 1, 2, 1);
            KitchenInterface.Name = "KitchenInterface";
            KitchenInterface.Size = new Size(319, 188);
            KitchenInterface.TabIndex = 3;
            KitchenInterface.Text = "KitchenInterface";
            KitchenInterface.UseVisualStyleBackColor = true;
            KitchenInterface.Click += KitchenInterface_Click;
            // 
            // RestaurantView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 438);
            Controls.Add(KitchenInterface);
            Controls.Add(DeliveryInterface);
            Controls.Add(CustomerInterface);
            Controls.Add(WaitStaffInterface);
            Margin = new Padding(2, 1, 2, 1);
            Name = "RestaurantView";
            Text = "RestaurantSystem";
            ResumeLayout(false);
        }

        #endregion

        private Button WaitStaffInterface;
        private Button CustomerInterface;
        private Button DeliveryInterface;
        private Button KitchenInterface;
    }
}