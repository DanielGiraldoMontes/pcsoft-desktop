namespace ENTIDADES
{
    public class CEProveedor
    {
        /// <summary>
        /// Obtiene o establece el numero de documento de cualquier entidad persona.
        /// </summary>
        public string documento { get; set; }
        /// <summary>
        /// Obtiene o establece el nombre corto cualquier entidad persona.
        /// </summary>
        public string nombreCorto { get; set; }
        /// <summary>
        /// Obtiene o establece el nombre completo o razon social de cualquier entidad persona.
        /// </summary>
        public string nombreCompleto { get; set; }
        /// <summary>
        /// Obtiene o establece el telefono de cualquier entidad persona.
        /// </summary>
        public string telefono { get; set; }
        /// <summary>
        /// Obtiene o establece el correo de cualquier entidad persona.
        /// </summary>
        public string correo { get; set; }
        /// <summary>
        /// Obtiene o establece el valor de la dirección de la sucursal principal del proveedor.
        /// </summary>
        public string direccion { get; set; }
    }
}
