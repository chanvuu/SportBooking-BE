using Microsoft.EntityFrameworkCore;
using SportBooking.Domain.Entities;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }
    public DbSet<BankAccount> BankAccounts { get; set; }
    public DbSet<Court> Courts { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<Payment> Payments { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Unique OwnerId in BankAccount
        modelBuilder.Entity<BankAccount>()
            .HasIndex(x => x.OwnerId)
            .IsUnique();

        // Unique OwnerId in Court
        modelBuilder.Entity<Court>()
            .HasIndex(x => x.OwnerId)
            .IsUnique();

        // Unique BookingId in Payment
        modelBuilder.Entity<Payment>()
            .HasIndex(x => x.BookingId)
            .IsUnique();
    }
}