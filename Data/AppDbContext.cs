using Microsoft.EntityFrameworkCore;
using s32757test2.Models;

namespace s32757test2.Data;

public class AppDbContext : DbContext
{

    public DbSet<Guests> Guests { get; set; } = null!;
    public DbSet<Rooms> Rooms { get; set; } = null!;
    public DbSet<Reservations> Reservations { get; set; } = null!;
    public DbSet<Services> Services { get; set; } = null!;
    public DbSet<ReservationServices> ReservationServices { get; set; } = null!;


    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Guests>().HasKey(g => g.GuestId);
        modelBuilder.Entity<Rooms>().HasKey(ro => ro.Roomid);
        modelBuilder.Entity<Reservations>().HasKey(re => re.ReservationId);
        modelBuilder.Entity<Services>().HasKey(s => s.ServiceId);
        modelBuilder.Entity<ReservationServices>().HasKey(rs => new { rs.ReservationId, rs.ServiceId });


    }

}
