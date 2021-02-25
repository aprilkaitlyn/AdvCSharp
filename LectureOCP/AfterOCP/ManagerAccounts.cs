using System;
namespace OCP
{
    public class ManagerAccounts : IAccounts
    {
        public Employee Create(IPerson person)
        {
            Employee output = new Employee();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@missouristate.edu";

            output.IsManager = true;

            return output;
        }
    }
}
