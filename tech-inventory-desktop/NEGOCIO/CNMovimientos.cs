using System.Collections.Generic;
using System.Data;
using DATOS;
using ENTIDADES;

namespace NEGOCIO
{
    public class CNMovimientos
    {

        private CDMovimientos movimientos = new CDMovimientos();

        #region 'INSTALACIONES DE PROVEEDORES'
        public DataSet CargarInstalaciones()
        {
            return movimientos.CargarInstalaciones();
        }
        public List<CEOrden> CargarInstalacionDetalle(int id)
        {
            return movimientos.CargarInstalacionDetalle(id);
        }
        public int AgregarInstalacion(CEOrden orden)
        {
            return movimientos.AgregarInstalacion(orden);
        }
        public int AgregarInstalacionDetalle(CEOrden orden)
        {
            return movimientos.AgregarInstalacionDetalle(orden);
        }
        public int AnularInstalacion(int id)
        {
            return movimientos.AnularInstalacion(id);
        }
        public int MaximoIdInstalacion()
        {
            return movimientos.MaximoIdInstalacion();
        }
        public byte[] CargarArchivoInstalacion(int id)
        {
            return movimientos.CargarArchivoInstalacion(id);
        }
        #endregion

        #region 'RECOGIDA DE PROVEEDORES'
        public DataSet CargarRecogidaTableFilter()
        {
            return movimientos.CargarRecogidaTableFilter();
        }
        public List<CEOrden> CargarRecogidaDetalle(int id)
        {
            return movimientos.CargarRecogidaDetalle(id);
        }
        public int AgregarRecogida(CEOrden orden)
        {
            return movimientos.AgregarRecogida(orden);
        }
        public int AgregarRecogidaDetalle(CEOrden orden)
        {
            return movimientos.AgregarRecogidaDetalle(orden);
        }
        public int AnularRecogida(int id)
        {
            return movimientos.AnularRecogida(id);
        }
        public int MaximoIdRecogida()
        {
            return movimientos.MaximoIdRecogida();
        }
        public byte[] CargarArchivoRecogida(int id)
        {
            return movimientos.CargarArchivoRecogida(id);
        }
        #endregion
    }
}
