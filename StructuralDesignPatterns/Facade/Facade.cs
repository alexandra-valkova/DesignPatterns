using Facade.Entities;

namespace Facade
{
    public class Facade
    {
        private readonly Cashier _cashier;

        public Facade()
        {
            _cashier = new Cashier("Alexandra");
        }

        public void PlaceOrder(Order order, double cash)
        {
            Bill? bill = _cashier.GenerateBill(order, cash);
            Console.WriteLine(bill?.ToString() ?? "Not enough money to process payment!");
        }
    }
}
