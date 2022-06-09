using Microsoft.EntityFrameworkCore;

namespace CourseeApp.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
        {
        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Request> Requests { get; set; }
    }
}
