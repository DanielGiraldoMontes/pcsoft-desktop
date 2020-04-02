using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Equipos
{
    public partial class Agregar : Form
    {
        private CNEquipos equipos;
        private CNPersonas personas;
        private CEEquipo equipo;

        public Agregar(CEEquipo equipo)
        {
            InitializeComponent();

            equipos = new CNEquipos();
            personas = new CNPersonas();
            this.equipo = equipo;
        }
        private void ImgAddMarca_Click(object sender, EventArgs e)
        {
            Marcas.Agregar agregarMarca = new Marcas.Agregar();
            agregarMarca.TopLevel = false;
            agregarMarca.Dock = DockStyle.None;
            Controls.Add(agregarMarca);
            Tag = agregarMarca;
            agregarMarca.Location = new Point(50, 50);
            agregarMarca.BringToFront();
            agregarMarca.FormClosed += new FormClosedEventHandler(AM_FormClosed);
            agregarMarca.Show();
        }
        private void ImgAddModelo_Click(object sender, EventArgs e)
        {
            Modelos.Agregar agregarModelo = new Modelos.Agregar();
            agregarModelo.TopLevel = false;
            agregarModelo.Dock = DockStyle.None;
            Controls.Add(agregarModelo);
            Tag = agregarModelo;
            agregarModelo.Location = new Point(50, 50);
            agregarModelo.BringToFront();
            agregarModelo.FormClosed += new FormClosedEventHandler(AM_FormClosed);
            agregarModelo.Show();
        }
        private void Agregar_Load(object sender, EventArgs e)
        {
            CargarComboMarcas();
            CargarComboProyectos();
            CargarComboSedes();
            CargarComboUbicaciones();
            CargarComboProveedores();
            try
            {
                DateSelect.Text = DateTime.Now.ToString("yyyy-MM-dd");
                //En la variable actualizar, capture el código desde el otro formulario.
                if (equipo != null)
                {
                    chkInactivo.Visible = true;
                    txtCodigo.Enabled = false;
                    TxtFechaModifi.Visible = true;
                    TxtUsuarioModifi.Visible = true;

                    CEEmpleado empleado = personas.CargarEmpleadosPorCodigoEquipo(equipo.equipoCodigo);
                    if (empleado.documento != "9999999999")
                    {
                        List<CEEmpleado> empleados = new List<CEEmpleado>();
                        empleados.Add(empleado);

                        tblEmployes.Visible = true;
                        tblEmployes.AutoGenerateColumns = false;
                        tblEmployes.DataSource = empleados;
                    }

                    txtCodigo.Text = equipo.equipoCodigo;
                    txtDescripcion.Text = equipo.equipoDescripcion;
                    cmbMarca.SelectedValue = equipo.marca.id;
                    cmbModelo.SelectedValue = equipo.marca.id;
                    txtSerial.Text = equipo.equipoSerial;
                    cmbProveedor.SelectedValue = equipo.proveedorDocumento;
                    cmbProyecto.SelectedValue = equipo.proyecto.id;
                    cmbSede.SelectedValue = equipo.sede.id;
                    cmbUbicacion.SelectedValue = equipo.ubicacion.id;
                    txtPuesto.Text = equipo.numeroPuesto;
                    DateSelect.Text = equipo.fechaIngreso;
                    txtObservacion.Text = equipo.observacion;
                    TxtFechaModifi.Text = equipo.fechaModifi;
                    TxtUsuarioModifi.Text = equipo.usuarioModifi;


                    if (equipo.equipoEstado == "INACTIVO")
                        chkInactivo.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Cargar combo modelos               
                List<CEModelo> modelos = equipos.CargarModelos(new CEMarca
                {
                    id = Convert.ToInt32(cmbMarca.SelectedValue)
                });
                modelos.Insert(0, new CEModelo
                {
                    id = 0,
                    descripcion = "SELECCIONE UN MODELO"
                });

                cmbModelo.ValueMember = "id";
                cmbModelo.DisplayMember = "descripcion";
                cmbModelo.DataSource = modelos;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void CargarComboMarcas()
        {
            try
            {
                List<CEMarca> marcas = equipos.CargarMarcas();

                marcas.Insert(0, new CEMarca
                {
                    id = 0,
                    descripcion = "SELECCIONE UNA MARCA"
                });

                cmbMarca.ValueMember = "id";
                cmbMarca.DisplayMember = "descripcion";
                cmbMarca.DataSource = marcas;
            }
            catch (Exception e)
            {
                MessageBox.Show("Se presento el siguiente error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarComboProveedores()
        {
            // Cargar combo proveedores
            List<CEProveedor> proveedores = personas.CargarComboProveedores();
            proveedores.Insert(0, new CEProveedor
            {
                documento = null,
                nombreCorto = "SELECCIONE UN PROVEEDOR"
            });

            cmbProveedor.ValueMember = "documento";
            cmbProveedor.DisplayMember = "nombreCorto";
            cmbProveedor.DataSource = proveedores;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CEEquipo equipoAgregar = new CEEquipo
                {
                    equipoCodigo = txtCodigo.Text.ToString().Trim().ToUpper(),
                    equipoDescripcion = txtDescripcion.Text.ToString().Trim().ToUpper(),
                    proveedorDocumento = cmbProveedor.SelectedValue.ToString(),

                    modelo = new CEModelo
                    {
                        id = Convert.ToInt32(cmbModelo.SelectedValue)
                    },

                    observacion = txtObservacion.Text.ToString().ToUpper(),
                    equipoSerial = txtSerial.Text.ToUpper(),
                    equipoEstado = chkInactivo.Checked ? "I" : "D",

                    proyecto = new CEProyecto
                    {
                        id = Convert.ToInt32(cmbProyecto.SelectedValue)
                    },

                    sede = new CESede
                    {
                        id = Convert.ToInt32(cmbSede.SelectedValue)
                    },

                    ubicacion = new CEUbicacion
                    {
                        id = Convert.ToInt32(cmbUbicacion.SelectedValue)
                    },

                    numeroPuesto = txtPuesto.Text,
                    documento = "9999999999",
                    fechaIngreso = DateSelect.Text.ToString(),
                    fechaSalida = "",
                };

                if (equipo == null)
                {
                    if (equipos.AgregarEquipo(equipoAgregar) > 0)
                        Close();
                }
                else
                {
                    if (equipos.ActualizarEquipo(equipoAgregar) > 0)
                        Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ImgAddProyecto_Click(object sender, EventArgs e)
        {
            Empleados.Proyectos.Agregar agregarProyecto = new Empleados.Proyectos.Agregar();
            agregarProyecto.TopLevel = false;
            agregarProyecto.Dock = DockStyle.None;
            Controls.Add(agregarProyecto);
            Tag = agregarProyecto;
            agregarProyecto.Location = new Point(50, 50);
            agregarProyecto.BringToFront();
            agregarProyecto.FormClosed += new FormClosedEventHandler(AP_FormClosed);
            agregarProyecto.Show();
        }
        private void ImgAddSede_Click(object sender, EventArgs e)
        {
            Empleados.Sedes.Agregar agregarSede = new Empleados.Sedes.Agregar();
            agregarSede.TopLevel = false;
            agregarSede.Dock = DockStyle.None;
            Controls.Add(agregarSede);
            Tag = agregarSede;
            agregarSede.Location = new Point(50, 50);
            agregarSede.BringToFront();
            agregarSede.FormClosed += new FormClosedEventHandler(AS_FormClosed);
            agregarSede.Show();
        }
        private void ImgAddUbicacion_Click(object sender, EventArgs e)
        {
            Empleados.Ubicaciones.Agregar agregarUbicacion = new Empleados.Ubicaciones.Agregar();
            agregarUbicacion.TopLevel = false;
            agregarUbicacion.Dock = DockStyle.None;
            Controls.Add(agregarUbicacion);
            Tag = agregarUbicacion;
            agregarUbicacion.Location = new Point(50, 50);
            agregarUbicacion.BringToFront();
            agregarUbicacion.FormClosed += new FormClosedEventHandler(AU_FormClosed);
            agregarUbicacion.Show();
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
        private void AM_FormClosed(Object sender, FormClosedEventArgs e)
        {
            CargarComboMarcas();
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
        private void TblEmployes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((tblEmployes.Rows[e.RowIndex].DataBoundItem != null) && (tblEmployes.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                e.Value = Config.BindProperty(tblEmployes.Rows[e.RowIndex].DataBoundItem, tblEmployes.Columns[e.ColumnIndex].DataPropertyName);
        }
    }
}
