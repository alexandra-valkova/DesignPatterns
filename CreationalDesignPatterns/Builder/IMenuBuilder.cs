﻿namespace Builder
{
    public interface IMenuBuilder
    {
        void AddHotDrink();
        void AddColdDrink();
        void AddDessert();
        Menu GetMenu();
    }
}
