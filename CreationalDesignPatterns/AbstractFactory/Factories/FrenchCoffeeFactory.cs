using AbstractFactory.Coffees.Milk;
using AbstractFactory.Coffees.Plain;

namespace AbstractFactory.Factories
{
    public class FrenchCoffeeFactory : CoffeeFactory
    {
        public override PlainCoffee GetPlainCoffee() => new Espresso();

        public override MilkCoffee GetMilkCoffee() => new CaffeLatte();
    }
}
