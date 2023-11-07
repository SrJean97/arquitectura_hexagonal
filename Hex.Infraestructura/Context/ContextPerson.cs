using Hex.Dominio;
using Microsoft.EntityFrameworkCore;

namespace Hex.Infraestructura.Context
{
    public class ContextPerson : DbContext
    {
        public ContextPerson( DbContextOptions<ContextPerson> context) : base(context){ }

        public DbSet<Persona>? Personas { get; set; }
    }
}
