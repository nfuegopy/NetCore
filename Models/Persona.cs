namespace Persona.Models
{
    public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NumeroDocumento { get; set; }
        public string CorreoElectronico { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }

public Persona()
    {
        Nombre = string.Empty;
        Apellido = string.Empty;
        NumeroDocumento = string.Empty;
        CorreoElectronico = string.Empty;
        Telefono = string.Empty;
    }

    }
}
