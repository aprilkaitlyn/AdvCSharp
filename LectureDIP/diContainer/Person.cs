namespace DIPLecture //the high level module is Main. The low level modules are the Person, Chore, Logger, Emailer classes
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

    }
}
