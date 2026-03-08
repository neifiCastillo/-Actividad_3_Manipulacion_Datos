using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PracticaWinFormsTienda.Data;

public partial class Proveedore
{
    [Key]
    [Column("ProveedorID")]
    public int ProveedorId { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NombreProveedor { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CorreoElectronico { get; set; }

    [InverseProperty("Proveedor")]
    public virtual ICollection<Compra> Compras { get; set; } = new List<Compra>();
}
