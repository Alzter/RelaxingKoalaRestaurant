namespace RestaurantSystem
{
    partial class CustomerInterface
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
            Menu = new ListBox();
            Order = new ListBox();
            BtnAddToOrder = new Button();
            BtnRemoveFromOrder = new Button();
            BtnPlaceOrder = new Button();
            BtnPickup = new RadioButton();
            BtnDelivery = new RadioButton();
            TextMenu = new Label();
            TextOrder = new Label();
            TextTotal = new Label();
            TextPrice = new Label();
            SuspendLayout();
            // 
            // Back
            // 
            Back.Location = new Point(12, 10);
            Back.Margin = new Padding(2, 1, 2, 1);
            Back.Name = "Back";
            Back.Size = new Size(42, 22);
            Back.TabIndex = 0;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Menu
            // 
            Menu.FormattingEnabled = true;
            Menu.ItemHeight = 15;
            Menu.Items.AddRange(new object[] { "Burger", "Fries", "Soda", "Lasagna", "Salad" });
            Menu.Location = new Point(12, 57);
            Menu.Name = "Menu";
            Menu.Size = new Size(309, 604);
            Menu.TabIndex = 1;
            // 
            // Order
            // 
            Order.FormattingEnabled = true;
            Order.ItemHeight = 15;
            Order.Location = new Point(573, 60);
            Order.Name = "Order";
            Order.Size = new Size(245, 289);
            Order.TabIndex = 2;
            // 
            // BtnAddToOrder
            // 
            BtnAddToOrder.Location = new Point(393, 94);
            BtnAddToOrder.Name = "BtnAddToOrder";
            BtnAddToOrder.Size = new Size(103, 23);
            BtnAddToOrder.TabIndex = 3;
            BtnAddToOrder.Text = "Add To Order";
            BtnAddToOrder.UseVisualStyleBackColor = true;
            // 
            // BtnRemoveFromOrder
            // 
            BtnRemoveFromOrder.Location = new Point(379, 140);
            BtnRemoveFromOrder.Name = "BtnRemoveFromOrder";
            BtnRemoveFromOrder.Size = new Size(133, 23);
            BtnRemoveFromOrder.TabIndex = 4;
            BtnRemoveFromOrder.Text = "Remove From Order";
            BtnRemoveFromOrder.UseVisualStyleBackColor = true;
            // 
            // BtnPlaceOrder
            // 
            BtnPlaceOrder.Location = new Point(656, 638);
            BtnPlaceOrder.Name = "BtnPlaceOrder";
            BtnPlaceOrder.Size = new Size(162, 23);
            BtnPlaceOrder.TabIndex = 5;
            BtnPlaceOrder.Text = "Place Order";
            BtnPlaceOrder.UseVisualStyleBackColor = true;
            // 
            // BtnPickup
            // 
            BtnPickup.AutoSize = true;
            BtnPickup.Location = new Point(656, 587);
            BtnPickup.Name = "BtnPickup";
            BtnPickup.Size = new Size(61, 19);
            BtnPickup.TabIndex = 6;
            BtnPickup.TabStop = true;
            BtnPickup.Text = "Pickup";
            BtnPickup.UseVisualStyleBackColor = true;
            // 
            // BtnDelivery
            // 
            BtnDelivery.AutoSize = true;
            BtnDelivery.Location = new Point(751, 587);
            BtnDelivery.Name = "BtnDelivery";
            BtnDelivery.Size = new Size(67, 19);
            BtnDelivery.TabIndex = 7;
            BtnDelivery.TabStop = true;
            BtnDelivery.Text = "Delivery";
            BtnDelivery.UseVisualStyleBackColor = true;
            // 
            // TextMenu
            // 
            TextMenu.AutoSize = true;
            TextMenu.Location = new Point(110, 28);
            TextMenu.Name = "TextMenu";
            TextMenu.Size = new Size(96, 15);
            TextMenu.TabIndex = 8;
            TextMenu.Text = "Take Away Menu";
            // 
            // TextOrder
            // 
            TextOrder.AutoSize = true;
            TextOrder.Location = new Point(680, 28);
            TextOrder.Name = "TextOrder";
            TextOrder.Size = new Size(37, 15);
            TextOrder.TabIndex = 9;
            TextOrder.Text = "Order";
            TextOrder.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextTotal
            // 
            TextTotal.AutoSize = true;
            TextTotal.Location = new Point(573, 363);
            TextTotal.Name = "TextTotal";
            TextTotal.Size = new Size(35, 15);
            TextTotal.TabIndex = 10;
            TextTotal.Text = "Total:";
            // 
            // TextPrice
            // 
            TextPrice.AutoSize = true;
            TextPrice.Location = new Point(623, 363);
            TextPrice.Name = "TextPrice";
            TextPrice.Size = new Size(13, 15);
            TextPrice.TabIndex = 11;
            TextPrice.Text = "$";
            // 
            // CustomerInterface
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(830, 678);
            Controls.Add(TextPrice);
            Controls.Add(TextTotal);
            Controls.Add(TextOrder);
            Controls.Add(TextMenu);
            Controls.Add(BtnDelivery);
            Controls.Add(BtnPickup);
            Controls.Add(BtnPlaceOrder);
            Controls.Add(BtnRemoveFromOrder);
            Controls.Add(BtnAddToOrder);
            Controls.Add(Order);
            Controls.Add(Menu);
            Controls.Add(Back);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CustomerInterface";
            Text = "CustomerInterface";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Back;
        private ListBox Menu;
        private ListBox Order;
        private Button BtnAddToOrder;
        private Button BtnRemoveFromOrder;
        private Button BtnPlaceOrder;
        private RadioButton BtnPickup;
        private RadioButton BtnDelivery;
        private Label TextMenu;
        private Label TextOrder;
        private Label TextTotal;
        private Label TextPrice;
    }
}