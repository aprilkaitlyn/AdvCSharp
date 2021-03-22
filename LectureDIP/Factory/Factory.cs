using System;
namespace DIPLecture
{
    public class Factory
    {
        public static IPerson CreatePerson()
        {
            return new Person();
        }

        public static IChore CreateChore()
        {
            return new Chore(CreateLogger(), CreateEmail()); //to match public Chore(ILogger log, IEmailer email)
        }

        public static ILogger CreateLogger()
        {
            return new Logger();
        }

        public static IEmailer CreateEmail()
        {
            return new Emailer();
        }
    } 
}
