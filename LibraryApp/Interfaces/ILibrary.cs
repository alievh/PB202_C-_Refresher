using LibraryApp.Models;

namespace LibraryApp.Interfaces;

public interface ILibrary
{
    public void AddBook(Book book);
    public List<Book> FilterByGenre(string genre);
    public List<Book> FilterByAuthor(string author);
    public List<Book> FilterByIsAvailable();
}
