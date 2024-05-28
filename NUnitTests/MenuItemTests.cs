using RestaurantSystem;

namespace RestaurantTests
{
    public class MenuItemTests
    {
        MenuItem pineapplePizza;
        MenuItem tiramisu;
        Ingredient extraCheese;
        Ingredient pineapple;
        Ingredient chocolateSprinkles;

        [SetUp]
        public void Setup()
        {
            extraCheese = new Ingredient("cheese", 2.5);
            pineapple = new Ingredient("pineapple", 2.5);
            chocolateSprinkles = new Ingredient("Chocolate Sprinkles", 0.5);
            

            pineapplePizza = new MenuItem("Pineapple Pizza", 12.80,
                new List<Ingredient> { pineapple },                 // The pineapple may be removed from the pineapple pizza.
                new List<Ingredient> { extraCheese }                // Extra cheese may be added to the pineapple pizza.
            );
        }

        [Test]
        public void TestIngredientsListCreated()
        {
            Assert.IsTrue(pineapplePizza.Ingredients.Contains(pineapple), "The pineapple pizza should contain a pineapple ingredient.");
            Assert.IsTrue(pineapplePizza.Ingredients.Count == 1, "The pineapple pizza should have one ingredient in its list.");
        }

        [Test]
        public void TestPrice()
        {
            Assert.AreEqual(12.80, pineapplePizza.Price, "The base price of a menu item should be constant.");
        }

        [Test]
        public void TestRemovingIngredientsRetainsPrice()
        {
            pineapplePizza.RemoveIngredient(pineapple);
            Assert.AreEqual(12.80, pineapplePizza.Price, "The base price of a menu item should not change when ingredients are removed.");
        }


        [Test]
        public void TestAddingIngredientsIncreasesPrice()
        {
            pineapplePizza.AddIngredient(extraCheese);
            Assert.AreEqual(15.3, pineapplePizza.Price, "Adding extra cheese to the pineapple pizza should increase its price by the price of the extraCheese ingredient.");
        }

        [Test]
        public void TestRemoveIngredient()
        {
            Assert.IsTrue(pineapplePizza.Ingredients.Contains(pineapple), "The pineapple pizza should have pineapple in its ingredients list.");

            pineapplePizza.RemoveIngredient(pineapple);

            Assert.IsTrue(pineapplePizza.Ingredients.Count == 0, "The list of ingredients for the Pineapple Pizza should now be empty.");
            Assert.IsFalse(pineapplePizza.Ingredients.Contains(pineapple), "The pineapple pizza should NOT have pineapple in its ingredients list after it was removed.");
        }

        [Test]
        public void TestAddIngredient()
        {
            Assert.IsFalse(pineapplePizza.Ingredients.Contains(extraCheese), "The pineapple pizza should not have extra cheese in its ingredients list initially.");

            pineapplePizza.AddIngredient(extraCheese);

            Assert.IsTrue(pineapplePizza.Ingredients.Contains(extraCheese), "The pineapple pizza should have extra cheese in its ingredients list after it was added.");

        }

        [Test]
        public void TestAddIngredientTwice()
        {
            pineapplePizza.AddIngredient(extraCheese);
            Assert.Throws<ArgumentException>(() => pineapplePizza.AddIngredient(extraCheese), "It should not be possible to add the same ingredient to a menu item more than once.");
        }

        [Test]
        public void TestAddIngredientThatWasRemoved()
        {
            pineapplePizza.RemoveIngredient(pineapple);
            Assert.IsTrue(pineapplePizza.AddableIngredients.Contains(pineapple), "It should be possible to re-add ingredients that were removed from a Menu Item.");
        }

        [Test]

        public void TestAddIngredientNotInList()
        {
            Assert.Throws<ArgumentException>(() => pineapplePizza.AddIngredient(chocolateSprinkles), "It should not be possible to add ingredients to a Menu Item that aren't specified on its list of addable ingredients.");
        }

        [Test]
        public void TestRemoveIngredientNotInList()
        {
            Assert.Throws<ArgumentException>(() => pineapplePizza.RemoveIngredient(chocolateSprinkles), "It should not be possible to remove ingredients from a Menu Item that aren't in its list of ingredients.");
            pineapplePizza.RemoveIngredient(pineapple);
            Assert.Throws<ArgumentException>(() => pineapplePizza.RemoveIngredient(pineapple), "It should not be possible to remove ingredients from a Menu Item that aren't in its list of ingredients.");
        }
    }
}