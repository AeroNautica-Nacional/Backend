using AeroMexic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AeroMexic.Infrasctructure.Configurations
{
    public partial class RolePermissionConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.ToTable("RolePermission");
            builder.HasKey(rp => rp.Id);

            builder.Property(rp => rp.Role_Id)
                .IsRequired();

            builder.Property(rp => rp.Permission_Id)
                .IsRequired();

            builder.HasOne(rp => rp.RoleUser)
                .WithMany()
                .HasForeignKey(rp => rp.Role_Id)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(rp => rp.Permission)
                .WithMany()
                .HasForeignKey(rp => rp.Permission_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
