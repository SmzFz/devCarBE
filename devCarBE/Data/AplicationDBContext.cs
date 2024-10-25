
// Data/DevCarDbContext.cs

using Microsoft.EntityFrameworkCore;
using devCarBE.Models;

public class DevCarDbContext : DbContext
{
    public DevCarDbContext(DbContextOptions<DevCarDbContext> options) : base(options) { }

    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Veiculo> Veiculos { get; set; }
    public DbSet<Patio> Patios { get; set; }
    public DbSet<Locacao> Locacoes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
