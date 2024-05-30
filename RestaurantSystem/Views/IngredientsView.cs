using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Views
{
    public partial class IngredientsView : Form
    {
        private UserInterface _userInterface;
        private MenuItem _item;
        private Order _order;

        private Ingredient SelectedAddIngredient
        {
            get { return ListBAddIngredients.SelectedItem == null ? null : _item.AddableIngredients[ListBAddIngredients.SelectedIndex]; }
        }
        private Ingredient SelectedIngredient
        {
            get { return ListBRemoveIngredients.SelectedItem == null ? null : _item.Ingredients[ListBRemoveIngredients.SelectedIndex]; }
        }

        public IngredientsView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        private List<String> GetIngredientsStrings(MenuItem item)
        {
            return GetIngredientsStrings(item.Ingredients, item);
        }

        private List<String> GetAddableIngredientsStrings(MenuItem item)
        {
            return GetIngredientsStrings(item.AddableIngredients, item);
        }

        public List<String> GetIngredientsStrings(List<Ingredient> ingredients, MenuItem m)
        {
            List<String> strings = new List<String>();
            foreach (Ingredient i in ingredients)
            {
                if (m.BaseIngredients.Contains(i))
                {
                    strings.Add(i.Name);
                }
                else
                {
                    strings.Add($"{i.Name}: {i.Price.ToString("C")}");
                }
            }
            return strings;
        }

        public void ReceiveMenuItem(MenuItem item, Order order)
        {
            _item = item;
            _order = order;

            List<String> list = new List<String>();
            UpdateIngredientsLists();
            TxtBMenuItem.Text = _item.Name.ToString();
            ListBAddIngredients.SelectedIndex = 0;
        }

        private void UpdateIngredientsLists()
        {
            ListBAddIngredients.DataSource = GetAddableIngredientsStrings(_item);
            ListBRemoveIngredients.DataSource = GetIngredientsStrings(_item);
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            TxtBTotal.Text = _item.Price.ToString("C");
        }

        // Go back to CreateOrder View
        private void BtnAddMenuItem_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        // Go back to CreateOrder View
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        private void ListBAddIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBAddIngredients.SelectedItem == null) { return; }
            ListBRemoveIngredients.SelectedItem = null;
        }

        private void ListBRemoveIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBRemoveIngredients.SelectedItem == null) { return; }
            ListBAddIngredients.SelectedItem = null;
        }

        // Add Ingredient to Menu Item
        private void BtnAddIngredient_Click(object sender, EventArgs e)
        {
            if (ListBAddIngredients.SelectedItems.Count != 0)
            {
                WaitStaffServiceInterface.AddIngredient(_order, _item, SelectedAddIngredient);
                UpdateIngredientsLists();
                ListBRemoveIngredients.SelectedIndex = ListBRemoveIngredients.Items.Count - 1;

                // Update the UI
                //WaitStaffServiceInterface.AddItem(o, )
                //ListBRemoveIngredients.Items.Add(ListBAddIngredients.SelectedItem);
                //ListBAddIngredients.Items.Remove(ListBAddIngredients.SelectedItem);
            }
        }

        // Remove Ingredient from Menu Item
        private void BtnRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (ListBRemoveIngredients.SelectedItems.Count != 0)
            {
                int index = Math.Clamp(ListBRemoveIngredients.SelectedIndex - 1, 0, ListBRemoveIngredients.Items.Count);
                WaitStaffServiceInterface.RemoveIngredient(_order, _item, SelectedIngredient);
                UpdateIngredientsLists();

                if (ListBRemoveIngredients.Items.Count > 0)
                {
                    ListBRemoveIngredients.SelectedIndex = index;
                }

                // Update the UI
                //ListBAddIngredients.Items.Add(ListBRemoveIngredients.SelectedItem);
                //ListBRemoveIngredients.Items.Remove(ListBRemoveIngredients.SelectedItem);
            }
        }
    }
}
