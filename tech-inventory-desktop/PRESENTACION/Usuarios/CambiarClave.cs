using System;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Usuarios
{
    public partial class CambiarClave : Form
    {
        private CNMantenimiento mantenimiento = new CNMantenimiento();
        private CEUsuario usuario { get; set; }

        public CambiarClave(CEUsuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            lblUsserNameChange.Text = this.usuario.userName;

            txtClave.UseSystemPasswordChar = true;
            txtConfirmClave.UseSystemPasswordChar = true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClave.Text != txtConfirmClave.Text)
                    throw new Exception("Las contraseñas no coinciden");

                usuario.password = txtConfirmClave.Text;

                if (mantenimiento.CambiarContraseña(usuario) > 0)
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
