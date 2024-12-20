namespace Campuslands.Entities.Models
{
    public class Pedidos
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaPedido { get; set; } = DateTime.UtcNow;
        public decimal Total { get; set; }

        public Clientes Clientes { get; set; }
        public ICollection<PedidoProductos> PedidoProductos { get; set; }

    }
}
