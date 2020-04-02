using System.Collections.Generic;
using System.Data;
using DATOS;
using ENTIDADES;

namespace NEGOCIO
{
    public class CNAsignaciones
    {
        private CDAsignaciones asignaciones = new CDAsignaciones();

        #region 'ASIGNACIONES EMPLEADO'
        public DataSet CargarAsignacionTableFilter()
        {
            return asignaciones.CargarAsignacionTableFilter();
        }
        public List<CEEquipo> CargarAsignacionDetalle(int id)
        {
            return asignaciones.CargarAsignacionDetalle(id);
        }
        public int AgregarAsignacion(CEAsignaciones asignacion)
        {
            return asignaciones.AgregarAsignacion(asignacion);
        }
        public int AgregarAsignacionDetalle(CEAsignaciones asignacion)
        {
            return asignaciones.AgregarAsignacionDetalle(asignacion);
        }
        public int AgregarDocumentoAsignacion(CEAsignaciones asignacion)
        {
            return asignaciones.AgregarDocumentoAsignacion(asignacion);
        }
        public byte[] CargarDocumentoAsignacion(int id)
        {
            return asignaciones.CargarDocumentoAsignacion(id);
        }
        public int AnularAsignacion(int id)
        {
            return asignaciones.AnularAsignacion(id);
        }
        public int MaximoIdAsignacion()
        {
            return asignaciones.MaximoIdAsignacion();
        }
        #endregion

        #region 'DEVOLUCION EMPLEADO'
        public DataSet CargarDevolucionTableFilter()
        {
            return asignaciones.CargarDevolucionTableFilter();
        }
        public List<CEEquipo> CargarDevolucionDetalle(int id)
        {
            return asignaciones.CargarDevolucionDetalle(id);
        }
        public CEAsignaciones CargarEmpleadoDevolver(string empleadoCedula)
        {
            return asignaciones.CargarEmpleadoDevolver(empleadoCedula);
        }
        public List<CEEquipo> CargarEmpleadoDevolverDetalle(string empleadoCedula)
        {
            return asignaciones.CargarEmpleadoDevolverDetalle(empleadoCedula);
        }
        public int AgregarDevolucion(CEAsignaciones asignacion)
        {
            return asignaciones.AgregarDevolucion(asignacion);
        }
        public int AgregarDevolucionDetalle(CEAsignaciones asignacion)
        {
            return asignaciones.AgregarDevolucionDetalle(asignacion);
        }
        public int AgregarDocumentoDevolucion(CEAsignaciones asignacion)
        {
            return asignaciones.AgregarDocumentoDevolucion(asignacion);
        }
        public byte[] CargarDocumentoDevolucion(int id)
        {
            return asignaciones.CargarDocumentoDevolucion(id);
        }
        public int AnularDevolucion(int id)
        {
            return asignaciones.AnularDevolucion(id);
        }
        public int MaximoIdDevolucion()
        {
            return asignaciones.MaximoIdDevolucion();
        }
        #endregion

        #region 'PRESTAMOS EMPLEADO'
        public DataSet CargarPrestamoTableFilter()
        {
            return asignaciones.CargarPrestamoTableFilter();
        }
        public List<CEEquipo> CargarPrestamoDetalle(int id)
        {
            return asignaciones.CargarPrestamoDetalle(id);
        }
        public int AgregarPrestamo(CEAsignaciones asignacion)
        {
            return asignaciones.AgregarPrestamo(asignacion);
        }
        public int AgregarPrestamoDetalle(CEAsignaciones asignacion)
        {
            return asignaciones.AgregarPrestamoDetalle(asignacion);
        }
        public int AgregarDocumentoPrestamo(CEAsignaciones asignacion)
        {
            return asignaciones.AgregarDocumentoPrestamo(asignacion);
        }
        public byte[] CargarDocumentoPrestamo(int id)
        {
            return asignaciones.CargarDocumentoPrestamo(id);
        }
        public int AnularPrestamo(int id)
        {
            return asignaciones.AnularPrestamo(id);
        }
        public int MaximoIdPrestamo()
        {
            return asignaciones.MaximoIdPrestamo();
        }
        #endregion
    }
}
