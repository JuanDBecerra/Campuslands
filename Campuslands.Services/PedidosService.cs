using Campuslands.Entities.Models;
using Campuslands.Entities.Request;
using Campuslands.Interfaces;

namespace Campuslands.Services
{
    public class PedidosService : GenericService<Pedidos>, IPedidosService
    {
        public PedidosService(IRepository<Pedidos> repository, IMediatorService mediator) : base(repository, mediator) { }

        public void CrearNuevoPedido(NuevoPedidoRequest payload)
        {
            throw new NotImplementedException();
        }
    }
}
