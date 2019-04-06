namespace Generics
{
    public class Book
    {
        private readonly string _title;
        public string Isbn { get; set; }

        public Book(string title)
        {
            _title = title;
        }
    }
}