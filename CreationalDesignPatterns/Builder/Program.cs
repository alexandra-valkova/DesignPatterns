using Builder;
using Builder.Builders;
using Builder.Enums;

Menu menu;
IMenuBuilder menuBuilder;
CoffeeShopDirector coffeeShopDirector;

Console.Write("Choose between French or Italian breakfast: ");
if (Enum.TryParse(Console.ReadLine(), ignoreCase: true, out CoffeeShop coffeeShop) && Enum.IsDefined(coffeeShop))
{
    menuBuilder = coffeeShop switch
    {
        CoffeeShop.French => new FrenchBreakfastMenuBuilder(),
        CoffeeShop.Italian => new ItalianBreakfastMenuBuilder(),
        _ => throw new NotSupportedException()
    };

    coffeeShopDirector = new CoffeeShopDirector(menuBuilder);
}

else
{
    Console.WriteLine("Wrong value!");
    return;
}

Console.WriteLine(@"Choose between one of the following menus:
Hot drink + Dessert [1]
Cold drink + Dessert [2]
Hot drink + Cold drink [3]
Hot drink + Cold drink + Dessert [4]");

if (Enum.TryParse(Console.ReadLine(), ignoreCase: true, out MenuType menuType) && Enum.IsDefined(menuType))
{
    coffeeShopDirector.PrepareMenu(menuType);
    menu = menuBuilder.GetMenu();

    Console.WriteLine($"{coffeeShop} Breakfast:");
    menu.Print();
}

else
{
    Console.WriteLine("Wrong value!");
    return;
}