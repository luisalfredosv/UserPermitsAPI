using Microsoft.EntityFrameworkCore;

namespace UserPermitsAPI.Models
{
    public class PermissionContext: DbContext
    {

        public PermissionContext(DbContextOptions<PermissionContext> options) : base(options){}

        public DbSet<Permission> Permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Permission>().HasIndex(c => c.Name).IsUnique();
        }
    }
}