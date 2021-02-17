using System;
namespace SRP
{
    public class StandardMessages
    //allows us to change console messages without recompling the main class
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to advanced C#!");
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"{fieldName} is not valid!");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Press Enter to close");
            Console.ReadLine();
        }
    }
}
