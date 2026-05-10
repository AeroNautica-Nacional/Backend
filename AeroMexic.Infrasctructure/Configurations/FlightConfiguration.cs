using AeroMexic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AeroMexic.Infrasctructure.Configurations
{
    public partial class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.ToTable("flight");
            builder.HasKey(f => f.Id);
        }
    }
}
