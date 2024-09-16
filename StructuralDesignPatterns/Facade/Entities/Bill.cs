namespace Facade.Entities
{
    public class Bill
    {
        public Bill(double amountDue, double amountPaid, double amountReturned, Order order, string cashierName)
        {
            AmountDue = amountDue;
            AmountPaid = amountPaid;
            AmountReturned = amountReturned;
            Order = order;
            CashierName = cashierName;
        }

        public double AmountDue { get; set; }

        public double AmountPaid { get; set; }

        public double AmountReturned { get; set; }

        public Order Order { get; set; }

        public string CashierName { get; set; }

        public override string ToString() => $"You paid {AmountDue}, amount received {AmountPaid}, amount returned {AmountReturned}. Cashier: {CashierName}";
    }
}
