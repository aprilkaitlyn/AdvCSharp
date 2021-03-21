  public class Chore
    {
        public string ChoreName { get; set; }
        public Person Owner { get; set; } //bad dependency on Person class no no
        public double HoursWorked { get; private set; }
        public bool IsComplete { get; private set; }

        public void PerformedChore(double hours)
        {
            HoursWorked += hours;
            Logger log = new Logger();
            log.Log($"{Owner.FirstName} worked on {ChoreName}");
        }

        public void CompletedChore()
        {
            IsComplete = true;
            Logger log = new Logger();
            log.Log($"Completed {ChoreName} and it took {HoursWorked} hours");

            Emailer emailer = new Emailer();
            emailer.SendEmail(Owner, $"The chore {ChoreName} is complete and took {HoursWorked} hours");
        }
    }
