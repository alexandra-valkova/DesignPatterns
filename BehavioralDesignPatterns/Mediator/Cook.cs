﻿namespace Mediator
{
    public class Cook : Employee
    {
        public Cook(string name, IMediator mediator) : base(name, mediator)
        {
        }
    }
}
