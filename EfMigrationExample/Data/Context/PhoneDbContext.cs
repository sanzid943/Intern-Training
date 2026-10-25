using EfMigrationExample.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfMigrationExample.Data.Context;

public class PhoneDbContext : DbContext
{
    public PhoneDbContext(DbContextOptions<PhoneDbContext> options) : base(options)
    {
    }

    public DbSet<Phone> Phones { get; set; }
}
