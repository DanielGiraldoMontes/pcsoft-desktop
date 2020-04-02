using ENTIDADES;
using NEGOCIO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PRESENTACION.Equipos.Modelos
{
    public partial class Agregar : Form
    {
        private CNEquipos equipos;

        public Agregar()
        {
            InitializeComponent();

            equipos = new CNEquipos();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtModelo.Text.ToString().Trim().Length > 0)
                {
                    CEMarca marca = new CEMarca
                    {
                        id = Convert.ToInt32(cmbMarcas.SelectedValue)
                    };

                    CEModelo modelo = new CEModelo
                    {
                        descripcion = txtModelo.Text.ToString().ToUpper()
                    };

                    if (equipos.AgregarModelo(marca, modelo) > 0)
                        Close();
                }
                else
                {
                    throw new Exception("El modelo no puede estar vacio.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Agregar_Load(object sender, EventArgs e)
        {
            List<CEMarca> marcas = equipos.CargarMarcas();
            marcas.Insert(0, new CEMarca
            {
                id = 0,
                descripcion = "SELECCIONE UNA MARCA"
            });

            cmbMarcas.ValueMember = "id";
            cmbMarcas.DisplayMember = "descripcion";
            cmbMarcas.DataSource = marcas;
        }
    }
}
