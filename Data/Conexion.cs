using Microsoft.Data.SqlClient;
namespace PracticaWinFormsTienda.Data
{
    public class Conexion
    {
        private readonly string cadenaConexion =
            "Server=DESKTOP-NDSAP95;Database=PracticaBD_Tienda;Trusted_Connection=True;TrustServerCertificate=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
