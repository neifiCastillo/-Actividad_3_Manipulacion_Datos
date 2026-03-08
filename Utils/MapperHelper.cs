using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Models;


namespace PracticaWinFormsTienda.Utils
{
    public static class MapperHelper
    {
        // Categoria
        public static CategoriaDto ToDTO(Categoria entity)
        {
            return new CategoriaDto
            {
                Id = entity.CategoriaId,
                Nombre = entity.NombreCategoria
            };
        }
        public static Categoria ToEntity(CategoriaDto dto)
        {
            return new Categoria
            {
                CategoriaId = dto.Id,
                NombreCategoria = dto.Nombre
            };
        }

        // Producto
        public static ProductoDto ToDTO(Producto entity)
        {
            return new ProductoDto
            {
                Id = entity.ProductoId,
                Nombre = entity.NombreProducto,
                Descripcion = entity.Descripcion,
                Precio = entity.Precio,
                Stock = entity.Stock,
                CategoriaId = entity.CategoriaId,
                CategoriaNombre = entity.Categoria != null
                    ? entity.Categoria.NombreCategoria
                    : ""
            };
        }
        public static Producto ToEntity(ProductoDto dto)
        {
            return new Producto
            {
                ProductoId = dto.Id,
                NombreProducto = dto.Nombre,
                Descripcion = dto.Descripcion,
                Precio = dto.Precio,
                Stock = dto.Stock,
                CategoriaId = dto.CategoriaId
            };
        }

        // Cliente
        public static ClienteDto ToDTO(Cliente entity)
        {
            return new ClienteDto
            {
                Id = entity.ClienteId,
                NombreCompleto = entity.NombreCompleto,
                CorreoElectronico = entity.CorreoElectronico,
                Telefono = entity.Telefono,
                Direccion = entity.Direccion
            };
        }
        public static Cliente ToEntity(ClienteDto dto)
        {
            return new Cliente
            {
                ClienteId = dto.Id,
                NombreCompleto = dto.NombreCompleto,
                CorreoElectronico = dto.CorreoElectronico,
                Telefono = dto.Telefono,
                Direccion = dto.Direccion
            };
        }
        // Proveedor
        public static ProveedorDto ToDTO(Proveedore entity)
        {
            return new ProveedorDto
            {
                Id = entity.ProveedorId,
                NombreProveedor = entity.NombreProveedor,
                Telefono = entity.Telefono,
                CorreoElectronico = entity.CorreoElectronico
            };
        }
        public static Proveedore ToEntity(ProveedorDto dto)
        {
            return new Proveedore
            {
                ProveedorId = dto.Id,
                NombreProveedor = dto.NombreProveedor,
                Telefono = dto.Telefono,
                CorreoElectronico = dto.CorreoElectronico
            };
        }
    }
}