using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaWinFormsTienda.Data;

public partial class Producto
{
    [Key]
    [Column("ProductoID")]
    public int ProductoId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NombreProducto { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Descripcion { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Precio { get; set; }

    public int Stock { get; set; }

    [Column("CategoriaID")]
    public int? CategoriaId { get; set; }

    [ForeignKey("CategoriaId")]
    [InverseProperty("Productos")]
    public virtual Categoria? Categoria { get; set; }

    [InverseProperty("Producto")]
    public virtual ICollection<DetallesCompra> DetallesCompras { get; set; } = new List<DetallesCompra>();

    [InverseProperty("Producto")]
    public virtual ICollection<DetallesFactura> DetallesFacturas { get; set; } = new List<DetallesFactura>();
}
