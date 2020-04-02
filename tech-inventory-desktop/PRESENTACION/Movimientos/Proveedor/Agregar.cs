using System;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Movimientos.Proveedor
{
    public partial class Agregar : Form
    {
        private CEProveedor proveedor;

        public Agregar(CEProveedor proveedor)
        {
            InitializeComponent();
            this.proveedor = proveedor;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CNPersonas personas = new CNPersonas();

                CEProveedor proveedor = new CEProveedor
                {
                    documento = txtId.Text,
                    nombreCompleto = txtRazonSocial.Text.ToUpper(),
                    nombreCorto = txtNombreCorto.Text.ToUpper(),
                    correo = txtCorreo.Text.ToUpper(),
                    telefono = txtNumero.Text,
                    direccion = txtDireccion.Text.ToUpper()
                };

                if (Tag.ToString() == "I")
                {
                    if (personas.AgregarProveedor(proveedor) > 0)
                        Close();
                }
                else
                {
                    if (personas.ActualizarProveedor(proveedor) > 0)
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
            try
            {
                if (Tag.ToString() == "U")
                {
                    txtId.Enabled = false;
                    txtId.Text = proveedor.documento;
                    txtRazonSocial.Text = proveedor.nombreCompleto;
                    txtNombreCorto.Text = proveedor.nombreCorto;
                    txtNumero.Text = proveedor.telefono;
                    txtCorreo.Text = proveedor.correo;
                    txtDireccion.Text = proveedor.direccion;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
