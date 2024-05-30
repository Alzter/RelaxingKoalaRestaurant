using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem
{
    public partial class CreateOrderView : Form
    {
        private UserInterface _userInterface;

        private Menu DineInMenu { get { return WaitStaffServiceInterface.DineInMenu; } }
        private Menu TakeAwayMenu { get { return WaitStaffServiceInterface.TakeAwayMenu; } }
        private List<Menu> Menus { get { return new List<Menu> { DineInMenu, TakeAwayMenu }; } }
        private Menu SelectedMenu { get { return Menus[MenuBox.SelectedIndex]; } }

        private MenuItem SelectedMenuItem { get { return SelectedMenu.GetItem(ListBMenu.SelectedIndex); } }
        private MenuItem SelectedOrderItem { get { return _order.GetItem(ListBOrder.SelectedIndex); } }

        private Order _order;

        public CreateOrderView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;

            MenuBox.DataSource = new List<String> { "Dine-in", "Take-away" };

            this.Activated += CreateOrderView_Shown;
            //this.Deactivate += CreateOrderView_Hidden;
        }

        public void CreateOrderView_Shown(object sender, EventArgs e)
        {
            if (_order != null) return;
            //Console.WriteLine("Create order");
            _order = WaitStaffServiceInterface.CreateTakeAwayOrder(new List<MenuItem> { });
            UpdateListBMenu();
            UpdateListBOrder();
        }

        //public void CreateOrderView_Hidden(object sender, EventArgs e)
        //{
        //    //Console.WriteLine("Delete order");
        //    _order = null; // Delete the order since we don't need it anymore.
        //}

        private void MenuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBMenu.SelectedIndex = 0; // Reset the selected index of the Menu Item list when changing Menus.
            UpdateListBMenu();
        }

        private List<String> GetMenuItemStrings(MenuItemContainer container)
        {
            List<MenuItem> items = container.Items;
            List<String> strings = new List<String>();
            foreach (MenuItem m in items) { strings.Add($"{m.Name}: {m.Price.ToString("C")}"); }
            return strings;
        }

        // Update ListBMenu to contain all menu items from the currently selected menu.
        private void UpdateListBMenu()
        {
            ListBMenu.DataSource = GetMenuItemStrings(SelectedMenu);
        }

        private void UpdateListBOrder()
        {
            if (_order == null) { MenuBox.Enabled = true; return; }

            ListBOrder.DataSource = GetMenuItemStrings(_order);

            // Only allow the user to change menus if they haven't added any items into their order.
            MenuBox.Enabled = _order.Items.Count == 0;

            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            TxtBTotal.Text = _order.Price.ToString("C");
        }

        // Return to WaitStaff View
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
            _order = null; // Delete the order since we don't need it anymore.
        }

        // Create Order
        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            WaitStaffServiceInterface.AddOrderToQueue(_order);

            _userInterface.StateMachine.PopState();
        }

        // Go to Ingredients View
        private void BtnIngredients_Click(object sender, EventArgs e)
        {
            if (ListBOrder.SelectedItem == null) return;
            _userInterface.StateFactory.IngredientsView.ReceiveMenuItem(_order.GetItem(ListBOrder.SelectedIndex));
            _userInterface.StateMachine.PushState(_userInterface.StateFactory.IngredientsView);
        }

        // Add MenuItem to order
        private void BtnAddToOrder_Click(object sender, EventArgs e)
        {
            if (ListBMenu.SelectedItem == null) return;

            WaitStaffServiceInterface.AddItem(_order, SelectedMenuItem);
            UpdateListBOrder();
            ListBOrder.SelectedIndex = ListBOrder.Items.Count - 1;
        }

        // Remove MenuItem from order
        private void BtnRemoveFromOrder_Click(object sender, EventArgs e)
        {
            int index = Math.Clamp(ListBOrder.SelectedIndex - 1, 0, ListBOrder.SelectedItems.Count);

            if (ListBOrder.SelectedItem == null) return;

            WaitStaffServiceInterface.RemoveItem(_order, ListBOrder.SelectedIndex);
            UpdateListBOrder();

            if (ListBOrder.SelectedItems.Count > 0) ListBOrder.SelectedIndex = index;
        }

        // On selection of MenuItem in Menu List
        private void ListBMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBMenu.SelectedItem == null) { return; }

            ListBOrder.SelectedItem = null; // Deselect any selected Menu Items.
        }

        // On selection of MenuItem in New Order List
        private void ListBOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBOrder.SelectedItem == null) { return; }

            ListBMenu.SelectedItem = null; // Deselect any selected Order Items.
        }

        private void TxtBTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotal_Click(object sender, EventArgs e)
        {
        }
    }
}
