using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PalabraController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string oracion)
        {
            if (string.IsNullOrEmpty(oracion))
            {
                return BadRequest("La oración no puede estar vacía.");
            }

            var palabras = oracion.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            return Ok(palabras.Count());
        }
    }
}
