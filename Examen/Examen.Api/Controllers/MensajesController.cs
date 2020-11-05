using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Examen.Infraestructure.Repositories;
using Examen.Domain.Interfaces;

namespace Examen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MensajesController : ControllerBase
    {
        private readonly IMensajesRepository  _repository;
        public MensajesController(IMensajesRepository repository)
        {
            this._repository = repository;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var animals = await _repository.GetAnimals();
            return Ok(animals);
        }


    }
}
