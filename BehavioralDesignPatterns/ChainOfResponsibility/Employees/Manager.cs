namespace ChainOfResponsibility.Employees
{
    public class Manager : Employee
    {
        public Manager(Priority level)
        {
            this.level = level;
        }
    }
}
