using Campuslands.Entities.Request;
using Campuslands.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CampuslandsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : Controller
    {
        private readonly IClienteService _clienteService;

        public ClientesController(IClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] ClienteRequest request)
        {
            try
            {
                _clienteService.CrearNuevoCliente(request);
                return StatusCode(StatusCodes.Status201Created); ;
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}
