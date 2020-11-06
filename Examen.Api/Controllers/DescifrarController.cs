using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;
namespace Examen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DescifrarController : ControllerBase
    {

        [HttpPost]
        [Route("post")]
        public IActionResult Post( string TMensaje,  string clave)
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
