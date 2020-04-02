using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;
using PRESENTACION.Asignaciones.Actas.Entrega;

namespace PRESENTACION.Asignaciones.Asignar
{
    public partial class Gestionar : Form
    {
        private CNAsignaciones asignaciones;
        private BindingSource origen;

        public Gestionar()
        {
            InitializeComponent();

            asignaciones = new CNAsignaciones();

            Dock = DockStyle.Fill;

            //Se crea el origen de datos y se pasa a la tabla de los filtros.
            origen = new BindingSource(asignaciones.CargarAsignacionTableFilter(), "INV.ASIGNACIONES");
            origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
            tblAsignacionesFilter.DataSource = origen;

            lblTotalRows.Text = string.Format("Total asignaciones {0}", this.origen.List.Count);
        }
        private void Buscar()
        {
            try
            {
                string busqueda = txtSearch.Text;
                switch (busqueda)
                {
                    case "":
                        origen.RemoveFilter();
                        break;
                    case "BUSCAR":
                        origen.RemoveFilter();
                        break;
                    default:
                        RadioButton rbtn = this.GroupOptButton.Controls.OfType<RadioButton>().Where(x => x.Checked).FirstOrDefault();
                        switch (rbtn.Name)
                        {
                            case "rbtnNumber":
                                origen.Filter = string.Format("NUMERO = '{0}'", busqueda);
                                break;
                            case "rbtnNames":
                                origen.Filter = string.Format("NOMBRES LIKE '%{0}%'", busqueda);
                                break;
                        }
                        break;
                }
                tblAsignacionesFilter.DataSource = origen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Agregar agregarAsignacion = new Agregar(null);
            Tag = "I";
            agregarAsignacion.BringToFront();
            agregarAsignacion.FormClosed += new FormClosedEventHandler(A_FormClosed);
            agregarAsignacion.Show();
        }
        private void A_FormClosed(object sender, FormClosedEventArgs ex)
        {
            if (Tag.ToString() == "I")
            {
                origen = new BindingSource(asignaciones.CargarAsignacionTableFilter(), "INV.ASIGNACIONES");
                origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
                origen.RemoveFilter();
                tblAsignacionesFilter.DataSource = origen;
            }
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "BUSCAR")
                txtSearch.Text = "";

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void btnActa_Click(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = tblAsignacionesFilter.SelectedRows[0].Index;
                CEAsignaciones asignacion = new CEAsignaciones
                {
                    id = Convert.ToInt32(tblAsignacionesFilter.Rows[rowIndex].Cells["NUMERO"].Value),
                    codigo = Convert.ToInt32(tblAsignacionesFilter.Rows[rowIndex].Cells["CODIGO"].Value),
                    documento = tblAsignacionesFilter.Rows[rowIndex].Cells["DOCUMENTO"].Value.ToString(),
                    nombreCompleto = tblAsignacionesFilter.Rows[rowIndex].Cells["NOMBRES"].Value.ToString(),
                    fecha = tblAsignacionesFilter.Rows[rowIndex].Cells["FECHA"].Value.ToString(),
                    asiTeclado = Convert.ToBoolean(tblAsignacionesFilter.Rows[rowIndex].Cells["TECLADO"].Value),
                    asiMouse = Convert.ToBoolean(tblAsignacionesFilter.Rows[rowIndex].Cells["MOUSE"].Value),
                    asiPuesto = Convert.ToBoolean(tblAsignacionesFilter.Rows[rowIndex].Cells["PUESTO"].Value),
                    asiBase = Convert.ToBoolean(tblAsignacionesFilter.Rows[rowIndex].Cells["BASE"].Value),
                    asiMaletin = Convert.ToBoolean(tblAsignacionesFilter.Rows[rowIndex].Cells["MALETIN"].Value),
                    asiMorral = Convert.ToBoolean(tblAsignacionesFilter.Rows[rowIndex].Cells["MORRAL"].Value),
                    asiCorreo = Convert.ToBoolean(tblAsignacionesFilter.Rows[rowIndex].Cells["CORREO"].Value),
                    anulado = Convert.ToBoolean(tblAsignacionesFilter.Rows[rowIndex].Cells["ANULADO"].Value),
                    observacion = tblAsignacionesFilter.Rows[rowIndex].Cells["OBSERVACIONES"].Value.ToString(),
                    fechaModifi = tblAsignacionesFilter.Rows[rowIndex].Cells["FECHAMODIFI"].Value.ToString(),
                    usuarioModifi = tblAsignacionesFilter.Rows[rowIndex].Cells["USUMODIFI"].Value.ToString(),
                    usuarioDocumento = tblAsignacionesFilter.Rows[rowIndex].Cells["USUDOCUMENTO"].Value.ToString(),
                    usuarioNombres = tblAsignacionesFilter.Rows[rowIndex].Cells["USUNOMBRES"].Value.ToString()
                };

                Acta actaAsignacion = new Acta(asignacion);
                actaAsignacion.WindowState = FormWindowState.Maximized;
                actaAsignacion.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(tblAsignacionesFilter.CurrentRow.Cells["ANULADO"].Value) == false)
                {
                    if (MessageBox.Show("¿Esta seguro de anular el movimiento?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (asignaciones.AnularAsignacion(Convert.ToInt32(tblAsignacionesFilter.CurrentRow.Cells[0].Value)) > 0)
                            tblAsignacionesFilter.CurrentRow.Cells["ANULADO"].Value = true;
                    }
                }
                else
                {
                    MessageBox.Show("El movimiento ya esta anulado", "Movimiento", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguinte error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Buscar();

        }
        private void btnShowFile_Click(object sender, EventArgs e)
        {
            try
            {
                int documentId = Convert.ToInt32(tblAsignacionesFilter.CurrentRow.Cells[0].Value);
                string folder = AppDomain.CurrentDomain.BaseDirectory + "/temp/";
                string fullFileName = folder + documentId.ToString() + ".pdf";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (File.Exists(fullFileName))
                    File.Delete(fullFileName);

                File.WriteAllBytes(fullFileName, asignaciones.CargarDocumentoAsignacion(documentId));
                Process.Start(fullFileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Se presento algun error o no hay ningun documento disponible para este registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivo PDF |*.pdf";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    byte[] File = null;
                    Stream stream = openFileDialog.OpenFile();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        stream.CopyTo(ms);
                        File = ms.ToArray();
                    }

                    asignaciones.AgregarDocumentoAsignacion(new CEAsignaciones
                    {
                        id = Convert.ToInt32(tblAsignacionesFilter.CurrentRow.Cells[0].Value),
                        archivo = File
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void origen_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotalRows.Text = string.Format("Total asignaciones {0}", this.origen.List.Count);
        }
        private void tblAsignacionesFilter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    CEAsignaciones asignacion = new CEAsignaciones
                    {
                        id = Convert.ToInt32(tblAsignacionesFilter.Rows[e.RowIndex].Cells["NUMERO"].Value),
                        documento = tblAsignacionesFilter.Rows[e.RowIndex].Cells["DOCUMENTO"].Value.ToString(),
                        nombreCompleto = tblAsignacionesFilter.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString(),
                        fecha = tblAsignacionesFilter.Rows[e.RowIndex].Cells["FECHA"].Value.ToString(),
                        asiTeclado = Convert.ToBoolean(tblAsignacionesFilter.Rows[e.RowIndex].Cells["TECLADO"].Value),
                        asiMouse = Convert.ToBoolean(tblAsignacionesFilter.Rows[e.RowIndex].Cells["MOUSE"].Value),
                        asiPuesto = Convert.ToBoolean(tblAsignacionesFilter.Rows[e.RowIndex].Cells["PUESTO"].Value),
                        asiBase = Convert.ToBoolean(tblAsignacionesFilter.Rows[e.RowIndex].Cells["BASE"].Value),
                        asiMaletin = Convert.ToBoolean(tblAsignacionesFilter.Rows[e.RowIndex].Cells["MALETIN"].Value),
                        asiMorral = Convert.ToBoolean(tblAsignacionesFilter.Rows[e.RowIndex].Cells["MORRAL"].Value),
                        asiCorreo = Convert.ToBoolean(tblAsignacionesFilter.Rows[e.RowIndex].Cells["CORREO"].Value),
                        anulado = Convert.ToBoolean(tblAsignacionesFilter.Rows[e.RowIndex].Cells["ANULADO"].Value),
                        observacion = tblAsignacionesFilter.Rows[e.RowIndex].Cells["OBSERVACIONES"].Value.ToString(),
                        fechaModifi = tblAsignacionesFilter.Rows[e.RowIndex].Cells["FECHAMODIFI"].Value.ToString(),
                        usuarioModifi = tblAsignacionesFilter.Rows[e.RowIndex].Cells["USUMODIFI"].Value.ToString()
                    };

                    Agregar agregarAsignacion = new Agregar(asignacion);
                    agregarAsignacion.TopLevel = false;
                    agregarAsignacion.Dock = DockStyle.None;
                    Controls.Add(agregarAsignacion);
                    Tag = "C";
                    agregarAsignacion.Location = new Point(50, 50);
                    agregarAsignacion.BringToFront();
                    agregarAsignacion.FormClosed += new FormClosedEventHandler(A_FormClosed);
                    agregarAsignacion.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                txtSearch.Text = "BUSCAR";
        }
    }
}
