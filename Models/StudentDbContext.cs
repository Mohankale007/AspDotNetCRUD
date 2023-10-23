using Microsoft.EntityFrameworkCore;

namespace CodeFirstAspCoreMVC.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Student> Students { get; set; }
    }
}
