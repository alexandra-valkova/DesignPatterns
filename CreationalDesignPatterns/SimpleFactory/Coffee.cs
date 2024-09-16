namespace SimpleFactory
{
    public abstract class Coffee
    {
        public abstract string Name { get; }

        public abstract int CoffeeContent { get; }

        public abstract int MilkContent { get; }

        public void Print()
        {
            Console.WriteLine($"{Name} contains {CoffeeContent} ml coffee and {MilkContent} ml milk.");
        }
    }
}
