using Mediator;
using Mediator.Employees;

IMediator mediator = new Mediator.Mediator();

Employee waiter = new Waiter("John");
Employee cook = new Cook("Jack");

mediator.Register(waiter);
mediator.Register(cook);

waiter.Send(receiver: cook, message: "Cheesecake ordered!");
cook.Send(receiver: waiter, message: "Cheesecake is ready!");
