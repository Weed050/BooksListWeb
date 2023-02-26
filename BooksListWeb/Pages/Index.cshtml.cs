using BooksListWeb.Data;
using BooksListWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BooksListWeb.Pages
{
    public class IndexModel : PageModel
    {
     
        private readonly BooksDBContext _context; // read only 
        public IndexModel(BooksDBContext  context) => _context = context;

        public async void OnGet() // handler method; OnPost OnGet - HTTP request
        {
            Books = await _context.Books.Where(i => i.BookID != null)
                .OrderByDescending(i => i.BookID)
                .ToListAsync();
                
        }
        public IEnumerable<Books> Books { get; set; } = Enumerable.Empty<Books>(); // empty to not get null
    }
}