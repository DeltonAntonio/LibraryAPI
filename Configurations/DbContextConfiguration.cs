using LibraryAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Configurations
{
    public class DbContextConfiguration : DbContext
    {
        public DbContextConfiguration(DbContextOptions<DbContextConfiguration> options) : base(options) {}
        public DbSet<Book> Books { get; set; }
    }
}
