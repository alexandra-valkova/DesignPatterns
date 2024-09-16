namespace AbstractFactory.Coffees.Plain
{
    public class Espresso : PlainCoffee
    {
        public override string Name => "Espresso";

        public override int CoffeeContent => 30;

        public override int MilkContent => 0;
    }
}
