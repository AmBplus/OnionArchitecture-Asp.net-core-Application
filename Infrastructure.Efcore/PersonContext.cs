using Microsoft.EntityFrameworkCore;
using Server.Domian;
using server.Infrastructure.Efcore.Maping;

namespace server.Infrastructure.Efcore;

public class PersonContext : DbContext
{
    public DbSet<Person> People { get; set; }

    public PersonContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new MapPerson());
        base.OnModelCreating(modelBuilder);
    }
}