using Campuslands.Entities.Request;
using Campuslands.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CampuslandsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidosController : Controller
    {
        private readonly IPedidosService _pedidosService;

        public PedidosController(IPedidosService pedidosService)
        {
            _pedidosService = pedidosService;
        }

        [HttpPost]
        public IActionResult CrearPedido([FromBody]NuevoPedidoRequest payload)
        {
            try
            {
                _pedidosService.CrearNuevoPedido(payload);
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerPedido(int id)
        {
            try
            {
                var pedido = _pedidosService.GetById(id);
                return Ok(pedido);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
