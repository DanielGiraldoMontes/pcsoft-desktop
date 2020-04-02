using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class CDMovimientos
    {

        private SqlConnection connection { get; set; }

        public CDMovimientos()
        {
            connection = Config.getConnection();
        }

        #region 'INSTALACIONES DE PROVEEDORES'
        public DataSet CargarInstalaciones()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.INSTALACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "COI");

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt, "INV.INSTALACIONES");
            Config.closeConnection(connection);
            return dt;
        }
        public List<CEOrden> CargarInstalacionDetalle(int Id)
        {
            Config.openConnection(connection);
            List<CEOrden> ordenDetalle = new List<CEOrden>();
            SqlCommand command = new SqlCommand("INV.INSTALACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "COID");
            command.Parameters.AddWithValue("@OI_ID", Id);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ordenDetalle.Add(new CEOrden
                {
                    equipoCodigo = reader.GetString(0),
                    equipoDescripcion = reader.GetString(1),
                    marca = new CEMarca { descripcion = reader.GetString(2) },
                    modelo = new CEModelo { descripcion = reader.GetString(3) },
                    equipoSerial = reader.GetString(4),
                    observacion = reader.GetString(5)
                });
            }
            reader.Close();
            Config.closeConnection(connection);
            return ordenDetalle;
        }
        public int AgregarInstalacion(CEOrden orden)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.INSTALACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "OI");
            command.Parameters.AddWithValue("@OI_FECHA", orden.fecha);
            command.Parameters.AddWithValue("@PROV_NIT", orden.proveedorDocumento);
            command.Parameters.AddWithValue("@OI_NUMERO", orden.numero);
            command.Parameters.AddWithValue("@OI_OBSERVACIONES", orden.observacion);
            command.Parameters.AddWithValue("@OI_ANULADO", orden.anulado ? "S" : "N");
            command.Parameters.AddWithValue("@OI_DOCUMENTO", orden.archivo);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarInstalacionDetalle(CEOrden orden)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.INSTALACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "OID");
            command.Parameters.AddWithValue("@OI_ID", orden.id);
            command.Parameters.AddWithValue("@EQ_CODIGO", orden.equipoCodigo);
            command.Parameters.AddWithValue("@EQ_DESCRIPCION", orden.equipoDescripcion);
            command.Parameters.AddWithValue("@EQ_MODELO", orden.modelo.id);
            command.Parameters.AddWithValue("@EQ_SERIAL", orden.equipoSerial);
            command.Parameters.AddWithValue("@EQ_OBSERVACION", orden.observacion);
            command.Parameters.AddWithValue("@OI_FECHA", orden.fecha);
            command.Parameters.AddWithValue("@PROV_NIT", orden.proveedorDocumento);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AnularInstalacion(int OiId)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.INSTALACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "AOI");
            command.Parameters.AddWithValue("@OI_ID", OiId);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int MaximoIdInstalacion()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT MAX(OI_ID) FROM INV.ORDEN_INSTALACION", connection);
            SqlDataReader Reader = command.ExecuteReader();
            int Resultado = 0;
            if (Reader.Read())
                Resultado = Reader.GetInt32(0);

            Config.closeConnection(connection);
            return Resultado;
        }
        public byte[] CargarArchivoInstalacion(int Id)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT OI_DOCUMENTO FROM INV.ORDEN_INSTALACION WHERE OI_ID = '" + Id + "'", connection);
            return command.ExecuteScalar() as byte[];
        }
        #endregion

        #region 'RECOGIDAS DE PROVEEDORES'
        public DataSet CargarRecogidaTableFilter()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.RECOGIDAS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "COR");

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt, "INV.RECOGIDAS");
            Config.closeConnection(connection);
            return dt;
        }
        public List<CEOrden> CargarRecogidaDetalle(int Id)
        {
            Config.openConnection(connection);
            List<CEOrden> ordenDetalle = new List<CEOrden>();
            SqlCommand command = new SqlCommand("INV.RECOGIDAS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CORD");
            command.Parameters.AddWithValue("@OR_ID", Id);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                ordenDetalle.Add(new CEOrden
                {
                    equipoCodigo = reader.GetString(0),
                    equipoDescripcion = reader.GetString(1),
                    marca = new CEMarca
                    {
                        descripcion = reader.GetString(2)
                    },
                    modelo = new CEModelo
                    {
                        descripcion = reader.GetString(3)
                    },
                    equipoSerial = reader.GetString(4),
                    observacion = reader.GetString(5)
                });
            reader.Close();
            Config.closeConnection(connection);
            return ordenDetalle;
        }
        public int AgregarRecogida(CEOrden orden)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.RECOGIDAS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "OR");
            command.Parameters.AddWithValue("@OR_FECHA", orden.fecha);
            command.Parameters.AddWithValue("@PROV_NIT", orden.proveedorDocumento);
            command.Parameters.AddWithValue("@OR_NUMERO", orden.numero);
            command.Parameters.AddWithValue("@OR_OBSERVACIONES", orden.observacion);
            command.Parameters.AddWithValue("@OR_ANULADO", orden.anulado ? "S" : "N");
            command.Parameters.AddWithValue("@OR_DOCUMENTO", orden.archivo);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarRecogidaDetalle(CEOrden orden)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.RECOGIDAS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "OR");
            command.Parameters.AddWithValue("@OR_ID", orden.id);
            command.Parameters.AddWithValue("@EQ_CODIGO", orden.equipoCodigo);
            command.Parameters.AddWithValue("@EQ_DESCRIPCION", orden.equipoDescripcion);
            command.Parameters.AddWithValue("@EQ_MODELO", orden.modelo.id);
            command.Parameters.AddWithValue("@EQ_SERIAL", orden.equipoSerial);
            command.Parameters.AddWithValue("@EQ_OBSERVACION", orden.observacion);
            command.Parameters.AddWithValue("@OR_FECHA", orden.fecha);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AnularRecogida(int OrId)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.RECOGIDAS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "AOR");
            command.Parameters.AddWithValue("@OR_ID", OrId);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int MaximoIdRecogida()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT MAX(OR_ID) FROM INV.ORDEN_RECOGIDA", connection);
            SqlDataReader Reader = command.ExecuteReader();
            int Resultado = 0;
            if (Reader.Read())
                Resultado = Reader.GetInt32(0);

            return Resultado;
        }
        public byte[] CargarArchivoRecogida(int Id)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT OR_DOCUMENTO FROM INV.ORDEN_RECOGIDA WHERE OR_ID = '" + Id + "'", connection);
            return command.ExecuteScalar() as byte[];
        }
        #endregion
    }
}
