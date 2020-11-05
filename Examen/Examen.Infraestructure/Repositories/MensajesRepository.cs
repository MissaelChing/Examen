using Examen.Domain.Entities;
using Examen.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infraestructure.Repositories
{
    public class MensajesRepository : IMensajesRepository
    {
        public async Task<IEnumerable<Mensajes>> GetAnimals()
        {
            var mensajes = Enumerable.Range(1, 10).Select(x => new Mensajes
            {
                Mensaje = $"animal-{x}",
                CaptureDate = DateTime.Now,
                Description = $"Description of animal-{x}",
                
            });
            await Task.Delay(10);

            return mensajes;
        }

    }
}
