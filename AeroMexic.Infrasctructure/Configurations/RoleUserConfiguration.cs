

using AeroMexic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AeroMexic.Infrasctructure.Configurations
{
    public partial class RoleUserConfiguration : IEntityTypeConfiguration<RoleUser>
    {
        public void Configure(EntityTypeBuilder<RoleUser> builder)
        {
            builder.ToTable("RoleUser");
            builder.HasKey(r => r.Id);

            builder.Property(r => r.Name)
                .HasColumnName("Name")
                .HasMaxLength(150)
                .IsRequired();
        }
    }
}
