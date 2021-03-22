using System;

namespace DIPLecture //the high level module is Main. The low level modules are the Person, Chore, Logger, Emailer classes
{
    public class Emailer : IEmailer
    {
        public void SendEmail(IPerson p, string msg)
        {
            Console.WriteLine($"Simulating sending an email to {p.EmailAddress}");
        }
    }
}
