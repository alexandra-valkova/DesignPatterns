﻿namespace AbstractFactory.Coffees.Milk
{
    public class Macchiato : MilkCoffee
    {
        public override string Name
        {
            get { return "Macchiato"; }
        }

        public override int CoffeeContent
        {
            get { return 100; }
        }

        public override int MilkContent
        {
            get { return 100; }
        }
    }
}
