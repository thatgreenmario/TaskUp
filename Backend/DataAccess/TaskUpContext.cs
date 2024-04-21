using Backend.DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend.Repository
{
    public class TaskUpContext : DbContext
    {
        public TaskUpContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
