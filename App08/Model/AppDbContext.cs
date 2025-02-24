using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection;

namespace App08.Model;
internal class AppDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("data source=.;initial catalog=cs140310_auth;integrated security=True;trustservercertificate=True;MultipleActiveResultSets=True;App=EFCodeFirst");
        optionsBuilder.LogTo(msg => Debug.WriteLine(msg));
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<User> Users { get; set; }
}
