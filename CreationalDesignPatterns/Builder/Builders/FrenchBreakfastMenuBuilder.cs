namespace Builder.Builders
{
    public class FrenchBreakfastMenuBuilder : IMenuBuilder
    {
        private readonly Menu _menu;

        public FrenchBreakfastMenuBuilder()
        {
            _menu = new Menu();
        }

        public void AddHotDrink() => _menu.HotDrink = "Coffee";

        public void AddColdDrink() => _menu.ColdDrink = "Orange Juice";

        public void AddDessert() => _menu.Dessert = "Croissant";

        public Menu GetMenu() => _menu;
    }
}
