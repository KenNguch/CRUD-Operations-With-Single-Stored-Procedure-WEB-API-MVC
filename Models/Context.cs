using Microsoft.EntityFrameworkCore;

namespace CRUD_WEB_API_SP_MVC.Models
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> options) :base (options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        private    DbSet<Book> Books { get; set;}
     private    DbSet<Author> Authors { get; set;}
    }
}