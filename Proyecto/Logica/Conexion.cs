using System.Configuration;

namespace ProyectoVenta.Logica
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena"].ToString();
    }
}
