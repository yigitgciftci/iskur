using Microsoft.EntityFrameworkCore;

namespace JQueryUIExample.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }
        
    }
}
