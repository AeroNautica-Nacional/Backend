using AeroMexic.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AeroMexic.Infrasctructure.Data
{
    public partial class AeronauticaNacionalDbContext : DbContext
    {
        public AeronauticaNacionalDbContext(DbContextOptions<AeronauticaNacionalDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<RoleUser> Roles { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RolePermission>()
                .HasKey(rp => new { rp.Role_Id, rp.Permission_Id });

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Role)
                .WithMany(r => r.RolePermissions)
                .HasForeignKey(rp => rp.Role_Id);

            modelBuilder.Entity<RolePermission>()
                .HasOne(rp => rp.Permission)
                .WithMany(p => p.RolePermissions)
                .HasForeignKey(rp => rp.Permission_Id);
        }
    }
}
