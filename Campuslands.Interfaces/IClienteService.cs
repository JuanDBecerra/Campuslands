using Campuslands.Entities.Models;
using Campuslands.Entities.Request;

namespace Campuslands.Interfaces
{
    public interface IClienteService : IGenericServices<Clientes>
    {
        void CrearNuevoCliente(ClienteRequest payload);
    }
}
