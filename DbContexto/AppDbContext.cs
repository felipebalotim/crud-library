using Microsoft.EntityFrameworkCore;
using library.Models;

namespace library.DbContexto
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Book> Book { get; set; }
    }
}