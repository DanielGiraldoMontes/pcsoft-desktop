using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using ENTIDADES;
using NEGOCIO;

namespace PRESENTACION.Reportes
{
    public partial class Empleados : Form
    {
        private CNReportes reportes;
        private CNPersonas personas;
        private SqlDataReader Reader;
        private SaveFileDialog fichero;
        private int FilaExcel;

        public Empleados()
        {
            InitializeComponent();

            reportes = new CNReportes();
            personas = new CNPersonas();

            DateStart.Text = DateTime.Now.ToString("yyyy-MM-dd");
            DateEnd.Text = DateTime.Now.ToString("yyyy-MM-dd");

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
        private void btnRepGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkProyectoGeneral.Checked == true)
                {
                    if (Convert.ToInt32(cmbProyectoGeneral.SelectedValue.ToString()) < 2)
                    { MessageBox.Show("Debe seleccionar un proyecto", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
                    else
                    { ReporteGeneral(); }
                }
                else
                {
                    ReporteGeneral();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un proyecto", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
        private void btnCobroPuestos_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateStart.Text != DateEnd.Text)
                {
                    if (Convert.ToInt32(cmbProyecto.SelectedValue.ToString()) < 2)
                    { MessageBox.Show("Debe seleccionar un proyecto", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning); }
                    else
                    { ReporteCobroPuestos(DateStart.Text, DateEnd.Text); }
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
        private void chkProyectoGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (chkProyectoGeneral.Checked == true)
                cmbProyectoGeneral.Visible = true;
            else
                cmbProyectoGeneral.Visible = false;
        }
        private void ReporteGeneral()
        {
            try
            {
                fichero = new SaveFileDialog();
                fichero.Filter = "Excel (*.xls)|*.xls";
                fichero.RestoreDirectory = true;
                fichero.FileName = "Empleados.xls";
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
                    Hoja.Name = "Empleados";

                    if (chkProyectoGeneral.Checked == true && chkRangoFechas.Checked == true)
                    {
                        Reader = reportes.RepEmpleadosPorFechasyProyecto(new CEReporte
                        {
                            Inicio = GeneralStartDate.Text,
                            Fin = GeneralEndDate.Text,
                            Proyecto = cmbProyectoGeneral.SelectedValue.ToString()
                        });
                    }
                    else if (chkProyectoGeneral.Checked == true)
                    {
                        Reader = reportes.RepEmpleadosPorProyecto(new CEReporte
                        {
                            Proyecto = cmbProyectoGeneral.SelectedValue.ToString()
                        });
                    }
                    else if (chkRangoFechas.Checked == true)
                    {
                        if (GeneralStartDate.Text != GeneralEndDate.Text)
                        {
                            Reader = reportes.RepEmpleadosPorFechas(new CEReporte
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
                        Reader = reportes.RepEmpleados();
                    }

                    Hoja.Cells[FilaExcel, 1] = "CEDULA";
                    Hoja.Cells[FilaExcel, 2] = "CODINV";
                    Hoja.Cells[FilaExcel, 3] = "NOMBRES";
                    Hoja.Cells[FilaExcel, 4] = "CORREO";
                    Hoja.Cells[FilaExcel, 5] = "TELEFONO";
                    Hoja.Cells[FilaExcel, 6] = "PROYECTO";
                    Hoja.Cells[FilaExcel, 7] = "SEDE";
                    Hoja.Cells[FilaExcel, 8] = "UBICACION";
                    Hoja.Cells[FilaExcel, 9] = "EMP_PUESTO";
                    Hoja.Cells[FilaExcel, 10] = "TECLADO";
                    Hoja.Cells[FilaExcel, 11] = "MOUSE";
                    Hoja.Cells[FilaExcel, 12] = "PUESTO";
                    Hoja.Cells[FilaExcel, 13] = "BASE";
                    Hoja.Cells[FilaExcel, 14] = "MALETIN";
                    Hoja.Cells[FilaExcel, 15] = "MORRAL";
                    Hoja.Cells[FilaExcel, 16] = "OBSERVACION";
                    Hoja.Cells[FilaExcel, 17] = "INGRESO";
                    Hoja.Cells[FilaExcel, 18] = "SALIDA";
                    Hoja.Cells[FilaExcel, 19] = "USUARIO_MODIFI";
                    Hoja.Cells[FilaExcel, 20] = "FECHA_MODIFI";

                    FilaExcel++;

                    while (Reader.Read())
                    {
                        Hoja.Cells[FilaExcel, 1] = Reader.GetString(0);
                        Hoja.Cells[FilaExcel, 2] = Reader.GetInt32(1);
                        Hoja.Cells[FilaExcel, 3] = Reader.GetString(2);
                        Hoja.Cells[FilaExcel, 4] = Reader.GetString(3);
                        Hoja.Cells[FilaExcel, 5] = Reader.GetString(4);
                        Hoja.Cells[FilaExcel, 6] = Reader.GetString(5);
                        Hoja.Cells[FilaExcel, 7] = Reader.GetString(6);
                        Hoja.Cells[FilaExcel, 8] = Reader.GetString(7);
                        Hoja.Cells[FilaExcel, 9] = Reader.GetString(8);
                        Hoja.Cells[FilaExcel, 10] = Reader.GetString(9);
                        Hoja.Cells[FilaExcel, 11] = Reader.GetString(10);
                        Hoja.Cells[FilaExcel, 12] = Reader.GetString(11);
                        Hoja.Cells[FilaExcel, 13] = Reader.GetString(12);
                        Hoja.Cells[FilaExcel, 14] = Reader.GetString(13);
                        Hoja.Cells[FilaExcel, 15] = Reader.GetString(14);
                        Hoja.Cells[FilaExcel, 16] = Reader.GetString(15);
                        Hoja.Cells[FilaExcel, 17] = Reader.GetDateTime(16).ToString("yyyy-MM-dd");
                        Hoja.Cells[FilaExcel, 18] = Reader.GetString(17);
                        Hoja.Cells[FilaExcel, 19] = Reader.GetString(18);
                        Hoja.Cells[FilaExcel, 20] = Reader.GetDateTime(19);

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

                    Reader = reportes.RepCobroPuestosEmpleado(new CEReporte
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
        static void AbrirDocumento(String File)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "EXCEL.EXE";
            startInfo.Arguments = File;
            Process.Start(startInfo);
        }
    }
}
