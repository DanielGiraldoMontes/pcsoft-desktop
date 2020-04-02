using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Inicio
{
    public partial class Principal : Form
    {

        private int LX, LY;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        public Principal()
        {
            InitializeComponent();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Minimice_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Maximice_Click(object sender, EventArgs e)
        {
            LX = this.Location.X;
            LY = this.Location.Y;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Restore.Visible = true;
            this.Maximice.Visible = false;
        }
        private void Restore_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1800, 900);
            this.Location = new Point(LX, LY);
            this.Restore.Visible = false;
            this.Maximice.Visible = true;
        }
        private void Tittle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void imgMenu_Click(object sender, EventArgs e)
        {
            if (MenuLeft.Size.Width == 190)
            {
                MenuLeft.Width = 55;
                lblUsseName.Visible = false;
                ImageUsser.Visible = false;
            }
            else
            {
                MenuLeft.Width = 190;
                lblUsseName.Visible = true;
                ImageUsser.Visible = true;
            }
        }
        private void Equipos_Click(object sender, EventArgs e)
        {
            BtnOrdenInstalacion.Visible = false;
            BtnOrdenDevolucion.Visible = false;
            BtnProveedor.Visible = false;
            BtnAsignacion.Visible = false;
            BtnDevolucion.Visible = false;
            BtnPrestamo.Visible = false;
            BtnRepEmpleados.Visible = false;
            BtnRepEquipos.Visible = false;
            BtnUsuarios.Visible = false;
            BtnBackups.Visible = false;
            AbrirEquipos();
        }
        private void Empleados_Click(object sender, EventArgs e)
        {
            BtnOrdenInstalacion.Visible = false;
            BtnOrdenDevolucion.Visible = false;
            BtnProveedor.Visible = false;
            BtnAsignacion.Visible = false;
            BtnDevolucion.Visible = false;
            BtnPrestamo.Visible = false;
            BtnRepEmpleados.Visible = false;
            BtnRepEquipos.Visible = false;
            BtnUsuarios.Visible = false;
            BtnBackups.Visible = false;
            AbrirEmpleados();
        }
        private void Radicaciones_Click(object sender, EventArgs e)
        {
            BtnOrdenInstalacion.Visible = false;
            BtnOrdenDevolucion.Visible = false;
            BtnProveedor.Visible = false;
            BtnAsignacion.Visible = false;
            BtnDevolucion.Visible = false;
            BtnPrestamo.Visible = false;
            BtnRepEmpleados.Visible = false;
            BtnRepEquipos.Visible = false;
            BtnUsuarios.Visible = false;
            BtnBackups.Visible = false;
            AbrirRadicaciones();
        }
        private void Reportes_Click(object sender, EventArgs e)
        {
            BtnOrdenInstalacion.Visible = false;
            BtnOrdenDevolucion.Visible = false;
            BtnProveedor.Visible = false;
            BtnAsignacion.Visible = false;
            BtnDevolucion.Visible = false;
            BtnPrestamo.Visible = false;
            BtnUsuarios.Visible = false;
            BtnBackups.Visible = false;
            BtnRepEmpleados.Visible = true;
            BtnRepEquipos.Visible = true;
        }
        private void Movimientos_Click(object sender, EventArgs e)
        {
            BtnOrdenInstalacion.Visible = true;
            BtnOrdenDevolucion.Visible = true;
            BtnProveedor.Visible = true;
            BtnAsignacion.Visible = false;
            BtnDevolucion.Visible = false;
            BtnPrestamo.Visible = false;
            BtnRepEmpleados.Visible = false;
            BtnRepEquipos.Visible = false;
            BtnUsuarios.Visible = false;
            BtnBackups.Visible = false;
        }
        private void Asignaciones_Click(object sender, EventArgs e)
        {
            BtnRepEmpleados.Visible = false;
            BtnRepEquipos.Visible = false;
            BtnOrdenInstalacion.Visible = false;
            BtnOrdenDevolucion.Visible = false;
            BtnProveedor.Visible = false;
            BtnUsuarios.Visible = false;
            BtnBackups.Visible = false;
            BtnAsignacion.Visible = true;
            BtnDevolucion.Visible = true;
            BtnPrestamo.Visible = true;
        }
        private void Mantenimiento_Click(object sender, EventArgs e)
        {
            BtnRepEmpleados.Visible = false;
            BtnRepEquipos.Visible = false;
            BtnOrdenInstalacion.Visible = false;
            BtnOrdenDevolucion.Visible = false;
            BtnProveedor.Visible = false;
            BtnAsignacion.Visible = false;
            BtnDevolucion.Visible = false;
            BtnPrestamo.Visible = false;
            BtnUsuarios.Visible = true;
            BtnBackups.Visible = true;
        }
        private void AbrirEquipos()
        {
            Equipos.Gestionar GP = new Equipos.Gestionar(null);
            GP.TopLevel = false;
            GP.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Clear();
            this.Contenedor.Controls.Add(GP);
            this.Contenedor.Tag = GP;
            GP.BringToFront();
            GP.Show();
        }
        private void AbrirProveedores()
        {
            Movimientos.Proveedor.Gestionar GP = new Movimientos.Proveedor.Gestionar();
            GP.TopLevel = false;
            GP.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Clear();
            this.Contenedor.Controls.Add(GP);
            this.Contenedor.Tag = GP;
            GP.BringToFront();
            GP.Show();
        }
        private void AbrirEmpleados()
        {
            Empleados.Gestionar GE = new Empleados.Gestionar();
            GE.TopLevel = false;
            GE.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Clear();
            this.Contenedor.Controls.Add(GE);
            this.Contenedor.Tag = GE;
            GE.BringToFront();
            GE.Show();
        }
        private void AbrirAsignaciones()
        {
            Asignaciones.Asignar.Gestionar GE = new Asignaciones.Asignar.Gestionar();
            GE.TopLevel = false;
            GE.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Clear();
            this.Contenedor.Controls.Add(GE);
            this.Contenedor.Tag = GE;
            GE.BringToFront();
            GE.Show();
        }
        private void AbrirDevoluciones()
        {
            Asignaciones.Devolver.Gestionar GE = new Asignaciones.Devolver.Gestionar();
            GE.TopLevel = false;
            GE.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Clear();
            this.Contenedor.Controls.Add(GE);
            this.Contenedor.Tag = GE;
            GE.BringToFront();
            GE.Show();
        }
        private void AbrirPrestamos()
        {
            Asignaciones.Prestar.Gestionar GE = new Asignaciones.Prestar.Gestionar();
            GE.TopLevel = false;
            GE.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Clear();
            this.Contenedor.Controls.Add(GE);
            this.Contenedor.Tag = GE;
            GE.BringToFront();
            GE.Show();
        }
        private void AbrirOrdenInstalacion()
        {
            Movimientos.Instalacion.Gestionar GE = new Movimientos.Instalacion.Gestionar();
            GE.TopLevel = false;
            GE.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Clear();
            this.Contenedor.Controls.Add(GE);
            this.Contenedor.Tag = GE;
            GE.BringToFront();
            GE.Show();
        }
        private void AbrirOrdenDevolucion()
        {
            Movimientos.Devolucion.Gestionar GE = new Movimientos.Devolucion.Gestionar();
            GE.TopLevel = false;
            GE.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Clear();
            this.Contenedor.Controls.Add(GE);
            this.Contenedor.Tag = GE;
            GE.BringToFront();
            GE.Show();
        }
        private void AbrirRadicaciones()
        {
            Radicacion.Gestionar GR = new Radicacion.Gestionar();
            GR.TopLevel = false;
            this.Contenedor.Controls.Clear();
            this.Contenedor.Controls.Add(GR);
            this.Contenedor.Tag = GR;
            GR.BringToFront();
            GR.Show();
        }
        private void AbrirRepEquipos()
        {
            Reportes.Equipos EQ = new Reportes.Equipos();
            EQ.TopLevel = false;
            this.Contenedor.Controls.Clear();
            this.Contenedor.Controls.Add(EQ);
            this.Contenedor.Tag = EQ;
            EQ.BringToFront();
            EQ.Show();
        }
        private void AbrirRepEmpleados()
        {
            Reportes.Empleados EM = new Reportes.Empleados();
            EM.TopLevel = false;
            this.Contenedor.Controls.Clear();
            this.Contenedor.Controls.Add(EM);
            this.Contenedor.Tag = EM;
            EM.BringToFront();
            EM.Show();
        }
        private void AbrirUsuarios()
        {
            Usuarios.Gestionar U = new Usuarios.Gestionar();
            U.TopLevel = false;
            this.Contenedor.Controls.Clear();
            this.Contenedor.Controls.Add(U);
            this.Contenedor.Tag = U;
            U.BringToFront();
            U.Show();
        }
        private void BtnPrestamo_Click(object sender, EventArgs e)
        {
            AbrirPrestamos();
        }
        private void BtnProveedor_Click(object sender, EventArgs e)
        {
            AbrirProveedores();
        }
        private void BtnOrdenDevolucion_Click(object sender, EventArgs e)
        {
            AbrirOrdenDevolucion();
        }
        private void BtnDevolucion_Click(object sender, EventArgs e)
        {
            AbrirDevoluciones();
        }
        private void BtnOrdenInstalacion_Click(object sender, EventArgs e)
        {
            AbrirOrdenInstalacion();
        }
        private void BtnRepEmpleados_Click(object sender, EventArgs e)
        {
            AbrirRepEmpleados();
        }
        private void BtnRepEquipos_Click(object sender, EventArgs e)
        {
            AbrirRepEquipos();
        }
        private void BtnAsignacion_Click(object sender, EventArgs e)
        {
            AbrirAsignaciones();
        }
        private void BtnBackups_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fichero = new SaveFileDialog();
                fichero.Filter = "BackUp file (*.bak)|*.bak";
                fichero.RestoreDirectory = true;
                fichero.FileName = "BackUp.bak";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    CNReportes reportes = new CNReportes();
                    reportes.CreaBackUp(new CEReporte { RutaBackUp = fichero.FileName });

                    MessageBox.Show("Se creo el backup con exito.", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirUsuarios();
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            lblUsseName.Text = Program.usuario;

            BtnOrdenInstalacion.Visible = false;
            BtnOrdenDevolucion.Visible = false;
            BtnProveedor.Visible = false;
            BtnAsignacion.Visible = false;
            BtnDevolucion.Visible = false;
            BtnPrestamo.Visible = false;
            BtnUsuarios.Visible = false;
            BtnBackups.Visible = false;
        }
    }
}
