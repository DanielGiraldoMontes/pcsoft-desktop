
namespace ENTIDADES
{
    public class CEOrden : CEEquipo
    {
        /// <summary>
        /// Obtiene o establece el valor del identificador único de la ordn.
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// Obtiene o establece el valor del número de la orden del proveedor.
        /// </summary>
        public string numero { get; set; }
        /// <summary>
        /// Obtiene o establece el valor de la fecha del movimiento.
        /// </summary>
        public string fecha { get; set; }
        /// <summary>
        /// Obtiene o establece el valor que marca como anulado el movimiento.
        /// </summary>
        public bool anulado { get; set; }
        /// <summary>
        /// Obtiene o establece el array de bytes que contiene el archivo descomprimido 
        /// digitalmente para enviarlo o reconstruirlo.
        /// </summary>
        public byte[] archivo { get; set; }
    }
}
