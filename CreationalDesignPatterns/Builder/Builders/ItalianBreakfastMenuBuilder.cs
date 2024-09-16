namespace Builder.Builders
{
    public class ItalianBreakfastMenuBuilder : IMenuBuilder
    {
        private readonly Menu _menu;

        public ItalianBreakfastMenuBuilder()
        {
            _menu = new Menu();
        }

        public void AddHotDrink() => _menu.HotDrink = "Cappuccino";

        public void AddColdDrink() => _menu.ColdDrink = "Lemonade";

        public void AddDessert() => _menu.Dessert = "Cornetto";

        public Menu GetMenu() => _menu;
    }
}
