using ChainOfResponsibility;
using ChainOfResponsibility.Employees;

Complaint complaint = new();

Console.WriteLine("Customer Name: ");
complaint.CustomerName = Console.ReadLine();

Console.Write("Enter priority (Low/Medium/High): ");
if (Enum.TryParse(Console.ReadLine(), ignoreCase: true, out Priority priority) && Enum.IsDefined(priority))
{
    complaint.Priority = priority;
}

else
{
    Console.WriteLine("Wrong value!");
    return;
}

CoffeeShopChain coffeeShop = new();
Employee employee = coffeeShop.GetEmployee();
employee.ProcessComplaint(complaint);
