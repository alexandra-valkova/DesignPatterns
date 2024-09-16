using Facade.Entities;

Facade.Facade facade = new();

Order order = new
([
    new Drink("Tea", price: 2.0),
    new Drink("Coffee", price: 3.0),
    new Drink("Hot Chocolate", price: 3.0)
]);

Console.WriteLine("Your order includes:");
order.Print();

Console.Write("Enter amount to pay: ");
double cash = Convert.ToDouble(Console.ReadLine());

facade.PlaceOrder(order, cash);
