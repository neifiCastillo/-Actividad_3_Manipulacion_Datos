using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaWinFormsTienda.Data;

[Table("DetallesCompra")]
public partial class DetallesCompra
{
    [Key]
    [Column("DetalleCompraID")]
    public int DetalleCompraId { get; set; }

    [Column("CompraID")]
    public int CompraId { get; set; }

    [Column("ProductoID")]
    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal CostoUnitario { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Impuesto { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Subtotal { get; set; }

    [ForeignKey("CompraId")]
    [InverseProperty("DetallesCompras")]
    public virtual Compra Compra { get; set; } = null!;

    [ForeignKey("ProductoId")]
    [InverseProperty("DetallesCompras")]
    public virtual Producto Producto { get; set; } = null!;
}
