namespace PRESENTACION.Asignaciones.Actas.Prestamo
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
			this.ReportePrestamo = new Microsoft.Reporting.WinForms.ReportViewer();
			this.SuspendLayout();
			// 
			// ReportePrestamo
			// 
			this.ReportePrestamo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ReportePrestamo.LocalReport.ReportEmbeddedResource = "PRESENTACION.Asignaciones.Actas.Prestamo.RepPrestamo.rdlc";
			this.ReportePrestamo.Location = new System.Drawing.Point(0, 0);
			this.ReportePrestamo.Name = "ReportePrestamo";
			this.ReportePrestamo.ServerReport.BearerToken = null;
			this.ReportePrestamo.Size = new System.Drawing.Size(859, 640);
			this.ReportePrestamo.TabIndex = 0;
			// 
			// Acta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 640);
			this.Controls.Add(this.ReportePrestamo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Acta";
			this.Text = "Acta de prestamo";
			this.Load += new System.EventHandler(this.Acta_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer ReportePrestamo;
	}
}