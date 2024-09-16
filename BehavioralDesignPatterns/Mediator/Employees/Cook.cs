namespace Mediator.Employees
{
    public class Cook : Employee
    {
        public Cook(string name) : base(name)
        {
        }

        public override string ToString() => $"Cook {Name}";
    }
}
