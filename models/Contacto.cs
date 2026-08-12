namespace ManoloContactos.Models;

public class Contacto
{
    public int Id { get; set; }

    public string Cedula { get; set; } = string.Empty;

    public string Nombre { get; set; } = string.Empty;

    public string Apellidos { get; set; } = string.Empty;

    public DateOnly FechaNacimiento { get; set; }

    public string Telefono { get; set; } = string.Empty;

    public string Direccion { get; set; } = string.Empty;

    public int Edad
    {
        get
        {
            var hoy = DateOnly.FromDateTime(DateTime.Today);
            var edad = hoy.Year - FechaNacimiento.Year;

            if (FechaNacimiento > hoy.AddYears(-edad))
                edad--;

            return edad;
        }
    }
}