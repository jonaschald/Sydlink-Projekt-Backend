using Backend_Rider.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Rider.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<User> Users { get; set; }

    public DbSet<SupportCase> SupportCases { get; set; }
}