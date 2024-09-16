using AbstractFactory.Coffees.Milk;
using AbstractFactory.Coffees.Plain;

namespace AbstractFactory.Factories
{
    public class ItalianCoffeeFactory : CoffeeFactory
    {
        public override PlainCoffee GetPlainCoffee() => new Ristretto();

        public override MilkCoffee GetMilkCoffee() => new Cappuccino();
    }
}
