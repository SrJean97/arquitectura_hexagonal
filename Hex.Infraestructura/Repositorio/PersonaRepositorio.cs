using Hex.Dominio;
using Hex.Infraestructura.Context;
using Hex.Infraestructura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex.Infraestructura.Repositorio
{
    public class PersonaRepositorio : IPersonaReppositorio
    {

        private readonly ContextPerson _context;

        public PersonaRepositorio(ContextPerson context)
        {
            _context = context;
        }

        public IEnumerable<Persona> ConsultarTodasLasPersonas()
        {
            var response = _context.Personas;

            return response!;
        }
    }
}
