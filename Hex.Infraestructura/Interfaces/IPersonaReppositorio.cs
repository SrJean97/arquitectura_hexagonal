using Hex.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex.Infraestructura.Interfaces
{
    public interface IPersonaReppositorio
    {
        //Hace el que, más no el cómo.
        IEnumerable<Persona> ConsultarTodasLasPersonas();

        //List.
        //IQueryable.
        //IEnumerable
    }
}
