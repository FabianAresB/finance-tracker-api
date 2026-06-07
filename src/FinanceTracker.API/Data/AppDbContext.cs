using Microsoft.EntityFrameworkCore;
using FinanceTracker.API.Models;

namespace FinanceTracker.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Transaccion> Transacciones { get; set; }
    public DbSet<Categoria> Categorias { get; set; }
}