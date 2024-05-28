using RestaurantSystem;

namespace RestaurantTests
{
    public class OrderTests
    {
        Order dineInOrder;
        Order takeAwayOrder;
        Order deliveryOrder;
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
                }
            );

            dineInOrder = new Order(new List<MenuItem> { pizza }, 1, 12);
            takeAwayOrder = new Order(new List<MenuItem> { beefKebab }, 2);
            deliveryOrder = new Order(new List<MenuItem> { pizza, beefKebab }, 3, "22122B2222221 St.");
        }

        [Test]
        public void TestAddItem()
        {
            dineInOrder.AddItem(beefKebab);
            CollectionAssert.AreEquivalent(new List<MenuItem> { pizza, beefKebab }, dineInOrder.Items, "Adding a Menu Item to an order should add it to the Items list.");
        }
        [Test]
        public void TestRemoveItem()
        {
            TestAddItem();
            dineInOrder.RemoveItem(beefKebab);
            CollectionAssert.AreEquivalent(new List<MenuItem> { pizza }, dineInOrder.Items, "Removing a Menu Item frpm an order should remove it from the Items list.");
        }

        [Test]
        public void TestOrderPriceIsTotalOfIngredients()
        {
            Assert.AreEqual(dineInOrder.Price, 12.80);
            dineInOrder.AddItem(beefKebab);
            Assert.AreEqual(dineInOrder.Price, (12.80 + 14.5));
            beefKebab.AddIngredient(extraCheese);
            Assert.AreEqual(dineInOrder.Price, (12.80 + 14.5 + 0.5));
            dineInOrder.RemoveItem(beefKebab);
            Assert.AreEqual(dineInOrder.Price, 12.80);
        }

        [Test]
        public void TestDineInOrderHasTableNumber()
        {
            Assert.AreEqual(dineInOrder.TableNumber, 12);
        }
        [Test]
        public void TestDeliveryOrderHasAddress()
        {
            Assert.AreEqual(deliveryOrder.Address, "22122B2222221 St.");
        }

        public int? getTakeAwayOrderTableNumber() { return takeAwayOrder.TableNumber; }
        public int? getDeliveryOrderTableNumber() { return deliveryOrder.TableNumber; }
        public string? getTakeAwayOrderAddress() { return takeAwayOrder.Address; }
        public string? getDineInOrderAddress() { return dineInOrder.Address; }

        [Test]
        public void TestNullTableNumberThrowsException()
        {

            Assert.Throws<NullReferenceException>(() => getTakeAwayOrderTableNumber(), "Attempting to get the table number from a take-away order should create a NullReferenceException.");
            Assert.Throws<NullReferenceException>(() => getDeliveryOrderTableNumber(), "Attempting to get the table number from a delivery order should create a NullReferenceException.");
        }

        [Test]
        public void TestNullAddressThrowsException()
        {
            Assert.Throws<NullReferenceException>(() => getTakeAwayOrderAddress(), "Attempting to get the address from a take-away order should create a NullReferenceException.");
            Assert.Throws<NullReferenceException>(() => getDineInOrderAddress(), "Attempting to get the address from a dine-in order should create a NullReferenceException.");
        }

        [Test]
        public void TestPayOrder()
        {
            Assert.IsFalse(deliveryOrder.IsPaid, "Instantiated orders should have the IsPaid flag set to false by default.");
            deliveryOrder.PayForOrder();
            Assert.IsTrue(deliveryOrder.IsPaid, "Paying for an order should set the IsPaid flag to true.");
        }

        [Test]
        public void TestPayingForOrderReturnsReceipt()
        {
            Receipt r = deliveryOrder.PayForOrder();
            Assert.IsNotNull(r, "Paying for an order should return a Receipt object");

        }

        [Test]
        public void TestOrderReceiptIsCorrect()
        {
            Receipt r = deliveryOrder.PayForOrder();
            Assert.AreEqual(r.Price, (12.80 + 14.5), "An order receipt's total price should be equal to the price of an order.");
            Assert.AreEqual(r.DateIssued, DateTime.Now, "When an order receipt is issued, its date and time should be the time it was issued.");
            Assert.AreEqual(r.OrderID, 3, "An order's receipt should have a copy of the Order ID.");
        }
    }
}