namespace OCP
{
    public interface IPerson //clicked on Person in the Person Class --> Extract Interface
    {
        string FirstName { get; set; }
        string LastName { get; set; }

        IAccounts AccountProcessor { get; set; }
    }
}
