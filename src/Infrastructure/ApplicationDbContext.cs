using Domain.Entities.Users;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
            => Database.Migrate();

        public DbSet<User> Users { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
