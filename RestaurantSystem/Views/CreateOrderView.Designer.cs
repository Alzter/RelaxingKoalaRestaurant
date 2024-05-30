namespace RestaurantSystem
{
    partial class CreateOrderView
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
            TxtTotal = new Label();
            TxtMenu = new Label();
            BtnCreateOrder = new Button();
            BtnRemoveFromOrder = new Button();
            BtnAddToOrder = new Button();
            ListBOrder = new ListBox();
            ListBMenu = new ListBox();
            TxtOrder = new Label();
            TxtBTotal = new TextBox();
            BtnIngredients = new Button();
            MenuBox = new ComboBox();
            label1 = new Label();
            TableNumberBox = new ComboBox();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(13, 604);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(107, 29);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // TxtTotal
            // 
            TxtTotal.AutoSize = true;
            TxtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotal.Location = new Point(493, 521);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(70, 32);
            TxtTotal.TabIndex = 22;
            TxtTotal.Text = "Total:";
            TxtTotal.Click += TxtTotal_Click;
            // 
            // TxtMenu
            // 
            TxtMenu.AutoSize = true;
            TxtMenu.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMenu.Location = new Point(26, 20);
            TxtMenu.Name = "TxtMenu";
            TxtMenu.Size = new Size(95, 41);
            TxtMenu.TabIndex = 20;
            TxtMenu.Text = "Menu";
            // 
            // BtnCreateOrder
            // 
            BtnCreateOrder.Location = new Point(686, 578);
            BtnCreateOrder.Margin = new Padding(3, 4, 3, 4);
            BtnCreateOrder.Name = "BtnCreateOrder";
            BtnCreateOrder.Size = new Size(200, 55);
            BtnCreateOrder.TabIndex = 17;
            BtnCreateOrder.Text = "Create Order";
            BtnCreateOrder.UseVisualStyleBackColor = true;
            BtnCreateOrder.Click += BtnCreateOrder_Click;
            // 
            // BtnRemoveFromOrder
            // 
            BtnRemoveFromOrder.Location = new Point(493, 455);
            BtnRemoveFromOrder.Margin = new Padding(3, 4, 3, 4);
            BtnRemoveFromOrder.Name = "BtnRemoveFromOrder";
            BtnRemoveFromOrder.Size = new Size(185, 36);
            BtnRemoveFromOrder.TabIndex = 16;
            BtnRemoveFromOrder.Text = "Remove From Order";
            BtnRemoveFromOrder.UseVisualStyleBackColor = true;
            BtnRemoveFromOrder.Click += BtnRemoveFromOrder_Click;
            // 
            // BtnAddToOrder
            // 
            BtnAddToOrder.Location = new Point(26, 455);
            BtnAddToOrder.Margin = new Padding(3, 4, 3, 4);
            BtnAddToOrder.Name = "BtnAddToOrder";
            BtnAddToOrder.Size = new Size(427, 36);
            BtnAddToOrder.TabIndex = 15;
            BtnAddToOrder.Text = "Add To Order";
            BtnAddToOrder.UseVisualStyleBackColor = true;
            BtnAddToOrder.Click += BtnAddToOrder_Click;
            // 
            // ListBOrder
            // 
            ListBOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBOrder.FormattingEnabled = true;
            ListBOrder.ItemHeight = 28;
            ListBOrder.Location = new Point(493, 79);
            ListBOrder.Margin = new Padding(3, 4, 3, 4);
            ListBOrder.Name = "ListBOrder";
            ListBOrder.Size = new Size(393, 368);
            ListBOrder.TabIndex = 14;
            ListBOrder.SelectedIndexChanged += ListBOrder_SelectedIndexChanged;
            // 
            // ListBMenu
            // 
            ListBMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBMenu.FormattingEnabled = true;
            ListBMenu.ItemHeight = 28;
            ListBMenu.Items.AddRange(new object[] { "Burger", "Fries", "Soda", "Lasagna", "Salad" });
            ListBMenu.Location = new Point(26, 79);
            ListBMenu.Margin = new Padding(3, 4, 3, 4);
            ListBMenu.Name = "ListBMenu";
            ListBMenu.Size = new Size(427, 368);
            ListBMenu.TabIndex = 13;
            ListBMenu.SelectedIndexChanged += ListBMenu_SelectedIndexChanged;
            // 
            // TxtOrder
            // 
            TxtOrder.AutoSize = true;
            TxtOrder.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOrder.Location = new Point(610, 20);
            TxtOrder.Name = "TxtOrder";
            TxtOrder.Size = new Size(163, 41);
            TxtOrder.TabIndex = 25;
            TxtOrder.Text = "New Order";
            // 
            // TxtBTotal
            // 
            TxtBTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBTotal.Location = new Point(569, 518);
            TxtBTotal.Margin = new Padding(3, 4, 3, 4);
            TxtBTotal.Name = "TxtBTotal";
            TxtBTotal.ReadOnly = true;
            TxtBTotal.Size = new Size(317, 39);
            TxtBTotal.TabIndex = 26;
            TxtBTotal.TextChanged += TxtBTotal_TextChanged;
            // 
            // BtnIngredients
            // 
            BtnIngredients.Location = new Point(701, 455);
            BtnIngredients.Margin = new Padding(3, 4, 3, 4);
            BtnIngredients.Name = "BtnIngredients";
            BtnIngredients.Size = new Size(185, 38);
            BtnIngredients.TabIndex = 27;
            BtnIngredients.Text = "Alter Ingredients";
            BtnIngredients.UseVisualStyleBackColor = true;
            BtnIngredients.Click += BtnIngredients_Click;
            // 
            // MenuBox
            // 
            MenuBox.FormattingEnabled = true;
            MenuBox.Location = new Point(140, 33);
            MenuBox.Name = "MenuBox";
            MenuBox.Size = new Size(313, 28);
            MenuBox.TabIndex = 28;
            MenuBox.SelectedIndexChanged += MenuBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 518);
            label1.Name = "label1";
            label1.Size = new Size(211, 41);
            label1.TabIndex = 29;
            label1.Text = "Table Number:";
            // 
            // TableNumberBox
            // 
            TableNumberBox.FormattingEnabled = true;
            TableNumberBox.Location = new Point(243, 525);
            TableNumberBox.Name = "TableNumberBox";
            TableNumberBox.Size = new Size(210, 28);
            TableNumberBox.TabIndex = 30;
            TableNumberBox.SelectedIndexChanged += TableNumberBox_SelectedIndexChanged;
            // 
            // CreateOrderView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 647);
            Controls.Add(TableNumberBox);
            Controls.Add(label1);
            Controls.Add(MenuBox);
            Controls.Add(BtnIngredients);
            Controls.Add(TxtBTotal);
            Controls.Add(TxtOrder);
            Controls.Add(TxtTotal);
            Controls.Add(TxtMenu);
            Controls.Add(BtnCreateOrder);
            Controls.Add(BtnRemoveFromOrder);
            Controls.Add(BtnAddToOrder);
            Controls.Add(ListBOrder);
            Controls.Add(ListBMenu);
            Controls.Add(BtnBack);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CreateOrderView";
            Text = "Create Orders";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBack;
        private Label TxtTotal;
        private Label TxtMenu;
        private Button BtnCreateOrder;
        private Button BtnRemoveFromOrder;
        private Button BtnAddToOrder;
        private ListBox ListBOrder;
        private ListBox ListBMenu;
        private Label TxtOrder;
        private TextBox TxtBTotal;
        private Button BtnIngredients;
        private ComboBox MenuBox;
        private Label label1;
        private ComboBox TableNumberBox;
    }
}