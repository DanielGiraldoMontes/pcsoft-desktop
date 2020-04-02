using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;
using PRESENTACION.Asignaciones.Asignar;
using PRESENTACION.Asignaciones.Prestar;
using PRESENTACION.Movimientos.Devolucion;

namespace PRESENTACION.Equipos
{
    public partial class Gestionar : Form
    {
        private string EquipoMovimiento;
        private CNEquipos equipos;
        private CNReportes reportes;
        private CNPersonas personas;
        private BindingSource origen;

        public Gestionar(string equipoMovimiento)
        {
            InitializeComponent();

            EquipoMovimiento = equipoMovimiento;

            equipos = new CNEquipos();
            reportes = new CNReportes();
            personas = new CNPersonas();

            Dock = DockStyle.Fill;

            if (equipoMovimiento != null)
                origen = new BindingSource(equipos.CargarEquiposDisponibles(), "INV.EQUIPOS");
            else
                origen = new BindingSource(equipos.CargarEquiposTableFilter(), "INV.EQUIPOS");

            origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
            tblEquiposFilter.DataSource = origen;
            lblTotalRows.Text = String.Format("Total equipos {0}", this.origen.List.Count);
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
                                origen.Filter = string.Format("CODIGO LIKE '%{0}%'", busqueda);
                                break;
                            case "rbtnObservaciones":
                                origen.Filter = string.Format("OBSERVACION LIKE '%{0}%'", busqueda);
                                break;
                            case "rbtnProveedor":
                                origen.Filter = string.Format("PROVEEDOR LIKE '%{0}%'", busqueda);
                                break;
                            case "rbtnDescripcion":
                                origen.Filter = string.Format("DESCRIPCION LIKE '%{0}%'", busqueda);
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
                tblEquiposFilter.DataSource = origen;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Agregar AE = new Agregar(null);
            AE.TopLevel = false;
            AE.Dock = DockStyle.None;
            Controls.Add(AE);
            AE.Location = new Point(50, 50);
            AE.BringToFront();
            AE.FormClosed += new FormClosedEventHandler(AE_FormClosed);
            AE.Show();
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
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Buscar();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            Buscar();
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
                    seleccion = new OleDbCommand("SELECT * FROM [IMPORTAR_EQUIPOS$]", origenDB);

                    OleDbDataAdapter adaptador = new OleDbDataAdapter();
                    adaptador.SelectCommand = seleccion;

                    DataSet ds = new DataSet();

                    adaptador.Fill(ds);

                    origenDB.Close();

                    reportes.ImportarEquipos(new CEReporte { Data = ds });

                    ///Al importar vuelve y refresca todos los registros de las tablas.
                    origen = new BindingSource(equipos.CargarEquiposTableFilter(), "INV.EQUIPOS");
                    origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
                    origen.RemoveFilter();
                    tblEquiposFilter.DataSource = origen;

                    MessageBox.Show("Se cargaron los datos correctamente", "Insersión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                    List<CEProveedor> proveedores = personas.CargarComboProveedores();
                    foreach (CEProveedor proveedor in proveedores)
                    {
                        OleDbCommand Query = default;
                        Query = new OleDbCommand("INSERT INTO [PROVEEDORES$] (PROV_NIT, PROV_NOMBRE) VALUES(@NIT, @NOMBRE)", origenDB);
                        Query.Parameters.AddWithValue("NIT", proveedor.documento);
                        Query.Parameters.AddWithValue("NOMBRE", proveedor.nombreCorto);
                        Query.ExecuteNonQuery();
                    }

                    List<CEModelo> modelos = equipos.CargarModelos(new CEMarca { id = 0 });
                    foreach (CEModelo modelo in modelos)
                    {
                        OleDbCommand Query = default;
                        Query = new OleDbCommand("INSERT INTO [MODELOS$] (MODELO_ID, MODELO_DESC) VALUES(@ID, @DESC)", origenDB);
                        Query.Parameters.AddWithValue("ID", modelo.id);
                        Query.Parameters.AddWithValue("DESC", modelo.descripcion);
                        Query.ExecuteNonQuery();
                    }

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
        private void origen_ListChanged(object sender, ListChangedEventArgs e)
        {
            lblTotalRows.Text = String.Format("Total equipos {0}", this.origen.List.Count);
        }
        private void tblEquiposFilter_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    CEEquipo equipo = new CEEquipo
                    {
                        equipoCodigo = tblEquiposFilter.Rows[e.RowIndex].Cells["CODIGO"].Value.ToString(),
                        equipoDescripcion = tblEquiposFilter.Rows[e.RowIndex].Cells["DESCRIPCION"].Value.ToString(),
                        proveedorDocumento = tblEquiposFilter.Rows[e.RowIndex].Cells["PROVEEDOR_NIT"].Value.ToString(),
                        proveedorNombreCorto = tblEquiposFilter.Rows[e.RowIndex].Cells["PROVEEDOR"].Value.ToString(),

                        marca = new CEMarca
                        {
                            id = Convert.ToInt32(tblEquiposFilter.Rows[e.RowIndex].Cells["MARCA_ID"].Value),
                            descripcion = tblEquiposFilter.Rows[e.RowIndex].Cells["MARCA_DESC"].Value.ToString()

                        },
                        modelo = new CEModelo
                        {
                            id = Convert.ToInt32(tblEquiposFilter.Rows[e.RowIndex].Cells["MODELO_ID"].Value),
                            descripcion = tblEquiposFilter.Rows[e.RowIndex].Cells["MODELO_DESC"].Value.ToString()
                        },

                        equipoSerial = tblEquiposFilter.Rows[e.RowIndex].Cells["SERIAL"].Value.ToString(),
                        fechaIngreso = tblEquiposFilter.Rows[e.RowIndex].Cells["INGRESO"].Value.ToString(),
                        fechaSalida = tblEquiposFilter.Rows[e.RowIndex].Cells["SALIDA"].Value.ToString(),
                        equipoEstado = tblEquiposFilter.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString(),

                        proyecto = new CEProyecto
                        {
                            id = Convert.ToInt32(tblEquiposFilter.Rows[e.RowIndex].Cells["PROYECTO_ID"].Value)
                        },
                        sede = new CESede
                        {
                            id = Convert.ToInt32(tblEquiposFilter.Rows[e.RowIndex].Cells["SEDE_ID"].Value)
                        },
                        ubicacion = new CEUbicacion
                        {
                            id = Convert.ToInt32(tblEquiposFilter.Rows[e.RowIndex].Cells["UBICACION_ID"].Value)
                        },

                        numeroPuesto = tblEquiposFilter.Rows[e.RowIndex].Cells["PUESTO"].Value.ToString(),
                        observacion = tblEquiposFilter.Rows[e.RowIndex].Cells["OBSERVACION"].Value.ToString(),
                        fechaModifi = tblEquiposFilter.Rows[e.RowIndex].Cells["FECHAMODIFI"].Value.ToString(),
                        usuarioModifi = tblEquiposFilter.Rows[e.RowIndex].Cells["USUMODIFI"].Value.ToString(),
                    };

                    if (EquipoMovimiento == null)
                    {
                        Agregar AE = new Agregar(equipo);
                        AE.TopLevel = false;
                        AE.Dock = DockStyle.None;
                        Controls.Add(AE);
                        AE.Location = new Point(50, 50);
                        AE.BringToFront();
                        AE.FormClosed += new FormClosedEventHandler(AE_FormClosed);
                        AE.Show();
                    }
                    else
                    {
                        switch (EquipoMovimiento)
                        {
                            case "ASIGNAR":
                                IEquipoAsignar parent = this.Owner as IEquipoAsignar;
                                parent.AgregarEquipoAsignar(equipo);
                                break;
                            case "RECOGER":
                                IAgregarEqRec parent2 = this.Owner as IAgregarEqRec;
                                parent2.AgregarEquipoRecogida(equipo);
                                break;
                            case "PRESTAR":
                                IEquipoPrestar parent3 = this.Owner as IEquipoPrestar;
                                parent3.AgregarEquipoPrestar(equipo);
                                break;
                        }
                        Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AE_FormClosed(object sender, FormClosedEventArgs ex)
        {
            origen = new BindingSource(equipos.CargarEquiposTableFilter(), "INV.EQUIPOS");
            origen.ListChanged += new ListChangedEventHandler(origen_ListChanged);
            origen.RemoveFilter();
            tblEquiposFilter.DataSource = origen;
        }
    }
}
