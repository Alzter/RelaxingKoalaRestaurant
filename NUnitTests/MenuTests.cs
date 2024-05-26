using RestaurantSystem;

namespace RestaurantTests
{
    public class MenuTests
    {
        Menu _takeAway;
        Menu _dineIn;

        MenuItem pizza;
        MenuItem spaghetti;
        MenuItem tacos;
        MenuItem nachos;

        [SetUp]
        public void SetUp()
        {
            pizza = new MenuItem("Pizza", 12.8);
            spaghetti = new MenuItem("Spaghetti Bolognese", 11.1);
            tacos = new MenuItem("Tacos", 1.4);
            nachos = new MenuItem("Nachos", 0.5);

            _takeAway = new Menu(new List<MenuItem> { pizza, tacos }, "Take Away");
            _dineIn = new Menu(new List<MenuItem> { spaghetti }, "Dine-in");

        }

        [Test]
        public void TestMenuItemsExist()
        {
            CollectionAssert.AreEquivalent(_takeAway.Items, new List<MenuItem> { pizza, tacos });
            CollectionAssert.AreEquivalent(_dineIn.Items, new List<MenuItem> { spaghetti });
        }

        [Test]
        public void TestAddMenuItem()
        {
            _takeAway.AddItem(nachos);
            CollectionAssert.AreEquivalent(_takeAway.Items, new List<MenuItem> { pizza, tacos, nachos });
        }

        [Test]
        public void TestRemoveMenuItem()
        {
            _takeAway.RemoveItem(1);
            CollectionAssert.AreEquivalent(_takeAway.Items, new List<MenuItem> { pizza });

            _takeAway.RemoveItem(pizza);
            CollectionAssert.AreEquivalent(_takeAway.Items, new List<MenuItem> { });
        }

        [Test]
        public void TestGetMenuItem()
        {
            Assert.AreEqual(_dineIn.GetItem(0), spaghetti);
        }

    }
}