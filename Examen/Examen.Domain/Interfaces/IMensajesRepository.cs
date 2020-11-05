using Examen.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Domain.Interfaces
{
    public interface IMensajesRepository
    {
        Task<IEnumerable<Mensajes>> GetAnimals();

    }
}
