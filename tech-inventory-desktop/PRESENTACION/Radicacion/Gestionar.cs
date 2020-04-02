using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NEGOCIO;

namespace PRESENTACION.Radicacion
{
    public partial class Gestionar : Form
    {
        private CNRadicaciones radicaciones;
        private SqlDataReader Reader;
        private SaveFileDialog fichero;
        private int FilaExcel;
        private BindingSource origen;

        public Gestionar()
        {
            InitializeComponent();

            radicaciones = new CNRadicaciones();

            Dock = DockStyle.Fill;

            //Se crea el origen de datos y se pasa a la tabla de los filtros.
            origen = new BindingSource(radicaciones.CargarRadicacionesTableFilter(), "INV.RADICACIONES");
            origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
            tblRadicacionesFilter.DataSource = origen;

            lblTotalRows.Text = String.Format("Total radicaciones {0}", this.origen.List.Count);
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
                            case "rbtnNames":
                                origen.Filter = string.Format("RAZON_SOCIAL LIKE '%{0}%'", busqueda);
                                break;
                            case "rbtnFactura":
                                origen.Filter = string.Format("FACTURA LIKE '%{0}%'", busqueda);
                                break;
                        }
                        break;
                }
                tblRadicacionesFilter.DataSource = origen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReporteExcel()
        {
            try
            {
                fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.RestoreDirectory = true;
                fichero.FileName = "Facturas.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    CNReportes reportes = new CNReportes();
                    FilaExcel = 1;

                    Microsoft.Office.Interop.Excel.Application Aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook Libro;
                    Microsoft.Office.Interop.Excel.Worksheet Hoja;
                    Aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    Libro = Aplicacion.Workbooks.Add();
                    Libro.Worksheets.Add();
                    Hoja = (Microsoft.Office.Interop.Excel.Worksheet)Libro.Worksheets.get_Item(1);
                    Hoja.Name = "Facturas";

                    Reader = reportes.RepFacturas();

                    Hoja.Cells[FilaExcel, 1] = "ID";
                    Hoja.Cells[FilaExcel, 2] = "FECHA";
                    Hoja.Cells[FilaExcel, 3] = "MONTO";
                    Hoja.Cells[FilaExcel, 4] = "NUMERO_DOC";
                    Hoja.Cells[FilaExcel, 5] = "OBSERVACION";
                    Hoja.Cells[FilaExcel, 6] = "ANULADO";
                    Hoja.Cells[FilaExcel, 7] = "USUARIO_MODIFI";
                    Hoja.Cells[FilaExcel, 8] = "FECHA_MODIFI";

                    FilaExcel++;

                    while (Reader.Read())
                    {
                        Hoja.Cells[FilaExcel, 3].NumberFormat = "#,##0.00 $";

                        Hoja.Cells[FilaExcel, 1] = Reader.GetInt32(0);
                        Hoja.Cells[FilaExcel, 2] = Reader.GetDateTime(1).ToString("yyyy-MM-dd");
                        Hoja.Cells[FilaExcel, 3] = Reader.GetDouble(2);
                        Hoja.Cells[FilaExcel, 4] = Reader.GetString(3);
                        Hoja.Cells[FilaExcel, 5] = Reader.GetString(4);
                        Hoja.Cells[FilaExcel, 6] = Reader.GetString(5);
                        Hoja.Cells[FilaExcel, 7] = Reader.GetString(6);
                        Hoja.Cells[FilaExcel, 8] = Reader.GetDateTime(7);

                        FilaExcel++;
                    }

                    Libro.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    Libro.Close(true);

                    AbrirDocumento(fichero.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "BUSCAR")
            {
                txtSearch.Text = "";
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "BUSCAR";
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Agregar agregarRadicacion = new Agregar();
            agregarRadicacion.TopLevel = false;
            Controls.Add(agregarRadicacion);
            agregarRadicacion.BringToFront();
            agregarRadicacion.FormClosed += new FormClosedEventHandler(A_FormClosed);
            agregarRadicacion.Show();
        }
        private void btnShowFile_Click(object sender, EventArgs e)
        {
            try
            {
                string path = AppDomain.CurrentDomain.BaseDirectory;
                string folder = path + "/temp/";
                string fullFileName;

                fullFileName = folder + tblRadicacionesFilter.CurrentRow.Cells[1].Value.ToString() + ".pdf";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (File.Exists(fullFileName))
                    File.Delete(fullFileName);

                File.WriteAllBytes(fullFileName, radicaciones.CargarArchivo(Convert.ToInt32(tblRadicacionesFilter.CurrentRow.Cells[0].Value)));
                Process.Start(fullFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToBoolean(tblRadicacionesFilter.CurrentRow.Cells[7].Value) == false)
                {

                    if (MessageBox.Show("¿Esta seguro que desea anular la radicación?", "Anular", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (radicaciones.AnularFactura(Convert.ToInt32(tblRadicacionesFilter.CurrentRow.Cells[0].Value)) > 0)
                            tblRadicacionesFilter.CurrentRow.Cells["ANULADO"].Value = true;
                    }
                }
                else
                {
                    if (MessageBox.Show("¿Esta seguro que desea borrar la radicación?", "Borrar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (radicaciones.BorrarFactura(Convert.ToInt32(tblRadicacionesFilter.CurrentRow.Cells[0].Value)) > 0)
                            tblRadicacionesFilter.Rows.Remove(tblRadicacionesFilter.CurrentRow);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            ReporteExcel();
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
            }
        }
        private void A_FormClosed(object sender, FormClosedEventArgs ex)
        {
            origen = new BindingSource(radicaciones.CargarRadicacionesTableFilter(), "INV.RADICACIONES");
            origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
            origen.RemoveFilter();
            tblRadicacionesFilter.DataSource = origen;
        }
        private void origen_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotalRows.Text = string.Format("Total radicaciones {0}", this.origen.List.Count);
        }
        static void AbrirDocumento(string File)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "EXCEL.EXE";
            startInfo.Arguments = File;
            Process.Start(startInfo);
        }
    }
}
