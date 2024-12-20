using Campuslands.Entities.Models;
using Campuslands.Entities.Request;

namespace Campuslands.Interfaces
{
    public interface IProductosService : IGenericServices<Productos>
    {
        Productos ObtenerProductos(ProductosFiltroRequest payload);
        void ActualizarProducto(int id, ActualizarProductoRequest payload);
    }
}
