namespace PracticaWinFormsTienda.Models
{
    public class ClienteDto
    {
        public int Id { get; set; }

        public string NombreCompleto { get; set; } = null!;

        public string? CorreoElectronico { get; set; }

        public string? Telefono { get; set; }

        public string? Direccion { get; set; }
    }
}
