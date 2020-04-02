using ENTIDADES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class CDAsignaciones
    {
        private SqlConnection connection { get; set; }

        public CDAsignaciones()
        {
            connection = Config.getConnection();
        }

        #region 'ASIGNACIONES EMPLEADO'
        public DataSet CargarAsignacionTableFilter()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.ASIGNACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CA");

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt, "INV.ASIGNACIONES");
            Config.closeConnection(connection);
            return dt;
        }
        public List<CEEquipo> CargarAsignacionDetalle(int Id)
        {
            Config.openConnection(connection);
            List<CEEquipo> asignacionDetalle = new List<CEEquipo>();
            SqlCommand command = new SqlCommand("INV.ASIGNACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CAD");
            command.Parameters.AddWithValue("@ID", Id);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                asignacionDetalle.Add(new CEEquipo
                {
                    equipoCodigo = reader.GetString(0),
                    equipoDescripcion = reader.GetString(1),
                    marca = new CEMarca { descripcion = reader.GetString(2) },
                    modelo = new CEModelo { descripcion = reader.GetString(3) },
                    observacion = reader.GetString(4)
                });
            }
            reader.Close();
            Config.closeConnection(connection);
            return asignacionDetalle;
        }
        public int AgregarAsignacion(CEAsignaciones asignacion)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.ASIGNACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "IA");
            command.Parameters.AddWithValue("@ASI_FECHA", asignacion.fecha);
            command.Parameters.AddWithValue("@EMP_CEDULA", asignacion.documento);
            command.Parameters.AddWithValue("@EMP_NOMBRES", asignacion.nombreCompleto);
            command.Parameters.AddWithValue("@ASI_TECLADO", asignacion.asiTeclado ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_MOUSE", asignacion.asiMouse ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_PUESTO", asignacion.asiPuesto ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_BASE", asignacion.asiBase ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_MALETIN", asignacion.asiMaletin ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_MORRAL", asignacion.asiMorral ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_CORREO", asignacion.asiCorreo ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_ANULADO", asignacion.anulado ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_OBSERVACION", asignacion.observacion);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarAsignacionDetalle(CEAsignaciones asignacion)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.ASIGNACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "IAD");
            command.Parameters.AddWithValue("@ID", asignacion.id);
            command.Parameters.AddWithValue("@EQ_CODIGO", asignacion.equipoCodigo);
            command.Parameters.AddWithValue("@EQ_DESCRIPCION", asignacion.equipoDescripcion);
            command.Parameters.AddWithValue("@EQ_MODELO", asignacion.modelo.id);
            command.Parameters.AddWithValue("@EQ_OBSERVACION", asignacion.observacion);
            command.Parameters.AddWithValue("@EMP_CEDULA", asignacion.documento);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarDocumentoAsignacion(CEAsignaciones asignacion)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.ASIGNACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "ADA");
            command.Parameters.AddWithValue("@ID", asignacion.id);
            command.Parameters.AddWithValue("@ARCHIVO", asignacion.archivo);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public byte[] CargarDocumentoAsignacion(int Id)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT ASI_DOCUMENTO FROM INV.ASIGNACION WHERE ASI_ID = '" + Id + "'", connection);
            return command.ExecuteScalar() as byte[];
        }
        public int AnularAsignacion(int AsiId)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.ASIGNACIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "AA");
            command.Parameters.AddWithValue("@ID", AsiId);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int MaximoIdAsignacion()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT MAX(ASI_ID) FROM INV.ASIGNACION ", connection);
            SqlDataReader Reader = command.ExecuteReader();
            int Resultado = 0;
            while (Reader.Read()) { Resultado = Reader.GetInt32(0); }
            return Resultado;
        }
        #endregion

        #region 'DEVOLUCIONES EMPLEADO'
        public DataSet CargarDevolucionTableFilter()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.DEVOLUCIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CD");
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt, "INV.DEVOLUCIONES");
            Config.closeConnection(connection);
            return dt;
        }
        public List<CEEquipo> CargarDevolucionDetalle(int Id)
        {
            Config.openConnection(connection);
            List<CEEquipo> devolucionDetalle = new List<CEEquipo>();
            SqlCommand command = new SqlCommand("INV.DEVOLUCIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CDD");
            command.Parameters.AddWithValue("@ID", Id);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                devolucionDetalle.Add(new CEEquipo
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
                    observacion = reader.GetString(4)
                });
            }
            reader.Close();
            Config.closeConnection(connection);
            return devolucionDetalle;
        }
        public CEAsignaciones CargarEmpleadoDevolver(string Documento)
        {
            Config.openConnection(connection);
            CEAsignaciones empleadoDevolver = new CEAsignaciones();
            SqlCommand command = new SqlCommand("INV.DEVOLUCIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CED");
            command.Parameters.AddWithValue("@EMP_CEDULA", Documento);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                empleadoDevolver = new CEAsignaciones
                {
                    asiTeclado = Convert.ToBoolean(reader.GetString(0)),
                    asiMouse = Convert.ToBoolean(reader.GetString(1)),
                    asiPuesto = Convert.ToBoolean(reader.GetString(2)),
                    asiBase = Convert.ToBoolean(reader.GetString(3)),
                    asiMaletin = Convert.ToBoolean(reader.GetString(4)),
                    asiMorral = Convert.ToBoolean(reader.GetString(5)),
                    asiCorreo = Convert.ToBoolean(reader.GetString(6))
                };
            }
            reader.Close();
            Config.closeConnection(connection);
            return empleadoDevolver;
        }
        public List<CEEquipo> CargarEmpleadoDevolverDetalle(string Documento)
        {
            Config.openConnection(connection);
            List<CEEquipo> empleadoDevolverDetalle = new List<CEEquipo>();
            SqlCommand command = new SqlCommand("INV.DEVOLUCIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CEDD");
            command.Parameters.AddWithValue("@EMP_CEDULA", Documento);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                empleadoDevolverDetalle.Add(new CEEquipo
                {
                    equipoCodigo = reader.GetString(0),
                    equipoDescripcion = reader.GetString(1),
                    marca = new CEMarca
                    {
                        descripcion = reader.GetString(2)
                    },
                    modelo = new CEModelo
                    {
                        id = reader.GetInt32(3),
                        descripcion = reader.GetString(4)
                    },
                    observacion = reader.GetString(5)
                });
            }
            reader.Close();
            Config.closeConnection(connection);
            return empleadoDevolverDetalle;
        }
        public int AgregarDevolucion(CEAsignaciones asignacion)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.DEVOLUCIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "ID");
            command.Parameters.AddWithValue("@DEV_FECHA", asignacion.fecha);
            command.Parameters.AddWithValue("@EMP_CEDULA", asignacion.documento);
            command.Parameters.AddWithValue("@EMP_NOMBRES", asignacion.nombreCompleto);
            command.Parameters.AddWithValue("@DEV_TECLADO", asignacion.asiTeclado ? "S" : "N");
            command.Parameters.AddWithValue("@DEV_MOUSE", asignacion.asiMouse ? "S" : "N");
            command.Parameters.AddWithValue("@DEV_PUESTO", asignacion.asiPuesto ? "S" : "N");
            command.Parameters.AddWithValue("@DEV_BASE", asignacion.asiBase ? "S" : "N");
            command.Parameters.AddWithValue("@DEV_MALETIN", asignacion.asiMaletin ? "S" : "N");
            command.Parameters.AddWithValue("@DEV_MORRAL", asignacion.asiMorral ? "S" : "N");
            command.Parameters.AddWithValue("@DEV_CORREO", asignacion.asiCorreo ? "S" : "N");
            command.Parameters.AddWithValue("@DEV_ANULADO", asignacion.anulado ? "S" : "N");
            command.Parameters.AddWithValue("@DEV_OBSERVACION", asignacion.observacion);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarDevolucionDetalle(CEAsignaciones asignacion)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.DEVOLUCIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "IDD");
            command.Parameters.AddWithValue("@ID", asignacion.id);
            command.Parameters.AddWithValue("@EQ_CODIGO", asignacion.equipoCodigo);
            command.Parameters.AddWithValue("@EQ_DESCRIPCION", asignacion.equipoDescripcion);
            command.Parameters.AddWithValue("@EQ_MODELO", asignacion.modelo.id);
            command.Parameters.AddWithValue("@EQ_OBSERVACION", asignacion.observacion);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarDocumentoDevolucion(CEAsignaciones asignacion)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.DEVOLUCIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "ADD");
            command.Parameters.AddWithValue("@ID", asignacion.id);
            command.Parameters.AddWithValue("@ARCHIVO", asignacion.archivo);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public byte[] CargarDocumentoDevolucion(int Id)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT DEV_DOCUMENTO FROM INV.DEVOLUCION WHERE DEV_ID = '" + Id + "'", connection);
            return command.ExecuteScalar() as byte[];
        }
        public int AnularDevolucion(int DevId)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.DEVOLUCIONES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "AD");
            command.Parameters.AddWithValue("@ID", DevId);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int MaximoIdDevolucion()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT MAX(DEV_ID) FROM INV.DEVOLUCION", connection);
            SqlDataReader Reader = command.ExecuteReader();
            int Resultado = 0;
            while (Reader.Read()) { Resultado = Reader.GetInt32(0); }
            return Resultado;
        }
        #endregion

        #region 'PRESTAMOS EMPLEADO'
        public DataSet CargarPrestamoTableFilter()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.PRESTAMOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CP");

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt, "INV.PRESTAMOS");
            Config.closeConnection(connection);
            return dt;
        }
        public List<CEEquipo> CargarPrestamoDetalle(int Id)
        {
            Config.openConnection(connection);
            List<CEEquipo> prestamoDetalle = new List<CEEquipo>();
            SqlCommand command = new SqlCommand("INV.PRESTAMOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CPD");
            command.Parameters.AddWithValue("@ID", Id);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                prestamoDetalle.Add(new CEEquipo
                {
                    equipoCodigo = reader.GetString(0),
                    equipoDescripcion = reader.GetString(1),
                    marca = new CEMarca { descripcion = reader.GetString(2) },
                    modelo = new CEModelo { descripcion = reader.GetString(3) },
                    observacion = reader.GetString(4)
                });
            }
            reader.Close();
            Config.closeConnection(connection);

            return prestamoDetalle;
        }
        public int AgregarPrestamo(CEAsignaciones asignacion)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.PRESTAMOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "IP");
            command.Parameters.AddWithValue("@PRES_FECHA", asignacion.fecha);
            command.Parameters.AddWithValue("@EMP_CEDULA", asignacion.documento);
            command.Parameters.AddWithValue("@EMP_NOMBRES", asignacion.nombreCompleto);
            command.Parameters.AddWithValue("@PRES_TECLADO", asignacion.asiTeclado ? "S" : "N");
            command.Parameters.AddWithValue("@PRES_MOUSE", asignacion.asiMouse ? "S" : "N");
            command.Parameters.AddWithValue("@PRES_PUESTO", asignacion.asiPuesto ? "S" : "N");
            command.Parameters.AddWithValue("@PRES_BASE", asignacion.asiBase ? "S" : "N");
            command.Parameters.AddWithValue("@PRES_MALETIN", asignacion.asiMaletin ? "S" : "N");
            command.Parameters.AddWithValue("@PRES_MORRAL", asignacion.asiMorral ? "S" : "N");
            command.Parameters.AddWithValue("@PRES_CORREO", asignacion.asiCorreo ? "S" : "N");
            command.Parameters.AddWithValue("@PRES_ANULADO", asignacion.anulado ? "S" : "N");
            command.Parameters.AddWithValue("@PRES_OBSERVACION", asignacion.observacion);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarPrestamoDetalle(CEAsignaciones asignacion)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.PRESTAMOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "IPD");
            command.Parameters.AddWithValue("PRESDE_ID", asignacion.id);
            command.Parameters.AddWithValue("EQ_CODIGO", asignacion.equipoCodigo);
            command.Parameters.AddWithValue("EQ_DESCRIPCION", asignacion.equipoDescripcion);
            command.Parameters.AddWithValue("EQ_MODELO", asignacion.modelo.id);
            command.Parameters.AddWithValue("EQ_OBSERVACION", asignacion.observacion);
            command.Parameters.AddWithValue("EMP_CEDULA", asignacion.documento);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarDocumentoPrestamo(CEAsignaciones asignacion)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.PRESTAMOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "ADP");
            command.Parameters.AddWithValue("PRES_ID", asignacion.id);
            command.Parameters.AddWithValue("ARCHIVO", asignacion.archivo);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public byte[] CargarDocumentoPrestamo(int Id)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT PRES_DOCUMENTO FROM INV.PRESTAMO WHERE PRES_ID = '" + Id + "'", connection);
            return command.ExecuteScalar() as byte[];
        }
        public int AnularPrestamo(int PresId)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.PRESTAMOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "AP");
            command.Parameters.AddWithValue("ID", PresId);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int MaximoIdPrestamo()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("SELECT MAX(PRES_ID) FROM INV.PRESTAMO ", connection);
            SqlDataReader Reader = command.ExecuteReader();
            int Resultado = 0;
            while (Reader.Read()) { Resultado = Reader.GetInt32(0); }
            return Resultado;
        }
        #endregion
    }
}
