namespace RestaurantTests
{
    public class MenuItemTests
    {
        MenuItem pineapplePizza;
        Ingredient extraCheese;
        Ingredient pineapple;

        [SetUp]
        public void Setup()
        {
            extraCheese = new Ingredient("cheese", 2.5);
            pineapple = new Ingredient("pineapple", 2.5);
            pineapplePizza = new MenuItem(
                "pizza", // Name (duh)
                12.80, // Base price.
                new List<Ingredient> { extraCheese }, // Extra cheese may be added to the pineapple pizza.
                new List<Ingredient> { pineapple }    // The pineapple may be removed from the pineapple pizza.
            );
        }

        [Test]
        public void TestBasePrice()
        {
            Assert.AreEqual(12.80, pineapplePizza.Price, "The base price of a menu item should be constant.");
        }

        [Test]
        public void TestRemovingItemsDoesNotAlterPrice()
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