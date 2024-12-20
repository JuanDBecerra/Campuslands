using Campuslands.Entities.Request;
using Campuslands.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CampuslandsAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : Controller
    {
        private readonly IProductosService _productosService;

        public ProductosController(IProductosService productosService)
        {
            _productosService = productosService;
        }


        [HttpGet]
        public ActionResult ObtenerProductos([FromQuery] ProductosFiltroRequest payload)
        {
            try
            {
                var productos = _productosService.ObtenerProductos(payload);
                return Ok(productos);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult ActualizarProducto([FromRoute] int id, [FromBody] ActualizarProductoRequest payload) 
        {
            try
            {
                _productosService.ActualizarProducto(id, payload);
                return Accepted();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
