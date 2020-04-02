using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;
using PRESENTACION.Asignaciones.Actas.Devolucion;

namespace PRESENTACION.Asignaciones.Devolver
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
            origen = new BindingSource(asignaciones.CargarDevolucionTableFilter(), "INV.DEVOLUCIONES");
            origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
            tblDevolucionesFilter.DataSource = origen;

            lblTotalRows.Text = string.Format("Total devoluciones {0}", this.origen.List.Count);

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
                tblDevolucionesFilter.DataSource = origen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Agregar agregarDevolucion = new Agregar(null);
            Tag = "I"; //ESTABLECE EL TAG EN OPCION I PARA DEFINIR QUE SE ESTA AGREGANDO UN REGISTRO.
            agregarDevolucion.BringToFront();
            agregarDevolucion.FormClosed += new FormClosedEventHandler(A_FormClosed);
            agregarDevolucion.Show();
        }
        private void A_FormClosed(object sender, FormClosedEventArgs ex)
        {
            if (Tag.ToString() == "I")
            {
                origen = new BindingSource(asignaciones.CargarDevolucionTableFilter(), "INV.DEVOLUCIONES");
                origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
                origen.RemoveFilter();
                tblDevolucionesFilter.DataSource = origen;
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
                int rowIndex = tblDevolucionesFilter.SelectedRows[0].Index;
                CEAsignaciones asignacion = new CEAsignaciones
                {
                    id = Convert.ToInt32(tblDevolucionesFilter.Rows[rowIndex].Cells["NUMERO"].Value),
                    codigo = Convert.ToInt32(tblDevolucionesFilter.Rows[rowIndex].Cells["CODIGO"].Value),
                    documento = tblDevolucionesFilter.Rows[rowIndex].Cells["DOCUMENTO"].Value.ToString(),
                    nombreCompleto = tblDevolucionesFilter.Rows[rowIndex].Cells["NOMBRES"].Value.ToString(),
                    fecha = tblDevolucionesFilter.Rows[rowIndex].Cells["FECHA"].Value.ToString(),
                    asiTeclado = Convert.ToBoolean(tblDevolucionesFilter.Rows[rowIndex].Cells["TECLADO"].Value),
                    asiMouse = Convert.ToBoolean(tblDevolucionesFilter.Rows[rowIndex].Cells["MOUSE"].Value),
                    asiPuesto = Convert.ToBoolean(tblDevolucionesFilter.Rows[rowIndex].Cells["PUESTO"].Value),
                    asiBase = Convert.ToBoolean(tblDevolucionesFilter.Rows[rowIndex].Cells["BASE"].Value),
                    asiMaletin = Convert.ToBoolean(tblDevolucionesFilter.Rows[rowIndex].Cells["MALETIN"].Value),
                    asiMorral = Convert.ToBoolean(tblDevolucionesFilter.Rows[rowIndex].Cells["MORRAL"].Value),
                    asiCorreo = Convert.ToBoolean(tblDevolucionesFilter.Rows[rowIndex].Cells["CORREO"].Value),
                    anulado = Convert.ToBoolean(tblDevolucionesFilter.Rows[rowIndex].Cells["ANULADO"].Value),
                    observacion = tblDevolucionesFilter.Rows[rowIndex].Cells["OBSERVACIONES"].Value.ToString(),
                    fechaModifi = tblDevolucionesFilter.Rows[rowIndex].Cells["FECHAMODIFI"].Value.ToString(),
                    usuarioModifi = tblDevolucionesFilter.Rows[rowIndex].Cells["USUMODIFI"].Value.ToString(),
                    usuarioDocumento = tblDevolucionesFilter.Rows[rowIndex].Cells["USUDOCUMENTO"].Value.ToString(),
                    usuarioNombres = tblDevolucionesFilter.Rows[rowIndex].Cells["USUNOMBRES"].Value.ToString(),
                };

                Acta actaDevolucion = new Acta(asignacion);
                actaDevolucion.WindowState = FormWindowState.Maximized;
                actaDevolucion.Show();
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

                    asignaciones.AgregarDocumentoDevolucion(new CEAsignaciones
                    {
                        id = Convert.ToInt32(tblDevolucionesFilter.CurrentRow.Cells[0].Value),
                        archivo = File
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnShowFile_Click(object sender, EventArgs e)
        {
            try
            {
                int documentId = Convert.ToInt32(tblDevolucionesFilter.CurrentRow.Cells[0].Value);
                string folder = AppDomain.CurrentDomain.BaseDirectory + "/temp/";
                string fullFileName = folder + documentId.ToString() + ".pdf";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (File.Exists(fullFileName))
                    File.Delete(fullFileName);

                File.WriteAllBytes(fullFileName, asignaciones.CargarDocumentoDevolucion(documentId));
                Process.Start(fullFileName);
            }
            catch (Exception)
            {
                MessageBox.Show("Se presento algun error o no hay ningun documento disponible para este registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(tblDevolucionesFilter.CurrentRow.Cells["ANULADO"].Value.ToString()) != true)
                {
                    if (MessageBox.Show("¿Esta seguro de anular el movimiento?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (asignaciones.AnularDevolucion(Convert.ToInt32(tblDevolucionesFilter.CurrentRow.Cells[0].Value)) > 0)
                            tblDevolucionesFilter.CurrentRow.Cells["ANULADO"].Value = true;
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
        private void origen_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotalRows.Text = string.Format("Total devoluciones {0}", this.origen.List.Count);
        }
        private void tblDevolucionesFilter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    CEAsignaciones asignacion = new CEAsignaciones
                    {
                        id = Convert.ToInt32(tblDevolucionesFilter.Rows[e.RowIndex].Cells["NUMERO"].Value),
                        documento = tblDevolucionesFilter.Rows[e.RowIndex].Cells["DOCUMENTO"].Value.ToString(),
                        nombreCompleto = tblDevolucionesFilter.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString(),
                        fecha = tblDevolucionesFilter.Rows[e.RowIndex].Cells["FECHA"].Value.ToString(),
                        asiTeclado = Convert.ToBoolean(tblDevolucionesFilter.Rows[e.RowIndex].Cells["TECLADO"].Value),
                        asiMouse = Convert.ToBoolean(tblDevolucionesFilter.Rows[e.RowIndex].Cells["MOUSE"].Value),
                        asiPuesto = Convert.ToBoolean(tblDevolucionesFilter.Rows[e.RowIndex].Cells["PUESTO"].Value),
                        asiBase = Convert.ToBoolean(tblDevolucionesFilter.Rows[e.RowIndex].Cells["BASE"].Value),
                        asiMaletin = Convert.ToBoolean(tblDevolucionesFilter.Rows[e.RowIndex].Cells["MALETIN"].Value),
                        asiMorral = Convert.ToBoolean(tblDevolucionesFilter.Rows[e.RowIndex].Cells["MORRAL"].Value),
                        asiCorreo = Convert.ToBoolean(tblDevolucionesFilter.Rows[e.RowIndex].Cells["CORREO"].Value),
                        anulado = Convert.ToBoolean(tblDevolucionesFilter.Rows[e.RowIndex].Cells["ANULADO"].Value),
                        observacion = tblDevolucionesFilter.Rows[e.RowIndex].Cells["OBSERVACIONES"].Value.ToString(),
                        fechaModifi = tblDevolucionesFilter.Rows[e.RowIndex].Cells["FECHAMODIFI"].Value.ToString(),
                        usuarioModifi = tblDevolucionesFilter.Rows[e.RowIndex].Cells["USUMODIFI"].Value.ToString()
                    };

                    Agregar A = new Agregar(asignacion);
                    A.TopLevel = false;
                    A.Dock = DockStyle.None;
                    Controls.Add(A);
                    Tag = "C";  // ESTABLECE EL TAG EN MODO CONSULTA PARA NO VOLVER A CARGAR LA DATA A LA TABLA.
                    A.Location = new Point(50, 50);
                    A.BringToFront();
                    A.FormClosed += new FormClosedEventHandler(A_FormClosed);
                    A.Show();
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
