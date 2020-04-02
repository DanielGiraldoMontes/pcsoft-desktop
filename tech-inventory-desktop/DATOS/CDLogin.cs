using ENTIDADES;
using System;
using System.Data.SqlClient;

namespace DATOS
{
    public class CDLogin
    {
        private SqlConnection connection { get; set; }

        public CDLogin()
        {
            connection = Config.getConnection();
        }

        public SqlDataReader InicioSesion(string UsserName, string Password)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT USU_USUARIO, USU_CLAVE FROM INV.USUARIO WHERE USU_USUARIO = '" + UsserName + "' AND USU_CLAVE = '" + Password + "'", connection);
            return sqlCommand.ExecuteReader();
        }
    }
}
