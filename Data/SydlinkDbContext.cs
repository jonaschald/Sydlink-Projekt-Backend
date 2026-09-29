using Backend_Rider.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Rider.Data;

public class SydlinkDbContext : DbContext
{
    public SydlinkDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Sag> Sager => Set<Sag>();
    public DbSet<Kunde> Kunder => Set<Kunde>();
    public DbSet<Medarbejder> Medarbejdere => Set<Medarbejder>();
    public DbSet<Besked> Beskeder => Set<Besked>();
}
