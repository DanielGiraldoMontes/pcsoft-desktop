using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Empleados
{
    public partial class Agregar : Form
    {
        private CNPersonas personas;
        private CNEquipos equipos;
        private CEEmpleado empleado;

        public Agregar(CEEmpleado empleado)
        {
            this.empleado = empleado;

            personas = new CNPersonas();
            equipos = new CNEquipos();

            InitializeComponent();

            Inicio();
        }
        private void Inicio()
        {
            try
            {
                CargarComboProyectos();
                CargarComboSedes();
                CargarComboUbicaciones();
                txtCodigo.Text = personas.MaximoCodigoInventario().ToString();
                txtCodigo.Enabled = false;
                DateFechaIngreso.Text = DateTime.Now.ToString("yyyy-MM-dd");
                if (empleado != null)
                {

                    tblEquipos.Visible = true;
                    tblEquipos.AutoGenerateColumns = false;
                    tblEquipos.DataSource = equipos.CargarEquiposPorEmpleado(empleado.documento);


                    chkTeclado.Visible = true;
                    chkMouse.Visible = true;
                    chkPuesto.Visible = true;
                    chkBase.Visible = true;
                    chkMaletin.Visible = true;
                    chkMorral.Visible = true;
                    chkCorreo.Visible = true;
                    txtDocumento.Enabled = false;
                    TxtFechaModifi.Visible = true;
                    TxtUsuarioModifi.Visible = true;

                    chkTeclado.Checked = empleado.asiTeclado;
                    chkMouse.Checked = empleado.asiMouse;
                    chkPuesto.Checked = empleado.asiPuesto;
                    chkBase.Checked = empleado.asiBase;
                    chkMaletin.Checked = empleado.asiMaletin;
                    chkMorral.Checked = empleado.asiMorral;
                    chkCorreo.Checked = empleado.asiCorreo;


                    txtDocumento.Text = empleado.documento;
                    txtCodigo.Text = empleado.codigo.ToString();
                    txtApellido1.Text = empleado.apellido1;
                    txtApellido2.Text = empleado.apellido2;
                    txtNombre1.Text = empleado.nombre1;
                    txtNombre2.Text = empleado.nombre2;
                    cmbProyecto.SelectedValue = empleado.proyecto.id;
                    cmbSede.SelectedValue = empleado.sede.id;
                    cmbUbicacion.SelectedValue = empleado.ubicacion.id;
                    txtPuesto.Text = empleado.numeroPuesto;
                    txtCorreo.Text = empleado.correo;
                    txtTelefono.Text = empleado.telefono;
                    DateFechaIngreso.Text = empleado.fechaIngreso;
                    DateFechaSalida.Text = empleado.fechaSalida;
                    txtObservacion.Text = empleado.observacion;
                    TxtFechaModifi.Text = empleado.fechaModifi;
                    TxtUsuarioModifi.Text = empleado.usuarioModifi;


                    if (empleado.fechaSalida != "")
                    {
                        DateFechaSalida.Visible = true;
                        lblSalida.Visible = true;
                    }
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
                CEEmpleado empleado = new CEEmpleado
                {
                    documento = txtDocumento.Text,
                    nombre1 = txtNombre1.Text.ToUpper(),
                    nombre2 = txtNombre2.Text.ToUpper(),
                    apellido1 = txtApellido1.Text.ToUpper(),
                    apellido2 = txtApellido2.Text.ToUpper(),
                    correo = txtCorreo.Text.ToUpper(),
                    telefono = txtTelefono.Text,
                    codigo = Convert.ToInt32(txtCodigo.Text),
                    proyecto = new CEProyecto { id = Convert.ToInt16(cmbProyecto.SelectedValue.ToString()) },
                    sede = new CESede { id = Convert.ToInt16(cmbSede.SelectedValue.ToString()) },
                    ubicacion = new CEUbicacion { id = Convert.ToInt16(cmbUbicacion.SelectedValue.ToString()) },
                    numeroPuesto = txtPuesto.Text,
                    observacion = txtObservacion.Text.ToUpper(),
                    fechaIngreso = DateFechaIngreso.Text,
                    asiTeclado = false,
                    asiMouse = false,
                    asiBase = false,
                    asiPuesto = false,
                    asiMorral = false,
                    asiMaletin = false,
                    asiCorreo = false,
                    fechaSalida = DateFechaSalida.Text
                };

                if (empleado == null)
                    if (personas.AgregarEmpleado(empleado) > 0)
                        Close();

                if (empleado != null)
                    if (personas.ActualizarEmpleado(empleado) > 0)
                        Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarComboProyectos()
        {
            // Cargar combo proyectos
            List<CEProyecto> proyectos = personas.CargarProyectos();

            proyectos.Insert(0, new CEProyecto
            {
                id = 0,
                descripcion = "SELECCIONE UN PROYECTO"
            });

            cmbProyecto.ValueMember = "id";
            cmbProyecto.DisplayMember = "descripcion";
            cmbProyecto.DataSource = proyectos;
        }
        private void CargarComboSedes()
        {
            // Cargar combo sedes
            List<CESede> sedes = personas.CargarSedes();

            sedes.Insert(0, new CESede
            {
                id = 0,
                descripcion = "SELECCIONE UNA SEDE"
            });

            cmbSede.ValueMember = "id";
            cmbSede.DisplayMember = "descripcion";
            cmbSede.DataSource = sedes;
        }
        private void CargarComboUbicaciones()
        {
            try
            {
                // Cargar combo ubicaciones
                List<CEUbicacion> ubicaciones = personas.CargarUbicaciones();

                ubicaciones.Insert(0, new CEUbicacion
                {
                    id = 0,
                    descripcion = "SELECCIONE UNA UBICACION"
                });

                cmbUbicacion.ValueMember = "id";
                cmbUbicacion.DisplayMember = "descripcion";
                cmbUbicacion.DataSource = ubicaciones;

            }
            catch (Exception e)
            {
                MessageBox.Show("Se presento el siguiente error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ImgAddProyecto_Click(object sender, EventArgs e)
        {
            Proyectos.Agregar A = new Proyectos.Agregar();
            A.TopLevel = false;
            A.Dock = DockStyle.None;
            Controls.Add(A);
            Tag = A;
            A.Location = new Point(50, 50);
            A.BringToFront();
            A.FormClosed += new FormClosedEventHandler(AP_FormClosed);
            A.Show();
        }
        private void ImgAddSede_Click(object sender, EventArgs e)
        {
            Sedes.Agregar A = new Sedes.Agregar();
            A.TopLevel = false;
            A.Dock = DockStyle.None;
            Controls.Add(A);
            Tag = A;
            A.Location = new Point(50, 50);
            A.BringToFront();
            A.FormClosed += new FormClosedEventHandler(AS_FormClosed);
            A.Show();
        }
        private void ImgAddUbicacion_Click(object sender, EventArgs e)
        {
            Ubicaciones.Agregar A = new Ubicaciones.Agregar();
            A.TopLevel = false;
            A.Dock = DockStyle.None;
            Controls.Add(A);
            Tag = A;
            A.Location = new Point(50, 50);
            A.BringToFront();
            A.FormClosed += new FormClosedEventHandler(AU_FormClosed);
            A.Show();
        }
        private void AP_FormClosed(Object sender, FormClosedEventArgs e)
        {
            CargarComboProyectos();
        }
        private void AS_FormClosed(Object sender, FormClosedEventArgs e)
        {
            CargarComboSedes();
        }
        private void AU_FormClosed(Object sender, FormClosedEventArgs e)
        {
            CargarComboUbicaciones();
        }
    }
}
