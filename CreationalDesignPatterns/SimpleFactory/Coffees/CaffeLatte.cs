namespace SimpleFactory.Coffees
{
    public class CaffeLatte : Coffee
    {
        public override string Name => "Caffe Latte";

        public override int CoffeeContent => 30;

        public override int MilkContent => 90;
    }
}
