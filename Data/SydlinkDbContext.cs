using Backend_Rider.Models;

namespace Backend_Rider.Data;

public class SydlinkDbContext : Dbcontext
{
    public SydlinkDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Sag> Sager => Set<Sag>();
}