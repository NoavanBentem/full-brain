using Microsoft.EntityFrameworkCore;
using FullBrain.Models;

namespace FullBrain.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }
    public DbSet<ThoughtModel> Thoughts { get; set; }
}