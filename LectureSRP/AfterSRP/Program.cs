using System;

namespace SRP
{
    class Program
    //using SRP, we can now make changes in all the new classes without having to chain the main class
    {
        static void Main(string[] args)
        {
            //display welcome message
            StandardMessages.WelcomeMessage();

            //ask user for information
            Person user = PersonDataCapture.Capture();

            //checks first & last name for validity
            bool isUserValid = PersonValidatior.Validate(user);

            //exit program if name is invalid
            if (isUserValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            //create person's username -- ex: kheishman
            AccountGenerator.CreateAccount(user);

            //exit program after displaying username
            StandardMessages.EndApplication();
        }
    }
}
