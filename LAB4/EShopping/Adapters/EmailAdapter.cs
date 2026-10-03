namespace EShopping.Adapters
{
    public class EmailAdapter
    {
        public bool Send(string email, string subject, string body)
        {
            return !string.IsNullOrWhiteSpace(email);
        }
    }
}
