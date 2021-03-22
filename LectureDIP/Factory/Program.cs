using System;

namespace DIPLecture //the high level module is Main. The low level modules are the Person, Chore, Logger, Emailer classes
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson owner = Factory.CreatePerson(); //removed newing up a Person
            owner.FirstName = "Kaitlyn";
            owner.LastName = "Heishman";
            owner.EmailAddress = "kh@gmail.com";
            owner.PhoneNumber = "123-123-1234"; //added owner. to beginning of each

            IChore chore = Factory.CreateChore(); //removed newing up a Chore
            chore.ChoreName = "Vacuum";
            chore.Owner = owner;

            chore.PerformedChore(3);
            chore.PerformedChore(1.5);
            chore.CompletedChore();

            Console.ReadLine();
        }
    }
}
