using Microsoft.EntityFrameworkCore;
using Prueba2.Models;

namespace Prueba2.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
}