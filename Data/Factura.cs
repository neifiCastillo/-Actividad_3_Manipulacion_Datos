using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PracticaWinFormsTienda.Data;

public partial class Factura
{
    [Key]
    [Column("FacturaID")]
    public int FacturaId { get; set; }

    [Column("ClienteID")]
    public int ClienteId { get; set; }

    public DateOnly FechaFactura { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal Total { get; set; }

    [ForeignKey("ClienteId")]
    [InverseProperty("Facturas")]
    public virtual Cliente Cliente { get; set; } = null!;

    [InverseProperty("Factura")]
    public virtual ICollection<DetallesFactura> DetallesFacturas { get; set; } = new List<DetallesFactura>();
}
