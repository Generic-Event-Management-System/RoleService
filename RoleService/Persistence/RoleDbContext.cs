using Microsoft.EntityFrameworkCore;
using RoleService.Models.Entities;

namespace RoleService.Persistence
{
    public class RoleDbContext : DbContext
    {
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        public RoleDbContext(DbContextOptions<RoleDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>()
                .HasOne<Role>()
                .WithMany(t => t.UserRoles)
                .HasForeignKey("RoleId")
                .IsRequired();
        }
    }
}
