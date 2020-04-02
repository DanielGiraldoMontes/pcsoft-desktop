using System;
using System.Windows.Forms;
using ENTIDADES;
using Microsoft.Reporting.WinForms;
using NEGOCIO;

namespace PRESENTACION.Asignaciones.Actas.Entrega
{
    public partial class Acta : Form
    {
        private CNAsignaciones asignaciones = new CNAsignaciones();
        private CEAsignaciones asignacion;

        public Acta(CEAsignaciones asignacion)
        {
            InitializeComponent();

            this.asignacion = asignacion;
        }
        private void Acta_Load(object sender, EventArgs e)
        {
            ReportParameter[] parametros = new ReportParameter[14];

            parametros[0] = new ReportParameter("ID", asignacion.id.ToString());
            parametros[1] = new ReportParameter("CODINV", asignacion.codigo.ToString());
            parametros[2] = new ReportParameter("EMP_CEDULA", asignacion.documento);
            parametros[3] = new ReportParameter("EMP_NOMBRES", asignacion.nombreCompleto);
            parametros[4] = new ReportParameter("FECHA", asignacion.fecha);
            parametros[5] = new ReportParameter("USU_NOMBRE", asignacion.usuarioNombres);
            parametros[6] = new ReportParameter("USU_DOCUMENTO", asignacion.usuarioDocumento);
            parametros[7] = new ReportParameter("OBSERVACION", asignacion.observacion);
            parametros[8] = new ReportParameter("MOUSE", asignacion.asiMouse == true ? "X" : "");
            parametros[9] = new ReportParameter("TECLADO", asignacion.asiTeclado == true ? "X" : "");
            parametros[10] = new ReportParameter("BASE", asignacion.asiBase == true ? "X" : "");
            parametros[11] = new ReportParameter("MORRAL", asignacion.asiMorral == true ? "X" : "");
            parametros[12] = new ReportParameter("CORREO", asignacion.asiCorreo == true ? "X" : "");
            parametros[13] = new ReportParameter("PUESTO", asignacion.asiPuesto == true ? "X" : "");

            ReporteEntrega.LocalReport.SetParameters(parametros);


            ReportDataSource Sourse = new ReportDataSource();
            Sourse.Name = "EQUIPOS";
            Sourse.Value = asignaciones.CargarAsignacionDetalle(asignacion.id);
            ReporteEntrega.LocalReport.DataSources.Add(Sourse);


            ReporteEntrega.RefreshReport();
            ReporteEntrega.SetDisplayMode(DisplayMode.PrintLayout);
        }
    }
}
