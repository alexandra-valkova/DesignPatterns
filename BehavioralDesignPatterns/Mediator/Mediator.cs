using Mediator.Employees;

namespace Mediator
{
    public class Mediator : IMediator
    {
        private readonly Dictionary<string, Employee> _employees;

        public Mediator()
        {
            _employees = [];
        }

        public void Register(Employee employee)
        {
            _employees.Add(key: employee.Name, value: employee);
            employee.SetMediator(this);
        }

        public void SendMessage(Employee sender, Employee receiver, string message)
        {
            if (_employees.GetValueOrDefault(receiver.Name) is not null)
            {
                receiver.Receive(sender, message);
            }
        }
    }
}
