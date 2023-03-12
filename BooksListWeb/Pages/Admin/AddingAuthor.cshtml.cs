using BooksListWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Web;

using BooksListWeb.Data;
using BooksListWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Identity.Client;

namespace BooksListWeb.Pages.Admin
{
    public class AddingModel2 : PageModel
    {
        private readonly BooksDBContext _booksDBContext;

        [BindProperty]
        public AddWhatFormContainsAuthor AddAuthorRecord { get; set; }
        public void OnGet()
        {
        }

        public AddingModel2(BooksDBContext BooksDBContext)
        {
            _booksDBContext = BooksDBContext;
        }
        public Task OnPost()
        {
            var NewRegistration1 = new Authors()
            {

                AuthorName = AddAuthorRecord.AuthorName
            };

            _booksDBContext.Authors.Add(NewRegistration1);
            _booksDBContext.SaveChanges();
            //string urlHome = "/Admin/AddingAuthor";
            //ActionResult MyAction(string url)
            //{
            //    return Redirect(url);
            //}
            //MyAction(urlHome);
            return Task.CompletedTask;
        }
    }
}
