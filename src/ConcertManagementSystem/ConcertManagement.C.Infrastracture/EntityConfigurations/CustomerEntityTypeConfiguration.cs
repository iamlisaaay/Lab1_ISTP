using ConcertManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcertManagement.Infrastructure.EntityConfigurations;

internal class CustomerEntityTypeConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.HasKey(c => c.Id); 

        builder.Property(c => c.FullName)
            .HasColumnName("full_name")
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(c => c.BirthDate)
            .HasColumnName("birth_date")
            .HasColumnType("date");

        builder.Property(c => c.LoyaltyDiscount)
            .HasColumnName("loyalty_discount")
            .HasColumnType("numeric(5,2)");
    }
}