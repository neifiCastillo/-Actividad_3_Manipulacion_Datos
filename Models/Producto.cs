namespace PracticaWinFormsTienda.Models
{
    public class Producto
    {
        public int ProductoID { get; set; }

        public string NombreProducto { get; set; } = string.Empty;

        public string? Descripcion { get; set; }

        public decimal Precio { get; set; }

        public int Stock { get; set; }

        public int? CategoriaID { get; set; }

        public Categoria? Categoria { get; set; }
    }
}
