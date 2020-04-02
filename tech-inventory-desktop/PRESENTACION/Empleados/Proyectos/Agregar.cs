using System;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Empleados.Proyectos
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

                CEProyecto proyecto = new CEProyecto
                {
                    descripcion = txtProyecto.Text
                };

                if (personas.AgregarProyecto(proyecto) > 0)
                    Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
