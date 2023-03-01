using BooksListWeb.Data;
using BooksListWeb.Models;
using BooksListWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BooksListWeb.Pages.Admin
{
    public class AddingModel1 : PageModel
    {
        private readonly BooksDBContext _context;
        

        public AddingModel1(BooksDBContext context)=> _context= context;

        [BindProperty]
        public AddWhatFormContainsBook AddBookRecord { get; set; }
        //[BindProperty]
        //public string? BookName { get; set; }
        //[BindProperty]
        //public string? selectAuthor { get; set; }
        //public IList<Authors>? Authors { get; set; }


        public IList<Authors> Authors { get; set; } = new List<Authors>();
        public async Task OnGet()
        {
           Authors = await _context.Authors.ToListAsync();
        }

    }

    // post data from form
    public class AddingModel1v2 : PageModel
    {
     
        private readonly BooksDBContext _contextPost;
        [BindProperty]
        public AddWhatFormContainsBook AddBookRecord { get; set; }
        public AddingModel1v2(BooksDBContext contextPost)
        {
            _contextPost = contextPost;
        }
        public void OnPost()
        {
            var NewRegisrationBook = new Books()
            {
                BookName = AddBookRecord.BookName,
                AuthorsID = AddBookRecord.AuthorsID
            };
            _contextPost.Books.Add(NewRegisrationBook);
            _contextPost.SaveChanges();
        }
    }
}
