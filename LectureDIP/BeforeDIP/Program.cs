using System;

namespace DIPLecture //the high level module is Main. The low level modules are the Person, Chore, Logger, Emailer classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person owner = new Person
            {
                FirstName = "Kaitlyn",
                LastName = "Heishman",
                EmailAddress = "kh@gmail.com",
                PhoneNumber = "123-123-1234"
            };
            Chore chore = new Chore
            {
                ChoreName = "Vacuum",
                Owner = owner
            };

            chore.PerformedChore(3);
            chore.PerformedChore(1.5);
            chore.CompletedChore();

            Console.ReadLine();
        }
    }
 }
