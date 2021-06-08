
using Microsoft.EntityFrameworkCore;
using NET5SignalR.Models;

namespace NET5SignalR.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext (DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<NET5SignalR.Models.Employee> Employee { get; set; }
        public DbSet<Notification> Notification { get; set; }
    }
}
