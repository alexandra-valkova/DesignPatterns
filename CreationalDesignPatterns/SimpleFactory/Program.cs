using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter coffee number: ");
            int coffeeNumber = int.Parse(Console.ReadLine());
            CoffeeType coffeeType = (CoffeeType)coffeeNumber;

            Coffee coffee = CoffeeFactory.GetCoffee(coffeeType);
            coffee.Print();
        }
    }
}
