namespace SimpleFactory.Coffees
{
    public class Ristretto : Coffee
    {
        public override string Name => "Ristretto";

        public override int CoffeeContent => 20;

        public override int MilkContent => 0;
    }
}
