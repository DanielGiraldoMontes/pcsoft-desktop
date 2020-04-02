namespace PRESENTACION.Asignaciones.Actas.Entrega
{
	partial class Acta
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acta));
			this.CARGAR_ASIGNACION_DETALLEBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ReporteEntrega = new Microsoft.Reporting.WinForms.ReportViewer();
			((System.ComponentModel.ISupportInitialize)(this.CARGAR_ASIGNACION_DETALLEBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// ReporteEntrega
			// 
			this.ReporteEntrega.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DetalleEntrega";
			reportDataSource1.Value = this.CARGAR_ASIGNACION_DETALLEBindingSource;
			this.ReporteEntrega.LocalReport.DataSources.Add(reportDataSource1);
			this.ReporteEntrega.LocalReport.ReportEmbeddedResource = "PRESENTACION.Asignaciones.Actas.Entrega.RepEntrega.rdlc";
			this.ReporteEntrega.Location = new System.Drawing.Point(0, 0);
			this.ReporteEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.ReporteEntrega.Name = "ReporteEntrega";
			this.ReporteEntrega.ServerReport.BearerToken = null;
			this.ReporteEntrega.Size = new System.Drawing.Size(1241, 761);
			this.ReporteEntrega.TabIndex = 0;
			// 
			// Acta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1241, 761);
			this.Controls.Add(this.ReporteEntrega);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "Acta";
			this.Text = "Acta de entrega";
			this.Load += new System.EventHandler(this.Acta_Load);
			((System.ComponentModel.ISupportInitialize)(this.CARGAR_ASIGNACION_DETALLEBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer ReporteEntrega;
		private System.Windows.Forms.BindingSource CARGAR_ASIGNACION_DETALLEBindingSource;
	}
}