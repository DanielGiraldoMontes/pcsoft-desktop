using ENTIDADES;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class CDPersonas
    {

        private SqlConnection connection { get; set; }

        public CDPersonas()
        {
            connection = Config.getConnection();
        }


        #region 'PROVEEDORES'
        public DataSet CargarProveedores()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.PROVEEDORES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CP");

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt, "INV.PROVEEDORES");
            Config.closeConnection(connection);
            return dt;
        }
        public List<CEProveedor> CargarComboProveedores()
        {
            Config.openConnection(connection);
            List<CEProveedor> proveedores = new List<CEProveedor>();
            SqlCommand command = new SqlCommand("INV.PROVEEDORES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CP");

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                proveedores.Add(new CEProveedor
                {
                    documento = reader.GetString(0),
                    nombreCompleto = reader.GetString(1),
                    nombreCorto = reader.GetString(2),
                    telefono = reader.GetString(3),
                    correo = reader.GetString(4),
                    direccion = reader.GetString(5),
                });

            Config.closeConnection(connection);
            return proveedores;
        }
        public int AgregarProveedor(CEProveedor proveedor)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.PROVEEDORES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "IP");
            command.Parameters.AddWithValue("@NIT", proveedor.documento);
            command.Parameters.AddWithValue("@RAZONSOCIAL", proveedor.nombreCompleto);
            command.Parameters.AddWithValue("@NOMBRECORTO", proveedor.nombreCorto);
            command.Parameters.AddWithValue("@TELEFONO", proveedor.telefono);
            command.Parameters.AddWithValue("@CORREO", proveedor.correo);
            command.Parameters.AddWithValue("@DIRECCION", proveedor.direccion);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int ActualizarProveedor(CEProveedor proveedor)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.PROVEEDORES", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "UP");
            command.Parameters.AddWithValue("@NIT", proveedor.documento);
            command.Parameters.AddWithValue("@RAZONSOCIAL", proveedor.nombreCompleto);
            command.Parameters.AddWithValue("@NOMBRECORTO", proveedor.nombreCorto);
            command.Parameters.AddWithValue("@TELEFONO", proveedor.telefono);
            command.Parameters.AddWithValue("@CORREO", proveedor.correo);
            command.Parameters.AddWithValue("@DIRECCION", proveedor.direccion);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int BorrarProveedor(string proveedorDocumento)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("EXEC INV.BORRAR_PROVEEDOR @NIT", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "DP");
            command.Parameters.AddWithValue("NIT", proveedorDocumento);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        #endregion

        #region 'EMPLEADOS'
        public CEEmpleado CargarEmpleadosPorCodigoEquipo(string equipoCodigo)
        {
            Config.openConnection(connection);
            CEEmpleado empleado = null;
            SqlCommand command = new SqlCommand("SELECT EM.EMP_CEDULA, EM.EMP_CODINV, CONCAT(EM.EMP_APELLIDO1,' ', EM.EMP_APELLIDO2,' ', EM.EMP_NOMBRE1,' ', EM.EMP_NOMBRE2) AS NOMBRES, P.PROY_DESC, S.SEDE_DESC, U.UBI_DESC, EM.EMP_PUESTO  FROM INV.EMPLEADO EM INNER JOIN INV.EQUIPO AS E ON E.EMP_CEDULA = EM.EMP_CEDULA INNER JOIN INV.PROYECTO AS P ON P.PROY_ID = EM.EMP_PROY_ID INNER JOIN INV.SEDE AS S ON S.SEDE_ID = EM.EMP_SEDE_ID INNER JOIN INV.UBICACION AS U ON U.UBI_ID = EM.EMP_UBI_ID WHERE E.EQ_CODIGO = '" + equipoCodigo + "'", connection);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                empleado = new CEEmpleado
                {
                    documento = reader.GetString(0),
                    codigo = reader.GetInt32(1),
                    nombreCompleto = reader.GetString(2),
                    proyecto = new CEProyecto
                    {
                        descripcion = reader.GetString(3)
                    },
                    sede = new CESede
                    {
                        descripcion = reader.GetString(4)
                    },
                    ubicacion = new CEUbicacion
                    {
                        descripcion = reader.GetString(5)
                    },
                    numeroPuesto = reader.GetString(6),
                };

            reader.Close();
            Config.closeConnection(connection);
            return empleado;
        }
        public DataSet CargarEmpleadosTableFilter()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.EMPLEADOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CE");

            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet dt = new DataSet();
            da.Fill(dt, "INV.EMPLEADOS");
            Config.closeConnection(connection);
            return dt;
        }
        public List<CEProyecto> CargarProyectos()
        {
            Config.openConnection(connection);
            List<CEProyecto> proyectos = new List<CEProyecto>();
            SqlCommand command = new SqlCommand("SELECT PROY_ID, PROY_DESC FROM INV.PROYECTO ORDER BY PROY_DESC ASC", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                proyectos.Add(new CEProyecto
                {
                    id = reader.GetInt32(0),
                    descripcion = reader.GetString(1)
                });

            reader.Close();
            Config.closeConnection(connection);
            return proyectos;
        }
        public List<CESede> CargarSedes()
        {
            Config.openConnection(connection);
            List<CESede> sedes = new List<CESede>();
            SqlCommand command = new SqlCommand("SELECT SEDE_ID, SEDE_DESC FROM INV.SEDE ORDER BY SEDE_DESC ASC", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                sedes.Add(new CESede
                {
                    id = reader.GetInt32(0),
                    descripcion = reader.GetString(1)
                });

            reader.Close();
            Config.closeConnection(connection);
            return sedes;
        }
        public List<CEUbicacion> CargarUbicaciones()
        {
            Config.openConnection(connection);
            List<CEUbicacion> ubicaciones = new List<CEUbicacion>();
            SqlCommand command = new SqlCommand("SELECT UBI_ID, UBI_DESC FROM INV.UBICACION ORDER BY UBI_DESC ASC", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
                ubicaciones.Add(new CEUbicacion
                {
                    id = reader.GetInt32(0),
                    descripcion = reader.GetString(1)
                });

            reader.Close();
            Config.closeConnection(connection);
            return ubicaciones;
        }
        public int AgregarProyecto(CEProyecto proyecto)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("EXEC INV.AGREGAR_PROYECTO @PROYECTO", connection);
            command.Parameters.AddWithValue("PROYECTO", proyecto.descripcion);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarSede(CESede sede)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("EXEC INV.AGREGAR_SEDE @SEDE", connection);
            command.Parameters.AddWithValue("SEDE", sede.descripcion);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarUbicacion(CEUbicacion ubicacion)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("EXEC INV.AGREGAR_UBICACION @UBICACION", connection);
            command.Parameters.AddWithValue("UBICACION", ubicacion.descripcion);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int AgregarEmpleado(CEEmpleado empleado)
        {
            Config.openConnection(connection);

            SqlCommand command = new SqlCommand("INV.EMPLEADOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "IE");
            command.Parameters.AddWithValue("@EMP_CEDULA", empleado.documento);
            command.Parameters.AddWithValue("@EMP_CODINV", empleado.codigo);
            command.Parameters.AddWithValue("@EMP_APELLIDO1", empleado.apellido1);
            command.Parameters.AddWithValue("@EMP_APELLIDO2", empleado.apellido2);
            command.Parameters.AddWithValue("@EMP_NOMBRE1", empleado.nombre1);
            command.Parameters.AddWithValue("@EMP_NOMBRE2", empleado.nombre2);
            command.Parameters.AddWithValue("@EMP_CORREO", empleado.correo);
            command.Parameters.AddWithValue("@EMP_TELEFONO", empleado.telefono);
            command.Parameters.AddWithValue("@EMP_PROY_ID", empleado.proyecto.id);
            command.Parameters.AddWithValue("@EMP_SEDE_ID", empleado.sede.id);
            command.Parameters.AddWithValue("@EMP_UBI_ID", empleado.ubicacion.id);
            command.Parameters.AddWithValue("@EMP_PUESTO", empleado.numeroPuesto);
            command.Parameters.AddWithValue("@ASI_TECLADO", empleado.asiTeclado ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_MOUSE", empleado.asiMouse ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_PUESTO", empleado.asiPuesto ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_BASE", empleado.asiBase ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_MALETIN", empleado.asiMaletin ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_MORRAL", empleado.asiMorral ? "S" : "N");
            command.Parameters.AddWithValue("@ASI_CORREO", empleado.asiCorreo ? "S" : "N");
            command.Parameters.AddWithValue("@EMP_FECHAINGRESO", empleado.fechaIngreso);
            command.Parameters.AddWithValue("@EMP_FECHASALIDA", empleado.fechaSalida);
            command.Parameters.AddWithValue("@EMP_OBSERVACION", empleado.observacion);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int ActualizarEmpleado(CEEmpleado empleado)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.EMPLEADOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "UE");
            command.Parameters.AddWithValue("@EMP_CEDULA", empleado.documento);
            command.Parameters.AddWithValue("@EMP_APELLIDO1", empleado.apellido1);
            command.Parameters.AddWithValue("@EMP_APELLIDO2", empleado.apellido2);
            command.Parameters.AddWithValue("@EMP_NOMBRE1", empleado.nombre1);
            command.Parameters.AddWithValue("@EMP_NOMBRE2", empleado.nombre2);
            command.Parameters.AddWithValue("@EMP_CORREO", empleado.correo);
            command.Parameters.AddWithValue("@EMP_TELEFONO", empleado.telefono);
            command.Parameters.AddWithValue("@EMP_PROY_ID", empleado.proyecto.id);
            command.Parameters.AddWithValue("@EMP_SEDE_ID", empleado.sede.id);
            command.Parameters.AddWithValue("@EMP_UBI_ID", empleado.ubicacion.id);
            command.Parameters.AddWithValue("@EMP_PUESTO", empleado.numeroPuesto);
            command.Parameters.AddWithValue("@EMP_FECHAINGRESO", empleado.fechaIngreso);
            command.Parameters.AddWithValue("@EMP_FECHASALIDA", empleado.fechaSalida);
            command.Parameters.AddWithValue("@EMP_OBSERVACION", empleado.observacion);

            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int MaximoCodigoInventario()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("EXEC INV.MAXIMO_CODIGO_INVENTARIO", connection);
            SqlDataReader Reader = command.ExecuteReader();
            int Resultado = 0;
            while (Reader.Read())
            {
                Resultado = (Reader.GetInt32(0));
            }
            Config.closeConnection(connection);
            return Resultado;
        }
        #endregion
    }
}
