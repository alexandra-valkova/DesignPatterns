namespace Facade.Entities
{
    public class Drink
    {
        public Drink(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override string ToString() => $"{Name}, costs {Price}.";
    }
}
