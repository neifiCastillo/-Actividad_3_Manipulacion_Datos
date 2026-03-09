using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaWinFormsTienda.Data;

public partial class Compra
{
    [Key]
    [Column("CompraID")]
    public int CompraId { get; set; }

    [Column("ProveedorID")]
    public int ProveedorId { get; set; }

    public DateOnly FechaCompra { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Total { get; set; }

    [InverseProperty("Compra")]
    public virtual ICollection<DetallesCompra> DetallesCompras { get; set; } = new List<DetallesCompra>();

    [ForeignKey("ProveedorId")]
    [InverseProperty("Compras")]
    public virtual Proveedore Proveedor { get; set; } = null!;
}
