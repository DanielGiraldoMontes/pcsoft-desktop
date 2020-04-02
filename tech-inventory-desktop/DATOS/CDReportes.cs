using ENTIDADES;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class CDReportes
    {
        private SqlConnection connection { get; set; }

        public CDReportes()
        {
            connection = Config.getConnection();
        }

        #region 'EQUIPOS'
        public SqlDataReader RepEquipos()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.REP_EQUIPOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "RE");
            return command.ExecuteReader();
        }
        public SqlDataReader RepEquiposPorProyecto(CEReporte reporte)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.REP_EQUIPOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "REP");
            command.Parameters.AddWithValue("@PROYECTO", reporte.Proyecto);
            return command.ExecuteReader();
        }
        public SqlDataReader RepEquiposPorFechas(CEReporte reporte)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.REP_EQUIPOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "REF");
            command.Parameters.AddWithValue("@INICIO", reporte.Inicio);
            command.Parameters.AddWithValue("@FIN", reporte.Fin);
            return command.ExecuteReader();
        }
        public SqlDataReader RepEquiposPorFechasyProyecto(CEReporte reporte)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.REP_EQUIPOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "REFP");
            command.Parameters.AddWithValue("@INICIO", reporte.Inicio);
            command.Parameters.AddWithValue("@FIN", reporte.Fin);
            command.Parameters.AddWithValue("@PROYECTO", reporte.Proyecto);
            return command.ExecuteReader();
        }
        public SqlDataReader RepCobroPuestosEquipos(CEReporte reporte)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("EXEC INV.REP_COBRO_PUESTOS_EQUIPOS @INICIO, @FIN, @PROY_ID", connection);
            command.Parameters.AddWithValue("INICIO", reporte.Inicio);
            command.Parameters.AddWithValue("FIN", reporte.Fin);
            command.Parameters.AddWithValue("PROY_ID", reporte.Proyecto);
            return command.ExecuteReader();
        }
        public void ImportarEquipos(CEReporte reporte)
        {
            Config.openConnection(connection);

            SqlBulkCopy importar = default(SqlBulkCopy);
            importar = new SqlBulkCopy(connection);

            importar.DestinationTableName = "INV.EQUIPO";

            importar.WriteToServer(reporte.Data.Tables[0]);
            connection.Close();
        }
        public SqlDataReader RepMovimientoEquipos()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.REP_EQUIPOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "RME");
            return command.ExecuteReader();
        }
        public SqlDataReader RepMovimientoEquiposFecha(CEReporte reporte)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.REP_EQUIPOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "RMEF");
            command.Parameters.AddWithValue("@INICIO", reporte.Inicio);
            command.Parameters.AddWithValue("@FIN", reporte.Fin);
            return command.ExecuteReader();
        }
        #endregion

        #region 'EMPLEADOS'
        public SqlDataReader RepEmpleados()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.REP_EMPLEADOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "RE");
            return command.ExecuteReader();
        }
        public SqlDataReader RepEmpleadosPorProyecto(CEReporte reporte)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.REP_EMPLEADOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "REP");
            command.Parameters.AddWithValue("@PROYECTO", reporte.Proyecto);
            return command.ExecuteReader();
        }
        public SqlDataReader RepEmpleadosPorFechas(CEReporte reporte)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.REP_EMPLEADOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "REF");
            command.Parameters.AddWithValue("@INICIO", reporte.Inicio);
            command.Parameters.AddWithValue("@FIN", reporte.Fin);
            return command.ExecuteReader();
        }
        public SqlDataReader RepEmpleadosPorFechasyProyecto(CEReporte reporte)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.REP_EMPLEADOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "REFP");
            command.Parameters.AddWithValue("@INICIO", reporte.Inicio);
            command.Parameters.AddWithValue("@FIN", reporte.Fin);
            command.Parameters.AddWithValue("@PROYECTO", reporte.Proyecto);
            return command.ExecuteReader();
        }
        public SqlDataReader RepCobroPuestosEmpleado(CEReporte reporte)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("EXEC INV.REP_COBRO_PUESTOS_PERSONAS @INICIO, @FIN, @PROY_ID", connection);
            command.Parameters.AddWithValue("INICIO", reporte.Inicio);
            command.Parameters.AddWithValue("FIN", reporte.Fin);
            command.Parameters.AddWithValue("PROY_ID", reporte.Proyecto);
            return command.ExecuteReader();
        }
        public void ImportarEmpleados(CEReporte reporte)
        {
            Config.openConnection(connection);

            SqlBulkCopy importar = default(SqlBulkCopy);
            importar = new SqlBulkCopy(connection);

            importar.DestinationTableName = "INV.EMPLEADO";

            importar.WriteToServer(reporte.Data.Tables[0]);
            connection.Close();
        }
        #endregion

        public SqlDataReader RepFacturas()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT FACT_ID, FACT_FECHA, FACT_MONTO, FACT_NUMPROVISIONAL, FACT_OBSERVACION, FACT_ANULADO, FACT_USUARIOMODIFI, FACT_FECHAMODIFI FROM INV.FACTURA", connection);
            return command.ExecuteReader();
        }
        public void CruceFacturacion(CEReporte reporte)
        {
            Config.openConnection(connection);

            SqlBulkCopy importar = default(SqlBulkCopy);
            importar = new SqlBulkCopy(connection);

            importar.DestinationTableName = "INV.CRUCE_FACTURACION";

            importar.WriteToServer(reporte.Data.Tables[0]);
            connection.Close();
        }
        public SqlDataReader RepCruceFacturacion(CEReporte reporte)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("EXEC INV.REP_CRUCE_FACTURACION @INICIO, @FIN", connection);
            command.Parameters.AddWithValue("INICIO", reporte.Inicio);
            command.Parameters.AddWithValue("FIN", reporte.Fin);
            return command.ExecuteReader();
        }
        public void CreaBackUp(CEReporte reporte)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("EXEC INV.REALIZA_BACKUP @FILE", connection);
            command.Parameters.AddWithValue("FILE", reporte.RutaBackUp);
            command.ExecuteReader();
        }
    }
}
