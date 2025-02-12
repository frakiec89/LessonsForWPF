// track
using Microsoft.EntityFrameworkCore;

namespace LessonsForWPF.DB
{
    public class MyMyContext : DbContext
    {


        public MyMyContext() 
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
