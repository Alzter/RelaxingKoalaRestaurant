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

        private Ingredient SelectedIngredient
        {
            get { return null; }
        }

        public IngredientsView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        private List<String> GetIngredientsStrings(MenuItem item)
        {
            List<Ingredient> ingredients = item.Ingredients;
            List<String> strings = new List<String>();
            foreach (Ingredient i in ingredients) { strings.Add($"{i.Name}"); }
            return strings;
        }

        private List<String> GetAddableIngredientsStrings(MenuItem item)
        {
            List<Ingredient> ingredients = item.AddableIngredients;
            List<String> strings = new List<String>();
            foreach (Ingredient i in ingredients) { strings.Add($"{i.Name}: {i.Price.ToString("C")}"); }
            return strings;
        }

        public void ReceiveMenuItem(MenuItem item, Order order)
        {
            _item = item;

            List<String> list = new List<String>();
            ListBAddIngredients.DataSource = GetAddableIngredientsStrings(_item);
            ListBRemoveIngredients.DataSource = GetIngredientsStrings(_item);
            TxtBMenuItem.Text = _item.Name.ToString();
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

        }

        // Add Ingredient to Menu Item
        private void BtnAddIngredient_Click(object sender, EventArgs e)
        {
            if (ListBAddIngredients.SelectedItems.Count != 0)
            {
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
                // Update the UI
                //ListBAddIngredients.Items.Add(ListBRemoveIngredients.SelectedItem);
                //ListBRemoveIngredients.Items.Remove(ListBRemoveIngredients.SelectedItem);
            }       
        }

        private void ListBRemoveIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
