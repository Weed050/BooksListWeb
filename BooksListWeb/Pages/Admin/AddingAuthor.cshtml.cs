using BooksListWeb.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using BooksListWeb.Data;
using BooksListWeb.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BooksListWeb.Pages.Admin
{
    public class AddingModel2 : PageModel
    {
        [BindProperty]
        public AddWhatFormContainsAuthor AddAuthorRecord { get; set; }
        public void OnGet()
        {
        }
        public void OnPost()
        {
        }
    }
}
