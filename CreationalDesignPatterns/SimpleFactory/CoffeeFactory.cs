using SimpleFactory.Coffees;

namespace SimpleFactory
{
    public class CoffeeFactory
    {
        public Coffee GetCoffee(CoffeeType coffeeType)
        {
            return coffeeType switch
            {
                CoffeeType.Espresso => new Espresso(),
                CoffeeType.Ristretto => new Ristretto(),
                CoffeeType.Cappuccino => new Cappuccino(),
                CoffeeType.CaffeLatte => new CaffeLatte(),
                _ => throw new NotSupportedException()
            };
        }
    }
}
