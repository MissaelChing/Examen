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
        public async Task<IActionResult> PostAsync(string Text)
        {
            if (!string.IsNullOrEmpty(Text))
            {
                Random random = new Random();
                int num = random.Next(1, 700);
                PokemonSpecies species = await DataFetcher.GetApiObject<PokemonSpecies>(num);
                StringBuilder Mensaje = new StringBuilder(Text);
                EnC.CIFRAR(ref Mensaje, Text);
                return Ok($"Escriba el Mensaje {Mensaje} \n" + $"Pokemon asignado como clave es: {species.Name} \n");
            }
            else
            {
                return NotFound();
            }
        }


    }
}
