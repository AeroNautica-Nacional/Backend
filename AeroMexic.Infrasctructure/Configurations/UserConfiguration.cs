using AeroMexic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroMexic.Infrasctructure.Configurations
{
    public partial class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            // Name my table
            builder.ToTable("User");

            // Primary key
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Name)
                .HasColumnName("Name")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.MiddleName)
                .HasColumnName("LastName")
                .HasMaxLength(150);

            builder.Property(u => u.PaternalLastName)
                .HasColumnName("PaternalLastName")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.MaternalLastName)
                .HasColumnName("MaternalLastName")
                .HasMaxLength(150)
                .IsRequired();

            builder.Property(u => u.Email)
                .HasColumnName("Email")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(u => u.Password)
                .HasColumnName("Password")
                .HasMaxLength(255)
                .IsRequired();

            builder.Property(u => u.Role_Id)
                .HasColumnName("Role_Id")
                .IsRequired();

            // Index unique in Email
            builder.HasIndex(u => u.Email)
                .IsUnique();
            
            builder.HasOne(u => u.Role)
                .WithMany()
                .HasForeignKey(u => u.Role_Id)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
