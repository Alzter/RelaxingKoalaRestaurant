namespace RestaurantSystem
{
    partial class WaitStaffService
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
            BtnCreateOrder = new Button();
            BtnManageOrders = new Button();
            BtnCreateReservation = new Button();
            BtnManageTables = new Button();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(11, 419);
            BtnBack.Margin = new Padding(2, 1, 2, 1);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(81, 22);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // BtnCreateOrder
            // 
            BtnCreateOrder.Location = new Point(43, 42);
            BtnCreateOrder.Name = "BtnCreateOrder";
            BtnCreateOrder.Size = new Size(195, 132);
            BtnCreateOrder.TabIndex = 1;
            BtnCreateOrder.Text = "Create Order";
            BtnCreateOrder.UseVisualStyleBackColor = true;
            BtnCreateOrder.Click += BtnCreateOrder_Click;
            // 
            // BtnManageOrders
            // 
            BtnManageOrders.Location = new Point(351, 42);
            BtnManageOrders.Name = "BtnManageOrders";
            BtnManageOrders.Size = new Size(195, 132);
            BtnManageOrders.TabIndex = 2;
            BtnManageOrders.Text = "Manage Orders";
            BtnManageOrders.UseVisualStyleBackColor = true;
            BtnManageOrders.Click += BtnManageOrders_Click;
            // 
            // BtnCreateReservation
            // 
            BtnCreateReservation.Location = new Point(43, 218);
            BtnCreateReservation.Name = "BtnCreateReservation";
            BtnCreateReservation.Size = new Size(195, 132);
            BtnCreateReservation.TabIndex = 3;
            BtnCreateReservation.Text = "Create Reservation";
            BtnCreateReservation.UseVisualStyleBackColor = true;
            BtnCreateReservation.Click += BtnCreateReservation_Click;
            // 
            // BtnManageTables
            // 
            BtnManageTables.Location = new Point(351, 218);
            BtnManageTables.Name = "BtnManageTables";
            BtnManageTables.Size = new Size(195, 132);
            BtnManageTables.TabIndex = 4;
            BtnManageTables.Text = "Manage Tables";
            BtnManageTables.UseVisualStyleBackColor = true;
            BtnManageTables.Click += BtnManageTables_Click;
            // 
            // WaitStaffService
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 451);
            Controls.Add(BtnManageTables);
            Controls.Add(BtnCreateReservation);
            Controls.Add(BtnManageOrders);
            Controls.Add(BtnCreateOrder);
            Controls.Add(BtnBack);
            Margin = new Padding(2, 1, 2, 1);
            Name = "WaitStaffService";
            Text = "WaitStaffInterface";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
        private Button BtnCreateOrder;
        private Button BtnManageOrders;
        private Button BtnCreateReservation;
        private Button BtnManageTables;
    }
}