using AeroMexic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AeroMexic.Infrasctructure.Configurations
{
    public partial class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permission");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name)
                .HasColumnName("Name")
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
