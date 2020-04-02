using System;
using System.Drawing;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Usuarios
{
    public partial class Gestionar : Form
    {
        private CNMantenimiento mantenimiento;
        private CEUsuario usuario;
        private BindingSource origen;

        public Gestionar()
        {
            InitializeComponent();

            mantenimiento = new CNMantenimiento();
            usuario = new CEUsuario();

            Dock = DockStyle.Fill;

            Buscar();
        }
        private void Buscar()
        {
            try
            {
                origen = new BindingSource(mantenimiento.CargarUsuarios(), "INV.USUARIOS");
                tblUsuarios.DataSource = origen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Agregar agregar = new Agregar(usuario);
            agregar.Tag = "I";
            agregar.TopLevel = false;
            agregar.Dock = DockStyle.None;
            Controls.Add(agregar);
            agregar.Location = new Point(50, 50);
            agregar.BringToFront();
            agregar.FormClosed += new FormClosedEventHandler(A_FormClosed);
            agregar.Show();
        }
        private void btnRestorePassword_Click(object sender, EventArgs e)
        {
            CambiarClave cambiarClave = new CambiarClave(new CEUsuario
            {
                userName = tblUsuarios.CurrentRow.Cells["USU_USUARIO"].Value.ToString()
            });
            cambiarClave.Tag = "RESTORE PASSWORD";
            cambiarClave.TopLevel = false;
            cambiarClave.Dock = DockStyle.None;
            Controls.Add(cambiarClave);
            cambiarClave.Location = new Point(50, 50);
            cambiarClave.BringToFront();
            cambiarClave.FormClosed += new FormClosedEventHandler(A_FormClosed);
            cambiarClave.Show();
        }
        private void tblUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Agregar agregar = new Agregar(new CEUsuario
                {
                    id = Convert.ToInt32(tblUsuarios.CurrentRow.Cells["ID"].Value.ToString()),
                    userName = tblUsuarios.CurrentRow.Cells["USU_USUARIO"].Value.ToString(),
                    password = tblUsuarios.CurrentRow.Cells["CLAVE"].Value.ToString(),
                    nombres = tblUsuarios.CurrentRow.Cells["NOMBRES"].Value.ToString(),
                    correo = tblUsuarios.CurrentRow.Cells["CORREO"].Value.ToString(),
                    documento = tblUsuarios.CurrentRow.Cells["DOCUMENTO"].Value.ToString()
                });
                agregar.Tag = "U";
                agregar.TopLevel = false;
                agregar.Dock = DockStyle.None;
                Controls.Add(agregar);
                agregar.Location = new Point(50, 50);
                agregar.BringToFront();
                agregar.FormClosed += new FormClosedEventHandler(A_FormClosed);
                agregar.Show();
            }
        }
        private void A_FormClosed(object sender, FormClosedEventArgs ex)
        {
            Buscar();
        }
    }
}
