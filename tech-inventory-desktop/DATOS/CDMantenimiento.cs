using ENTIDADES;
using System;
using System.Data;
using System.Data.SqlClient;

namespace DATOS
{
    public class CDMantenimiento
    {

        private SqlConnection connection { get; set; }

        public CDMantenimiento()
        {
            connection = Config.getConnection();
        }

        public int AgregarUsuario(CEUsuario usuario)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.USUARIOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "IU");
            command.Parameters.AddWithValue("USUARIO", usuario.userName);
            command.Parameters.AddWithValue("CLAVE", usuario.password);
            command.Parameters.AddWithValue("NOMBRES", usuario.nombres);
            command.Parameters.AddWithValue("CORREO", usuario.correo);
            command.Parameters.AddWithValue("DOCUMENTO", usuario.documento);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int ActualizarUsuario(CEUsuario usuario)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.USUARIOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "UU");
            command.Parameters.AddWithValue("@USUARIO", usuario.userName);
            command.Parameters.AddWithValue("@CLAVE", usuario.password);
            command.Parameters.AddWithValue("@NOMBRES", usuario.nombres);
            command.Parameters.AddWithValue("@CORREO", usuario.correo);
            command.Parameters.AddWithValue("@DOCUMENTO", usuario.documento);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public int CambiarContraseña(CEUsuario usuario)
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.USUARIOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "RP");
            command.Parameters.AddWithValue("@USUARIO", usuario.userName);
            command.Parameters.AddWithValue("@CLAVE", usuario.password);
            int Resultado = command.ExecuteNonQuery();
            Config.closeConnection(connection);
            return Resultado;
        }
        public DataSet CargarUsuarios()
        {
            Config.openConnection(connection);
            SqlCommand command = new SqlCommand("INV.USUARIOS", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@OPERACION", "CU");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "INV.USUARIOS");
            Config.closeConnection(connection);
            return dataSet;
        }
    }
}
