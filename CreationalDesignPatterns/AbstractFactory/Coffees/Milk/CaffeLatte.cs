namespace AbstractFactory.Coffees.Milk
{
    public class CaffeLatte : MilkCoffee
    {
        public override string Name => "Caffe Latte";

        public override int CoffeeContent => 30;

        public override int MilkContent => 90;
    }
}
