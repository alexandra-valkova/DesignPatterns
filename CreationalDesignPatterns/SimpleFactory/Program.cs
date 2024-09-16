using SimpleFactory;

Console.WriteLine("Available coffees: Espresso, Ristretto, Cappuccino, Caffe Latte.");
Console.Write("Select coffee: ");

if (Enum.TryParse(Console.ReadLine(), ignoreCase: true, out CoffeeType coffeeType) && Enum.IsDefined(coffeeType))
{
    CoffeeFactory coffeeFactory = new();
    Coffee coffee = coffeeFactory.GetCoffee(coffeeType);
    coffee.Print();
}

else
{
    Console.WriteLine("Wrong value!");
    return;
}