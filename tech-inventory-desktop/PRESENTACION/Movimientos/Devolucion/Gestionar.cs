using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Movimientos.Devolucion
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

            origen = new BindingSource(movimientos.CargarRecogidaTableFilter(), "INV.RECOGIDAS");
            origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
            tblRecogidasFilter.DataSource = origen;

            lblTotalRows.Text = string.Format("Total recogidas {0}", this.origen.List.Count);

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
                                origen.Filter = String.Format("NUMERO = '{0}'", busqueda);
                                break;
                            case "rbtnNames":
                                origen.Filter = String.Format("RAZON_SOCIAL LIKE '%{0}%'", busqueda);
                                break;
                        }
                        break;
                }
                tblRecogidasFilter.DataSource = origen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Agregar agregarRecogida = new Agregar(null);
            Tag = "I";
            agregarRecogida.BringToFront();
            agregarRecogida.FormClosed += new FormClosedEventHandler(A_FormClosed);
            agregarRecogida.Show();
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "BUSCAR")
                txtSearch.Text = "";
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                txtSearch.Text = "BUSCAR";
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void btnShowFile_Click(object sender, EventArgs e)
        {
            try
            {
                int documentId = Convert.ToInt32(tblRecogidasFilter.CurrentRow.Cells[1].Value);
                string folder = AppDomain.CurrentDomain.BaseDirectory + "/temp/";
                string fullFileName = folder + documentId.ToString() + ".pdf";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (File.Exists(fullFileName))
                    File.Delete(fullFileName);

                File.WriteAllBytes(fullFileName, movimientos.CargarArchivoRecogida(documentId));
                Process.Start(fullFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (Convert.ToBoolean(tblRecogidasFilter.CurrentRow.Cells[5].Value.ToString()) != true)
                {
                    if (MessageBox.Show("¿Esta seguro de anular el movimiento?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (movimientos.AnularRecogida(Convert.ToInt32(tblRecogidasFilter.CurrentRow.Cells[0].Value)) > 0)
                            tblRecogidasFilter.CurrentRow.Cells["ANULADO"].Value = true;
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
            lblTotalRows.Text = string.Format("Total recogidas {0}", this.origen.List.Count);
        }
        private void tblRecogidasFilter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormularioAgregar(e, tblRecogidasFilter);
        }
        private void A_FormClosed(object sender, FormClosedEventArgs ex)
        {
            if (Tag.ToString() == "I")
            {
                origen = new BindingSource(movimientos.CargarRecogidaTableFilter(), "INV.RECOGIDAS");
                origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
                origen.RemoveFilter();
                tblRecogidasFilter.DataSource = origen;
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

                    Agregar agregarRecogida = new Agregar(orden);
                    Tag = "C";
                    agregarRecogida.TopLevel = false;
                    agregarRecogida.Dock = DockStyle.None;
                    Controls.Add(agregarRecogida);
                    agregarRecogida.Location = new Point(50, 50);
                    agregarRecogida.BringToFront();
                    agregarRecogida.FormClosed += new FormClosedEventHandler(A_FormClosed);
                    agregarRecogida.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
