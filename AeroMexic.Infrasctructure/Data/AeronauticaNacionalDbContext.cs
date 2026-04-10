using AeroMexic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AeroMexic.Infrasctructure.Data
{
    public partial class AeronauticaNacionalDbContext : DbContext
    {
        public AeronauticaNacionalDbContext(DbContextOptions<AeronauticaNacionalDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<RoleUser> RoleUsers { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}