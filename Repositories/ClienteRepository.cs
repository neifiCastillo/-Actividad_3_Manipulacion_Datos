using Microsoft.Data.SqlClient;
using PracticaWinFormsTienda.Data;
using PracticaWinFormsTienda.Models;
using PracticaWinFormsTienda.Repositories.Interfaces;
using System.Data;

namespace PracticaWinFormsTienda.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly Conexion _conexion = new Conexion();

        public async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            var lista = new List<Cliente>();

            try
            {
                using var conn = _conexion.ObtenerConexion();
                await conn.OpenAsync();

                string query = "SELECT * FROM Clientes ORDER BY ClienteID DESC";

                using var cmd = new SqlCommand(query, conn);
                using var reader = await cmd.ExecuteReaderAsync();

                while (await reader.ReadAsync())
                {
                    lista.Add(new Cliente
                    {
                        ClienteID = (int)reader["ClienteID"],
                        NombreCompleto = reader["NombreCompleto"].ToString()!,
                        CorreoElectronico = reader["CorreoElectronico"] as string,
                        Telefono = reader["Telefono"] as string,
                        Direccion = reader["Direccion"] as string
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error obteniendo clientes", ex);
            }

            return lista;
        }

        public async Task<Cliente?> GetByIdAsync(int id)
        {
            using var conn = _conexion.ObtenerConexion();
            await conn.OpenAsync();

            string query = "SELECT * FROM Clientes WHERE ClienteID=@id";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            using var reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync())
            {
                return new Cliente
                {
                    ClienteID = (int)reader["ClienteID"],
                    NombreCompleto = reader["NombreCompleto"].ToString()!,
                    CorreoElectronico = reader["CorreoElectronico"] as string
                };
            }

            return null;
        }

        public async Task InsertAsync(Cliente entity)
        {
            using var conn = _conexion.ObtenerConexion();
            await conn.OpenAsync();

            string query = @"INSERT INTO Clientes
                             VALUES (@NombreCompleto,@correo,@telefono,@direccion)";

            using var cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add("@NombreCompleto", SqlDbType.VarChar, 150).Value = entity.NombreCompleto;
            cmd.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value =
                (object?)entity.CorreoElectronico ?? DBNull.Value;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 15).Value =
                (object?)entity.Telefono ?? DBNull.Value;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 255).Value =
                (object?)entity.Direccion ?? DBNull.Value;

            await cmd.ExecuteNonQueryAsync();
        }

        public async Task UpdateAsync(Cliente entity)
        {
            using var conn = _conexion.ObtenerConexion();
            await conn.OpenAsync();

            string query = @"UPDATE Clientes SET
                             NombreCompleto=@nombre,
                             CorreoElectronico=@correo,
                             Telefono=@telefono,
                             Direccion=@direccion
                             WHERE ClienteID=@id";

            using var cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add("@id", SqlDbType.Int).Value = entity.ClienteID;
            cmd.Parameters.Add("@nombre", SqlDbType.VarChar, 150).Value = entity.NombreCompleto;
            cmd.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value =
                (object?)entity.CorreoElectronico ?? DBNull.Value;
            cmd.Parameters.Add("@telefono", SqlDbType.VarChar, 15).Value =
                (object?)entity.Telefono ?? DBNull.Value;
            cmd.Parameters.Add("@direccion", SqlDbType.VarChar, 255).Value =
                (object?)entity.Direccion ?? DBNull.Value;

            await cmd.ExecuteNonQueryAsync();
        }

        public async Task DeleteAsync(int id)
        {
            using var conn = _conexion.ObtenerConexion();
            await conn.OpenAsync();

            string query = "DELETE FROM Clientes WHERE ClienteID=@id";
            using var cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            await cmd.ExecuteNonQueryAsync();
        }
    }
}
