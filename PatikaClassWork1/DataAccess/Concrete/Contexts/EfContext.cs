using Microsoft.EntityFrameworkCore;
using PatikaClassWork1.Entity.Concrete;

namespace PatikaClassWork1.DataAccess.Concrete.Contexts
{
    public class EfContext : DbContext
    {
        public EfContext() { }
        public EfContext(DbContextOptions options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer(new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build().GetConnectionString("MsSqlConnectionString"));
        }
    }
}