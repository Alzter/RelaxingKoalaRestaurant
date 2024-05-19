namespace RestaurantSystem
{
    partial class DeliverOrdersController
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
            TxtOrdersReady = new Label();
            ListBOrdersReady = new ListBox();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 418);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(42, 22);
            BtnBack.TabIndex = 2;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // TxtOrdersReady
            // 
            TxtOrdersReady.AutoSize = true;
            TxtOrdersReady.Location = new Point(12, 9);
            TxtOrdersReady.Name = "TxtOrdersReady";
            TxtOrdersReady.Size = new Size(80, 15);
            TxtOrdersReady.TabIndex = 3;
            TxtOrdersReady.Text = "Orders Ready:";
            // 
            // ListBOrdersReady
            // 
            ListBOrdersReady.FormattingEnabled = true;
            ListBOrdersReady.ItemHeight = 15;
            ListBOrdersReady.Items.AddRange(new object[] { "Order 1", "Order 2" });
            ListBOrdersReady.Location = new Point(26, 40);
            ListBOrdersReady.Name = "ListBOrdersReady";
            ListBOrdersReady.Size = new Size(563, 364);
            ListBOrdersReady.TabIndex = 4;
            ListBOrdersReady.SelectedIndexChanged += ListBOrdersReady_SelectedIndexChanged;
            // 
            // DeliverOrdersInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 450);
            Controls.Add(ListBOrdersReady);
            Controls.Add(TxtOrdersReady);
            Controls.Add(BtnBack);
            Name = "DeliverOrdersInterface";
            Text = "DeliverOrdersInterface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBack;
        private Label TxtOrdersReady;
        private ListBox ListBOrdersReady;
    }
}