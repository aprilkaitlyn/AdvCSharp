using System;
namespace OCP
{
    public class Accounts
    {
        public EmployeeModel Create(PersonModel person) {
            EmployeeModel output = new EmployeeModel();

            output.FirstName = person.FirstName;
            output.LastName = person.LastName;
            output.EmailAddress = $"{person.FirstName.Substring(0, 1)}{person.LastName}@missouristate.edu";
    

            switch (person.TypeOfEmployee) //option hold will add a case for each field !!
            {
                case EmployeeType.Staff:
                    break;
                case EmployeeType.Manager: output.IsManager = true;
                    break;
                case EmployeeType.Executive: output.IsExecutive = true; output.IsManager = true; 
                    break;
                default: throw new ArgumentException();
            }

            return output;
        }
    }
}
