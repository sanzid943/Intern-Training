using Microsoft.EntityFrameworkCore;

namespace EfCoreExample;

public class AppDbContext : DbContext
{
    public DbSet<Student> Students { get; set; }

    protected override void OnConfiguring(
        DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=5432;Database=EfCoreDB;Username=postgres;Password=123456"
        );
    }
}
