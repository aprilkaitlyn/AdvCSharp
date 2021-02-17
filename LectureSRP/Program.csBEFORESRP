using System;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to advanced C#!");

            //ask user for information
            Person user = new Person();

            Console.WriteLine("What is your first name?");
            user.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            user.LastName = Console.ReadLine();

            //checks first & last name for validity
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("First name is not valid");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("First name is not valid");
                Console.ReadLine();
                return;
            }

            //create person's username -- ex: kheishman
            Console.WriteLine($"Your username is: {user.FirstName.Substring(0,1)}{user.LastName}");
            Console.ReadLine();
        }
    }
}
