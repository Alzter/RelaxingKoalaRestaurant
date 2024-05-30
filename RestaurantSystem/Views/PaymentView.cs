using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Interfaces
{
    public partial class PaymentView : Form
    {
        private UserInterface _userInterface;
        private Order _order;
        private TransactionRecord _transactionRecord;

        public PaymentView(UserInterface userInterface)
        {
            InitializeComponent();
            _userInterface = userInterface;
        }

        public void ReceiveOrder(Order order)
        {
            _order = order;
            TxtBOrderID.Text = _order.ID.ToString();
            TxtBTotal.Text = _order.Price.ToString();
            TxtBDate.Text = DateTime.Now.ToString();
            TxtBPaid.Text = _order.IsPaid.ToString();
            ListBMenuItems.DataSource = GetMenuItemStrings(_order);

            BtnPay.Enabled = !_order.IsPaid;
            BtnReceipt.Enabled = !_order.IsPaid;
        }

        private List<String> GetMenuItemStrings(MenuItemContainer container)
        {
            List<MenuItem> items = container.Items;
            List<String> strings = new List<String>();
            foreach (MenuItem m in items) { strings.Add($"{m.Name}: {m.Price.ToString("C")}"); }
            return strings;
        }

        // Go back to ManageOrders View
        private void BtnBack_Click(object sender, EventArgs e)
        {
            _userInterface.StateMachine.PopState();
        }

        // Payment connection to a bank
        private void BtnPay_Click(object sender, EventArgs e)
        {
            _transactionRecord = WaitStaffServiceInterface.PayForOrder(_order);
            TxtBPaid.Text = _order.IsPaid.ToString();
            BtnPay.Enabled = false;
        }

        // Print receipt
        private void BtnReceipt_Click(object sender, EventArgs e)
        {
            if (_transactionRecord == null) return;
            Console.Write(_transactionRecord.ToString());
        }
    }
}
