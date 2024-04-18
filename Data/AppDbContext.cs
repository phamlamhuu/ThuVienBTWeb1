using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ThuVien_AIP.Models;

namespace ThuVien_AIP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Author> Ạuthors { get; set; }
        public DbSet<Pubishers> Pubishers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        

    }
}
