using System;
namespace SRP
{
    public class PersonDataCapture
    {
        public static Person Capture() //not void since we are returning a Person object
        {
            Person output = new Person();

            Console.WriteLine("What is your first name?");
            output.FirstName = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}
