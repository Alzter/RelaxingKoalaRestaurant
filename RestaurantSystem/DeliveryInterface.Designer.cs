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
            SuspendLayout();
            // 
            // Back
            // 
            Back.Location = new Point(873, 33);
            Back.Name = "Back";
            Back.Size = new Size(150, 46);
            Back.TabIndex = 0;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // DeliveryInterface
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 723);
            Controls.Add(Back);
            Name = "DeliveryInterface";
            Text = "DeliveryInterface";
            ResumeLayout(false);
        }

        #endregion

        private Button Back;
    }
}