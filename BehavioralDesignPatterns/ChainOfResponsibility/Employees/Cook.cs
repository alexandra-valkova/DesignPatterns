﻿namespace ChainOfResponsibility.Employees
{
    public class Cook : Employee
    {
        public Cook(Priority level)
        {
            this.level = level;
        }
    }
}
