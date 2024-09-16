using Facade.Entities;

namespace Facade
{
    public class Cashier
    {
        public string Name { get; set; }

        public Cashier(string name)
        {
            Name = name;
        }

        public Bill? GenerateBill(Order order, double cash)
        {
            double amountDue = CalculateSum(order);
            bool isPaid = TryCashPayment(amountDue, cash, out double amountToReturn);

            return isPaid ? new Bill(amountDue, cash, amountToReturn, order, Name) : null;
        }

        public static double CalculateSum(Order order) => order.Drinks.Sum(drink => drink.Price);

        private static bool TryCashPayment(double dueAmount, double paidAmount, out double amountToReturn)
        {
            if (paidAmount >= dueAmount)
            {
                amountToReturn = paidAmount - dueAmount;
                return true;
            }

            amountToReturn = 0;
            return false;
        }
    }
}
