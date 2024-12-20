namespace Campuslands.Entities.Models
{
    public class PedidoProductos
    {
        public int Id { get; set; }
        public int PedidoId { get; set; }
        public int ProductoId { get; set; }
        public int Cantidad { get; set; }

        public Pedidos Pedidos { get; set; } 
        public Productos Productos { get; set; }
    }
}
