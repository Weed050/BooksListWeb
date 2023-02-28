using BooksListWeb.Data;
using BooksListWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BooksListWeb.Pages.Admin
{
    public class AddingModel : PageModel
    {
        [BindProperty]
        public string? BookName { get; set; }
        [BindProperty]
        public string? selectAuthor { get; set; }
        public IList<Authors>? Authors { get; set; }

        //public async Task OnGet() 
        //{
        //    Authors = await _context.Authors.ToListAsync();


        //}
        public void OnGet()
        {
           
        }
    }
}
