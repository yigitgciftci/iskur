using Microsoft.EntityFrameworkCore;

namespace SchoolApp.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<MainTeacher> MainTeachers { get; set; }
        public DbSet<GuideTeacher> GuideTeachers { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
    }
}
