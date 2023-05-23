using Microsoft.EntityFrameworkCore;

namespace ApiPersona.Models
{
    public class PersonaContext : DbContext
    {
       public PersonaContext(DbContextOptions<PersonaContext> options)
    : base(options)
{
    Personas = Set<Persona.Models.Persona>();
}

public DbSet<Persona.Models.Persona> Personas { get; set; }


    }
}
