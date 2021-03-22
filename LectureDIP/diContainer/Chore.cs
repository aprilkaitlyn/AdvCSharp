namespace DIPLecture //the high level module is Main. The low level modules are the Person, Chore, Logger, Emailer classes
{
    public class Chore : IChore
    {
        ILogger _logger; //local variables
        IEmailer _email;

        public string ChoreName { get; set; }
        public IPerson Owner { get; set; }
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public Chore(ILogger log, IEmailer email) //dependency injection, removes dependencies from PerfomedChore & CompletedChore
        {
            _logger = log; //whatever log is passed in will be set equal to _logger
            _email = email;
        }

        public void PerformedChore(double hours)
        {
            HoursWorked += hours;
            _logger.Log($"{Owner.FirstName} worked on {ChoreName}");
        }

        public void CompletedChore()
        {
            IsComplete = true;
            _logger.Log($"Completed {ChoreName} and it took {HoursWorked} hours");
            _email.SendEmail(Owner, $"The chore {ChoreName} is complete and took {HoursWorked} hours");
        }
    }
}
