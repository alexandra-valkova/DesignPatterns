namespace SimpleFactory.Coffees
{
    public class Espresso : Coffee
    {
        public override string Name => "Espresso";

        public override int CoffeeContent => 30;

        public override int MilkContent => 0;
    }
}
