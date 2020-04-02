using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Inicio
{
    public partial class Login : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Login()
        {
            InitializeComponent();
        }
        private void ImgExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ImgMinimice_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }
        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "CONTRASEÑA")
            {
                txtClave.Text = "";
                txtClave.UseSystemPasswordChar = true;
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }
        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "CONTRASEÑA";
                txtClave.UseSystemPasswordChar = false;
            }
        }
        private void ImgLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pnlLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Login_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            txtUsuario.Focus();

            LblProductName.Text = Application.ProductName;
            LblCompanyName.Text = Application.CompanyName;
            LblProductVersion.Text = Application.ProductVersion;
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Ingresar();
        }
        private void txtClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Ingresar();
            }
        }
        void Ingresar()
        {
            try
            {
                Config.usuario = txtUsuario.Text.ToString();
                Config.clave = txtClave.Text.ToString();

                CNLogin login = new CNLogin(txtUsuario.Text.ToString(), txtClave.Text.ToString());
                SqlDataReader Reader = login.IniciarSesion();
                if (Reader.Read())
                {
                    Hide();
                    Principal principal = new Principal();
                    principal.StartPosition = FormStartPosition.CenterScreen;
                    principal.Show();
                }
                else
                {
                    MessageBox.Show("No se encontró el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
