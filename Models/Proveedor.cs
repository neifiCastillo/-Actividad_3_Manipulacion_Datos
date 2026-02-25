namespace PracticaWinFormsTienda.Models
{
    public class Proveedor
    {
        public int ProveedorID { get; set; }

        public string NombreProveedor { get; set; } = string.Empty;

        public string? Telefono { get; set; }

        public string? CorreoElectronico { get; set; }
    }
}
