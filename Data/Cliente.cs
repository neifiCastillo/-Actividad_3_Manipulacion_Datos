using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PracticaWinFormsTienda.Data;

public partial class Cliente
{
    [Key]
    [Column("ClienteID")]
    public int ClienteId { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string NombreCompleto { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? CorreoElectronico { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [InverseProperty("Cliente")]
    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();
}
