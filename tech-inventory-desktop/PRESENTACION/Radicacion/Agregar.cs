using ENTIDADES;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace PRESENTACION.Radicacion
{
    public partial class Agregar : Form
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private CNRadicaciones radicaciones;
        private CNPersonas personas;

        public Agregar()
        {
            InitializeComponent();

            radicaciones = new CNRadicaciones();
            personas = new CNPersonas();

            CargarComboProveedor();
        }
        private void btnFile_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK) { txtFile.Text = openFileDialog.FileName; }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFile.Text.Trim().Equals(""))
                    throw new Exception("No se encontro el archivo");

                byte[] File = null;
                Stream stream = openFileDialog.OpenFile();
                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    File = ms.ToArray();
                }

                CERadicacion radicacion = new CERadicacion
                {
                    Fecha = DateSelect.Text.ToString(),
                    NumProvisional = txtNumero.Text.ToString().ToUpper(),
                    ProvNit = cmbProveedor.SelectedValue.ToString(),
                    Monto = Convert.ToDouble(txtMonto.Text.ToString()),
                    Observacion = txtObservaciones.Text.ToString().ToUpper(),
                    Archivo = File,
                    NombreArchivo = openFileDialog.SafeFileName
                };

                if (radicaciones.RadicarFactura(radicacion) > 0)
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarComboProveedor()
        {
            DateSelect.Text = DateTime.Now.ToString("yyyy-MM-dd");

            // Cargar combo proveedores
            List<CEProveedor> proveedores = personas.CargarComboProveedores();
            proveedores.Insert(0, new CEProveedor
            {
                documento = null,
                nombreCorto = "SELECCIONE UN PROVEEDOR"
            });

            cmbProveedor.ValueMember = "documento";
            cmbProveedor.DisplayMember = "nombreCorto";
            cmbProveedor.DataSource = proveedores;
        }
    }
}
