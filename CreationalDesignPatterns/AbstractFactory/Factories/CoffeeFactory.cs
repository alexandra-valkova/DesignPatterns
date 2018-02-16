using AbstractFactory.Coffees.Milk;
using AbstractFactory.Coffees.Plain;

namespace AbstractFactory.Factories
{
    public abstract class CoffeeFactory
    {
        public abstract PlainCoffee GetPlainCoffee();

        public abstract MilkCoffee GetMilkCoffee();
    }
}
