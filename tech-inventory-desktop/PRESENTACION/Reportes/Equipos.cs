using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Reportes
{
    public partial class Equipos : Form
    {
        private CNReportes reportes;
        private CNPersonas personas;
        private SqlDataReader Reader;
        private SaveFileDialog fichero;
        private int FilaExcel;

        public Equipos()
        {
            InitializeComponent();

            reportes = new CNReportes();
            personas = new CNPersonas();

            GeneralStartDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            GeneralEndDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            DateStartRep.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DateEndRep.Text = DateTime.Now.ToString("yyyy-MM-dd");

            DateStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DateEnd.Text = DateTime.Now.ToString("yyyy-MM-dd");

            MovimientoStartDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            MovimientoEndDate.Text = DateTime.Now.ToString("yyyy-MM-dd");

            CargarCombos();
        }
        private void CargarCombos()
        {
            try
            {
                // Cargar combo proyectos                
                List<CEProyecto> proyectos = personas.CargarProyectos();

                proyectos.Insert(0, new CEProyecto
                {
                    id = 0,
                    descripcion = "SELECCIONE UN PROYECTO"
                });

                cmbProyecto.ValueMember = "id";
                cmbProyecto.DisplayMember = "descripcion";
                cmbProyecto.DataSource = proyectos;

                ///Cargar combo Proyectos General
                cmbProyectoGeneral.ValueMember = "id";
                cmbProyectoGeneral.DisplayMember = "descripcion";
                cmbProyectoGeneral.DataSource = proyectos;
            }
            catch (Exception e)
            {
                MessageBox.Show("Se presento el siguiente error: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRepMovimientos_Click(object sender, EventArgs e)
        {
            ReporteMovimientos();
        }
        private void btnRepGeneral_Click(object sender, EventArgs e)
        {
            ReporteGeneral();
        }
        private void btnCruceFacturacion_Click(object sender, EventArgs e)
        {
            ReporteCruceFacturacion();
        }
        private void ReporteGeneral()
        {
            try
            {
                fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.RestoreDirectory = true;
                fichero.FileName = "Equipos.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    CNReportes reportes = new CNReportes();
                    FilaExcel = 1;

                    Microsoft.Office.Interop.Excel.Application Aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook Libro;
                    Microsoft.Office.Interop.Excel.Worksheet Hoja;
                    Aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    Libro = Aplicacion.Workbooks.Add();
                    Libro.Worksheets.Add();
                    Hoja = (Microsoft.Office.Interop.Excel.Worksheet)Libro.Worksheets.get_Item(1);
                    Hoja.Name = "Equipos";

                    if (chkProyectoGeneral.Checked == true && chkRangoFechas.Checked == true)
                    {
                        Reader = reportes.RepEquiposPorFechasyProyecto(new CEReporte
                        {
                            Inicio = GeneralStartDate.Text,
                            Fin = GeneralEndDate.Text,
                            Proyecto = cmbProyectoGeneral.SelectedValue.ToString()
                        });
                    }
                    else if (chkProyectoGeneral.Checked == true)
                    {
                        Reader = reportes.RepEquiposPorProyecto(new CEReporte
                        {
                            Proyecto = cmbProyectoGeneral.SelectedValue.ToString()
                        });
                    }
                    else if (chkRangoFechas.Checked == true)
                    {
                        if (GeneralStartDate.Text != GeneralEndDate.Text)
                        {
                            Reader = reportes.RepEquiposPorFechas(new CEReporte
                            {
                                Inicio = GeneralStartDate.Text,
                                Fin = GeneralEndDate.Text
                            });
                        }
                        else
                        {
                            MessageBox.Show("Las fechas no pueden ser iguales", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else
                    {
                        Reader = reportes.RepEquipos();
                    }

                    Hoja.Cells[FilaExcel, 1] = "CODIGO";
                    Hoja.Cells[FilaExcel, 2] = "DESCRIPCION";
                    Hoja.Cells[FilaExcel, 3] = "MARCA";
                    Hoja.Cells[FilaExcel, 4] = "MODELO";
                    Hoja.Cells[FilaExcel, 5] = "SERIAL";
                    Hoja.Cells[FilaExcel, 6] = "PROYECTO";
                    Hoja.Cells[FilaExcel, 7] = "SEDE";
                    Hoja.Cells[FilaExcel, 8] = "UBICACION";
                    Hoja.Cells[FilaExcel, 9] = "PUESTO";
                    Hoja.Cells[FilaExcel, 10] = "ESTADO";
                    Hoja.Cells[FilaExcel, 11] = "PROVEEDOR";
                    Hoja.Cells[FilaExcel, 12] = "INGRESO";
                    Hoja.Cells[FilaExcel, 13] = "SALIDA";
                    Hoja.Cells[FilaExcel, 14] = "OBSERVACION";
                    Hoja.Cells[FilaExcel, 15] = "CEDULA";
                    Hoja.Cells[FilaExcel, 16] = "CODINV";
                    Hoja.Cells[FilaExcel, 17] = "NOMBRES";
                    Hoja.Cells[FilaExcel, 18] = "USUARIO_MODIFI";
                    Hoja.Cells[FilaExcel, 19] = "FECHA_MODIFI";

                    FilaExcel++;

                    while (Reader.Read())
                    {
                        Hoja.Cells[FilaExcel, 1] = Reader.GetString(0);
                        Hoja.Cells[FilaExcel, 2] = Reader.GetString(1);
                        Hoja.Cells[FilaExcel, 3] = Reader.GetString(2);
                        Hoja.Cells[FilaExcel, 4] = Reader.GetString(3);
                        Hoja.Cells[FilaExcel, 5] = Reader.GetString(4);
                        Hoja.Cells[FilaExcel, 6] = Reader.GetString(5);
                        Hoja.Cells[FilaExcel, 7] = Reader.GetString(6);
                        Hoja.Cells[FilaExcel, 8] = Reader.GetString(7);
                        Hoja.Cells[FilaExcel, 9] = Reader.GetString(8);
                        Hoja.Cells[FilaExcel, 10] = Reader.GetString(9);
                        Hoja.Cells[FilaExcel, 11] = Reader.GetString(10);
                        Hoja.Cells[FilaExcel, 12] = Reader.GetDateTime(11).ToString("yyyy-MM-dd");
                        Hoja.Cells[FilaExcel, 13] = Reader.GetString(12);
                        Hoja.Cells[FilaExcel, 14] = Reader.GetString(13);
                        Hoja.Cells[FilaExcel, 15] = Reader.GetString(14);
                        Hoja.Cells[FilaExcel, 16] = Reader.GetInt32(15);
                        Hoja.Cells[FilaExcel, 17] = Reader.GetString(16);
                        Hoja.Cells[FilaExcel, 18] = Reader.GetString(17);
                        Hoja.Cells[FilaExcel, 19] = Reader.GetDateTime(18).ToString("yyyy-MM-dd H:mm:sss");

                        FilaExcel++;
                    }

                    Libro.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    Libro.Close(true);

                    ///Apertura de documento
                    AbrirDocumento(fichero.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReporteMovimientos()
        {
            try
            {
                fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.RestoreDirectory = true;
                fichero.FileName = "Movimientos.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    CNReportes reportes = new CNReportes();
                    FilaExcel = 1;

                    Microsoft.Office.Interop.Excel.Application Aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook Libro;
                    Microsoft.Office.Interop.Excel.Worksheet Hoja;
                    Aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    Libro = Aplicacion.Workbooks.Add();
                    Libro.Worksheets.Add();
                    Hoja = (Microsoft.Office.Interop.Excel.Worksheet)Libro.Worksheets.get_Item(1);
                    Hoja.Name = "Movimientos";

                    if (chkMovimientoRangoFechas.Checked == true)
                    {
                        Reader = reportes.RepMovimientoEquiposFecha(new CEReporte
                        {
                            Inicio = MovimientoStartDate.Text + " 00:00:00",
                            Fin = MovimientoEndDate.Text + " 23:59:59"
                        });
                    }
                    else
                    {
                        Reader = reportes.RepMovimientoEquipos();
                    }

                    Hoja.Cells[FilaExcel, 1] = "N° MOVIMIENTO";
                    Hoja.Cells[FilaExcel, 2] = "DOCUMENTO";
                    Hoja.Cells[FilaExcel, 3] = "NOMBRES";
                    Hoja.Cells[FilaExcel, 4] = "CODIGO";
                    Hoja.Cells[FilaExcel, 5] = "DESCRIPCION";
                    Hoja.Cells[FilaExcel, 6] = "NUM_REF";
                    Hoja.Cells[FilaExcel, 7] = "TIPO";
                    Hoja.Cells[FilaExcel, 8] = "FECHA";
                    Hoja.Cells[FilaExcel, 9] = "USUARIO";

                    FilaExcel++;

                    while (Reader.Read())
                    {
                        Hoja.Cells[FilaExcel, 1] = Reader.GetInt32(0);
                        Hoja.Cells[FilaExcel, 2] = Reader.GetString(1);
                        Hoja.Cells[FilaExcel, 3] = Reader.GetString(2);
                        Hoja.Cells[FilaExcel, 4] = Reader.GetString(3);
                        Hoja.Cells[FilaExcel, 5] = Reader.GetString(4);
                        Hoja.Cells[FilaExcel, 6] = Reader.GetString(5);
                        Hoja.Cells[FilaExcel, 7] = Reader.GetString(6);
                        Hoja.Cells[FilaExcel, 8] = Reader.GetDateTime(7);
                        Hoja.Cells[FilaExcel, 9] = Reader.GetString(8);

                        FilaExcel++;
                    }

                    Libro.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    Libro.Close(true);

                    ///Apertura de documento
                    AbrirDocumento(fichero.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ReporteCruceFacturacion()
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

                    OleDbConnection origen = default(OleDbConnection);
                    origen = new OleDbConnection(conexion);

                    OleDbCommand seleccion = default(OleDbCommand);
                    seleccion = new OleDbCommand("SELECT * FROM [CRUCE_FACTURACION$]", origen);

                    OleDbDataAdapter adaptador = new OleDbDataAdapter();
                    adaptador.SelectCommand = seleccion;

                    DataSet ds = new DataSet();

                    adaptador.Fill(ds);

                    origen.Close();

                    reportes.CruceFacturacion(new CEReporte { Data = ds });


                    fichero = new SaveFileDialog();
                    fichero.Filter = "Excel (*.xls)|*.xls";
                    fichero.RestoreDirectory = true;
                    fichero.FileName = "Facturacion.xls";

                    if (fichero.ShowDialog() == DialogResult.OK)
                    {
                        FilaExcel = 1;

                        Microsoft.Office.Interop.Excel.Application Aplicacion;
                        Microsoft.Office.Interop.Excel.Workbook Libro;
                        Microsoft.Office.Interop.Excel.Worksheet Hoja;
                        Aplicacion = new Microsoft.Office.Interop.Excel.Application();
                        Libro = Aplicacion.Workbooks.Add();
                        Libro.Worksheets.Add();
                        Hoja = (Microsoft.Office.Interop.Excel.Worksheet)Libro.Worksheets.get_Item(1);
                        Hoja.Name = "Facturacion";

                        Reader = reportes.RepCruceFacturacion(new CEReporte
                        {
                            Inicio = DateStart.Text.ToString(),
                            Fin = DateEnd.Text.ToString()
                        });

                        Hoja.Cells[FilaExcel, 1] = "EQ_CODIGO";
                        Hoja.Cells[FilaExcel, 2] = "EQ_DESCRIPCION";
                        Hoja.Cells[FilaExcel, 3] = "EQ_OBSERVACION";
                        Hoja.Cells[FilaExcel, 4] = "EQ_ESTADO";
                        Hoja.Cells[FilaExcel, 5] = "EMP_CEDULA";
                        Hoja.Cells[FilaExcel, 6] = "EMP_NOMBRES";
                        Hoja.Cells[FilaExcel, 7] = "EMP_PROYECTO";
                        Hoja.Cells[FilaExcel, 8] = "EMP_SEDE";
                        Hoja.Cells[FilaExcel, 9] = "EMP_UBICACION";
                        Hoja.Cells[FilaExcel, 10] = "ASI_PUESTO";
                        Hoja.Cells[FilaExcel, 11] = "EMP_PUESTO";
                        Hoja.Cells[FilaExcel, 12] = "EQ_FECHAINGRESO";
                        Hoja.Cells[FilaExcel, 13] = "EQ_FECHASALIDA";
                        Hoja.Cells[FilaExcel, 14] = "COBRO_INICIAL";
                        Hoja.Cells[FilaExcel, 15] = "COBRO_FINAL";
                        Hoja.Cells[FilaExcel, 16] = "EQ_VALOR";
                        Hoja.Cells[FilaExcel, 17] = "EQ_TOTAL";
                        Hoja.Cells[FilaExcel, 18] = "DIAS";
                        Hoja.Cells[FilaExcel, 19] = "TOTAL_QUICK";

                        FilaExcel++;

                        while (Reader.Read())
                        {
                            Hoja.Cells[FilaExcel, 16].NumberFormat = "#,##0.00 $";
                            Hoja.Cells[FilaExcel, 17].NumberFormat = "#,##0.00 $";
                            Hoja.Cells[FilaExcel, 19].NumberFormat = "#,##0.00 $";

                            Hoja.Cells[FilaExcel, 1] = Reader.GetString(0);
                            Hoja.Cells[FilaExcel, 2] = Reader.GetString(1);
                            Hoja.Cells[FilaExcel, 3] = Reader.GetString(2);
                            Hoja.Cells[FilaExcel, 4] = Reader.GetString(3);
                            Hoja.Cells[FilaExcel, 5] = Reader.GetString(4);
                            Hoja.Cells[FilaExcel, 6] = Reader.GetString(5);
                            Hoja.Cells[FilaExcel, 7] = Reader.GetString(6);
                            Hoja.Cells[FilaExcel, 8] = Reader.GetString(7);
                            Hoja.Cells[FilaExcel, 9] = Reader.GetString(8);
                            Hoja.Cells[FilaExcel, 10] = Reader.GetString(9);
                            Hoja.Cells[FilaExcel, 11] = Reader.GetString(10);
                            Hoja.Cells[FilaExcel, 12] = Reader.GetDateTime(11).ToString("yyyy-MM-dd");
                            Hoja.Cells[FilaExcel, 13] = Reader.GetDateTime(12).ToString("yyyy-MM-dd");
                            Hoja.Cells[FilaExcel, 14] = Reader.GetDateTime(13).ToString("yyyy-MM-dd");
                            Hoja.Cells[FilaExcel, 15] = Reader.GetDateTime(14).ToString("yyyy-MM-dd");
                            Hoja.Cells[FilaExcel, 16] = Reader.GetDouble(15);
                            Hoja.Cells[FilaExcel, 17] = Reader.GetDouble(16);
                            Hoja.Cells[FilaExcel, 18] = Reader.GetInt32(17);
                            Hoja.Cells[FilaExcel, 19] = Reader.GetDouble(18);

                            FilaExcel++;
                        }

                        //Hoja.Cells["A1:R" + FilaExcel].Style.HorizontalAlignment = true;

                        Libro.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                        Libro.Close(true);

                        ///Apertura de documento
                        AbrirDocumento(fichero.FileName);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error en tiempo de ejecución" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnCobroPuestos_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateStartRep.Text != DateEndRep.Text)
                {
                    if (Convert.ToInt32(cmbProyecto.SelectedValue.ToString()) < 2)
                    { MessageBox.Show("Debe seleccionar un proyecto", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
                    else
                    { ReporteCobroPuestos(DateStartRep.Text, DateEndRep.Text); }
                }
                else
                {
                    MessageBox.Show("Las fechas no pueden ser iguales", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void ReporteCobroPuestos(string Inicio, string Fin)
        {
            try
            {

                fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.RestoreDirectory = true;
                fichero.FileName = "CobroPuestos.xls";
                if (fichero.ShowDialog() == DialogResult.OK)
                {
                    CNReportes reportes = new CNReportes();
                    FilaExcel = 1;

                    Microsoft.Office.Interop.Excel.Application Aplicacion;
                    Microsoft.Office.Interop.Excel.Workbook Libro;
                    Microsoft.Office.Interop.Excel.Worksheet Hoja;
                    Aplicacion = new Microsoft.Office.Interop.Excel.Application();
                    Libro = Aplicacion.Workbooks.Add();
                    Libro.Worksheets.Add();
                    Hoja = (Microsoft.Office.Interop.Excel.Worksheet)Libro.Worksheets.get_Item(1);
                    Hoja.Name = "PUESTOS";


                    Reader = reportes.RepCobroPuestosEquipos(new CEReporte
                    {
                        Inicio = Inicio,
                        Fin = Fin,
                        Proyecto = cmbProyecto.SelectedValue.ToString()
                    });

                    Hoja.Cells[FilaExcel, 1] = "CEDULA";
                    Hoja.Cells[FilaExcel, 2] = "CODINV";
                    Hoja.Cells[FilaExcel, 3] = "NOMBRES";
                    Hoja.Cells[FilaExcel, 4] = "EMP_PROYECTO";
                    Hoja.Cells[FilaExcel, 5] = "EMP_SEDE";
                    Hoja.Cells[FilaExcel, 6] = "EMP_UBICACION";
                    Hoja.Cells[FilaExcel, 7] = "EMP_PUESTO";
                    Hoja.Cells[FilaExcel, 8] = "OBSERVACION";
                    Hoja.Cells[FilaExcel, 9] = "EMP_INGRESO";
                    Hoja.Cells[FilaExcel, 10] = "EMP_SALIDA";
                    Hoja.Cells[FilaExcel, 11] = "EMP_USUARIOMODIFI";
                    Hoja.Cells[FilaExcel, 12] = "EMP_FECHAMODIFI";
                    Hoja.Cells[FilaExcel, 13] = "EQ_CODIGO";
                    Hoja.Cells[FilaExcel, 14] = "EQ_DESCRIPCION";
                    Hoja.Cells[FilaExcel, 15] = "EQ_PROYECTO";
                    Hoja.Cells[FilaExcel, 16] = "EQ_SEDE";
                    Hoja.Cells[FilaExcel, 17] = "EQ_UBICACION";
                    Hoja.Cells[FilaExcel, 18] = "EQ_PUESTO";
                    Hoja.Cells[FilaExcel, 19] = "EQ_FECHAINGRESO";
                    Hoja.Cells[FilaExcel, 20] = "EQ_FECHASALIDA";
                    Hoja.Cells[FilaExcel, 21] = "EQ_OBSERVACION";
                    Hoja.Cells[FilaExcel, 22] = "EQ_USUARIOMODIFI";
                    Hoja.Cells[FilaExcel, 23] = "EQ_FECHAMODIFI";
                    Hoja.Cells[FilaExcel, 24] = "DIAS";

                    FilaExcel++;

                    while (Reader.Read())
                    {

                        Hoja.Cells[FilaExcel, 1] = Reader.GetString(0);
                        Hoja.Cells[FilaExcel, 2] = Reader.GetString(1);
                        Hoja.Cells[FilaExcel, 3] = Reader.GetString(2);
                        Hoja.Cells[FilaExcel, 4] = Reader.GetString(3);
                        Hoja.Cells[FilaExcel, 5] = Reader.GetString(4);
                        Hoja.Cells[FilaExcel, 6] = Reader.GetString(5);
                        Hoja.Cells[FilaExcel, 7] = Reader.GetString(6);
                        Hoja.Cells[FilaExcel, 8] = Reader.GetString(7);
                        Hoja.Cells[FilaExcel, 9] = Reader.GetString(8);
                        Hoja.Cells[FilaExcel, 10] = Reader.GetString(9);
                        Hoja.Cells[FilaExcel, 11] = Reader.GetString(10);
                        Hoja.Cells[FilaExcel, 12] = Reader.GetDateTime(11).ToString("yyyy-MM-dd H:mm:ss");
                        Hoja.Cells[FilaExcel, 13] = Reader.GetString(12);
                        Hoja.Cells[FilaExcel, 14] = Reader.GetString(13);
                        Hoja.Cells[FilaExcel, 15] = Reader.GetString(14);
                        Hoja.Cells[FilaExcel, 16] = Reader.GetString(15);
                        Hoja.Cells[FilaExcel, 17] = Reader.GetString(16);
                        Hoja.Cells[FilaExcel, 18] = Reader.GetString(17);
                        Hoja.Cells[FilaExcel, 19] = Reader.GetString(18);
                        Hoja.Cells[FilaExcel, 20] = Reader.GetString(19);
                        Hoja.Cells[FilaExcel, 21] = Reader.GetString(20);
                        Hoja.Cells[FilaExcel, 22] = Reader.GetString(21);
                        Hoja.Cells[FilaExcel, 23] = Reader.GetDateTime(22).ToString("yyyy-MM-dd H:mm:ss");
                        Hoja.Cells[FilaExcel, 24] = Reader.GetInt32(23);

                        FilaExcel++;
                    }

                    Libro.SaveAs(fichero.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    Libro.Close(true);

                    ///Apertura de documento
                    AbrirDocumento(fichero.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se presento el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void chkRangoFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRangoFechas.Checked == true)
            {
                GeneralStartDate.Visible = true;
                GeneralEndDate.Visible = true;
                lblGeneralStart.Visible = true;
                lblGeneralEnd.Visible = true;
            }
            else
            {
                GeneralStartDate.Visible = false;
                GeneralEndDate.Visible = false;
                lblGeneralStart.Visible = false;
                lblGeneralEnd.Visible = false;
            }
        }
        private void chkProyectoGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProyectoGeneral.Checked == true)
            { cmbProyectoGeneral.Visible = true; }
            else
            { cmbProyectoGeneral.Visible = false; }
        }
        private void chkMovimientoRangoFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMovimientoRangoFechas.Checked == true)
            {
                MovimientoStartDate.Visible = true;
                MovimientoEndDate.Visible = true;
                lblMovimientoStartDate.Visible = true;
                lblMovimientoEndDate.Visible = true;
            }
            else
            {
                MovimientoStartDate.Visible = false;
                MovimientoEndDate.Visible = false;
                lblMovimientoStartDate.Visible = false;
                lblMovimientoEndDate.Visible = false;
            }
        }
        static void AbrirDocumento(String File)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "EXCEL.EXE";
            startInfo.Arguments = File;
            Process.Start(startInfo);
        }
    }
}
