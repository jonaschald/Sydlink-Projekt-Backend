using Backend_Rider.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Rider.Data;

public class SydlinkDbContext : DbContext
{
    public SydlinkDbContext(DbContextOptions options) : base(options) { }
    public DbSet<Sag> Sager => Set<Sag>();
}