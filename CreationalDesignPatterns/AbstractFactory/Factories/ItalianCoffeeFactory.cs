using AbstractFactory.Coffees.Milk;
using AbstractFactory.Coffees.Plain;

namespace AbstractFactory.Factories
{
    public class ItalianCoffeeFactory : CoffeeFactory
    {
        public override PlainCoffee GetPlainCoffee()
        {
            return new RegularCoffee();
        }

        public override MilkCoffee GetMilkCoffee()
        {
            return new Cappuccino();
        }
    }
}
