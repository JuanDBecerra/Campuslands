using Microsoft.EntityFrameworkCore;
using Campuslands.Entities.Models;

namespace Campuslands.Utils
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Pedidos> Pedidos { get; set; }
        public DbSet<PedidoProductos> PedidoProductos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.FechaRegistro).IsRequired();
            });
            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Nombre).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Precio).IsRequired().HasPrecision(10, 2);
                entity.Property(e => e.Stock).IsRequired();
                entity.Property(e => e.FechaCreacion).IsRequired();
            });
            modelBuilder.Entity<Pedidos>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.ClienteId).IsRequired();
                entity.Property(e => e.FechaPedido).IsRequired();
                entity.Property(e => e.Total).IsRequired().HasPrecision(20, 2);

                entity.HasOne(e => e.Clientes)
                      .WithMany(c => c.Pedidos)
                      .HasForeignKey(e => e.ClienteId);
            });
            modelBuilder.Entity<PedidoProductos>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.PedidoId).IsRequired();
                entity.Property(e => e.ProductoId).IsRequired();
                entity.Property(e => e.Cantidad).IsRequired();

                entity.HasOne(e => e.Pedidos)
                      .WithMany(p => p.PedidoProductos)
                      .HasForeignKey(e => e.PedidoId);

                entity.HasOne(e => e.Productos)
                      .WithMany(p => p.PedidoProductos)
                      .HasForeignKey(e => e.ProductoId);
            });
        }
    }
}
