using LibraryApp.Interfaces;
using LibraryApp.Models.Base;

namespace LibraryApp.Models;

public class Library : BaseEntity, ILibrary
{
    private static int _counter;

    List<Book> books;

    public Library()
    {
        books = new List<Book>();
        Id = ++_counter;
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public List<Book> FilterByAuthor(string author)
    {
        return books.FindAll(x => x.Author == author);
    }

    public List<Book> FilterByGenre(string genre)
    {
        List<Book> filteredBooks = new List<Book>();
        foreach (var book in books)
        {
            foreach (var value in book.Genres)
            {
                if (value.ToString() == genre)
                    filteredBooks.Add(book);
            }
        }

        return filteredBooks;
    }

    public List<Book> FilterByIsAvailable()
    {
        return books.FindAll(n => n.IsAvailable);
    }

}
