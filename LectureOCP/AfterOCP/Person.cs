using System;
namespace OCP
{
    public class Person : IPerson //Person class now inherets IPerson interface
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public EmployeeType TypeOfEmployee { get; set; }

        public IAccounts AccountProcessor { get; set; } = new Accounts(); //newing up Accounts here instead of main class for OCP

    }
}
