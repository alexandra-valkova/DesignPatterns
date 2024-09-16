using ChainOfResponsibility.Employees;

namespace ChainOfResponsibility
{
    public class CoffeeShopChain
    {
        private readonly List<Employee> _employees;

        public CoffeeShopChain()
        {
            Employee waiter = new Waiter(Priority.Low);
            Employee cook = new Cook(Priority.Medium);
            Employee manager = new Manager(Priority.High);

            waiter.SetSuccessor(cook);
            cook.SetSuccessor(manager);

            _employees = [waiter, cook, manager];
        }

        public Employee GetEmployee()
        {
            return _employees.First(employee => employee.Level == Priority.Low);
        }
    }
}
