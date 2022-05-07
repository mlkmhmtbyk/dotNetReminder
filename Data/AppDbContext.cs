using Microsoft.EntityFrameworkCore;
using Reminder.Data.Models;

namespace Reminder.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {   
            
        }

        public DbSet<Book> Books {get; set; }
    }
}