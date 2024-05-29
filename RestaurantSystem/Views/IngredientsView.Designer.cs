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
            Label TxtAddIngredients;
            Label TxtRemoveIngredients;
            BtnBack = new Button();
            BtnAddMenuItem = new Button();
            ListBAddIngredients = new ListBox();
            ListBRemoveIngredients = new ListBox();
            BtnAddIngredient = new Button();
            BtnRemoveIngredient = new Button();
            TxtBMenuItem = new TextBox();
            TxtMenuItem = new Label();
            TxtBTotal = new TextBox();
            TxtTotal = new Label();
            TxtAddIngredients = new Label();
            TxtRemoveIngredients = new Label();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 569);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(81, 22);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnAddMenuItem
            // 
            BtnAddMenuItem.Location = new Point(573, 534);
            BtnAddMenuItem.Margin = new Padding(2, 1, 2, 1);
            BtnAddMenuItem.Name = "BtnAddMenuItem";
            BtnAddMenuItem.Size = new Size(128, 48);
            BtnAddMenuItem.TabIndex = 3;
            BtnAddMenuItem.Text = "Add Menu Item";
            BtnAddMenuItem.UseVisualStyleBackColor = true;
            BtnAddMenuItem.Click += BtnAddMenuItem_Click;
            // 
            // ListBAddIngredients
            // 
            ListBAddIngredients.FormattingEnabled = true;
            ListBAddIngredients.ItemHeight = 15;
            ListBAddIngredients.Items.AddRange(new object[] { "Cheese (+$1)", "Bacon (+$2)" });
            ListBAddIngredients.Location = new Point(28, 127);
            ListBAddIngredients.Name = "ListBAddIngredients";
            ListBAddIngredients.Size = new Size(248, 349);
            ListBAddIngredients.TabIndex = 4;
            // 
            // ListBRemoveIngredients
            // 
            ListBRemoveIngredients.FormattingEnabled = true;
            ListBRemoveIngredients.ItemHeight = 15;
            ListBRemoveIngredients.Items.AddRange(new object[] { "Tomato", "BBQ Sauce", "Lettuce" });
            ListBRemoveIngredients.Location = new Point(453, 127);
            ListBRemoveIngredients.Name = "ListBRemoveIngredients";
            ListBRemoveIngredients.Size = new Size(248, 349);
            ListBRemoveIngredients.TabIndex = 5;
            // 
            // TxtAddIngredients
            // 
            TxtAddIngredients.AutoSize = true;
            TxtAddIngredients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAddIngredients.Location = new Point(77, 93);
            TxtAddIngredients.Name = "TxtAddIngredients";
            TxtAddIngredients.Size = new Size(149, 21);
            TxtAddIngredients.TabIndex = 6;
            TxtAddIngredients.Text = "Addable Ingredients";
            // 
            // TxtRemoveIngredients
            // 
            TxtRemoveIngredients.AutoSize = true;
            TxtRemoveIngredients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRemoveIngredients.Location = new Point(496, 93);
            TxtRemoveIngredients.Name = "TxtRemoveIngredients";
            TxtRemoveIngredients.Size = new Size(170, 21);
            TxtRemoveIngredients.TabIndex = 7;
            TxtRemoveIngredients.Text = "Removable Ingredients";
            // 
            // BtnAddIngredient
            // 
            BtnAddIngredient.Location = new Point(311, 173);
            BtnAddIngredient.Name = "BtnAddIngredient";
            BtnAddIngredient.Size = new Size(103, 23);
            BtnAddIngredient.TabIndex = 8;
            BtnAddIngredient.Text = "Add Ingredient";
            BtnAddIngredient.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveIngredient
            // 
            BtnRemoveIngredient.Location = new Point(311, 223);
            BtnRemoveIngredient.Name = "BtnRemoveIngredient";
            BtnRemoveIngredient.Size = new Size(103, 41);
            BtnRemoveIngredient.TabIndex = 9;
            BtnRemoveIngredient.Text = "Remove Ingredient";
            BtnRemoveIngredient.UseVisualStyleBackColor = true;
            // 
            // TxtBMenuItem
            // 
            TxtBMenuItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBMenuItem.Location = new Point(322, 33);
            TxtBMenuItem.Name = "TxtBMenuItem";
            TxtBMenuItem.ReadOnly = true;
            TxtBMenuItem.Size = new Size(263, 39);
            TxtBMenuItem.TabIndex = 16;
            // 
            // TxtMenuItem
            // 
            TxtMenuItem.AutoSize = true;
            TxtMenuItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMenuItem.Location = new Point(167, 33);
            TxtMenuItem.Name = "TxtMenuItem";
            TxtMenuItem.Size = new Size(137, 32);
            TxtMenuItem.TabIndex = 15;
            TxtMenuItem.Text = "Menu Item:";
            // 
            // TxtBTotal
            // 
            TxtBTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBTotal.Location = new Point(328, 540);
            TxtBTotal.Name = "TxtBTotal";
            TxtBTotal.ReadOnly = true;
            TxtBTotal.Size = new Size(135, 33);
            TxtBTotal.TabIndex = 28;
            // 
            // TxtTotal
            // 
            TxtTotal.AutoSize = true;
            TxtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotal.Location = new Point(251, 543);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(71, 25);
            TxtTotal.TabIndex = 27;
            TxtTotal.Text = "Total: $";
            // 
            // IngredientsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 601);
            Controls.Add(TxtBTotal);
            Controls.Add(TxtTotal);
            Controls.Add(TxtBMenuItem);
            Controls.Add(TxtMenuItem);
            Controls.Add(BtnRemoveIngredient);
            Controls.Add(BtnAddIngredient);
            Controls.Add(TxtRemoveIngredients);
            Controls.Add(TxtAddIngredients);
            Controls.Add(ListBRemoveIngredients);
            Controls.Add(ListBAddIngredients);
            Controls.Add(BtnAddMenuItem);
            Controls.Add(BtnBack);
            Name = "IngredientsView";
            Text = "IngredientsView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBack;
        private Button BtnAddMenuItem;
        private ListBox ListBAddIngredients;
        private ListBox ListBRemoveIngredients;
        private Button BtnAddIngredient;
        private Button BtnRemoveIngredient;
        private TextBox TxtBMenuItem;
        private Label TxtMenuItem;
        private TextBox TxtBTotal;
        private Label TxtTotal;
    }
}