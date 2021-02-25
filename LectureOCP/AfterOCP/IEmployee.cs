namespace OCP
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string EmailAddress { get; set; }
        bool IsManager { get; set; }
        bool IsExecutive { get; set; }
    }
}
