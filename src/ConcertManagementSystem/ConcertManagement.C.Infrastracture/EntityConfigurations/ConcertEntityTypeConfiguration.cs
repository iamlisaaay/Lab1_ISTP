using ConcertManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcertManagement.Infrastructure.EntityConfigurations;

internal class ConcertEntityTypeConfiguration : IEntityTypeConfiguration<Concert>
{
    public void Configure(EntityTypeBuilder<Concert> builder)
    {
        builder.HasKey(c => c.Id); 

        builder.Property(c => c.Name)
            .HasColumnName("title")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(c => c.DateTime)
            .HasColumnName("date_time")
            .HasColumnType("datetime2")
            .IsRequired();

        
        builder.HasOne(c => c.Venue)
            .WithMany(v => v.Concerts)
            .HasForeignKey(c => c.VenueId);
    }
}