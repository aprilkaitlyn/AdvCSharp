using System;
using System.Collections.Generic;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel {FirstName = "Kaitlyn", LastName = "Heishman", TypeOfEmployee = EmployeeType.Executive},
                new PersonModel {FirstName = "Lana", LastName = "Rosen", TypeOfEmployee = EmployeeType.Manager},
                new PersonModel {FirstName = "Stella", LastName = "Montclair"}
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
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
