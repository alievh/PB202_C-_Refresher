using LibraryApp.Models.Base;

namespace LibraryApp.Models;

public class Rent : BaseEntity
{
    private static int _counter;

    public Book Book { get; set; }
    public User User { get; set; }
    public DateTime RentDate { get; set; }
    public DateTime RefundDate { get; set; }
    public Rent()
    {
        Id = ++_counter;
    }
}
