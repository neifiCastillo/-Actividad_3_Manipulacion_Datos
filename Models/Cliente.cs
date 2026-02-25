namespace PracticaWinFormsTienda.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }

        public string NombreCompleto { get; set; } = string.Empty;

        public string? CorreoElectronico { get; set; }

        public string? Telefono { get; set; }

        public string? Direccion { get; set; }
    }
}
