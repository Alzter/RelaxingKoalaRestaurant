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
            TxtBTotal = new TextBox();
            TxtTotal = new Label();
            TxtAddIngredients = new Label();
            TxtRemoveIngredients = new Label();
            SuspendLayout();
            // 
            // TxtAddIngredients
            // 
            TxtAddIngredients.AutoSize = true;
            TxtAddIngredients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAddIngredients.Location = new Point(126, 75);
            TxtAddIngredients.Name = "TxtAddIngredients";
            TxtAddIngredients.Size = new Size(189, 28);
            TxtAddIngredients.TabIndex = 6;
            TxtAddIngredients.Text = "Addable Ingredients";
            // 
            // TxtRemoveIngredients
            // 
            TxtRemoveIngredients.AutoSize = true;
            TxtRemoveIngredients.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRemoveIngredients.Location = new Point(522, 75);
            TxtRemoveIngredients.Name = "TxtRemoveIngredients";
            TxtRemoveIngredients.Size = new Size(212, 28);
            TxtRemoveIngredients.TabIndex = 7;
            TxtRemoveIngredients.Text = "Removable Ingredients";
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(13, 759);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(93, 29);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnAddMenuItem
            // 
            BtnAddMenuItem.Location = new Point(659, 724);
            BtnAddMenuItem.Margin = new Padding(2, 1, 2, 1);
            BtnAddMenuItem.Name = "BtnAddMenuItem";
            BtnAddMenuItem.Size = new Size(146, 64);
            BtnAddMenuItem.TabIndex = 3;
            BtnAddMenuItem.Text = "Add Menu Item";
            BtnAddMenuItem.UseVisualStyleBackColor = true;
            BtnAddMenuItem.Click += BtnAddMenuItem_Click;
            // 
            // ListBAddIngredients
            // 
            ListBAddIngredients.FormattingEnabled = true;
            ListBAddIngredients.ItemHeight = 20;
            ListBAddIngredients.Items.AddRange(new object[] { "Cheese (+$1)", "Bacon (+$2)" });
            ListBAddIngredients.Location = new Point(32, 129);
            ListBAddIngredients.Margin = new Padding(3, 4, 3, 4);
            ListBAddIngredients.Name = "ListBAddIngredients";
            ListBAddIngredients.Size = new Size(381, 464);
            ListBAddIngredients.TabIndex = 4;
            ListBAddIngredients.SelectedIndexChanged += ListBAddIngredients_SelectedIndexChanged;
            // 
            // ListBRemoveIngredients
            // 
            ListBRemoveIngredients.FormattingEnabled = true;
            ListBRemoveIngredients.ItemHeight = 20;
            ListBRemoveIngredients.Items.AddRange(new object[] { "Tomato", "BBQ Sauce", "Lettuce" });
            ListBRemoveIngredients.Location = new Point(462, 129);
            ListBRemoveIngredients.Margin = new Padding(3, 4, 3, 4);
            ListBRemoveIngredients.Name = "ListBRemoveIngredients";
            ListBRemoveIngredients.Size = new Size(343, 464);
            ListBRemoveIngredients.TabIndex = 5;
            ListBRemoveIngredients.SelectedIndexChanged += ListBRemoveIngredients_SelectedIndexChanged;
            // 
            // BtnAddIngredient
            // 
            BtnAddIngredient.Location = new Point(32, 601);
            BtnAddIngredient.Margin = new Padding(3, 4, 3, 4);
            BtnAddIngredient.Name = "BtnAddIngredient";
            BtnAddIngredient.Size = new Size(381, 47);
            BtnAddIngredient.TabIndex = 8;
            BtnAddIngredient.Text = "Add Ingredient";
            BtnAddIngredient.UseVisualStyleBackColor = true;
            BtnAddIngredient.Click += BtnAddIngredient_Click;
            // 
            // BtnRemoveIngredient
            // 
            BtnRemoveIngredient.Location = new Point(462, 601);
            BtnRemoveIngredient.Margin = new Padding(3, 4, 3, 4);
            BtnRemoveIngredient.Name = "BtnRemoveIngredient";
            BtnRemoveIngredient.Size = new Size(343, 47);
            BtnRemoveIngredient.TabIndex = 9;
            BtnRemoveIngredient.Text = "Remove Ingredient";
            BtnRemoveIngredient.UseVisualStyleBackColor = true;
            BtnRemoveIngredient.Click += BtnRemoveIngredient_Click;
            // 
            // TxtBMenuItem
            // 
            TxtBMenuItem.BorderStyle = BorderStyle.None;
            TxtBMenuItem.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBMenuItem.Location = new Point(32, 13);
            TxtBMenuItem.Margin = new Padding(3, 4, 3, 4);
            TxtBMenuItem.Name = "TxtBMenuItem";
            TxtBMenuItem.ReadOnly = true;
            TxtBMenuItem.Size = new Size(773, 40);
            TxtBMenuItem.TabIndex = 16;
            TxtBMenuItem.Text = "Menu Item Name";
            TxtBMenuItem.TextAlign = HorizontalAlignment.Center;
            // 
            // TxtBTotal
            // 
            TxtBTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBTotal.Location = new Point(140, 656);
            TxtBTotal.Margin = new Padding(3, 4, 3, 4);
            TxtBTotal.Name = "TxtBTotal";
            TxtBTotal.ReadOnly = true;
            TxtBTotal.Size = new Size(665, 39);
            TxtBTotal.TabIndex = 28;
            // 
            // TxtTotal
            // 
            TxtTotal.AutoSize = true;
            TxtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotal.Location = new Point(36, 659);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(70, 32);
            TxtTotal.TabIndex = 27;
            TxtTotal.Text = "Total:";
            // 
            // IngredientsView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 801);
            Controls.Add(TxtBTotal);
            Controls.Add(TxtTotal);
            Controls.Add(TxtBMenuItem);
            Controls.Add(BtnRemoveIngredient);
            Controls.Add(BtnAddIngredient);
            Controls.Add(TxtRemoveIngredients);
            Controls.Add(TxtAddIngredients);
            Controls.Add(ListBRemoveIngredients);
            Controls.Add(ListBAddIngredients);
            Controls.Add(BtnAddMenuItem);
            Controls.Add(BtnBack);
            Margin = new Padding(3, 4, 3, 4);
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
        private TextBox TxtBTotal;
        private Label TxtTotal;
    }
}