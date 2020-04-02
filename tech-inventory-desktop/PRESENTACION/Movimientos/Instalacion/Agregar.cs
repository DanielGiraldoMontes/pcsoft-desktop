using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Movimientos.Instalacion
{
    public partial class Agregar : Form, IAgregarProveedorIns
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private CNEquipos equipos;
        private CNMovimientos movimientos;
        private CEOrden orden;

        public Agregar(CEOrden orden)
        {
            InitializeComponent();

            this.orden = orden;

            equipos = new CNEquipos();
            movimientos = new CNMovimientos();

            DateSelect.Text = DateTime.Now.ToString("yyyy-MM-dd");

            CargarInstalaciones();
        }
        private void CargarInstalaciones()
        {
            try
            {
                if (orden != null)
                {
                    btnShowFile.Visible = true;
                    tblInstalacion.Visible = false;
                    tblInstalacionDetalle.Visible = true;
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


                    tblInstalacionDetalle.AutoGenerateColumns = false;
                    tblInstalacionDetalle.DataSource = movimientos.CargarInstalacionDetalle(orden.id);
                }
                else
                {
                    DataGridViewComboBoxColumn Marcas = tblInstalacion.Columns[2] as DataGridViewComboBoxColumn;

                    // Cargar combo marcas
                    List<CEMarca> marcas = equipos.CargarMarcas();
                    marcas.Insert(0, new CEMarca
                    {
                        id = 0,
                        descripcion = "SELECCIONE UNA MARCA"
                    });

                    Marcas.ValueMember = "id";
                    Marcas.DisplayMember = "descripcion";
                    Marcas.DataSource = marcas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void AgregarProveedorInstalacion(CEProveedor proveedor)
        {
            txtNit.Text = proveedor.documento;
            txtRazonSocial.Text = proveedor.nombreCompleto;
        }
        private void Agregar_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
        private void tblInstalacion_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (tblInstalacion.Columns[e.ColumnIndex].Name == "MARCA")
                {
                    DataGridViewComboBoxCell Modelos = tblInstalacion.Rows[e.RowIndex].Cells[3] as DataGridViewComboBoxCell;

                    //Cargar modelos
                    List<CEModelo> modelos = equipos.CargarModelos(new CEMarca
                    {
                        id = Convert.ToInt32(tblInstalacion.Rows[e.RowIndex].Cells[2].Value)
                    });
                    modelos.Insert(0, new CEModelo
                    {
                        id = 0,
                        descripcion = "SELECCIONE UN MODELO"
                    });

                    Modelos.ValueMember = "id";
                    Modelos.DisplayMember = "descripcion";
                    Modelos.DataSource = modelos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Archivo PDF |*.pdf";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                txtFile.Text = openFileDialog.FileName;
        }
        private void txtNit_DoubleClick(object sender, EventArgs e)
        {
            Proveedor.Gestionar A = new Proveedor.Gestionar();
            A.BringToFront();
            A.ProveedorMovimientos = "INSTALAR";
            A.Show(this);
        }
        private void btnShowFile_Click(object sender, EventArgs e)
        {
            try
            {

                string path = AppDomain.CurrentDomain.BaseDirectory;
                string folder = path + "/temp/";
                string fullFileName = folder + txtNumero.Text + ".pdf";

                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                if (File.Exists(fullFileName))
                    File.Delete(fullFileName);

                File.WriteAllBytes(fullFileName, movimientos.CargarArchivoInstalacion(orden.id));
                Process.Start(fullFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Exception exception = null;

                if (tblInstalacion.Rows.Count < 2)
                {
                    exception = new Exception("No se registro ningun equipo.");
                    throw exception;
                }

                if (txtFile.Text.Trim().Equals(""))
                {
                    exception = new Exception("Debe disponser del archvio de soporte.");
                    throw exception;
                }
                foreach (DataGridViewRow row in tblInstalacion.Rows)
                {
                    if (Equals(row.Cells[0].Value, null))
                    {
                        exception = new Exception("Código invalido");
                        throw exception;
                    }

                    if (Equals(row.Cells[1].Value, null))
                    {
                        exception = new Exception("Descripción invalido");
                        throw exception;
                    }
                }

                byte[] File = null;
                Stream stream = openFileDialog.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    File = ms.ToArray();
                }

                CEOrden instalacion = new CEOrden
                {
                    fecha = DateSelect.Text.ToString(),
                    proveedorDocumento = txtNit.Text,
                    numero = txtNumero.Text,
                    observacion = txtObservaciones.Text,
                    anulado = false,
                    archivo = File,
                };


                if (movimientos.AgregarInstalacion(instalacion) > 0)
                {
                    instalacion.id = movimientos.MaximoIdInstalacion();

                    foreach (DataGridViewRow row in tblInstalacion.Rows)
                    {
                        instalacion.equipoCodigo = row.Cells[0].Value.ToString();
                        instalacion.equipoDescripcion = row.Cells[1].Value.ToString();
                        instalacion.observacion = Equals(row.Cells[5].Value, null) ? "" : row.Cells[5].Value.ToString();
                        instalacion.modelo = new CEModelo
                        {
                            id = Equals(row.Cells[3].Value, null) ? 0 : Convert.ToInt32(row.Cells[3].Value)
                        };
                        instalacion.equipoSerial = Equals(row.Cells[4].Value, null) ? "" : row.Cells[4].Value.ToString();

                        movimientos.AgregarInstalacionDetalle(instalacion);
                    }

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tblInstalacionDetalle_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((tblInstalacionDetalle.Rows[e.RowIndex].DataBoundItem != null) && (tblInstalacionDetalle.Columns[e.ColumnIndex].DataPropertyName.Contains(".")))
                e.Value = Config.BindProperty(tblInstalacionDetalle.Rows[e.RowIndex].DataBoundItem, tblInstalacionDetalle.Columns[e.ColumnIndex].DataPropertyName);
        }
    }
    interface IAgregarProveedorIns { void AgregarProveedorInstalacion(CEProveedor proveedor); }

}
