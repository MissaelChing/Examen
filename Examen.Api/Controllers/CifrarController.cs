using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using PokeAPI;
using System.Text;
using Microsoft.Extensions.Logging;

namespace Examen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CifrarController : ControllerBase
    {
        [HttpPost]
        [Route("post")]
        public async Task<IActionResult> PostAsync(string Text, string Clave)
        {
            if (!string.IsNullOrEmpty(Text) && !string.IsNullOrEmpty(Clave))
            {
                Random random = new Random();
                int num = random.Next(1, 700);
                PokemonSpecies species = await DataFetcher.GetApiObject<PokemonSpecies>(num);
                StringBuilder Mensaje = new StringBuilder(Text);
                Clave = species.Name;
                EnC.CIFRAR(ref Mensaje, Clave);
                return Ok($"su texto{Mensaje} \n" + $"Pokemon asignado como clave es: {Clave} \n");
            }
            else
            {
                return NotFound();
            }
        }


    }
}
