using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using T4Ex24.Models;

namespace T4Ex24.Pages
{
    public class BooksModel : PageModel
    {
        private static readonly List<Book> _allBooks = new()
        {
            new("El Quixot", "Miguel de Cervantes"),
            new("Cien años de soledad", "Gabriel García Márquez"),
            new("1984", "George Orwell"),
            new("To Kill a Mockingbird", "Harper Lee"),
            new("The Great Gatsby", "F. Scott Fitzgerald"),
            new("Pride and Prejudice", "Jane Austen"),
            new("The Catcher in the Rye", "J.D. Salinger"),
            new("Lord of the Flies", "William Golding"),
            new("Animal Farm", "George Orwell"),
            new("Brave New World", "Aldous Huxley"),
            new("The Lord of the Rings", "J.R.R. Tolkien"),
            new("Harry Potter and the Philosopher's Stone", "J.K. Rowling")
        };

        [BindProperty]
        public string SearchTerm { get; set; } = string.Empty;

        public List<Book> FilteredBooks { get; set; } = new();

        public void OnGet()
        {
            FilteredBooks = _allBooks;
        }

        public void OnPost()
        {
            if (string.IsNullOrWhiteSpace(SearchTerm))
            {
                FilteredBooks = _allBooks;
            }
            else
            {
                FilteredBooks = _allBooks
                    .Where(book => book.Title.ToLower().Contains(SearchTerm.ToLower()))
                    .ToList();
            }
        }
    }
}
