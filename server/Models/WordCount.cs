namespace server.Models
{
    public class WordCount
    {
        public virtual string Word { get; set; }

        public virtual long UserId { get; set; }

        public virtual long Count { get; set; }
    }
}
