using RestaurantSystem;

namespace RestaurantTests
{
    public class OrderTests
    {
        Order o;
        MenuItem pizza;

        [SetUp]
        public void Setup()
        {
            pizza = new MenuItem("pizza", 12.80);
            
        }
    }
}