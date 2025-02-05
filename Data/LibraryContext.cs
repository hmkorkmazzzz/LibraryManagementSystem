using Microsoft.EntityFrameworkCore;
using LibraryManagementSystem.Models;

// LibraryContext sınıfı, Entity Framework Core'un DbContext sınıfından türetilmiştir.
// Bu sınıf, veritabanı ile etkileşim kurmak için kullanılır ve uygulamanın veritabanı bağlamını temsil eder.

namespace LibraryManagementSystem.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
