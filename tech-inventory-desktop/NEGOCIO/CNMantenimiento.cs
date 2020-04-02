using DATOS;
using ENTIDADES;
using System.Data;

namespace NEGOCIO
{
    public class CNMantenimiento
    {

        private CDMantenimiento mantenimiento = new CDMantenimiento();

        public int AgregarUsuario(CEUsuario usuario)
        {
            return mantenimiento.AgregarUsuario(usuario);
        }
        public int ActualizarUsuario(CEUsuario usuario)
        {
            return mantenimiento.ActualizarUsuario(usuario);
        }
        public int CambiarContraseña(CEUsuario usuario)
        {
            return mantenimiento.CambiarContraseña(usuario);
        }
        public DataSet CargarUsuarios()
        {
            return mantenimiento.CargarUsuarios();
        }
    }
}
