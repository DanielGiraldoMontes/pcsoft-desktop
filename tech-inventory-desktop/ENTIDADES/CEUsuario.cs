
namespace ENTIDADES
{
    public class CEUsuario
    {
        /// <summary>
        /// Obtiene o establece el identificador único del usuario.
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Obtiene o establece el valor de userName de la entidad de seguridad.
        /// </summary>
        public string userName { get; set; }
        /// <summary>
        /// Obtiene o establece el valor de la contraseña de la entidad de seguridad.
        /// </summary>
        public string password { get; set; }
        /// <summary>
        /// Obtiene o establece el valor de los nombres de la entidad de seguridad.
        /// </summary>
        public string nombres { get; set; }
        /// <summary>
        /// Obtiene o establece el valor del numero de identificación de la entidad de seguridad.
        /// </summary>
        public string documento { get; set; }
        /// <summary>
        /// Obtiene o establece el valor del correo electrónico de la entidad de seguridad.
        /// </summary>
        public string correo { get; set; }
    }
}
