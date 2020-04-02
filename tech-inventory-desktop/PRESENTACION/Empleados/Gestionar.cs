using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;
using PRESENTACION.Asignaciones.Asignar;
using PRESENTACION.Asignaciones.Devolver;
using PRESENTACION.Asignaciones.Prestar;

namespace PRESENTACION.Empleados
{
    public partial class Gestionar : Form
    {
        public string EmpAsignar;
        private CNPersonas personas;
        private CNReportes reportes;
        private BindingSource origen;

        public Gestionar()
        {
            InitializeComponent();

            personas = new CNPersonas();
            reportes = new CNReportes();

            Dock = DockStyle.Fill;

            // Se crea el origen de datos y se pasa a la tabla de los filtros.
            origen = new BindingSource(personas.CargarEmpleadosTableFilter(), "INV.EMPLEADOS");
            origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
            tblEmployesFilter.DataSource = origen;

            lblTotalRows.Text = string.Format("Total empleados {0}", this.origen.List.Count);
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Agregar AE = new Agregar(null);
            AE.TopLevel = false;
            AE.Dock = DockStyle.None;
            Controls.Add(AE);
            Tag = AE;
            AE.Location = new Point(50, 50);
            AE.BringToFront();
            AE.FormClosed += new FormClosedEventHandler(AE_FormClosed);
            AE.Show();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Buscar();
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
                                origen.Filter = string.Format("DOCUMENTO LIKE '%{0}%'", busqueda);
                                break;
                            case "rbtnName":
                                origen.Filter = string.Format("NOMBRES LIKE '%{0}%'", busqueda);
                                break;
                            case "rbtnProyecto":
                                origen.Filter = string.Format("PROYECTO LIKE '%{0}%'", busqueda);
                                break;
                            case "rbtnSede":
                                origen.Filter = string.Format("SEDE LIKE '%{0}%'", busqueda);
                                break;
                            case "rbtnIngreso":
                                origen.Filter = string.Format("INGRESO LIKE '%{0}%'", busqueda);
                                break;
                            case "rbtnSalida":
                                origen.Filter = string.Format("SALIDA LIKE '%{0}%'", busqueda);
                                break;
                        }
                        break;
                }
                tblEmployesFilter.DataSource = origen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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
        private void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult = MessageBox.Show("Pulse SI para realizar la importación, NO para poner en el excel los datos auxiliares o cancelar para salir.", "Importar", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                switch (DialogResult)
                {
                    case DialogResult.Yes:
                        Importar();
                        break;
                    case DialogResult.No:
                        MostrarDatos();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en tiempo de ejecución" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Importar()
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Libros de Excel |*.xls;*.xlsx";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string conexion = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + dialog.FileName + ";Extended Properties=\"Excel 8.0; HDR=Yes\"";

                    OleDbConnection origenDB = default(OleDbConnection);
                    origenDB = new OleDbConnection(conexion);

                    OleDbCommand seleccion = default(OleDbCommand);
                    seleccion = new OleDbCommand("SELECT * FROM [IMPORTAR_EMPLEADOS$]", origenDB);

                    OleDbDataAdapter adaptador = new OleDbDataAdapter();
                    adaptador.SelectCommand = seleccion;

                    DataSet ds = new DataSet();

                    adaptador.Fill(ds);

                    origenDB.Close();

                    reportes.ImportarEmpleados(new CEReporte { Data = ds });

                    ///Al importar vuelve y refresca todos los registros de las tablas.
                    origen = new BindingSource(personas.CargarEmpleadosTableFilter(), "INV.EMPLEADOS");
                    origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
                    origen.RemoveFilter();
                    tblEmployesFilter.DataSource = origen;

                    MessageBox.Show("Se cargaron los datos correctamente", "Insersión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en tiempo de ejecución" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MostrarDatos()
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Libros de Excel |*.xls;*.xlsx";
                dialog.FilterIndex = 1;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string conexion = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + dialog.FileName + ";Extended Properties=\"Excel 8.0; HDR=Yes\"";

                    OleDbConnection origenDB = default;
                    origenDB = new OleDbConnection(conexion);
                    origenDB.Open();

                    List<CEProyecto> proyectos = personas.CargarProyectos();
                    foreach (CEProyecto proyecto in proyectos)
                    {
                        OleDbCommand Query = default;
                        Query = new OleDbCommand("INSERT INTO [PROYECTOS$] (PROYECTO_ID, PROYECTO_DESC) VALUES(@ID, @DESC)", origenDB);
                        Query.Parameters.AddWithValue("ID", proyecto.id);
                        Query.Parameters.AddWithValue("DESC", proyecto.descripcion);
                        Query.ExecuteNonQuery();
                    }

                    List<CESede> sedes = personas.CargarSedes();
                    foreach (CESede sede in sedes)
                    {
                        OleDbCommand Query = default;
                        Query = new OleDbCommand("INSERT INTO [SEDES$] (SEDE_ID, SEDE_DESC) VALUES(@ID, @DESC)", origenDB);
                        Query.Parameters.AddWithValue("ID", sede.id);
                        Query.Parameters.AddWithValue("DESC", sede.descripcion);
                        Query.ExecuteNonQuery();
                    }

                    List<CEUbicacion> ubicaciones = personas.CargarUbicaciones();
                    foreach (CEUbicacion ubicacion in ubicaciones)
                    {
                        OleDbCommand Query = default;
                        Query = new OleDbCommand("INSERT INTO [UBICACIONES$] (UBICACION_ID, UBICACION_DESC) VALUES(@ID, @DESC)", origenDB);
                        Query.Parameters.AddWithValue("ID", ubicacion.id);
                        Query.Parameters.AddWithValue("DESC", ubicacion.descripcion);
                        Query.ExecuteNonQuery();
                    }

                    MessageBox.Show("Los datos auxiliares ya se encuentran en su hoja de excel para que aliste su plantilla de importacion", " ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
            }
        }
        private void origen_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotalRows.Text = string.Format("Total empleados {0}", this.origen.List.Count);
        }
        private void tblEmployesFilter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    CEEmpleado empleado = new CEEmpleado
                    {
                        documento = tblEmployesFilter.CurrentRow.Cells["DOCUMENTO"].Value.ToString(),
                        codigo = Convert.ToInt32(tblEmployesFilter.CurrentRow.Cells["CODIGO"].Value),
                        nombre1 = tblEmployesFilter.CurrentRow.Cells["NOMBRE1"].Value.ToString(),
                        nombre2 = tblEmployesFilter.CurrentRow.Cells["NOMBRE2"].Value.ToString(),
                        apellido1 = tblEmployesFilter.CurrentRow.Cells["APELLIDO1"].Value.ToString(),
                        apellido2 = tblEmployesFilter.CurrentRow.Cells["APELLIDO2"].Value.ToString(),
                        asiTeclado = Convert.ToBoolean(tblEmployesFilter.CurrentRow.Cells["TECLADO"].Value),
                        asiMouse = Convert.ToBoolean(tblEmployesFilter.CurrentRow.Cells["MOUSE"].Value),
                        asiPuesto = Convert.ToBoolean(tblEmployesFilter.CurrentRow.Cells["PUESTO"].Value),
                        asiBase = Convert.ToBoolean(tblEmployesFilter.CurrentRow.Cells["BASE"].Value),
                        asiMaletin = Convert.ToBoolean(tblEmployesFilter.CurrentRow.Cells["MALETIN"].Value),
                        asiMorral = Convert.ToBoolean(tblEmployesFilter.CurrentRow.Cells["MORRAL"].Value),
                        asiCorreo = Convert.ToBoolean(tblEmployesFilter.CurrentRow.Cells["CORREO"].Value),
                        nombreCompleto = tblEmployesFilter.CurrentRow.Cells["NOMBRES"].Value.ToString(),
                        telefono = tblEmployesFilter.CurrentRow.Cells["TELEFONO"].Value.ToString(),
                        correo = tblEmployesFilter.CurrentRow.Cells["EMP_CORREO"].Value.ToString(),
                        numeroPuesto = tblEmployesFilter.CurrentRow.Cells["PUESTO_N"].Value.ToString(),
                        fechaIngreso = tblEmployesFilter.CurrentRow.Cells["INGRESO"].Value.ToString(),
                        fechaSalida = tblEmployesFilter.CurrentRow.Cells["SALIDA"].Value.ToString(),
                        fechaModifi = tblEmployesFilter.CurrentRow.Cells["FECHAMODIFI"].Value.ToString(),
                        usuarioModifi = tblEmployesFilter.CurrentRow.Cells["USUMODIFI"].Value.ToString(),
                        observacion = tblEmployesFilter.CurrentRow.Cells["OBSERVACION"].Value.ToString(),

                        proyecto = new CEProyecto
                        {
                            id = Convert.ToInt32(tblEmployesFilter.CurrentRow.Cells["PROYECTO_ID"].Value),
                            descripcion = tblEmployesFilter.CurrentRow.Cells["PROYECTO"].Value.ToString()
                        },
                        sede = new CESede
                        {
                            id = Convert.ToInt32(tblEmployesFilter.CurrentRow.Cells["SEDE_ID"].Value),
                            descripcion = tblEmployesFilter.CurrentRow.Cells["SEDE"].Value.ToString()
                        },
                        ubicacion = new CEUbicacion
                        {
                            id = Convert.ToInt32(tblEmployesFilter.CurrentRow.Cells["UBICACION_ID"].Value),
                            descripcion = tblEmployesFilter.CurrentRow.Cells["UBICACION"].Value.ToString()
                        }
                    };

                    if (EmpAsignar == null)
                    {
                        Agregar AE = new Agregar(empleado);
                        AE.TopLevel = false;
                        AE.Dock = DockStyle.None;
                        Controls.Add(AE);
                        Tag = AE;
                        AE.Location = new Point(50, 50);
                        AE.BringToFront();
                        AE.FormClosed += new FormClosedEventHandler(AE_FormClosed);
                        AE.Show();
                    }
                    else
                    {
                        switch (EmpAsignar)
                        {
                            case "ASIGNAR":
                                IPersonaAsignar parent = this.Owner as IPersonaAsignar;
                                parent.AgregarPersonaAsignar(empleado);
                                break;
                            case "DEVOLVER":
                                IPersonaDevolver parent2 = this.Owner as IPersonaDevolver;
                                parent2.AgregarPersonaDevolver(empleado);
                                break;
                            case "PRESTAR":
                                IPersonaPrestar parent3 = this.Owner as IPersonaPrestar;
                                parent3.AgregarPersonaPrestar(empleado);
                                break;
                        }
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en tiempo de ejecución: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AE_FormClosed(object sender, FormClosedEventArgs ex)
        {
            origen = new BindingSource(personas.CargarEmpleadosTableFilter(), "INV.EMPLEADOS");
            origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
            origen.RemoveFilter();
            tblEmployesFilter.DataSource = origen;
        }
    }
}
