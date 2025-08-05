using Microsoft.EntityFrameworkCore;
using SmartLibrary_MVC.Models;

namespace SmartLibrary_MVC.DBContext
{
    public class AppDBContext: DbContext
    {
        private readonly IConfiguration _configuration;

        public AppDBContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Category{ get; set; }
        public DbSet <Member> Members { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
