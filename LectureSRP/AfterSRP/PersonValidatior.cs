using System;
namespace SRP
{
    public class PersonValidatior
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError(person.FirstName);
                Console.ReadLine();
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError(person.LastName);
                Console.ReadLine();
                return false;
            }

            return true; //returns true if first & last name are both valid
        }
    }
}
