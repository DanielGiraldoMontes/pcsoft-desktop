using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;
using PRESENTACION.Asignaciones.Actas.Prestamo;

namespace PRESENTACION.Asignaciones.Prestar
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
            origen = new BindingSource(asignaciones.CargarPrestamoTableFilter(), "INV.PRESTAMOS");
            origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
            tblPrestamosFilter.DataSource = origen;

            lblTotalRows.Text = string.Format("Total prestamos {0}", this.origen.List.Count);

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
                tblPrestamosFilter.DataSource = origen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Agregar agregarPrestamo = new Agregar(null);
            Tag = "I";
            agregarPrestamo.BringToFront();
            agregarPrestamo.FormClosed += new FormClosedEventHandler(A_FormClosed);
            agregarPrestamo.Show();
        }
        private void A_FormClosed(object sender, FormClosedEventArgs ex)
        {
            if (Tag.ToString() == "i")
            {
                origen = new BindingSource(asignaciones.CargarPrestamoTableFilter(), "INV.PRESTAMOS");
                origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
                origen.RemoveFilter();
                tblPrestamosFilter.DataSource = origen;
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
                int rowIndex = tblPrestamosFilter.SelectedRows[0].Index;
                CEAsignaciones asignacion = new CEAsignaciones
                {
                    id = Convert.ToInt32(tblPrestamosFilter.Rows[rowIndex].Cells["NUMERO"].Value),
                    codigo = Convert.ToInt32(tblPrestamosFilter.Rows[rowIndex].Cells["CODIGO"].Value),
                    documento = tblPrestamosFilter.Rows[rowIndex].Cells["DOCUMENTO"].Value.ToString(),
                    nombreCompleto = tblPrestamosFilter.Rows[rowIndex].Cells["NOMBRES"].Value.ToString(),
                    fecha = tblPrestamosFilter.Rows[rowIndex].Cells["FECHA"].Value.ToString(),
                    asiTeclado = Convert.ToBoolean(tblPrestamosFilter.Rows[rowIndex].Cells["TECLADO"].Value),
                    asiMouse = Convert.ToBoolean(tblPrestamosFilter.Rows[rowIndex].Cells["MOUSE"].Value),
                    asiPuesto = Convert.ToBoolean(tblPrestamosFilter.Rows[rowIndex].Cells["PUESTO"].Value),
                    asiBase = Convert.ToBoolean(tblPrestamosFilter.Rows[rowIndex].Cells["BASE"].Value),
                    asiMaletin = Convert.ToBoolean(tblPrestamosFilter.Rows[rowIndex].Cells["MALETIN"].Value),
                    asiMorral = Convert.ToBoolean(tblPrestamosFilter.Rows[rowIndex].Cells["MORRAL"].Value),
                    asiCorreo = Convert.ToBoolean(tblPrestamosFilter.Rows[rowIndex].Cells["CORREO"].Value),
                    anulado = Convert.ToBoolean(tblPrestamosFilter.Rows[rowIndex].Cells["ANULADO"].Value),
                    observacion = tblPrestamosFilter.Rows[rowIndex].Cells["OBSERVACIONES"].Value.ToString(),
                    fechaModifi = tblPrestamosFilter.Rows[rowIndex].Cells["FECHAMODIFI"].Value.ToString(),
                    usuarioModifi = tblPrestamosFilter.Rows[rowIndex].Cells["USUMODIFI"].Value.ToString(),
                    usuarioDocumento = tblPrestamosFilter.Rows[rowIndex].Cells["USUDOCUMENTO"].Value.ToString(),
                    usuarioNombres = tblPrestamosFilter.Rows[rowIndex].Cells["USUNOMBRES"].Value.ToString()
                };

                Acta actaPrestamo = new Acta(asignacion);
                actaPrestamo.WindowState = FormWindowState.Maximized;
                actaPrestamo.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int documentId = Convert.ToInt32(tblPrestamosFilter.CurrentRow.Cells[0].Value);
                string folder = AppDomain.CurrentDomain.BaseDirectory + "/temp/";
                string fullFileName = folder + documentId.ToString() + ".pdf";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (File.Exists(fullFileName))
                    File.Delete(fullFileName);

                File.WriteAllBytes(fullFileName, asignaciones.CargarDocumentoPrestamo(documentId));
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

                    asignaciones.AgregarDocumentoPrestamo(new CEAsignaciones
                    {
                        id = Convert.ToInt32(tblPrestamosFilter.CurrentRow.Cells[0].Value),
                        archivo = File
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(tblPrestamosFilter.CurrentRow.Cells["ANULADO"].Value.ToString()) != true)
                {
                    if (MessageBox.Show("¿Esta seguro de anular el movimiento?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (asignaciones.AnularPrestamo(Convert.ToInt32(tblPrestamosFilter.CurrentRow.Cells[0].Value)) > 0)
                            tblPrestamosFilter.CurrentRow.Cells["ANULADO"].Value = true;
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
        private void tblPrestamosFilter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    CEAsignaciones asignacion = new CEAsignaciones
                    {
                        id = Convert.ToInt32(tblPrestamosFilter.Rows[e.RowIndex].Cells["NUMERO"].Value),
                        documento = tblPrestamosFilter.Rows[e.RowIndex].Cells["DOCUMENTO"].Value.ToString(),
                        nombreCompleto = tblPrestamosFilter.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString(),
                        fecha = tblPrestamosFilter.Rows[e.RowIndex].Cells["FECHA"].Value.ToString(),
                        asiTeclado = Convert.ToBoolean(tblPrestamosFilter.Rows[e.RowIndex].Cells["TECLADO"].Value),
                        asiMouse = Convert.ToBoolean(tblPrestamosFilter.Rows[e.RowIndex].Cells["MOUSE"].Value),
                        asiPuesto = Convert.ToBoolean(tblPrestamosFilter.Rows[e.RowIndex].Cells["PUESTO"].Value),
                        asiBase = Convert.ToBoolean(tblPrestamosFilter.Rows[e.RowIndex].Cells["BASE"].Value),
                        asiMaletin = Convert.ToBoolean(tblPrestamosFilter.Rows[e.RowIndex].Cells["MALETIN"].Value),
                        asiMorral = Convert.ToBoolean(tblPrestamosFilter.Rows[e.RowIndex].Cells["MORRAL"].Value),
                        asiCorreo = Convert.ToBoolean(tblPrestamosFilter.Rows[e.RowIndex].Cells["CORREO"].Value),
                        anulado = Convert.ToBoolean(tblPrestamosFilter.Rows[e.RowIndex].Cells["ANULADO"].Value),
                        observacion = tblPrestamosFilter.Rows[e.RowIndex].Cells["OBSERVACIONES"].Value.ToString(),
                        fechaModifi = tblPrestamosFilter.Rows[e.RowIndex].Cells["FECHAMODIFI"].Value.ToString(),
                        usuarioModifi = tblPrestamosFilter.Rows[e.RowIndex].Cells["USUMODIFI"].Value.ToString()
                    };

                    Agregar agregarPrestamo = new Agregar(asignacion);
                    agregarPrestamo.TopLevel = false;
                    agregarPrestamo.Dock = DockStyle.None;
                    Controls.Add(agregarPrestamo);
                    Tag = "C";
                    agregarPrestamo.Location = new Point(50, 50);
                    agregarPrestamo.BringToFront();
                    agregarPrestamo.FormClosed += new FormClosedEventHandler(A_FormClosed);
                    agregarPrestamo.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void origen_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotalRows.Text = string.Format("Total prestamos {0}", origen.List.Count);
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                txtSearch.Text = "BUSCAR";
        }
    }
}
