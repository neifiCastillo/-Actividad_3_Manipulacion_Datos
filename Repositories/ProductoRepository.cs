using Microsoft.Data.SqlClient;
using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;
using System.Data;

namespace PracticaWinFormsTienda.Repositories
{
    public class ProductoRepository : IProductoRepository
    {
        private readonly Conexion _conexion;

        public ProductoRepository()
        {
            _conexion = new Conexion();
        }

        public async Task<IEnumerable<Producto>> GetAllAsync()
        {
            var lista = new List<Producto>();

            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = @"
                    SELECT p.*, c.NombreCategoria 
                    FROM Productos p
                    LEFT JOIN Categorias c ON p.CategoriaID = c.CategoriaID ORDER BY ProductoID DESC";

                using var cmd = new SqlCommand(query, conn);
                using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    lista.Add(new Producto
                    {
                        ProductoID = (int)reader["ProductoID"],
                        NombreProducto = reader["NombreProducto"].ToString()!,
                        Descripcion = reader["Descripcion"] as string,
                        Precio = (decimal)reader["Precio"],
                        Stock = (int)reader["Stock"],
                        CategoriaID = reader["CategoriaID"] as int?,
                        Categoria = reader["NombreCategoria"] != DBNull.Value
                            ? new Categoria
                            {
                                CategoriaID = (int)reader["CategoriaID"],
                                NombreCategoria = reader["NombreCategoria"].ToString()!
                            }
                            : null
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo productos", ex);
            }

            return lista;
        }

        public async Task<Producto?> GetByIdAsync(int id)
        {
            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = "SELECT * FROM Productos WHERE ProductoID = @id";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                using var reader = await cmd.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    return new Producto
                    {
                        ProductoID = (int)reader["ProductoID"],
                        NombreProducto = reader["NombreProducto"].ToString()!,
                        Descripcion = reader["Descripcion"] as string,
                        Precio = (decimal)reader["Precio"],
                        Stock = (int)reader["Stock"],
                        CategoriaID = reader["CategoriaID"] as int?
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo producto por ID", ex);
            }

            return null;
        }

        public async Task InsertAsync(Producto entity)
        {
            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = @"
                    INSERT INTO Productos
                    (NombreProducto, Descripcion, Precio, Stock, CategoriaID)
                    VALUES
                    (@nombre,@desc,@precio,@stock,@categoria)";

                using var cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = entity.NombreProducto;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar, 255).Value =
                    (object?)entity.Descripcion ?? DBNull.Value;
                cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = entity.Precio;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = entity.Stock;
                cmd.Parameters.Add("@categoria", SqlDbType.Int).Value =
                    (object?)entity.CategoriaID ?? DBNull.Value;

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error insertando producto", ex);
            }
        }

        public async Task UpdateAsync(Producto entity)
        {
            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = @"
                    UPDATE Productos SET
                    NombreProducto=@nombre,
                    Descripcion=@desc,
                    Precio=@precio,
                    Stock=@stock,
                    CategoriaID=@categoria
                    WHERE ProductoID=@id";

                using var cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = entity.ProductoID;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = entity.NombreProducto;
                cmd.Parameters.Add("@desc", SqlDbType.VarChar, 255).Value =
                    (object?)entity.Descripcion ?? DBNull.Value;
                cmd.Parameters.Add("@precio", SqlDbType.Decimal).Value = entity.Precio;
                cmd.Parameters.Add("@stock", SqlDbType.Int).Value = entity.Stock;
                cmd.Parameters.Add("@categoria", SqlDbType.Int).Value =
                    (object?)entity.CategoriaID ?? DBNull.Value;

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error actualizando producto", ex);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = "DELETE FROM Productos WHERE ProductoID=@id";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error eliminando producto", ex);
            }
        }
    }
}
