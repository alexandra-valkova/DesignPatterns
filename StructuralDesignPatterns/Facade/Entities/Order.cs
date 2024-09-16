namespace Facade.Entities
{
    public class Order
    {
        public List<Drink> Drinks { get; set; }

        public Order(List<Drink> drinks)
        {
            Drinks = drinks;
        }

        public void Print() => Drinks.ForEach(Console.WriteLine);
    }
}
