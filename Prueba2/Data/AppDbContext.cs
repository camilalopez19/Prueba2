using Microsoft.EntityFrameworkCore;
using Prueba2.Models;

namespace Prueba2.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Helicoptero> Helicoptero => Set<Helicoptero>();
}