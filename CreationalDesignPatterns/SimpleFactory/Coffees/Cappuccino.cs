﻿namespace SimpleFactory.Coffees
{
    public class Cappuccino : Coffee
    {
        public override string Name
        {
            get { return "Cappuccino"; }
        }

        public override int CoffeeContent
        {
            get { return 100; }
        }

        public override int MilkContent
        {
            get { return 200; }
        }
    }
}
