using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Movimientos.Devolucion
{
    public partial class Agregar : Form, IAgregarProveedorRec, IAgregarEqRec
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private CNMovimientos movimientos;
        private CEOrden orden;
        private List<CEEquipo> equipos;
        private BindingSource source = new BindingSource();

        public Agregar(CEOrden orden)
        {
            InitializeComponent();

            this.orden = orden;

            movimientos = new CNMovimientos();

            DateSelect.Text = DateTime.Now.ToString("yyyy-MM-dd");
            CargarRecogidas();
        }
        private void CargarRecogidas()
        {
            try
            {
                if (orden != null)
                {
                    btnShowFile.Visible = true;
                    tblRecogida.Visible = false;
                    tblRecogidaDetalle.Visible = true;
                    btnSave.Visible = false;
                    btnFile.Visible = false;
                    txtFile.Visible = false;
                    lblFile.Visible = false;
                    txtNumero.Enabled = false;
                    DateSelect.Enabled = false;
                    txtRazonSocial.Enabled = false;
                    txtObservaciones.Enabled = false;
                    txtNit.Enabled = false;


                    txtNumero.Text = orden.numero;
                    txtNit.Text = orden.proveedorDocumento;
                    txtRazonSocial.Text = orden.proveedorNombreCorto;
                    DateSelect.Text = orden.fecha;
                    lblAnulada.Visible = orden.anulado;
                    txtObservaciones.Text = orden.observacion;


                    tblRecogidaDetalle.AutoGenerateColumns = false;
                    tblRecogidaDetalle.DataSource = movimientos.CargarRecogidaDetalle(orden.id);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AgregarProveedorRecogida(CEProveedor proveedor)
        {
            txtNit.Text = proveedor.documento;
            txtRazonSocial.Text = proveedor.nombreCompleto;
        }
        public void AgregarEquipoRecogida(CEEquipo equipo)
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

                tblRecogida.AutoGenerateColumns = false;
                tblRecogida.DataSource = source;

                source.ResetBindings(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Archivo PDF |*.pdf";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK) { txtFile.Text = openFileDialog.FileName; }
        }
        private void txtNit_DoubleClick(object sender, EventArgs e)
        {
            Proveedor.Gestionar A = new Proveedor.Gestionar();
            A.BringToFront();
            A.ProveedorMovimientos = "RECOGER";
            A.Show(this);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFile.Text.Trim().Equals("") || tblRecogida.Rows.Count < 2)
                {
                    Exception exception = new Exception("No se encontro el archivo o no hay ningun equipo registrado");
                    throw exception;
                }


                byte[] File = null;
                Stream stream = openFileDialog.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    File = ms.ToArray();
                }

                CEOrden orden = new CEOrden
                {
                    fecha = DateSelect.Text,
                    proveedorDocumento = txtNit.Text,
                    numero = txtNumero.Text,
                    observacion = txtObservaciones.Text,
                    anulado = false,
                    archivo = File
                };


                if (movimientos.AgregarRecogida(orden) > 0)
                {
                    int id = movimientos.MaximoIdRecogida();
                    foreach (CEEquipo equipo in equipos)
                    {
                        orden = new CEOrden
                        {
                            id = id,
                            equipoCodigo = equipo.equipoCodigo,
                            equipoDescripcion = equipo.equipoDescripcion,
                            observacion = equipo.observacion,
                            modelo = new CEModelo { id = equipo.modelo.id },
                            fecha = DateSelect.Text
                        };

                        movimientos.AgregarRecogidaDetalle(orden);
                    }
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tblRecogida_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Equipos.Gestionar GE = new Equipos.Gestionar("RECOGER");
            GE.BringToFront();
            GE.StartPosition = FormStartPosition.CenterScreen;
            GE.Show(this);
        }
        private void btnShowFile_Click(object sender, EventArgs e)
        {
            try
            {
                string folder = AppDomain.CurrentDomain.BaseDirectory + "/temp/";
                string fullFileName = folder + orden.id + ".pdf";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (File.Exists(fullFileName))
                    File.Delete(fullFileName);

                File.WriteAllBytes(fullFileName, movimientos.CargarArchivoRecogida(orden.id));
                Process.Start(fullFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Agregar_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
        }

        private void tblRecogidaDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((tblRecogidaDetalle.Rows[e.RowIndex].DataBoundItem != null) && (tblRecogidaDetalle.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                e.Value = Config.BindProperty(tblRecogidaDetalle.Rows[e.RowIndex].DataBoundItem, tblRecogidaDetalle.Columns[e.ColumnIndex].DataPropertyName);
        }

        private void tblRecogida_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((tblRecogida.Rows[e.RowIndex].DataBoundItem != null) && (tblRecogida.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                e.Value = Config.BindProperty(tblRecogida.Rows[e.RowIndex].DataBoundItem, tblRecogida.Columns[e.ColumnIndex].DataPropertyName);
        }
    }
    interface IAgregarProveedorRec { void AgregarProveedorRecogida(CEProveedor proveedor); }
    interface IAgregarEqRec { void AgregarEquipoRecogida(CEEquipo equipo); }
}
