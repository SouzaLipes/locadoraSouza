using Microsoft.EntityFrameworkCore;
using backend_locadora.Models;

namespace backend_locadora.Data{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<CategoriaVeiculo> CategoriaVeiculo { get; set; }
        public DbSet<Cliente> Cliente { get; set; } 
        public DbSet<MarcaVeiculo> MarcaVeiculo { get; set; }
        public DbSet<ModeloVeiculo> ModeloVeiculo { get; set; }
        public DbSet<Pagamento> Pagamento { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        
    }
}