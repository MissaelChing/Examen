using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using PokeAPI;
using System.Text;

namespace Examen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CifrarController : ControllerBase
    {
        public async Task<IActionResult> Post([FromHeader] string Key)
        {
            if (!string.IsNullOrEmpty(Key))
            {
                Random random = new Random();
                int num = random.Next(1, 500);
                PokemonSpecies species = await DataFetcher.GetApiObject<PokemonSpecies>(num);
                StringBuilder Ms = new StringBuilder(Key);
                var p = species.Name;
                EnC.CIFRAR(ref Ms, Key);
                return Ok($"Escriba el Mensaje {Ms} \n" + $"Pokemon asignado como clave es: {p} \n");
            }
            else
            {
                return NotFound();
            }
        }


    }
}
