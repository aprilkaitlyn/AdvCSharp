using System;
using Microsoft.Extensions.DependencyInjection;

namespace DIPLecture //the high level module is Main. The low level modules are the Person, Chore, Logger, Emailer classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var diContainer = Startup.ConfigureService(); //dependency injection

            var owner = diContainer.GetRequiredService<IPerson>();
            owner.FirstName = "Kaitlyn";
            owner.LastName = "Heishman";
            owner.EmailAddress = "kh@gmail.com";
            owner.PhoneNumber = "123-123-1234"; //added owner. to beginning of each

            var chore = diContainer.GetRequiredService<IChore>();
            chore.ChoreName = "Vacuum";
            chore.Owner = owner;

            chore.PerformedChore(3);
            chore.PerformedChore(1.5);
            chore.CompletedChore();

            Console.ReadLine();
        }
    }
}
