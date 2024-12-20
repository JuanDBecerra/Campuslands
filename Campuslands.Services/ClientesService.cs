using Campuslands.Entities.Models;
using Campuslands.Entities.Request;
using Campuslands.Interfaces;

namespace Campuslands.Services
{
    public class ClientesService : GenericService<Clientes>, IClienteService
    {        
        public ClientesService(IRepository<Clientes> repository, IMediatorService mediator) : base(repository, mediator)
        {
        }

        public void CrearNuevoCliente(ClienteRequest payload)
        {
            Clientes cliente = new()
            {
                Nombre = payload.Nombre,
                Email = payload.Email
            };
            Create(cliente);
        }

    }
}
