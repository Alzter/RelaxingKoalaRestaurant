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

        private Menu _menu;

        private Menu DineInMenu { get { return WaitStaffServiceInterface.DineInMenu; } }
        private Menu TakeAwayMenu { get { return WaitStaffServiceInterface.TakeAwayMenu; } }
        private List<Menu> Menus { get { return new List<Menu> { DineInMenu, TakeAwayMenu }; } }

        public CreateOrderView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;

            MenuBox.DataSource = new List<String> { "Dine-in", "Take-away" };
            _menu = Menus[0];
            UpdateMenuBox(_menu);
        }

        private void MenuBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _menu = Menus[MenuBox.SelectedIndex];

            UpdateMenuBox(_menu);
        }

        private List<String> GetMenuItemStrings(Menu menu)
        {
            List<MenuItem> items = menu.Items;
            List<String> strings = new List<String>();
            foreach (MenuItem m in items) { strings.Add(m.Name); }
            return strings;
        }

        private void UpdateMenuBox(Menu menu)
        {
            ListBMenu.DataSource = GetMenuItemStrings(menu);
        }

        // Return to WaitStaff View
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        // Create Order
        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {

        }

        // Go to Ingredients View
        private void BtnIngredients_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PushState(_userInterface.StateFactory.IngredientsView);
        }

        // Add MenuItem to order
        private void BtnAddToOrder_Click(object sender, EventArgs e)
        {
            // Update UI
            ListBOrder.Items.Add(ListBMenu.SelectedItem);
        }

        // Remove MenuItem from order
        private void BtnRemoveFromOrder_Click(object sender, EventArgs e)
        {
            // Update UI
            ListBOrder.Items.Remove(ListBOrder.SelectedItem);
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
    }
}
