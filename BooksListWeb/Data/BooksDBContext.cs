using BooksListWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksListWeb.Data
{
    public class BooksDBContext : DbContext
    {
        public BooksDBContext(DbContextOptions options):base(options) 
        {

        }
        public DbSet<Books> Books { get; set; }
        public DbSet<Authors> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.ApplyConfiguration();
        }

    }
}
