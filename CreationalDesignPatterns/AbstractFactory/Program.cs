using AbstractFactory.Coffees;
using AbstractFactory.Enums;
using AbstractFactory.Factories;

CoffeeFactory coffeeFactory;
Coffee coffee;

Console.Write("Choose French or Italian Coffee: ");
if (Enum.TryParse(Console.ReadLine(), ignoreCase: true, out CoffeeShop coffeeShop) && Enum.IsDefined(coffeeShop))
{
    coffeeFactory = coffeeShop switch
    {
        CoffeeShop.French => new FrenchCoffeeFactory(),
        CoffeeShop.Italian => new ItalianCoffeeFactory(),
        _ => throw new NotSupportedException()
    };
}

else
{
    Console.WriteLine("Wrong value!");
    return;
}

Console.Write("Choose Plain or Milk Coffee: ");
if (Enum.TryParse(Console.ReadLine(), ignoreCase: true, out CoffeeType coffeeType) && Enum.IsDefined(coffeeType))
{
    coffee = coffeeType switch
    {
        CoffeeType.Plain => coffeeFactory.GetPlainCoffee(),
        CoffeeType.Milk => coffeeFactory.GetMilkCoffee(),
        _ => throw new NotSupportedException()
    };
}

else
{
    Console.WriteLine("Wrong value!");
    return;
}

coffee.Print();
