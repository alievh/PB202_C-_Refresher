using LibraryApp.Models.Base;

namespace LibraryApp.Models;

public class User : BaseEntity
{
    private static int _counter;
    public string Name { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }

    public User()
    {
        Id = ++_counter;
    }
}
