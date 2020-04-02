
namespace ENTIDADES
{
    public class CEEmpleado
    {
        /// <summary>
        /// Obtiene o establece el objeto proyecto sobre el cual se identifica el recurso.
        /// </summary>
        public CEProyecto proyecto { get; set; }
        /// <summary>
        /// Obtiene o establece el objeto sede sobre el cual se identifica el recurso.
        /// </summary>
        public CESede sede { get; set; }
        /// <summary>
        /// Obtiene o establece el objeto ubicación sobre el cual se identifica el recurso.
        /// </summary>
        public CEUbicacion ubicacion { get; set; }
        /// <summary>
        /// Obtiene o establece el valor del código único del empleado.
        /// </summary>
        public int codigo { get; set; }
        /// <summary>
        /// Obtiene o establece el primer nombre del empleado.
        /// </summary>
        public string nombre1 { get; set; }
        /// <summary>
        /// Obtiene o establece el segundo nombre del empleado.
        /// </summary>
        public string nombre2 { get; set; }
        /// <summary>
        /// Obtiene o establece el primer apellido del empleado.
        /// </summary>
        public string apellido1 { get; set; }
        /// <summary>
        /// Obtiene o establece el segundo apellido del empleado.
        /// </summary>
        public string apellido2 { get; set; }
        /// <summary>
        /// Obtiene o establece el numero de documento de cualquier entidad persona.
        /// </summary>
        public string documento { get; set; }
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
        /// Obtiene o establece el valor que determina si el usuario cuenta o no con teclado.
        /// </summary>
        public bool asiTeclado { get; set; }
        /// <summary>
        /// Obtiene o establece el valor que determina si el usuario cuenta o no con mouse.
        /// </summary>
        public bool asiMouse { get; set; }
        /// <summary>
        /// Obtiene o establece el valor que determina si el usuario cuenta o no con puesto.
        /// </summary>
        public bool asiPuesto { get; set; }
        /// <summary>
        /// Obtiene o establece el valor que determina si el usuario cuenta o no con base.
        /// </summary>
        public bool asiBase { get; set; }
        /// <summary>
        /// Obtiene o establece el valor que determina si el usuario cuenta o no con maletin.
        /// </summary>
        public bool asiMaletin { get; set; }
        /// <summary>
        /// Obtiene o establece el valor que determina si el usuario cuenta o no con morral.
        /// </summary>
        public bool asiMorral { get; set; }
        /// <summary>
        /// Obtiene o establece el valor que determina si el usuario cuenta o no con correo.
        /// </summary>
        public bool asiCorreo { get; set; }
        /// <summary>
        /// Obtiene o establece el valor del numero de puesto donde se situa el empleado o equipo.
        /// </summary>
        public string numeroPuesto { get; set; }
        /// <summary>
        /// Obtiene o establece el valor de la fecha de ingreso.
        /// </summary>
        public string fechaIngreso { get; set; }
        /// <summary>
        /// Obtiene o establece el valor de la fecha de salida.
        /// </summary>
        public string fechaSalida { get; set; }
        /// <summary>
        /// Obtiene o establece el valor del usuario que realizó la ultima modificación sobre el recurso.
        /// </summary>
        public string usuarioModifi { get; set; }
        /// <summary>
        /// Obtiene o establece el valor de la ultima fecha de modificación del recurso.
        /// </summary>
        public string fechaModifi { get; set; }
        /// <summary>
        /// Obtiene o establece el valor de la observación general con la que se describe el recurso
        /// </summary>
        public string observacion { get; set; }
        /// <summary>
        /// Obtiene o establece la descripción del proyecto al cual se encuentra adscrito el recurso.
        /// </summary>
    }
}
