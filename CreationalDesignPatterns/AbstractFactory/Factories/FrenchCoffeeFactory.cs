using AbstractFactory.Coffees.Milk;
using AbstractFactory.Coffees.Plain;

namespace AbstractFactory.Factories
{
    public class FrenchCoffeeFactory : CoffeeFactory
    {
        public override PlainCoffee GetPlainCoffee()
        {
            return new DoubleCoffee();
        }

        public override MilkCoffee GetMilkCoffee()
        {
            return new Macchiato();
        }
    }
}
