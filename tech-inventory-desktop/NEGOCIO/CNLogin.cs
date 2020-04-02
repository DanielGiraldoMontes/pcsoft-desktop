using System.Data.SqlClient;
using DATOS;

namespace NEGOCIO
{
    public class CNLogin
    {
        private CDLogin LogDatos = new CDLogin();

        private string Usuario, Clave;

        public CNLogin(string usuario, string clave)
        {
            Usuario = usuario;
            Clave = clave;
        }

        public SqlDataReader IniciarSesion()
        {
            return LogDatos.InicioSesion(Usuario, Clave);
        }
    }
}
