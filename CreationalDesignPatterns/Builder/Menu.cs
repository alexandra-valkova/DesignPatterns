namespace Builder
{
    public class Menu
    {
        public string? HotDrink { get; set; }

        public string? ColdDrink { get; set; }

        public string? Dessert { get; set; }

        public void Print()
        {
            if (HotDrink is not null) Console.WriteLine($"Hot Drink: {HotDrink}");
            if (ColdDrink is not null) Console.WriteLine($"Cold Drink: {ColdDrink}");
            if (Dessert is not null) Console.WriteLine($"Dessert: {Dessert}");
        }
    }
}
