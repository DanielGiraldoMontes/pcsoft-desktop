
namespace ENTIDADES
{
    public class CEAsignaciones : CEEquipo
    {
        /// <summary>
        /// Obtiene o establece el valor del identificador único de una asignación.
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Obtiene o establece el valor de la fecha del movimiento.
        /// </summary>
        public string fecha { get; set; }
        /// <summary>
        /// Obtiene o establece el valor booleano para saber si el movimiento esta o no anulado.
        /// </summary>
        public bool anulado { get; set; }
        /// <summary>
        /// Obtiene o establece el array de bytes que contiene el archivo descomprimido 
        /// digitalmente para enviarlo o reconstruirlo.
        /// </summary>
        public byte[] archivo { get; set; }
        /// <summary>
        /// Obiene o establece el valor del documento de identidad del usuario que realizó el movimiento.
        /// </summary>
        public string usuarioDocumento { get; set; }
        /// <summary>
        /// Obiene o establece el valor del nombre del usuario que realizo el movimiento.
        /// </summary>
        public string usuarioNombres { get; set; }
    }
}
