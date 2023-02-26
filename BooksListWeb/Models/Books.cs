using System.ComponentModel.DataAnnotations;

namespace BooksListWeb.Models
{
    public class Books
    {
        [Key]
        public int BookID { get; set; }
        public string? BookName { get; set; }
        public Authors? AuthorsID { get; set; }
      
    }
}
