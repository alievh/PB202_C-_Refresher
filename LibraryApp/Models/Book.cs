using LibraryApp.Enums;
using LibraryApp.Models.Base;

namespace LibraryApp.Models
{
    public class Book : BaseEntity
    {
        private static int _counter;

        public Book()
        {
            Id = ++_counter;
        }

        public string Name { get; set; }
        public string Author { get; set; }
        public List<Genre> Genres { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }
    }
}
