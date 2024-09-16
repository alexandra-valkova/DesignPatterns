namespace SimpleFactory.Coffees
{
    public class Cappuccino : Coffee
    {
        public override string Name => "Cappuccino";

        public override int CoffeeContent => 60;

        public override int MilkContent => 120;
    }
}
