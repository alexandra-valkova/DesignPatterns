﻿using System;

namespace ChainOfResponsibility.Employees
{
    public abstract class Employee
    {
        protected Priority level;

        public Employee successor;

        public void SetSuccessor(Employee successor)
        {
            this.successor = successor;
        }

        public void ProcessComplaint(Complaint complaint)
        {
            if (complaint.Priority <= level)
            {
                Respond(complaint);
            }

            else if (successor != null)
            {
                successor.ProcessComplaint(complaint);
            }

            else
            {
                Console.WriteLine("Complaint cannot be handled!");
            }
        }

        protected virtual void Respond(Complaint complaint)
        {
            Console.WriteLine("Mr/Mrs {0}, your complaint will be handled by the {1}", complaint.CustomerName, GetType().Name.ToString());
        }
    }
}
