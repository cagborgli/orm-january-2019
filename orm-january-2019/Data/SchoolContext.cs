using Microsoft.EntityFrameworkCore;
using orm_january_2019.Data.Entity;

namespace orm_january_2019.Data
{
    public class SchoolContext : DbContext
    {
    
        public DbSet<Student> Students { get; set; }

        public DbSet<Major> Major { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("server=127.0.0.1;port=5432;database=example;userid=postgres;password=bondstone");
        }

    }
    
}