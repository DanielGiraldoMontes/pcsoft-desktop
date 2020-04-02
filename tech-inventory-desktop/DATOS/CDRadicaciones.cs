using ENTIDADES;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class CDRadicaciones
    {
        private SqlConnection connection { get; set; }

        public CDRadicaciones()
        {
            connection = Config.getConnection();
        }

        #region 'RADICACIONES'
        public DataSet CargarRadicacionesTableFilter()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.RADICACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CR");

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt, "INV.RADICACIONES");
            Config.closeConnection(connection);
            return dt;
        }
        public int RadicarFactura(CERadicacion radicacion)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INV.RADICACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "RF");
            command.Parameters.AddWithValue("@FACT_FECHA", radicacion.Fecha);
            command.Parameters.AddWithValue("@PROV_NIT", radicacion.ProvNit);
            command.Parameters.AddWithValue("@FACT_MONTO", radicacion.Monto);
            command.Parameters.AddWithValue("@FACT_NUMPROVISIONAL", radicacion.NumProvisional);
            command.Parameters.AddWithValue("@FACT_OBSERVACION", radicacion.Observacion);
            command.Parameters.AddWithValue("@FACT_PDF", radicacion.Archivo);
            command.Parameters.AddWithValue("@FACT_PDFNOMBRE", radicacion.NombreArchivo);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AnularFactura(int Id)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INV.RADICACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "AR");
            command.Parameters.AddWithValue("@ID", Id);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int BorrarFactura(int Id)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("INV.RADICACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "BR");
            command.Parameters.AddWithValue("ID", Id);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public byte[] CargarArchivo(int Id)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT FACT_PDF FROM INV.FACTURA WHERE FACT_ID = '" + Id + "'", connection);
            return command.ExecuteScalar() as byte[];
        }
        #endregion
    }
}
