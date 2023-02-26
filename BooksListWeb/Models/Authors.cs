using System.ComponentModel.DataAnnotations;

namespace BooksListWeb.Models
{
    public class Authors
    {
        [Key]
        public int AuthorID { get; set; }
        public string? AuthorName { get; set; }
        public List<Books> Books { get; set; } = new List<Books>();
    }
}
