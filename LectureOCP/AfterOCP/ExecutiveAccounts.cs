using System;
namespace OCP
{
    public class ExecutiveAccounts : IAccounts
    {
        public Employee Create(IPerson person)
        {
            Employee output = new Employee();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@msu.edu"; //diff email for execs
            output.IsExecutive = true;
            output.IsManager = true;

            return output;
        }
    }
}
