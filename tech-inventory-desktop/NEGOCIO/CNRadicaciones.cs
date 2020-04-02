using System.Data;
using DATOS;
using ENTIDADES;

namespace NEGOCIO
{
    public class CNRadicaciones
    {
        private CDRadicaciones radicaciones = new CDRadicaciones();

        public DataSet CargarRadicacionesTableFilter()
        {
            return radicaciones.CargarRadicacionesTableFilter();
        }
        public int RadicarFactura(CERadicacion radicacion)
        {
            return radicaciones.RadicarFactura(radicacion);
        }
        public int AnularFactura(int id)
        {
            return radicaciones.AnularFactura(id);
        }
        public int BorrarFactura(int id)
        {
            return radicaciones.BorrarFactura(id);
        }
        public byte[] CargarArchivo(int id)
        {
            return radicaciones.CargarArchivo(id);
        }
    }
}
