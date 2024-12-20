using Campuslands.Entities.Models;
using Campuslands.Entities.Request;

namespace Campuslands.Interfaces
{
    public interface IPedidosService : IGenericServices<Pedidos>
    {
        void CrearNuevoPedido(NuevoPedidoRequest payload);
    }
}
