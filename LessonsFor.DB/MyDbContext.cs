// track

using Microsoft.EntityFrameworkCore;

namespace LessonsFor.DB
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=MyDb.db");
        }

        public DbSet<User> Users { get; set; }
    }
}
