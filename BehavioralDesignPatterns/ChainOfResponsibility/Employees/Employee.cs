namespace ChainOfResponsibility.Employees
{
    public abstract class Employee
    {
        public Priority Level { get; private set; }

        public Employee? Successor { get; private set; }

        protected Employee(Priority level)
        {
            Level = level;
        }

        public void SetSuccessor(Employee successor)
        {
            Successor = successor.Level > Level
                ? successor
                : throw new ArgumentException("Cannot assign successor with a lower or equal priority level!", nameof(successor));
        }

        public void ProcessComplaint(Complaint complaint)
        {
            if (complaint.Priority <= Level)
            {
                Respond(complaint);
            }

            else if (Successor is not null)
            {
                Successor.ProcessComplaint(complaint);
            }

            else
            {
                Console.WriteLine("Complaint cannot be handled!");
            }
        }

        protected virtual void Respond(Complaint complaint)
        {
            Console.WriteLine($"Mr/Mrs {complaint.CustomerName}, your complaint will be handled by the {GetType().Name}.");
        }
    }
}
