using Campuslands.Entities.Models;
using Campuslands.Entities.Request;
using Campuslands.Interfaces;

namespace Campuslands.Services
{
    public class ProductosService : GenericService<Productos>, IProductosService
    {
        public ProductosService(IRepository<Productos> repository, IMediatorService mediator) : base(repository, mediator) { }

        public Productos ObtenerProductos(ProductosFiltroRequest payload)
        {
            throw new NotImplementedException();
        }

        public void ActualizarProducto(int id, ActualizarProductoRequest payload) 
        {
            throw new NotImplementedException();
        }

    }
}
