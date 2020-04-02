using System;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Usuarios
{
    public partial class Agregar : Form
    {
        private CNMantenimiento mantenimiento = new CNMantenimiento();
        private CEUsuario usuario { get; set; }

        public Agregar(CEUsuario usuario)
        {
            InitializeComponent();

            this.usuario = usuario;

            txtClave.UseSystemPasswordChar = true;
            txtConfirmClave.UseSystemPasswordChar = true;
        }
        private void Agregar_Load(object sender, EventArgs e)
        {
            try
            {
                if (Tag.ToString() == "U")
                {
                    txtUsuario.Enabled = false;
                    txtClave.Enabled = false;
                    txtConfirmClave.Enabled = false;

                    txtUsuario.Text = usuario.userName;
                    txtClave.Text = usuario.password;
                    txtConfirmClave.Text = usuario.password;
                    txtNombres.Text = usuario.nombres;
                    txtCorreo.Text = usuario.correo;
                    txtDocumento.Text = usuario.documento;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtClave.Text != txtConfirmClave.Text)
                    throw new Exception("Las contraseñas no coinciden");

                usuario.userName = txtUsuario.Text;
                usuario.password = txtConfirmClave.Text;
                usuario.nombres = txtNombres.Text.ToUpper();
                usuario.correo = txtCorreo.Text.ToUpper();
                usuario.documento = txtDocumento.Text;

                switch (Tag.ToString())
                {
                    case "U":
                        mantenimiento.ActualizarUsuario(usuario);
                        break;
                    case "I":
                        mantenimiento.AgregarUsuario(usuario);
                        break;
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
