using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaWinFormsTienda.Data;

[Table("DetallesFactura")]
public partial class DetallesFactura
{
    [Key]
    [Column("DetalleID")]
    public int DetalleId { get; set; }

    [Column("FacturaID")]
    public int FacturaId { get; set; }

    [Column("ProductoID")]
    public int ProductoId { get; set; }

    public int Cantidad { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Precio { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Impuesto { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Subtotal { get; set; }

    [ForeignKey("FacturaId")]
    [InverseProperty("DetallesFacturas")]
    public virtual Factura Factura { get; set; } = null!;

    [ForeignKey("ProductoId")]
    [InverseProperty("DetallesFacturas")]
    public virtual Producto Producto { get; set; } = null!;
}
