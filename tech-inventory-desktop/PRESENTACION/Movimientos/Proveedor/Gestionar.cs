using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;
using PRESENTACION.Movimientos.Devolucion;
using PRESENTACION.Movimientos.Instalacion;

namespace PRESENTACION.Movimientos.Proveedor
{
    public partial class Gestionar : Form
    {
        private CNPersonas personas;
        public string ProveedorRadicar, ProveedorMovimientos;
        private BindingSource origen;

        public Gestionar()
        {
            InitializeComponent();

            personas = new CNPersonas();

            this.Dock = DockStyle.Fill;

            // Se crea el origen de datos y se pasa a la tabla de los filtros.
            origen = new BindingSource(personas.CargarProveedores(), "INV.PROVEEDORES");
            origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
            tblProveedores.DataSource = origen;

            lblTotalRows.Text = string.Format("Total proveedores {0}", this.origen.List.Count);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Agregar agregarProveedor = new Agregar(null);
            agregarProveedor.Tag = "I";
            agregarProveedor.TopLevel = false;
            agregarProveedor.Dock = DockStyle.None;
            Controls.Add(agregarProveedor);
            agregarProveedor.Location = new Point(50, 50);
            agregarProveedor.BringToFront();
            agregarProveedor.FormClosed += new FormClosedEventHandler(A_FormClosed);
            agregarProveedor.Show();
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
                            case "rbtnId":
                                origen.Filter = string.Format("NIT LIKE '%{0}%'", busqueda);
                                break;
                            case "rbtnName":
                                origen.Filter = string.Format("RAZON_SOCIAL LIKE '%{0}%'", busqueda);
                                break;
                        }
                        break;
                }
                tblProveedores.DataSource = origen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void origen_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotalRows.Text = string.Format("Total proveedores {0}", this.origen.List.Count);
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta seguro que desea eliminar el proveedor?", "Eliminar", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (personas.BorrarProveedor(tblProveedores.CurrentRow.Cells["NIT"].Value.ToString()) > 0)
                        tblProveedores.Rows.Remove(tblProveedores.CurrentRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tblProveedores_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    CEProveedor proveedor = new CEProveedor
                    {
                        documento = tblProveedores.CurrentRow.Cells["NIT"].Value.ToString(),
                        nombreCompleto = tblProveedores.CurrentRow.Cells["RAZON_SOCIAL"].Value.ToString(),
                        nombreCorto = tblProveedores.CurrentRow.Cells["NOMBRE_CORTO"].Value.ToString(),
                        correo = tblProveedores.CurrentRow.Cells["CORREO"].Value.ToString(),
                        telefono = tblProveedores.CurrentRow.Cells["TELEFONO"].Value.ToString(),
                        direccion = tblProveedores.CurrentRow.Cells["DIRECCION"].Value.ToString()
                    };

                    if (ProveedorMovimientos != null)
                    {
                        switch (ProveedorMovimientos)
                        {
                            case "INSTALAR":
                                IAgregarProveedorIns parent = this.Owner as IAgregarProveedorIns;
                                parent.AgregarProveedorInstalacion(proveedor);
                                break;
                            case "RECOGER":
                                IAgregarProveedorRec parent2 = this.Owner as IAgregarProveedorRec;
                                parent2.AgregarProveedorRecogida(proveedor);
                                break;
                        }
                        this.Close();
                    }
                    else
                    {
                        Agregar agregarProveedor = new Agregar(proveedor);
                        agregarProveedor.Tag = "U";
                        agregarProveedor.TopLevel = false;
                        agregarProveedor.Dock = DockStyle.None;
                        Controls.Add(agregarProveedor);
                        agregarProveedor.Location = new Point(50, 50);
                        agregarProveedor.BringToFront();
                        agregarProveedor.FormClosed += new FormClosedEventHandler(A_FormClosed);
                        agregarProveedor.Show();
                    }
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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Buscar();
        }
        private void A_FormClosed(object sender, FormClosedEventArgs ex)
        {
            Buscar();
        }
    }
}
