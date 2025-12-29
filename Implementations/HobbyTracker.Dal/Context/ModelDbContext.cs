using HobbyTracker.Dal.Entities;
using Microsoft.EntityFrameworkCore;

namespace HobbyTracker.Dal.Context;

public class ModelDbContext : DbContext
{
    public ModelDbContext(DbContextOptions<ModelDbContext> options) : base(options)
    {
    }
    
    public DbSet<User> Users { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Id)
                .HasDefaultValueSql("gen_random_uuid()")
                .HasColumnType("uuid");
        });
    }
}