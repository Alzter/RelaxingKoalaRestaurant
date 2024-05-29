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
            TxtBMenu = new TextBox();
            TxtOrder = new Label();
            TxtBTotal = new TextBox();
            BtnIngredients = new Button();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 453);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 22);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // TxtTotal
            // 
            TxtTotal.AutoSize = true;
            TxtTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotal.Location = new Point(546, 374);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.Size = new Size(71, 25);
            TxtTotal.TabIndex = 22;
            TxtTotal.Text = "Total: $";
            // 
            // TxtMenu
            // 
            TxtMenu.AutoSize = true;
            TxtMenu.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtMenu.Location = new Point(40, 35);
            TxtMenu.Name = "TxtMenu";
            TxtMenu.Size = new Size(77, 32);
            TxtMenu.TabIndex = 20;
            TxtMenu.Text = "Menu";
            // 
            // BtnCreateOrder
            // 
            BtnCreateOrder.Location = new Point(580, 424);
            BtnCreateOrder.Name = "BtnCreateOrder";
            BtnCreateOrder.Size = new Size(162, 23);
            BtnCreateOrder.TabIndex = 17;
            BtnCreateOrder.Text = "Create Order";
            BtnCreateOrder.UseVisualStyleBackColor = true;
            BtnCreateOrder.Click += BtnCreateOrder_Click;
            // 
            // BtnRemoveFromOrder
            // 
            BtnRemoveFromOrder.Location = new Point(364, 178);
            BtnRemoveFromOrder.Name = "BtnRemoveFromOrder";
            BtnRemoveFromOrder.Size = new Size(133, 23);
            BtnRemoveFromOrder.TabIndex = 16;
            BtnRemoveFromOrder.Text = "Remove From Order";
            BtnRemoveFromOrder.UseVisualStyleBackColor = true;
            // 
            // BtnAddToOrder
            // 
            BtnAddToOrder.Location = new Point(378, 132);
            BtnAddToOrder.Name = "BtnAddToOrder";
            BtnAddToOrder.Size = new Size(103, 23);
            BtnAddToOrder.TabIndex = 15;
            BtnAddToOrder.Text = "Add To Order";
            BtnAddToOrder.UseVisualStyleBackColor = true;
            // 
            // ListBOrder
            // 
            ListBOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBOrder.FormattingEnabled = true;
            ListBOrder.ItemHeight = 21;
            ListBOrder.Location = new Point(530, 94);
            ListBOrder.Name = "ListBOrder";
            ListBOrder.Size = new Size(245, 256);
            ListBOrder.TabIndex = 14;
            // 
            // ListBMenu
            // 
            ListBMenu.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ListBMenu.FormattingEnabled = true;
            ListBMenu.ItemHeight = 21;
            ListBMenu.Items.AddRange(new object[] { "Burger", "Fries", "Soda", "Lasagna", "Salad" });
            ListBMenu.Location = new Point(23, 91);
            ListBMenu.Name = "ListBMenu";
            ListBMenu.Size = new Size(309, 256);
            ListBMenu.TabIndex = 13;
            // 
            // TxtBMenu
            // 
            TxtBMenu.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBMenu.Location = new Point(135, 32);
            TxtBMenu.Name = "TxtBMenu";
            TxtBMenu.ReadOnly = true;
            TxtBMenu.Size = new Size(182, 39);
            TxtBMenu.TabIndex = 24;
            // 
            // TxtOrder
            // 
            TxtOrder.AutoSize = true;
            TxtOrder.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOrder.Location = new Point(589, 35);
            TxtOrder.Name = "TxtOrder";
            TxtOrder.Size = new Size(130, 32);
            TxtOrder.TabIndex = 25;
            TxtOrder.Text = "New Order";
            // 
            // TxtBTotal
            // 
            TxtBTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBTotal.Location = new Point(623, 371);
            TxtBTotal.Name = "TxtBTotal";
            TxtBTotal.ReadOnly = true;
            TxtBTotal.Size = new Size(135, 33);
            TxtBTotal.TabIndex = 26;
            // 
            // BtnIngredients
            // 
            BtnIngredients.Location = new Point(364, 231);
            BtnIngredients.Name = "BtnIngredients";
            BtnIngredients.Size = new Size(133, 23);
            BtnIngredients.TabIndex = 27;
            BtnIngredients.Text = "Alter Ingredients";
            BtnIngredients.UseVisualStyleBackColor = true;
            BtnIngredients.Click += BtnIngredients_Click;
            // 
            // CreateOrderView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 485);
            Controls.Add(BtnIngredients);
            Controls.Add(TxtBTotal);
            Controls.Add(TxtOrder);
            Controls.Add(TxtBMenu);
            Controls.Add(TxtTotal);
            Controls.Add(TxtMenu);
            Controls.Add(BtnCreateOrder);
            Controls.Add(BtnRemoveFromOrder);
            Controls.Add(BtnAddToOrder);
            Controls.Add(ListBOrder);
            Controls.Add(ListBMenu);
            Controls.Add(BtnBack);
            Name = "CreateOrderView";
            Text = "CreateOrdersController";
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
        private TextBox TxtBMenu;
        private Label TxtOrder;
        private TextBox TxtBTotal;
        private Button BtnIngredients;
    }
}