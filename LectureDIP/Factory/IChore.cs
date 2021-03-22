namespace DIPLecture
{
    public interface IChore
    {
        string ChoreName { get; set; }
        IPerson Owner { get; set; }
        double HoursWorked { get; }
        bool IsComplete { get; }

        void CompletedChore();
        void PerformedChore(double hours);
    }
}
