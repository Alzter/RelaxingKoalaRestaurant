using RestaurantSystem;

namespace RestaurantTests
{
    public class MenuItemTests
    {
        MenuItem pineapplePizza;
        MenuItem tiramisu;
        Ingredient extraCheese;
        Ingredient pineapple;

        [SetUp]
        public void Setup()
        {
            extraCheese = new Ingredient("cheese", 2.5);
            pineapple = new Ingredient("pineapple", 2.5);

            pineapplePizza = new MenuItem("Pineapple Pizza", 12.80,
                new List<Ingredient> { pineapple },                 // Extra cheese may be added to the pineapple pizza.
                new List<Ingredient> { extraCheese });              // The pineapple may be removed from the pineapple pizza.

        }

        [Test]
        public void TestPrice()
        {
            Assert.AreEqual(12.80, pineapplePizza.Price, "The base price of a menu item should be constant.");
        }

        [Test]
        public void TestRemoveIngredient()
        {
            pineapplePizza.RemoveIngredient(pineapple);
            Assert.AreEqual(12.80, pineapplePizza.Price, "The base price of a menu item should not change when ingredients are removed.");
        }


        [Test]
        public void TestAddingItemsIncreasesPrice()
        {
            pineapplePizza.AddIngredient(extraCheese);
            Assert.AreEqual(15.3, pineapplePizza.Price, "Adding extra cheese to the pineapple pizza should increase its price by the price of the extraCheese ingredient.");
        }

        [Test]
        public void TestRemoveItem()
        {
            Assert.IsTrue(pineapplePizza.Ingredients.Contains(pineapple), "The pineapple pizza should have pineapple in its ingredients list.");

            pineapplePizza.RemoveIngredient(pineapple);

            Assert.IsTrue(pineapplePizza.Ingredients.Count == 0, "The list of ingredients for the Pineapple Pizza should now be empty.");
            Assert.IsFalse(pineapplePizza.Ingredients.Contains(pineapple), "The pineapple pizza should NOT have pineapple in its ingredients list after it was removed.");
        }

        [Test]
        public void TestAddItem()
        {
            Assert.IsFalse(pineapplePizza.Ingredients.Contains(extraCheese), "The pineapple pizza should not have extra cheese in its ingredients list initially.");

            pineapplePizza.AddIngredient(extraCheese);

            Assert.IsTrue(pineapplePizza.Ingredients.Contains(extraCheese), "The pineapple pizza should have extra cheese in its ingredients list after it was added.");

        }
    }
}