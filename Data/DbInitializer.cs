using Microsoft.EntityFrameworkCore;
using ThuVien_AIP.Models;

namespace ThuVien_AIP.Data
{
    public class DbInitializer
    {
        private readonly ModelBuilder _builder;

        public DbInitializer(ModelBuilder builder)
        {
            _builder = builder;
        }

        public void Seed()
        {

            _builder.Entity<BookAuthor>(b =>
            {
                b.HasData(new Author
                {                 
                    FullName = "Harry Potter and the Sorcerer's Stone",
                });

                b.HasData(new Author
                {
                    FullName = "Harry Potter and the Chamber of Secrets",
                });

            });
    }
    }
}

