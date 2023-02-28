using BooksListWeb.Data;
using BooksListWeb.Models;
using BooksListWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BooksListWeb.Pages.Admin
{
    public class AddingModel : PageModel
    {
        private readonly BooksDBContext _context;
        public AddingModel(BooksDBContext context)=> _context= context;

        [BindProperty]
        public AddWhatFormContainsBook AddBookRecord { get; set; }
        //[BindProperty]
        //public string? BookName { get; set; }
        //[BindProperty]
        //public string? selectAuthor { get; set; }
        //public IList<Authors>? Authors { get; set; }

        //public async Task OnGet() 
        //{
        //    Authors = await _context.Authors.ToListAsync();


        //}
        public IList<Authors> Authors { get; set; } = new List<Authors>();
        public async Task OnGet()
        {
           Authors = await _context.Authors.ToListAsync();
        }
        
    }
}
