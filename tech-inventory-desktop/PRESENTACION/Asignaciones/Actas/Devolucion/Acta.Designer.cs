namespace PRESENTACION.Asignaciones.Actas.Devolucion
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acta));
			this.ReporteDevolucion = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// ReporteDevolucion
			// 
			this.ReporteDevolucion.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ReporteDevolucion.LocalReport.ReportEmbeddedResource = "PRESENTACION.Asignaciones.Actas.Devolucion.RepDevolucion.rdlc";
			this.ReporteDevolucion.Location = new System.Drawing.Point(0, 0);
			this.ReporteDevolucion.Name = "ReporteDevolucion";
			this.ReporteDevolucion.ServerReport.BearerToken = null;
			this.ReporteDevolucion.Size = new System.Drawing.Size(501, 469);
			this.ReporteDevolucion.TabIndex = 0;
			// 
			// Acta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 469);
			this.Controls.Add(this.ReporteDevolucion);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "Acta";
			this.Text = "Acta de devolución";
			this.Load += new System.EventHandler(this.Acta_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer ReporteDevolucion;
	}
}