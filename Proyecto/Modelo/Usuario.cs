namespace Proyecto.Modelo
{
    public class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreCompleto { get; set; }
        public string NombreUsuario { get; set; }
        public string Clave { get; set; }
        public int IdPermisos { get; set; }
        public string Descripcion { get; set; }
    }
}
