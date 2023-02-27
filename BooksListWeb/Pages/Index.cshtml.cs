using BooksListWeb.Data;
using BooksListWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BooksListWeb.Pages
{
    public class IndexModel : PageModel
    {

        private readonly BooksDBContext _context; // read only 
        public IndexModel(BooksDBContext context)
        {
            _context = context;
        }
        //public IList<Books> Books { get; set; }
        public IList<Books> Books { get; set; }
        public async Task OnGet() // handler method; OnPost OnGet - HTTP request
        {

            //var xxx = await _context.Books.ToListAsync();
            Books = await _context.Books.ToListAsync();


        }

    }
}