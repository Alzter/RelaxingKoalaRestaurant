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
        public void TestGetItem()
        {
            Assert.AreEqual(beefKebab, deliveryOrder.GetItem(1), "Getting Menu Items by ID should return the proper item.");
            Assert.AreEqual(beefKebab, deliveryOrder.GetItem("Beef Kebab"), "Getting Menu Items by ID should return the proper item.");
        }

        [Test]
        public void TestGetItemFailCreatesException()
        {
            Assert.Throws<IndexOutOfRangeException>(() => deliveryOrder.GetItem(2), "Attempting to get a Menu Item using an ID outside of the range of possible IDs should throw an exception.");
            Assert.Throws<IndexOutOfRangeException>(() => deliveryOrder.GetItem(-1), "Attempting to get a Menu Item using an ID outside of the range of possible IDs should throw an exception.");
            Assert.Throws<IndexOutOfRangeException>(() => deliveryOrder.GetItem(1234), "Attempting to get a Menu Item using an ID outside of the range of possible IDs should throw an exception.");
            Assert.Throws<NullReferenceException>(() => deliveryOrder.GetItem("ABCDEF"), "Attempting to get a Menu Item by String that isn't found should return a Null reference exception.");
            Assert.Throws<NullReferenceException>(() => dineInOrder.RemoveItem(beefKebab), "Attempting to remove a Menu Item not in an order should throw a Null reference exception.");
        }

        [Test]
        public void TestAddItem()
        {
            MenuItem orderBeefKebab = dineInOrder.AddItem(beefKebab);
            CollectionAssert.AreEquivalent(new List<MenuItem> { pizza, orderBeefKebab }, dineInOrder.Items, "Adding a Menu Item to an order should add it to the Items list.");
        }

        [Test]
        public void TestRemoveItem()
        {
            MenuItem orderBeefKebab = dineInOrder.AddItem(beefKebab);
            dineInOrder.RemoveItem(orderBeefKebab);
            CollectionAssert.AreEquivalent(new List<MenuItem> { pizza }, dineInOrder.Items, "Removing a Menu Item from an order should remove it from the Items list.");
        }

        [Test]
        public void TestRemoveUsingMenuReference()
        {
            dineInOrder.AddItem(beefKebab);
            dineInOrder.RemoveItem(beefKebab);
            CollectionAssert.AreEquivalent(new List<MenuItem> { pizza }, dineInOrder.Items, "Removing a Menu Item from an order should remove it from the Items list.");
        }

        [Test]
        public void TestOrderPriceIsTotalOfIngredients()
        {
            Assert.AreEqual(dineInOrder.Price, 12.80);

            MenuItem orderBeefKebab = dineInOrder.AddItem(beefKebab);

            Assert.AreEqual(dineInOrder.Price, (12.80 + 14.5));

            orderBeefKebab.AddIngredient(extraCheese);
            Assert.AreEqual(dineInOrder.Price, (12.80 + 14.5 + 0.5));

            dineInOrder.RemoveItem(orderBeefKebab);
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
            TransactionRecord r = deliveryOrder.PayForOrder();
            Assert.IsNotNull(r, "Paying for an order should return a Receipt object");

        }

        [Test]
        public void TestOrderReceiptIsCorrect()
        {
            TransactionRecord r = deliveryOrder.PayForOrder();
            Assert.AreEqual(r.Price, (12.80 + 14.5), "An order receipt's total price should be equal to the price of an order.");
            Assert.AreEqual(r.DateIssued.Year, DateTime.Now.Year, "When an order receipt is issued, its date and time should be the time it was issued.");
            Assert.AreEqual(r.DateIssued.Month, DateTime.Now.Month, "When an order receipt is issued, its date and time should be the time it was issued.");
            Assert.AreEqual(r.DateIssued.Day, DateTime.Now.Day, "When an order receipt is issued, its date and time should be the time it was issued.");
            Assert.AreEqual(r.DateIssued.Minute, DateTime.Now.Minute, "When an order receipt is issued, its date and time should be the time it was issued.");
            Assert.AreEqual(r.DateIssued.Day, DateTime.Now.Day, "When an order receipt is issued, its date and time should be the time it was issued.");
            Assert.AreEqual(r.OrderID, 3, "An order's receipt should have a copy of the Order ID.");
        }


        [Test]
        public void TestAddingMenuItemsDuplicatesThem()
        {
            CollectionAssert.AreEquivalent(new List<Ingredient> { beefFilling, garlicSauce, chilliSauce }, beefKebab.Ingredients);
            MenuItem orderBeefKebab = dineInOrder.AddItem(beefKebab);

            orderBeefKebab.RemoveIngredient(garlicSauce);
            orderBeefKebab.AddIngredient(extraCheese);

            CollectionAssert.AreEquivalent(new List<Ingredient> { beefFilling, chilliSauce, extraCheese }, orderBeefKebab.Ingredients, "Modifying a menu item in an order should change the order's copy of the menu item.");
            CollectionAssert.AreEquivalent(new List<Ingredient> { beefFilling, garlicSauce, chilliSauce }, beefKebab.Ingredients, "Modifying a menu item in an order should not change the original menu item.");
        }
    }
}