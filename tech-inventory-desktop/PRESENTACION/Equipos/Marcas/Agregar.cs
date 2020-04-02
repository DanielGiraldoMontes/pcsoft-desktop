using ENTIDADES;
using NEGOCIO;
using System;
using System.Windows.Forms;

namespace PRESENTACION.Equipos.Marcas
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMarca.Text.ToString().Trim().Length > 0)
                {
                    CNEquipos equipos = new CNEquipos();
                    CEMarca marca = new CEMarca
                    {
                        descripcion = txtMarca.Text.ToString().ToUpper()
                    };
                    if (equipos.AgregarMarca(marca) > 0)
                        Close();
                }
                else
                {
                    throw new Exception("La marca no puede estar vacia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
