namespace AbstractFactory.Coffees.Milk
{
    public class Cappuccino : MilkCoffee
    {
        public override string Name => "Cappuccino";

        public override int CoffeeContent => 60;

        public override int MilkContent => 120;
    }
}
