using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Asignaciones.Prestar
{
    public partial class Agregar : Form, IEquipoPrestar, IPersonaPrestar
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
        }
        public void AgregarEquipoPrestar(CEEquipo equipo)
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
                        Exception exception = new Exception("No puede prestar el mismo equipo a la persona");
                        throw exception;
                    }
                equipos.Add(equipo);

                tblPrestar.AutoGenerateColumns = false;
                tblPrestar.DataSource = source;

                source.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AgregarPersonaPrestar(CEEmpleado empleado)
        {
            txtDocumento.Text = empleado.documento;
            txtNombres.Text = empleado.nombreCompleto;
        }
        private void txtDocumento_DoubleClick(object sender, EventArgs e)
        {
            Empleados.Gestionar GE = new Empleados.Gestionar();
            GE.BringToFront();
            GE.EmpAsignar = "PRESTAR";
            GE.Show(this);
        }
        private void tblPrestar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (tblPrestar.Rows[e.RowIndex].Cells[0].Value != null || tblPrestar.Rows.Count == 1))
            {
                Equipos.Gestionar GE = new Equipos.Gestionar("PRESTAR");
                GE.BringToFront();
                GE.StartPosition = FormStartPosition.CenterScreen;
                GE.Show(this);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool detalle = true;

                if (tblPrestar.Rows.Count < 2)
                {
                    DialogResult resultado = MessageBox.Show("¿Esta seguro que no se devuelve ningun equipo?", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (resultado == DialogResult.OK)
                        detalle = false;
                    else
                        return;
                }
                CEAsignaciones prestar = new CEAsignaciones
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

                if (asignaciones.AgregarPrestamo(prestar) > 0)
                {
                    if (detalle)
                    {
                        int id = asignaciones.MaximoIdPrestamo();
                        foreach (CEEquipo equipo in equipos)
                        {
                            prestar.id = id;
                            prestar.equipoCodigo = equipo.equipoCodigo;
                            prestar.equipoDescripcion = equipo.equipoDescripcion;
                            prestar.observacion = equipo.observacion;
                            prestar.modelo = new CEModelo { id = equipo.modelo.id };

                            asignaciones.AgregarPrestamoDetalle(prestar);
                        }
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Agregar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            try
            {
                DateSelect.Text = DateTime.Now.ToString("yyyy-MM-dd");

                if (asignacion != null)
                {
                    tblPrestar.Visible = false;
                    tblPrestarDetalle.Visible = true;

                    txtDocumento.Enabled = false;
                    txtNombres.Enabled = false;
                    chkBase.Enabled = false;
                    chkCorreo.Enabled = false;
                    chkMaletin.Enabled = false;
                    chkMorral.Enabled = false;
                    chkMouse.Enabled = false;
                    chkPuesto.Enabled = false;
                    chkTeclado.Enabled = false;
                    DateSelect.Enabled = false;
                    txtObservaciones.Enabled = false;
                    btnSave.Visible = false;
                    TxtUsuarioModifi.Visible = true;
                    TxtFechaModifi.Visible = true;


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
                    lblAnulada.Visible = asignacion.anulado;
                    txtObservaciones.Text = asignacion.observacion;
                    TxtUsuarioModifi.Text = asignacion.usuarioModifi;
                    TxtFechaModifi.Text = asignacion.fechaModifi;

                    tblPrestarDetalle.AutoGenerateColumns = false;
                    tblPrestarDetalle.DataSource = asignaciones.CargarPrestamoDetalle(asignacion.id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tblPrestarDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((tblPrestarDetalle.Rows[e.RowIndex].DataBoundItem != null) && (tblPrestarDetalle.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                e.Value = Config.BindProperty(tblPrestarDetalle.Rows[e.RowIndex].DataBoundItem, tblPrestarDetalle.Columns[e.ColumnIndex].DataPropertyName);
        }

        private void tblPrestar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((tblPrestar.Rows[e.RowIndex].DataBoundItem != null) && (tblPrestar.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                e.Value = Config.BindProperty(tblPrestar.Rows[e.RowIndex].DataBoundItem, tblPrestar.Columns[e.ColumnIndex].DataPropertyName);
        }
    }
    interface IEquipoPrestar { void AgregarEquipoPrestar(CEEquipo equipo); }
    interface IPersonaPrestar { void AgregarPersonaPrestar(CEEmpleado empleado); }
}
