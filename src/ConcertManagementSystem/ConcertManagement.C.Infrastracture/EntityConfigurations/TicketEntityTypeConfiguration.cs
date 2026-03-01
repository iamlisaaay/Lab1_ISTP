using ConcertManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcertManagement.Infrastructure.EntityConfigurations;

internal class TicketEntityTypeConfiguration : IEntityTypeConfiguration<Ticket>
{
    public void Configure(EntityTypeBuilder<Ticket> builder)
    {
        builder.HasKey(t => t.Id); 

        builder.Property(t => t.SeatNumber).HasColumnName("seat_number");
        builder.Property(t => t.RowNumber).HasColumnName("row_number");

        builder.Property(t => t.Price)
            .HasColumnType("numeric(10,2)")
            .IsRequired();

        builder.Property(t => t.Status)
            .HasMaxLength(50);

   
        builder.HasOne(t => t.Concert)
            .WithMany(c => c.Tickets)
            .HasForeignKey(t => t.ConcertId);

  
        builder.HasOne(t => t.Customer)
            .WithMany(cust => cust.Tickets)
            .HasForeignKey(t => t.CustomerId);
    }
}