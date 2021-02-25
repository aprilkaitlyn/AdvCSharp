using System;
namespace OCP
{
    public class Employee : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public bool IsManager { get; set; } = false; //sets default to false
        public bool IsExecutive { get; set; } = false;

    }
}
