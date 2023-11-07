using Hex.Aplicacion.Base;
using Hex.Aplicacion.Dtos;
using Hex.Aplicacion.Interfaces;
using Hex.Infraestructura.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex.Aplicacion.Servicios
{
    public class PersonaAplicacion : IPersonaAplicacion
    {

        private readonly IPersonaReppositorio _repo;

        public PersonaAplicacion(IPersonaReppositorio repo)
        {
            _repo = repo;
        }

        public IEnumerable<PersonaDto> ConsultarTodasLasPersonas()
        {
            var response = new BaseResponse<IEnumerable<PersonaDto>>();

            var personas = _repo.ConsultarTodasLasPersonas();

            if (personas != null)
            {
                response.IsSuccess = true;
                response.Mensage = "Consulta exitosa";
                response.Errores = null;
                //response.Data = (IEnumerable<PersonaDto>?)personas;
                response.Data = personas.Select(res => new PersonaDto
                {
                    Id = res.Id,
                    Nombre = res.Nombre,
                    UsuarioIdCreacion = res.UsuarioIdCreacion
                });
            }
            else
            {
                response.IsSuccess = false;
                response.Mensage = "Error al consultar";
                response.Data = null;
                response.Errores = new List<string> { "Error de aplicacion ", response.Mensage };
            }

            return (IEnumerable<PersonaDto>)response;
        }
    }
}
