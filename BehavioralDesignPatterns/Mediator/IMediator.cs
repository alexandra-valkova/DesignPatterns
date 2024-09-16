using Mediator.Employees;

namespace Mediator
{
    public interface IMediator
    {
        void Register(Employee employee);

        void SendMessage(Employee sender, Employee receiver, string message);
    }
}
