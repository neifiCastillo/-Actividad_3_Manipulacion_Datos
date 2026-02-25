using Microsoft.Data.SqlClient;
using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;
using System.Data;

namespace PracticaWinFormsTienda.Repositories
{
    public class ProveedorRepository : IProveedorRepository
    {
        private readonly Conexion _conexion;

        public ProveedorRepository()
        {
            _conexion = new Conexion();
        }

        public async Task<IEnumerable<Proveedor>> GetAllAsync()
        {
            var lista = new List<Proveedor>();

            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = @"SELECT ProveedorID, NombreProveedor, 
                                        Telefono, CorreoElectronico 
                                 FROM Proveedores";

                using var cmd = new SqlCommand(query, conn);
                using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    lista.Add(new Proveedor
                    {
                        ProveedorID = (int)reader["ProveedorID"],
                        NombreProveedor = reader["NombreProveedor"].ToString()!,
                        Telefono = reader["Telefono"] as string,
                        CorreoElectronico = reader["CorreoElectronico"] as string
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo proveedores.", ex);
            }

            return lista;
        }

        public async Task<Proveedor?> GetByIdAsync(int id)
        {
            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = @"SELECT ProveedorID, NombreProveedor, 
                                        Telefono, CorreoElectronico
                                 FROM Proveedores
                                 WHERE ProveedorID=@id";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                using var reader = await cmd.ExecuteReaderAsync();

                if (await reader.ReadAsync())
                {
                    return new Proveedor
                    {
                        ProveedorID = (int)reader["ProveedorID"],
                        NombreProveedor = reader["NombreProveedor"].ToString()!,
                        Telefono = reader["Telefono"] as string,
                        CorreoElectronico = reader["CorreoElectronico"] as string
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error obteniendo proveedor con ID {id}.", ex);
            }

            return null;
        }

        public async Task InsertAsync(Proveedor entity)
        {
            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = @"INSERT INTO Proveedores
                                 (NombreProveedor, Telefono, CorreoElectronico)
                                 VALUES (@nombre,@telefono,@correo)";

                using var cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = entity.NombreProveedor;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 15).Value =
                    (object?)entity.Telefono ?? DBNull.Value;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value =
                    (object?)entity.CorreoElectronico ?? DBNull.Value;

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error insertando proveedor.", ex);
            }
        }

        public async Task UpdateAsync(Proveedor entity)
        {
            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = @"UPDATE Proveedores SET
                                 NombreProveedor=@nombre,
                                 Telefono=@telefono,
                                 CorreoElectronico=@correo
                                 WHERE ProveedorID=@id";

                using var cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add("@id", SqlDbType.Int).Value = entity.ProveedorID;
                cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 100).Value = entity.NombreProveedor;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 15).Value =
                    (object?)entity.Telefono ?? DBNull.Value;
                cmd.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value =
                    (object?)entity.CorreoElectronico ?? DBNull.Value;

                await cmd.ExecuteNonQueryAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Error actualizando proveedor.", ex);
            }
        }

        public async Task DeleteAsync(int id)
        {
            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = "DELETE FROM Proveedores WHERE ProveedorID=@id";

                using var cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

                await cmd.ExecuteNonQueryAsync();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new Exception("No se puede eliminar el proveedor porque tiene compras asociadas.", ex);
            }
            catch (Exception ex)
            {
                throw new Exception("Error eliminando proveedor.", ex);
            }
        }
    }
}
