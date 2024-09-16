using Builder.Builders;
using Builder.Enums;
using static Builder.Enums.MenuType;

namespace Builder
{
    public class CoffeeShopDirector
    {
        private readonly IMenuBuilder _menuBuilder;

        public CoffeeShopDirector(IMenuBuilder builder)
        {
            _menuBuilder = builder;
        }

        public void PrepareMenu(MenuType menu)
        {
            switch (menu)
            {
                case HotDrinkAndDessert:
                    PrepareHotDrinkAndDessert();
                    break;
                case ColdDrinkAndDessert:
                    PrepareColdDrinkAndDessert();
                    break;
                case HotDrinkAndColdDrink:
                    PrepareHotDrinkAndColdDrink();
                    break;
                case HotDrinkAndColdDrinkAndDessert:
                    PrepareHotDrinkAndColdDrinkAndDessert();
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        private void PrepareHotDrinkAndDessert()
        {
            _menuBuilder.AddHotDrink();
            _menuBuilder.AddDessert();
        }

        private void PrepareColdDrinkAndDessert()
        {
            _menuBuilder.AddColdDrink();
            _menuBuilder.AddDessert();
        }

        private void PrepareHotDrinkAndColdDrink()
        {
            _menuBuilder.AddHotDrink();
            _menuBuilder.AddColdDrink();
        }

        private void PrepareHotDrinkAndColdDrinkAndDessert()
        {
            _menuBuilder.AddHotDrink();
            _menuBuilder.AddColdDrink();
            _menuBuilder.AddDessert();
        }
    }
}
