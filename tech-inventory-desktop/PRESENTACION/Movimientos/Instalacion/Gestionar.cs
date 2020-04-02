using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Movimientos.Instalacion
{
    public partial class Gestionar : Form
    {
        private CNMovimientos movimientos;
        private BindingSource origen;

        public Gestionar()
        {
            InitializeComponent();

            movimientos = new CNMovimientos();

            Dock = DockStyle.Fill;

            origen = new BindingSource(movimientos.CargarInstalaciones(), "INV.INSTALACIONES");
            origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
            tblInstalacionesFilter.AutoGenerateColumns = false;
            tblInstalacionesFilter.DataSource = origen;

            lblTotalRows.Text = string.Format("Total instalaciones {0}", this.origen.List.Count);
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
                                origen.Filter = string.Format("RAZON_SOCIAL LIKE '%{0}%'", busqueda);
                                break;
                        }
                        break;
                }
                tblInstalacionesFilter.DataSource = origen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void A_FormClosed(object sender, FormClosedEventArgs ex)
        {
            if (Tag.ToString() == "I")
            {
                origen = new BindingSource(movimientos.CargarInstalaciones(), "INV.INSTALACIONES");
                origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
                origen.RemoveFilter();
                tblInstalacionesFilter.DataSource = origen;
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                txtSearch.Text = "BUSCAR";
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "BUSCAR")
                txtSearch.Text = "";
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Agregar agregarInstalacion = new Agregar(null);
            Tag = "I";
            agregarInstalacion.BringToFront();
            agregarInstalacion.FormClosed += new FormClosedEventHandler(A_FormClosed);
            agregarInstalacion.Show();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                Buscar();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Convert.ToBoolean(tblInstalacionesFilter.CurrentRow.Cells[5].Value.ToString()))
                {
                    if (MessageBox.Show("¿Esta seguro de anular el movimiento?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (movimientos.AnularInstalacion(Convert.ToInt32(tblInstalacionesFilter.CurrentRow.Cells[0].Value)) > 0)
                            tblInstalacionesFilter.CurrentRow.Cells["ANULADO"].Value = true;
                    }
                }
                else
                {
                    throw new Exception("El movimiento ya esta anulado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguinte error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void origen_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotalRows.Text = string.Format("Total instalaciones {0}", this.origen.List.Count);
        }
        private void tblInstalacionesFilter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioAgregar(e, tblInstalacionesFilter);
        }
        private void btnShowFile_Click(object sender, EventArgs e)
        {
            try
            {
                int documentId = Convert.ToInt32(tblInstalacionesFilter.CurrentRow.Cells[1].Value);
                string folder = AppDomain.CurrentDomain.BaseDirectory + "/temp/";
                string fullFileName = folder + documentId.ToString() + ".pdf";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (File.Exists(fullFileName))
                    File.Delete(fullFileName);

                File.WriteAllBytes(fullFileName, movimientos.CargarArchivoInstalacion(documentId));
                Process.Start(fullFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AbrirFormularioAgregar(DataGridViewCellEventArgs row, DataGridView view)
        {
            try
            {
                if (row.RowIndex >= 0)
                {
                    CEOrden orden = new CEOrden
                    {
                        id = Convert.ToInt32(view.Rows[row.RowIndex].Cells[0].Value),
                        numero = view.Rows[row.RowIndex].Cells[1].Value.ToString(),
                        proveedorDocumento = view.Rows[row.RowIndex].Cells[2].Value.ToString(),
                        proveedorNombreCorto = view.Rows[row.RowIndex].Cells[3].Value.ToString(),
                        fecha = view.Rows[row.RowIndex].Cells[4].Value.ToString(),
                        anulado = Convert.ToBoolean(view.Rows[row.RowIndex].Cells[5].Value),
                        observacion = view.Rows[row.RowIndex].Cells[6].Value.ToString()
                    };

                    Agregar agregarInstalacion = new Agregar(orden);
                    Tag = "C";
                    agregarInstalacion.TopLevel = false;
                    agregarInstalacion.Dock = DockStyle.None;
                    Controls.Add(agregarInstalacion);
                    agregarInstalacion.Location = new Point(50, 50);
                    agregarInstalacion.BringToFront();
                    agregarInstalacion.FormClosed += new FormClosedEventHandler(A_FormClosed);
                    agregarInstalacion.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
