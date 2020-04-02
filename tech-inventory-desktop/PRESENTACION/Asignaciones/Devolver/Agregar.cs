using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Asignaciones.Devolver
{
    public partial class Agregar : Form, IPersonaDevolver
    {
        private CNAsignaciones asignaciones;
        private CEAsignaciones asignacion;
        private List<CEEquipo> equipos;

        public Agregar(CEAsignaciones asignacion)
        {
            InitializeComponent();

            this.asignacion = asignacion;

            asignaciones = new CNAsignaciones();

            CargarDevoluciones();
        }
        private void CargarDevoluciones()
        {
            try
            {
                DateSelect.Text = DateTime.Now.ToString("yyyy-MM-dd");

                if (asignacion != null)
                {
                    TxtUsuarioModifi.Visible = true;
                    TxtFechaModifi.Visible = true;
                    tblDevolver.Visible = false;
                    tblDevolverDetalle.Visible = true;
                    txtDocumento.Enabled = false;
                    btnSave.Visible = false;
                    lblEnunciado.Visible = false;


                    txtDocumento.Text = asignacion.documento;
                    txtNombres.Text = asignacion.nombreCompleto;
                    DateSelect.Text = asignacion.fecha;

                    chkTeclado.Checked = asignacion.asiTeclado;
                    chkMouse.Checked = asignacion.asiMouse;
                    chkPuesto.Checked = asignacion.asiPuesto;
                    chkBase.Checked = asignacion.asiBase;
                    chkMaletin.Checked = asignacion.asiMaletin;
                    chkMorral.Checked = asignacion.asiMorral;
                    chkCorreo.Checked = asignacion.asiCorreo;

                    TxtUsuarioModifi.Text = asignacion.usuarioModifi;
                    TxtFechaModifi.Text = asignacion.fechaModifi;

                    txtObservaciones.Text = asignacion.observacion;
                    lblAnulada.Visible = asignacion.anulado;

                    tblDevolverDetalle.AutoGenerateColumns = false;
                    tblDevolverDetalle.DataSource = asignaciones.CargarDevolucionDetalle(asignacion.id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AgregarPersonaDevolver(CEEmpleado empleado)
        {
            try
            {
                txtDocumento.Text = empleado.documento;
                txtNombres.Text = empleado.nombreCompleto;
                DateSelect.Enabled = true;


                chkTeclado.Checked = empleado.asiTeclado;
                chkTeclado.Enabled = empleado.asiTeclado;

                chkMouse.Checked = empleado.asiMouse;
                chkMouse.Enabled = empleado.asiMouse;

                chkPuesto.Checked = empleado.asiPuesto;
                chkPuesto.Enabled = empleado.asiPuesto;

                chkBase.Checked = empleado.asiBase;
                chkBase.Enabled = empleado.asiBase;

                chkMaletin.Checked = empleado.asiMaletin;
                chkMaletin.Enabled = empleado.asiMaletin;

                chkMorral.Checked = empleado.asiMorral;
                chkMorral.Enabled = empleado.asiMorral;

                chkCorreo.Checked = empleado.asiCorreo;
                chkCorreo.Enabled = empleado.asiCorreo;


                BindingSource source = new BindingSource();
                equipos = asignaciones.CargarEmpleadoDevolverDetalle(empleado.documento);
                source.DataSource = equipos;
                tblDevolver.AutoGenerateColumns = false;
                tblDevolver.DataSource = source;


                DateSelect.Enabled = true;
                btnSave.Enabled = true;
                txtObservaciones.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Agregar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void txtDocumento_DoubleClick(object sender, EventArgs e)
        {
            Empleados.Gestionar GE = new Empleados.Gestionar();
            GE.BringToFront();
            GE.EmpAsignar = "DEVOLVER";
            GE.Show(this);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool detalle = true;

                if (tblDevolver.Rows.Count < 2)
                {
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que no se devuelve ningun equipo?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                        detalle = false;
                    else
                        return;
                }

                CEAsignaciones devolucion = new CEAsignaciones
                {
                    documento = txtDocumento.Text,
                    nombreCompleto = txtNombres.Text,
                    fecha = DateSelect.Text.ToString(),
                    asiTeclado = chkTeclado.Checked,
                    asiMouse = chkMouse.Checked,
                    asiBase = chkBase.Checked,
                    asiMaletin = chkMaletin.Checked,
                    asiMorral = chkMorral.Checked,
                    asiPuesto = chkPuesto.Checked,
                    asiCorreo = chkCorreo.Checked,
                    anulado = false,
                    observacion = txtObservaciones.Text.ToString()
                };


                if (asignaciones.AgregarDevolucion(devolucion) > 0)
                {
                    if (detalle)
                    {
                        int id = asignaciones.MaximoIdDevolucion();
                        foreach (CEEquipo equipo in equipos)
                        {
                            devolucion.id = id;
                            devolucion.equipoCodigo = equipo.equipoCodigo;
                            devolucion.equipoDescripcion = equipo.equipoDescripcion;
                            devolucion.observacion = equipo.observacion;
                            devolucion.modelo = new CEModelo { id = equipo.modelo.id };

                            asignaciones.AgregarDevolucionDetalle(devolucion);
                        }

                        Close();
                    }
                    else
                    {
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tblDevolver_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((tblDevolver.Rows[e.RowIndex].DataBoundItem != null) && (tblDevolver.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                e.Value = Config.BindProperty(tblDevolver.Rows[e.RowIndex].DataBoundItem, tblDevolver.Columns[e.ColumnIndex].DataPropertyName);
        }

        private void tblDevolverDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((tblDevolverDetalle.Rows[e.RowIndex].DataBoundItem != null) && (tblDevolverDetalle.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                e.Value = Config.BindProperty(tblDevolverDetalle.Rows[e.RowIndex].DataBoundItem, tblDevolverDetalle.Columns[e.ColumnIndex].DataPropertyName);
        }
    }
    interface IPersonaDevolver { void AgregarPersonaDevolver(CEEmpleado empleado); }
}
