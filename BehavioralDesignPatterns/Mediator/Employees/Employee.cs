namespace Mediator.Employees
{
    public abstract class Employee
    {
        public string Name { get; set; }

        protected Employee(string name)
        {
            Name = name;
        }

        protected IMediator? Mediator { get; private set; }

        public void SetMediator(IMediator mediator)
        {
            Mediator = mediator;
        }

        public void Send(Employee receiver, string message)
        {
            Mediator?.SendMessage(sender: this, receiver, message);
        }

        public void Receive(Employee sender, string message)
        {
            Console.WriteLine($"{sender} to {this}: {message}");
        }

        public abstract override string ToString();
    }
}
