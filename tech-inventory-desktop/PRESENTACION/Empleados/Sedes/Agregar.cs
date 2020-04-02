using System;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Empleados.Sedes
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

                CESede sede = new CESede
                {
                    descripcion = txtSede.Text
                };

                if (personas.AgregarSede(sede) > 0)
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
