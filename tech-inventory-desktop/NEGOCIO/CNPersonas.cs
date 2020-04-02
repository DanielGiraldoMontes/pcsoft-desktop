using System.Collections.Generic;
using System.Data;
using DATOS;
using ENTIDADES;

namespace NEGOCIO
{
    public class CNPersonas
    {

        private CDPersonas personas = new CDPersonas();

        #region 'PROVEEDORES'
        public DataSet CargarProveedores()
        {
            return personas.CargarProveedores();
        }
        public List<CEProveedor> CargarComboProveedores()
        {
            return personas.CargarComboProveedores();
        }
        public int AgregarProveedor(CEProveedor proveedor)
        {
            return personas.AgregarProveedor(proveedor);
        }
        public int ActualizarProveedor(CEProveedor proveedor)
        {
            return personas.ActualizarProveedor(proveedor);
        }
        public int BorrarProveedor(string proveedorDocumento)
        {
            return personas.BorrarProveedor(proveedorDocumento);
        }
        #endregion

        #region 'EMPLEADOS'
        public CEEmpleado CargarEmpleadosPorCodigoEquipo(string equipoCodigo)
        {
            return personas.CargarEmpleadosPorCodigoEquipo(equipoCodigo);
        }
        public DataSet CargarEmpleadosTableFilter()
        {
            return personas.CargarEmpleadosTableFilter();
        }
        public List<CEProyecto> CargarProyectos()
        {
            return personas.CargarProyectos();
        }
        public List<CESede> CargarSedes()
        {
            return personas.CargarSedes();
        }
        public List<CEUbicacion> CargarUbicaciones()
        {
            return personas.CargarUbicaciones();
        }
        public int AgregarProyecto(CEProyecto proyecto)
        {
            return personas.AgregarProyecto(proyecto);
        }
        public int AgregarSede(CESede sede)
        {
            return personas.AgregarSede(sede);
        }
        public int AgregarUbicacion(CEUbicacion ubicacion)
        {
            return personas.AgregarUbicacion(ubicacion);
        }
        public int AgregarEmpleado(CEEmpleado empleado)
        {
            return personas.AgregarEmpleado(empleado);
        }
        public int ActualizarEmpleado(CEEmpleado empleado)
        {
            return personas.ActualizarEmpleado(empleado);
        }
        public int MaximoCodigoInventario()
        {
            return personas.MaximoCodigoInventario();
        }
        #endregion
    }
}
