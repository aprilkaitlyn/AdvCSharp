namespace DIPLecture
{
    public interface IEmailer
    {
        void SendEmail(IPerson p, string msg);
    }
}
