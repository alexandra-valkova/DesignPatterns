﻿namespace Mediator
{
    public class Waiter : Employee
    {
        public Waiter(string name, IMediator mediator) : base(name, mediator)
        {
        }
    }
}
