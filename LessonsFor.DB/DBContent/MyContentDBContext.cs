// track

using Microsoft.EntityFrameworkCore;

namespace LessonsFor.DB.DBContent
{
    public class MyContentDBContext : DbContext
    {

        public MyContentDBContext() 
        {
            Database.EnsureCreated();
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("FileName=MyContentDB.db");
        }


        public DbSet<Student> Students { get; set; }
    }
}
