namespace RestaurantSystem
{
    partial class CreateOrderService
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
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 418);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(42, 22);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // CreateOrdersController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BtnBack);
            Name = "CreateOrdersController";
            Text = "CreateOrdersController";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
    }
}