using System.Data.SqlClient;
using DATOS;
using ENTIDADES;

namespace NEGOCIO
{
    public class CNReportes
    {
        private CDReportes reportes = new CDReportes();

        public SqlDataReader RepMovimientoEquipos()
        {
            return reportes.RepMovimientoEquipos();
        }
        public SqlDataReader RepMovimientoEquiposFecha(CEReporte reporte)
        {
            return reportes.RepMovimientoEquiposFecha(reporte);
        }
        public SqlDataReader RepFacturas()
        {
            return reportes.RepFacturas();
        }
        public SqlDataReader RepEquipos()
        {
            return reportes.RepEquipos();
        }
        public SqlDataReader RepEquiposPorProyecto(CEReporte reporte)
        {
            return reportes.RepEquiposPorProyecto(reporte);
        }
        public SqlDataReader RepEquiposPorFechas(CEReporte reporte)
        {
            return reportes.RepEquiposPorFechas(reporte);
        }
        public SqlDataReader RepEquiposPorFechasyProyecto(CEReporte reporte)
        {
            return reportes.RepEquiposPorFechasyProyecto(reporte);
        }
        public SqlDataReader RepEmpleados()
        {
            return reportes.RepEmpleados();
        }
        public SqlDataReader RepEmpleadosPorProyecto(CEReporte reporte)
        {
            return reportes.RepEmpleadosPorProyecto(reporte);
        }
        public SqlDataReader RepEmpleadosPorFechas(CEReporte reporte)
        {
            return reportes.RepEmpleadosPorFechas(reporte);
        }
        public SqlDataReader RepEmpleadosPorFechasyProyecto(CEReporte reporte)
        {
            return reportes.RepEmpleadosPorFechasyProyecto(reporte);
        }
        public SqlDataReader RepCobroPuestosEmpleado(CEReporte reporte)
        {
            return reportes.RepCobroPuestosEmpleado(reporte);
        }
        public SqlDataReader RepCobroPuestosEquipos(CEReporte reporte)
        {
            return reportes.RepCobroPuestosEquipos(reporte);
        }
        public void ImportarEmpleados(CEReporte reporte)
        {
            reportes.ImportarEmpleados(reporte);
        }
        public void ImportarEquipos(CEReporte reporte)
        {
            reportes.ImportarEquipos(reporte);
        }
        public void CruceFacturacion(CEReporte reporte)
        {
            reportes.CruceFacturacion(reporte);
        }
        public SqlDataReader RepCruceFacturacion(CEReporte reporte)
        {
            return reportes.RepCruceFacturacion(reporte);
        }
        public void CreaBackUp(CEReporte reporte)
        {
            reportes.CreaBackUp(reporte);
        }
    }
}
