using System;

namespace DIPLecture //the high level module is Main. The low level modules are the Person, Chore, Logger, Emailer classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person owner = new Person //newing up - high level module is depending on low level module (Person class) 
            {
                FirstName = "Kaitlyn",
                LastName = "Heishman",
                EmailAddress = "kh@gmail.com",
                PhoneNumber = "123-123-1234"
            };
            Chore chore = new Chore //newing up - high level module is depending on low level module (Chore class) 
            {
                ChoreName = "Vacuum",
                Owner = owner //also dependant on Person Class
            };

            chore.PerformedChore(3);
            chore.PerformedChore(1.5);
            chore.CompletedChore();

            Console.ReadLine();
        }
    }
 }
