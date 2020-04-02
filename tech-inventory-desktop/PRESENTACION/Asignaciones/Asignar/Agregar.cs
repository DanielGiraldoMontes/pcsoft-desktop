using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Asignaciones.Asignar
{
    public partial class Agregar : Form, IEquipoAsignar, IPersonaAsignar
    {
        private CNAsignaciones asignaciones;
        private CEAsignaciones asignacion;
        private List<CEEquipo> equipos;
        private BindingSource source = new BindingSource();

        public Agregar(CEAsignaciones asignacion)
        {
            InitializeComponent();

            this.asignacion = asignacion;

            asignaciones = new CNAsignaciones();

            CargarAsignacion();
        }
        private void CargarAsignacion()
        {
            try
            {
                DateSelect.Text = DateTime.Now.ToString("yyyy-MM-dd");
                if (asignacion != null)
                {
                    TxtUsuarioModifi.Visible = true;
                    TxtFechaModifi.Visible = true;

                    tblAsignar.Visible = false;
                    tblAsignarDetalle.Visible = true;
                    DateSelect.Enabled = false;
                    txtDocumento.Enabled = false;
                    txtNombres.Enabled = false;
                    txtObservaciones.Enabled = false;
                    btnSave.Visible = false;

                    txtDocumento.Text = asignacion.documento;
                    txtNombres.Text = asignacion.nombreCompleto;
                    DateSelect.Text = asignacion.fecha;
                    txtObservaciones.Text = asignacion.observacion;


                    chkTeclado.Checked = asignacion.asiTeclado;
                    chkMouse.Checked = asignacion.asiMouse;
                    chkPuesto.Checked = asignacion.asiPuesto;
                    chkBase.Checked = asignacion.asiBase;
                    chkMaletin.Checked = asignacion.asiMaletin;
                    chkMorral.Checked = asignacion.asiMorral;
                    chkCorreo.Checked = asignacion.asiCorreo;
                    lblAnulada.Visible = asignacion.anulado;


                    TxtUsuarioModifi.Text = asignacion.usuarioModifi;
                    TxtFechaModifi.Text = asignacion.fechaModifi;


                    chkTeclado.Enabled = false;
                    chkMouse.Enabled = false;
                    chkPuesto.Enabled = false;
                    chkBase.Enabled = false;
                    chkMaletin.Enabled = false;
                    chkMorral.Enabled = false;
                    chkCorreo.Enabled = false;


                    tblAsignarDetalle.AutoGenerateColumns = false;
                    tblAsignarDetalle.DataSource = asignaciones.CargarAsignacionDetalle(asignacion.id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AgregarEquipoAsignar(CEEquipo equipo)
        {
            try
            {
                if (equipos == null)
                {
                    equipos = new List<CEEquipo>();
                    source.DataSource = equipos;
                }

                foreach (CEEquipo equi in equipos)
                    if (equi.equipoCodigo == equipo.equipoCodigo)
                    {
                        Exception exception = new Exception("No puede asignar el mismo equipo a la persona");
                        throw exception;
                    }
                equipos.Add(equipo);

                tblAsignar.AutoGenerateColumns = false;
                tblAsignar.DataSource = source;

                source.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AgregarPersonaAsignar(CEEmpleado empleado)
        {
            txtDocumento.Text = empleado.documento;
            txtNombres.Text = empleado.nombreCompleto;
        }
        private void txtDocumento_DoubleClick(object sender, EventArgs e)
        {
            Empleados.Gestionar GE = new Empleados.Gestionar();
            GE.BringToFront();
            GE.EmpAsignar = "ASIGNAR";
            GE.Show(this);
        }
        private void tblAsignar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (tblAsignar.Rows[e.RowIndex].Cells[0].Value != null || tblAsignar.Rows.Count == 1))
            {
                Equipos.Gestionar gestionarEquipo = new Equipos.Gestionar("ASIGNAR");
                gestionarEquipo.BringToFront();
                gestionarEquipo.StartPosition = FormStartPosition.CenterScreen;
                gestionarEquipo.Show(this);
            }
        }
        private void Agregar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool detalle = true;

                if (tblAsignar.Rows.Count < 2)
                {
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que no se devuelve ningun equipo?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                        detalle = false;
                    else
                        return;
                }

                CEAsignaciones asignar = new CEAsignaciones
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

                if (asignaciones.AgregarAsignacion(asignar) > 0)
                {
                    if (detalle)
                    {
                        int id = asignaciones.MaximoIdAsignacion();
                        foreach (CEEquipo equipo in equipos)
                        {
                            asignar.id = id;
                            asignar.equipoCodigo = equipo.equipoCodigo;
                            asignar.equipoDescripcion = equipo.equipoDescripcion;
                            asignar.observacion = equipo.observacion;
                            asignar.modelo = new CEModelo { id = equipo.modelo.id };

                            asignaciones.AgregarAsignacionDetalle(asignar);
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

        private void tblAsignarDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((tblAsignarDetalle.Rows[e.RowIndex].DataBoundItem != null) && (tblAsignarDetalle.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                e.Value = Config.BindProperty(tblAsignarDetalle.Rows[e.RowIndex].DataBoundItem, tblAsignarDetalle.Columns[e.ColumnIndex].DataPropertyName);
        }

        private void tblAsignar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((tblAsignar.Rows[e.RowIndex].DataBoundItem != null) && (tblAsignar.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                e.Value = Config.BindProperty(tblAsignar.Rows[e.RowIndex].DataBoundItem, tblAsignar.Columns[e.ColumnIndex].DataPropertyName);
        }
    }
    interface IEquipoAsignar { void AgregarEquipoAsignar(CEEquipo equipo); }
    interface IPersonaAsignar { void AgregarPersonaAsignar(CEEmpleado empleado); }
}
