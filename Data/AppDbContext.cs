using Microsoft.EntityFrameworkCore;
using kritik.Models;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Movie> Movies { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
