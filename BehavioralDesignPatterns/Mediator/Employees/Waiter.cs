namespace Mediator.Employees
{
    public class Waiter : Employee
    {
        public Waiter(string name) : base(name)
        {
        }

        public override string ToString() => $"Waiter {Name}";
    }
}
