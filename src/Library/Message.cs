namespace Library
{
    public class Message
    {
        protected Message(Phonebook from, string[] to)
        {
            this.From = from;
            this.To = to;
        }

        public string Text { get; set; }

        public Phonebook From { get; }

        public string[] To { get; }
    }
}