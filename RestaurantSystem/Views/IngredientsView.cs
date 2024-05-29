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

        public IngredientsView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
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
                ListBRemoveIngredients.Items.Add(ListBAddIngredients.SelectedItem);
                ListBAddIngredients.Items.Remove(ListBAddIngredients.SelectedItem);
            }
        }

        // Remove Ingredient from Menu Item
        private void BtnRemoveIngredient_Click(object sender, EventArgs e)
        {
            if (ListBRemoveIngredients.SelectedItems.Count != 0)
            {
                // Update the UI
                ListBAddIngredients.Items.Add(ListBRemoveIngredients.SelectedItem);
                ListBRemoveIngredients.Items.Remove(ListBRemoveIngredients.SelectedItem);
            }       
        }

        private void ListBRemoveIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
