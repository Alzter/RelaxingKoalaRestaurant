using RestaurantSystem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace RestaurantTests
{
    public class TransactionRecordTests
    {
        MenuItem pizza;
        MenuItem tacos;
        MenuItem nachos;
        MenuItem spaghetti;
        Receipt r;
        Invoice i;

        [SetUp]
        public void SetUp()
        {
            pizza = new MenuItem("Pizza", 12.8);
            spaghetti = new MenuItem("Spaghetti Bolognese", 11.1);
            tacos = new MenuItem("Tacos", 1.4);
            nachos = new MenuItem("Nachos", 0.5);
            r = new Receipt(12, new List<MenuItem>{ pizza, spaghetti, tacos }, new DateTime(2024, 05, 29, 10, 37, 00));
            i = new Invoice(1, new List<MenuItem> { nachos, tacos }, new DateTime(2002, 10, 1, 16, 20, 69));
        }

        [Test]
        public void TestTotalPrice()
        {
            Assert.AreEqual(r.Price, (12.8 + 11.1 + 1.4));
            Assert.AreEqual(i.Price, (0.5 + 1.4));
        }

        [Test]
        public void TestPrintReceipt()
        {
            Assert.AreEqual(r.ToString(), "Relaxing Koala Receipt:\nOrder ID: 12\nDate: 29/05/2024, 10:37 AM\nOwed: $25.30\n" +
                "Items:\nPizza: $12.80\nSpaghetti Bolognese: $11.1\nTacos: $1.40");
        }

        [Test]
        public void TestPrintInvoice()
        {
            Assert.AreEqual(r.ToString(), "Relaxing Koala Invoice:\nOrder ID: 1\nDate: 1/10/2002, 4:20 PM\nPaid: $1.90\n" +
                "Items:\nNachos: $0.50\nTacos: $1.40");
        }
    }
}