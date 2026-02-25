using Microsoft.Data.SqlClient;
using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;
using System.Data;

namespace PracticaWinFormsTienda.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly Conexion _conexion;

        public CategoriaRepository()
        {
            _conexion = new Conexion();
        }

        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            var lista = new List<Categoria>();

            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = "SELECT CategoriaID, NombreCategoria FROM Categorias";

                using var cmd = new SqlCommand(query, conn);
                using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    lista.Add(new Categoria
                    {
                        CategoriaID = (int)reader["CategoriaID"],
                        NombreCategoria = reader["NombreCategoria"].ToString()!
                    });
                }
            }
            catch (SqlException ex)
            {
                throw new Exception("Error de base de datos obteniendo categorías.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado obteniendo categorías.", ex);
            }

            return lista;
        }

        public async Task<Categoria?> GetByIdAsync(int id)
        {
            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = "SELECT CategoriaID, NombreCategoria FROM Categorias WHERE CategoriaID=@id";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                using var reader = await cmd.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    return new Categoria
                    {
                        CategoriaID = (int)reader["CategoriaID"],
                        NombreCategoria = reader["NombreCategoria"].ToString()!
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error obteniendo categoría con ID {id}.", ex);
            }

            return null;
        }

        public async Task InsertAsync(Categoria entity)
        {
            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = @"INSERT INTO Categorias 
                                 (NombreCategoria)
                                 VALUES (@nombre)";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = entity.NombreCategoria;

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error insertando categoría.", ex);
            }
        }

        public async Task UpdateAsync(Categoria entity)
        {
            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = @"UPDATE Categorias
                                 SET NombreCategoria=@nombre
                                 WHERE CategoriaID=@id";

                using var cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = entity.CategoriaID;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = entity.NombreCategoria;

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error actualizando categoría.", ex);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = "DELETE FROM Categorias WHERE CategoriaID=@id";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                await cmd.ExecuteNonQueryAsync();
            }
            catch (SqlException ex) when (ex.Number == 547) // FK violation
            {
                throw new Exception("No se puede eliminar la categoría porque está relacionada con productos.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error eliminando categoría.", ex);
            }
        }
    }
}
