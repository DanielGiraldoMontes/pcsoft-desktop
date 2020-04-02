
namespace ENTIDADES
{
    public class CEEquipo : CEEmpleado
    {
        /// <summary>
        /// Obtiene o establece el valor del codigo único del equipo.
        /// </summary>
        public string equipoCodigo { set; get; }
        /// <summary>
        /// Obtiene o establece el valor de la descripcion del equipo.
        /// </summary>
        public string equipoDescripcion { set; get; }
        /// <summary>
        /// Obtiene o establece el valor del serial único interno del equipo.
        /// </summary>
        public string equipoSerial { set; get; }
        /// <summary>
        /// Obtiene o establece el valor del estado del equipo R = RETIRADO, I = INACTIVO, A = ASIGNADO, D = DISPONIBLE
        /// </summary>
        public string equipoEstado { set; get; }
        /// <summary>
        /// Obtiene o establece el documento del proveedor del equipo.
        /// </summary>
        public string proveedorDocumento { set; get; }
        /// <summary>
        /// Obtiene o establece el nombre corto para mostrar del proveedor del equipo.
        /// </summary>
        public string proveedorNombreCorto { set; get; }
        /// <summary>
        /// Obtiene o establece el valor del objeto proveedor que suministra el equipo.
        /// </summary>
        public CEProveedor proveedor { get; set; }
        /// <summary>
        /// Obtiene o establece el valor del objeto sobre el cual se identifica el modelo del equipo.
        /// </summary>
        ///
        public CEModelo modelo { get; set; }
        /// <summary>
        /// Obtiene o establece el valor del objeto sobre el cual se identifica la marca del equipo.
        /// </summary>
        public CEMarca marca { get; set; }
    }
}
