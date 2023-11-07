using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hex.Dominio
{
    public class Persona
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Nombre { get; set; }

        [Required]
        public int UsuarioIdCreacion { get; set; } //LLave foranea de la tabla usuarios => Usuarios: id, nombreusuario, codigo
    }
}
