namespace RestaurantSystem
{
    partial class WaitStaffController
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
            BtnCreateOrders = new Button();
            BtnDeliverOrders = new Button();
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
            // BtnCreateOrders
            // 
            BtnCreateOrders.Location = new Point(231, 123);
            BtnCreateOrders.Name = "BtnCreateOrders";
            BtnCreateOrders.Size = new Size(120, 23);
            BtnCreateOrders.TabIndex = 1;
            BtnCreateOrders.Text = "Create Orders";
            BtnCreateOrders.UseVisualStyleBackColor = true;
            BtnCreateOrders.Click += BtnCreateOrders_Click;
            // 
            // BtnDeliverOrders
            // 
            BtnDeliverOrders.Location = new Point(231, 187);
            BtnDeliverOrders.Name = "BtnDeliverOrders";
            BtnDeliverOrders.Size = new Size(120, 23);
            BtnDeliverOrders.TabIndex = 2;
            BtnDeliverOrders.Text = "Deliver Orders";
            BtnDeliverOrders.UseVisualStyleBackColor = true;
            BtnDeliverOrders.Click += BtnDeliverOrders_Click;
            // 
            // BtnManageTables
            // 
            BtnManageTables.Location = new Point(231, 253);
            BtnManageTables.Name = "BtnManageTables";
            BtnManageTables.Size = new Size(120, 23);
            BtnManageTables.TabIndex = 3;
            BtnManageTables.Text = "Manage Tables";
            BtnManageTables.UseVisualStyleBackColor = true;
            BtnManageTables.Click += BtnManageTables_Click;
            // 
            // WaitStaffController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(592, 451);
            Controls.Add(BtnManageTables);
            Controls.Add(BtnDeliverOrders);
            Controls.Add(BtnCreateOrders);
            Controls.Add(BtnBack);
            Margin = new Padding(2, 1, 2, 1);
            Name = "WaitStaffController";
            Text = "WaitStaffInterface";
            ResumeLayout(false);
        }

        #endregion

        private Button BtnBack;
        private Button BtnCreateOrders;
        private Button BtnDeliverOrders;
        private Button BtnManageTables;
    }
}