namespace ChainOfResponsibility.Employees
{
    public class Waiter : Employee
    {
        public Waiter(Priority level)
        {
            this.level = level;
        }
    }
}
