namespace TheMailer.Models
{
    public class Email
    {
        public string Subject
        {
            get;
            set;
        }

        public string Message
        {
            get;
            set;
        }

        public string Priority
        {
            get;
            set;
        }

        public string SentDate
        {
            get;
            set;
        }
    }
}