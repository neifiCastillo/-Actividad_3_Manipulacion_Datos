namespace PracticaWinFormsTienda.Models
{
    public class ProveedorDto
    {
        public int Id { get; set; }

        public string NombreProveedor { get; set; } = null!;

        public string? Telefono { get; set; }

        public string? CorreoElectronico { get; set; }
    }
}
