namespace RestaurantSystem
{
    partial class DeliveryInterface
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
            Back = new Button();
            TxtReadyOrders = new Label();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Location = new Point(470, 15);
            Back.Margin = new Padding(2, 1, 2, 1);
            Back.Name = "Back";
            Back.Size = new Size(81, 22);
            Back.TabIndex = 0;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
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
            // DeliveryInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 477);
            Controls.Add(TxtReadyOrders);
            Controls.Add(Back);
            Margin = new Padding(2, 1, 2, 1);
            Name = "DeliveryInterface";
            Text = "DeliveryInterface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private Label TxtReadyOrders;
    }
}