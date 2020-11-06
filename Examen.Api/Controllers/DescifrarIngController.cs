using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Examen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescifrarIngController : ControllerBase
    {
        [HttpPost]
        [Route("post")]
        public IActionResult Post([FromHeader] string TMensaje, [FromHeader] string clave)
        {
            if (!string.IsNullOrEmpty(TMensaje) && !string.IsNullOrEmpty(clave))
            {
                StringBuilder Mensaje = new StringBuilder(TMensaje);
                DesenC.DESCIFRAR(ref Mensaje, clave);
                return Ok(Mensaje.ToString());
            }
            else
            {
                return NotFound();
            }
        }
    }
}
