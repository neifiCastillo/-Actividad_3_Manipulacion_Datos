using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PracticaWinFormsTienda.Data;

public partial class PracticaTiendaContext : DbContext
{
    public PracticaTiendaContext()
    {
    }

    public PracticaTiendaContext(DbContextOptions<PracticaTiendaContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<DetallesCompra> DetallesCompras { get; set; }

    public virtual DbSet<DetallesFactura> DetallesFacturas { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

 //   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer("Server=DESKTOP-NDSAP95;Database=PracticaBD_Tienda;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__Categori__F353C1C5C9069539");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("PK__Clientes__71ABD0A74D927BFF");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.CompraId).HasName("PK__Compras__067DA725809BB490");

            entity.Property(e => e.CompraId).ValueGeneratedNever();

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Compras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Compras_Proveedores");
        });

        modelBuilder.Entity<DetallesCompra>(entity =>
        {
            entity.HasKey(e => e.DetalleCompraId).HasName("PK__Detalles__F7FC189AEBEF9298");

            entity.Property(e => e.DetalleCompraId).ValueGeneratedNever();

            entity.HasOne(d => d.Compra).WithMany(p => p.DetallesCompras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetallesCompra_Compras");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallesCompras)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetallesCompra_Productos");
        });

        modelBuilder.Entity<DetallesFactura>(entity =>
        {
            entity.HasKey(e => e.DetalleId).HasName("PK__Detalles__6E19D6FA65949114");

            entity.Property(e => e.DetalleId).ValueGeneratedNever();

            entity.HasOne(d => d.Factura).WithMany(p => p.DetallesFacturas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetallesFactura_Facturas");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallesFacturas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetallesFactura_Productos");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.FacturaId).HasName("PK__Facturas__5C024805740D7287");

            entity.Property(e => e.FacturaId).ValueGeneratedNever();

            entity.HasOne(d => d.Cliente).WithMany(p => p.Facturas)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Facturas_Clientes");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.ProductoId).HasName("PK__Producto__A430AE833A74CB46");

            entity.HasOne(d => d.Categoria).WithMany(p => p.Productos).HasConstraintName("FK_Productos_Categorias");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.ProveedorId).HasName("PK__Proveedo__61266BB9C7358BC7");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
