using System;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Empleados.Ubicaciones
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
                CNPersonas personas = new CNPersonas();

                CEUbicacion ubicacion = new CEUbicacion
                {
                    descripcion = txtUbicacion.Text
                };

                if (personas.AgregarUbicacion(ubicacion) > 0)
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
