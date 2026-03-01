using ConcertManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ConcertManagement.Infrastructure.EntityConfigurations;

internal class GroupEntityTypeConfiguration : IEntityTypeConfiguration<Group>
{
    public void Configure(EntityTypeBuilder<Group> builder)
    {
        builder.HasKey(g => g.Id);

        builder.Property(g => g.Name).HasMaxLength(255).IsRequired();
        builder.Property(g => g.Description).HasColumnType("text");
        builder.Property(g => g.LogoUrl).HasColumnName("logo_url").HasMaxLength(255);
        builder.Property(g => g.BgVideoUrl).HasColumnName("bg_video_url").HasMaxLength(255);
        builder.Property(g => g.FanClubUrl).HasColumnName("fan_club_url").HasMaxLength(255);
    }
}