using ConcertManagement.Domain.Entities;
using ConcertManagement.Infrastructure.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace ConcertManagement.Infrastructure;

public class ConcertContext : DbContext
{
    public ConcertContext(DbContextOptions<ConcertContext> options) : base(options)
    {
    }

    public DbSet<Concert> Concerts { get; set; }
    public DbSet<ConcertGroup> ConcertGroups { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Group> Groups { get; set; }
    public DbSet<GroupParticipant> GroupParticipants { get; set; }
    public DbSet<Member> Members { get; set; }
    public DbSet<Ticket> Tickets { get; set; }
    public DbSet<Venue> Venues { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

       
        modelBuilder.ApplyConfiguration(new VenueEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new ConcertEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new TicketEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new CustomerEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new GroupEntityTypeConfiguration());
        modelBuilder.ApplyConfiguration(new MemberEntityTypeConfiguration());

     
        modelBuilder.Entity<ConcertGroup>()
            .HasKey(cg => new { cg.ConcertId, cg.GroupId });

     
        modelBuilder.Entity<GroupParticipant>()
            .HasKey(gp => new { gp.GroupId, gp.MemberId });
    }
}