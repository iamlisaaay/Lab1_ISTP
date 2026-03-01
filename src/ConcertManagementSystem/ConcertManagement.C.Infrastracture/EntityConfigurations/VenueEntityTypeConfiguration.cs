using ConcertManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcertManagement.Infrastructure.EntityConfigurations;

internal class VenueEntityTypeConfiguration : IEntityTypeConfiguration<Venue>
{
    public void Configure(EntityTypeBuilder<Venue> builder)
    {
        builder.HasKey(v => v.Id); 

        builder.Property(v => v.Name)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(v => v.Address)
            .HasColumnType("text");

        builder.Property(v => v.Capacity).IsRequired();
        builder.Property(v => v.TotalSeats).IsRequired();
        builder.Property(v => v.TotalRows).IsRequired();
    }
}