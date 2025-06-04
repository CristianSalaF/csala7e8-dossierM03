namespace T4Ex24.Models
{
    public class Book
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;

        public Book() { }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}
