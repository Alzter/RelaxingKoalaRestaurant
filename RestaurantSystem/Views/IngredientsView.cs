using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        private void BtnAddMenuItem_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        private void ListBAddIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnAddIngredient_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoveIngredient_Click(object sender, EventArgs e)
        {

        }

        private void ListBRemoveIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
