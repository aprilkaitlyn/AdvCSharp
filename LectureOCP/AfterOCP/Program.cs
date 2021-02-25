using System;
using System.Collections.Generic;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IPerson> applicants = new List<IPerson> //changed Person to IPerson, eliminated dependency on Person class
            {
                new Executive {FirstName = "Kaitlyn", LastName = "Heishman"},
                new Manager {FirstName = "Lana", LastName = "Rosen"},
                new Person {FirstName = "Stella", LastName = "Montclair"}
            };

            List<IEmployee> employees = new List<IEmployee>(); //changed Employee to IEmployee

            foreach (var person in applicants)
            {
                employees.Add(person.AccountProcessor.Create(person)); //removes dependancy on Accounts class
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}: {emp.EmailAddress} -- Is Manager? {emp.IsManager} -- Is Executive? {emp.IsExecutive}");
            }

            Console.ReadLine();
        }
    }

    public enum EmployeeType
    {
        Staff,
        Manager,
        Executive
    }
}
