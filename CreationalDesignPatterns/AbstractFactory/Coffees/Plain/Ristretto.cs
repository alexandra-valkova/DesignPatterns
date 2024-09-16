namespace AbstractFactory.Coffees.Plain
{
    public class Ristretto : PlainCoffee
    {
        public override string Name => "Ristretto";

        public override int CoffeeContent => 20;

        public override int MilkContent => 0;
    }
}
