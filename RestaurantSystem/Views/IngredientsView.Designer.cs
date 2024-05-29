namespace RestaurantSystem.Views
{
    partial class IngredientsView
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
            BtnAddMenuItem = new Button();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 462);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(81, 22);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            // 
            // BtnAddMenuItem
            // 
            BtnAddMenuItem.Location = new Point(408, 436);
            BtnAddMenuItem.Margin = new Padding(2, 1, 2, 1);
            BtnAddMenuItem.Name = "BtnAddMenuItem";
            BtnAddMenuItem.Size = new Size(205, 48);
            BtnAddMenuItem.TabIndex = 3;
            BtnAddMenuItem.Text = "Add Menu Item";
            BtnAddMenuItem.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(24, 62);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(248, 349);
            listBox1.TabIndex = 4;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(344, 62);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(248, 349);
            listBox2.TabIndex = 5;
            // 
            // IngredientsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 494);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(BtnAddMenuItem);
            Controls.Add(BtnBack);
            Name = "IngredientsView";
            Text = "IngredientsView";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
        private Button BtnAddMenuItem;
        private ListBox listBox1;
        private ListBox listBox2;
    }
}