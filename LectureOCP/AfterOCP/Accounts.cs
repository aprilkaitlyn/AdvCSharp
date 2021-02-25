using System;
namespace OCP
{
    public class Accounts : IAccounts
    {
        public Employee Create(IPerson person) //changed Person to IPerson
        {
            Employee output = new Employee();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@missouristate.edu";

            return output;
        }
    }
}
