using System;
namespace SRP
{
    public class AccountGenerator
    {
        public static void CreateAccount(Person person)
        {
            Console.WriteLine($"Your username is: {person.FirstName.Substring(0, 1)}{person.LastName}");   
        }
    }
}
