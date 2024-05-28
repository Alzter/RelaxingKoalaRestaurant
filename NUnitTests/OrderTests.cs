using RestaurantSystem;

namespace RestaurantTests
{
    public class OrderTests
    {
        Order o;
        MenuItem pizza;
        MenuItem beefKebab;
        Ingredient beefFilling;
        Ingredient chickenFilling;
        Ingredient garlicSauce;
        Ingredient chilliSauce;
        Ingredient barbequeSauce;
        Ingredient extraCheese;

        [SetUp]
        public void Setup()
        {
            pizza = new MenuItem("Pizza", 12.80);
            beefFilling = new Ingredient("Beef Filling", 0.0);
            chickenFilling = new Ingredient("Chicken Filling", 0.0);
            garlicSauce = new Ingredient("Garlic Sauce", 0.0);
            chilliSauce = new Ingredient("Chilli Sauce", 0.0);
            barbequeSauce = new Ingredient("Barbeque Sauce", 0.0);
            extraCheese = new Ingredient("Extra Cheese", 0.5);

            beefKebab = new MenuItem("Beef Kebab", 14.5,

                // Removable ingredients
                new List<Ingredient> {
                    beefFilling,
                    garlicSauce,
                    chilliSauce

                // Addable ingredients
                }, new List<Ingredient>
                {
                    barbequeSauce,
                    extraCheese
                });
        }
    }
}