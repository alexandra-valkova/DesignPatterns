﻿using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            CoffeeShop coffeeShop = new CoffeeShop();
            coffeeShop.DisplayDesserts();

            Console.ReadKey(true);
        }
    }
}
