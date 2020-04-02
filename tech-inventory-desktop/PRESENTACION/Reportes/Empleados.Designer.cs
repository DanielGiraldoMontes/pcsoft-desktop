namespace PRESENTACION.Reportes
{
	partial class Empleados
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Empleados));
			this.tabRepCobroPuesto = new System.Windows.Forms.TabPage();
			this.lblInicio = new System.Windows.Forms.Label();
			this.DateStart = new System.Windows.Forms.DateTimePicker();
			this.cmbProyecto = new System.Windows.Forms.ComboBox();
			this.lblEnd = new System.Windows.Forms.Label();
			this.DateEnd = new System.Windows.Forms.DateTimePicker();
			this.btnCobroPuestos = new System.Windows.Forms.Button();
			this.tabGeneral = new System.Windows.Forms.TabControl();
			this.tabRepGeneral = new System.Windows.Forms.TabPage();
			this.chkRangoFechas = new System.Windows.Forms.CheckBox();
			this.lblGeneralStart = new System.Windows.Forms.Label();
			this.GeneralStartDate = new System.Windows.Forms.DateTimePicker();
			this.lblGeneralEnd = new System.Windows.Forms.Label();
			this.GeneralEndDate = new System.Windows.Forms.DateTimePicker();
			this.chkProyectoGeneral = new System.Windows.Forms.CheckBox();
			this.cmbProyectoGeneral = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnRepGeneral = new System.Windows.Forms.Button();
			this.tabRepCobroPuesto.SuspendLayout();
			this.tabGeneral.SuspendLayout();
			this.tabRepGeneral.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabRepCobroPuesto
			// 
			this.tabRepCobroPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.tabRepCobroPuesto.Controls.Add(this.lblInicio);
			this.tabRepCobroPuesto.Controls.Add(this.DateStart);
			this.tabRepCobroPuesto.Controls.Add(this.cmbProyecto);
			this.tabRepCobroPuesto.Controls.Add(this.lblEnd);
			this.tabRepCobroPuesto.Controls.Add(this.DateEnd);
			this.tabRepCobroPuesto.Controls.Add(this.btnCobroPuestos);
			this.tabRepCobroPuesto.Location = new System.Drawing.Point(4, 22);
			this.tabRepCobroPuesto.Margin = new System.Windows.Forms.Padding(2);
			this.tabRepCobroPuesto.Name = "tabRepCobroPuesto";
			this.tabRepCobroPuesto.Padding = new System.Windows.Forms.Padding(2);
			this.tabRepCobroPuesto.Size = new System.Drawing.Size(366, 392);
			this.tabRepCobroPuesto.TabIndex = 3;
			this.tabRepCobroPuesto.Text = "Cobro de puestos";
			// 
			// lblInicio
			// 
			this.lblInicio.AutoSize = true;
			this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInicio.ForeColor = System.Drawing.Color.White;
			this.lblInicio.Location = new System.Drawing.Point(20, 47);
			this.lblInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblInicio.Name = "lblInicio";
			this.lblInicio.Size = new System.Drawing.Size(147, 22);
			this.lblInicio.TabIndex = 0;
			this.lblInicio.Text = "Inicio de cobro:";
			// 
			// DateStart
			// 
			this.DateStart.CustomFormat = "yyyy-MM-dd";
			this.DateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateStart.Location = new System.Drawing.Point(194, 47);
			this.DateStart.Margin = new System.Windows.Forms.Padding(2);
			this.DateStart.Name = "DateStart";
			this.DateStart.Size = new System.Drawing.Size(117, 26);
			this.DateStart.TabIndex = 2;
			// 
			// cmbProyecto
			// 
			this.cmbProyecto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.cmbProyecto.FormattingEnabled = true;
			this.cmbProyecto.Location = new System.Drawing.Point(90, 197);
			this.cmbProyecto.Margin = new System.Windows.Forms.Padding(2);
			this.cmbProyecto.Name = "cmbProyecto";
			this.cmbProyecto.Size = new System.Drawing.Size(197, 25);
			this.cmbProyecto.TabIndex = 5;
			// 
			// lblEnd
			// 
			this.lblEnd.AutoSize = true;
			this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnd.ForeColor = System.Drawing.Color.White;
			this.lblEnd.Location = new System.Drawing.Point(20, 95);
			this.lblEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblEnd.Name = "lblEnd";
			this.lblEnd.Size = new System.Drawing.Size(128, 22);
			this.lblEnd.TabIndex = 0;
			this.lblEnd.Text = "Fin de cobro:";
			// 
			// DateEnd
			// 
			this.DateEnd.CustomFormat = "yyyy-MM-dd";
			this.DateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateEnd.Location = new System.Drawing.Point(194, 95);
			this.DateEnd.Margin = new System.Windows.Forms.Padding(2);
			this.DateEnd.Name = "DateEnd";
			this.DateEnd.Size = new System.Drawing.Size(117, 26);
			this.DateEnd.TabIndex = 3;
			// 
			// btnCobroPuestos
			// 
			this.btnCobroPuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
			this.btnCobroPuestos.FlatAppearance.BorderSize = 0;
			this.btnCobroPuestos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
			this.btnCobroPuestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCobroPuestos.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCobroPuestos.ForeColor = System.Drawing.Color.White;
			this.btnCobroPuestos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCobroPuestos.Location = new System.Drawing.Point(100, 317);
			this.btnCobroPuestos.Margin = new System.Windows.Forms.Padding(2);
			this.btnCobroPuestos.Name = "btnCobroPuestos";
			this.btnCobroPuestos.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.btnCobroPuestos.Size = new System.Drawing.Size(158, 41);
			this.btnCobroPuestos.TabIndex = 6;
			this.btnCobroPuestos.Text = "Generar";
			this.btnCobroPuestos.UseVisualStyleBackColor = false;
			this.btnCobroPuestos.Click += new System.EventHandler(this.btnCobroPuestos_Click);
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.tabRepGeneral);
			this.tabGeneral.Controls.Add(this.tabRepCobroPuesto);
			this.tabGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabGeneral.Location = new System.Drawing.Point(0, 0);
			this.tabGeneral.Margin = new System.Windows.Forms.Padding(2);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.SelectedIndex = 0;
			this.tabGeneral.Size = new System.Drawing.Size(374, 418);
			this.tabGeneral.TabIndex = 1;
			// 
			// tabRepGeneral
			// 
			this.tabRepGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.tabRepGeneral.Controls.Add(this.chkRangoFechas);
			this.tabRepGeneral.Controls.Add(this.lblGeneralStart);
			this.tabRepGeneral.Controls.Add(this.GeneralStartDate);
			this.tabRepGeneral.Controls.Add(this.lblGeneralEnd);
			this.tabRepGeneral.Controls.Add(this.GeneralEndDate);
			this.tabRepGeneral.Controls.Add(this.chkProyectoGeneral);
			this.tabRepGeneral.Controls.Add(this.cmbProyectoGeneral);
			this.tabRepGeneral.Controls.Add(this.label1);
			this.tabRepGeneral.Controls.Add(this.btnRepGeneral);
			this.tabRepGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabRepGeneral.Margin = new System.Windows.Forms.Padding(2);
			this.tabRepGeneral.Name = "tabRepGeneral";
			this.tabRepGeneral.Padding = new System.Windows.Forms.Padding(2);
			this.tabRepGeneral.Size = new System.Drawing.Size(366, 392);
			this.tabRepGeneral.TabIndex = 1;
			this.tabRepGeneral.Text = "General";
			// 
			// chkRangoFechas
			// 
			this.chkRangoFechas.AutoSize = true;
			this.chkRangoFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkRangoFechas.ForeColor = System.Drawing.Color.White;
			this.chkRangoFechas.Location = new System.Drawing.Point(16, 74);
			this.chkRangoFechas.Margin = new System.Windows.Forms.Padding(2);
			this.chkRangoFechas.Name = "chkRangoFechas";
			this.chkRangoFechas.Size = new System.Drawing.Size(155, 21);
			this.chkRangoFechas.TabIndex = 9;
			this.chkRangoFechas.Text = "Rango de fechas:";
			this.chkRangoFechas.UseVisualStyleBackColor = true;
			this.chkRangoFechas.CheckedChanged += new System.EventHandler(this.chkRangoFechas_CheckedChanged);
			// 
			// lblGeneralStart
			// 
			this.lblGeneralStart.AutoSize = true;
			this.lblGeneralStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGeneralStart.ForeColor = System.Drawing.Color.White;
			this.lblGeneralStart.Location = new System.Drawing.Point(35, 122);
			this.lblGeneralStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblGeneralStart.Name = "lblGeneralStart";
			this.lblGeneralStart.Size = new System.Drawing.Size(63, 22);
			this.lblGeneralStart.TabIndex = 5;
			this.lblGeneralStart.Text = "Inicio:";
			this.lblGeneralStart.Visible = false;
			// 
			// GeneralStartDate
			// 
			this.GeneralStartDate.CustomFormat = "yyyy-MM-dd";
			this.GeneralStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GeneralStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.GeneralStartDate.Location = new System.Drawing.Point(162, 117);
			this.GeneralStartDate.Margin = new System.Windows.Forms.Padding(2);
			this.GeneralStartDate.Name = "GeneralStartDate";
			this.GeneralStartDate.Size = new System.Drawing.Size(117, 26);
			this.GeneralStartDate.TabIndex = 7;
			this.GeneralStartDate.Visible = false;
			// 
			// lblGeneralEnd
			// 
			this.lblGeneralEnd.AutoSize = true;
			this.lblGeneralEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGeneralEnd.ForeColor = System.Drawing.Color.White;
			this.lblGeneralEnd.Location = new System.Drawing.Point(35, 170);
			this.lblGeneralEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblGeneralEnd.Name = "lblGeneralEnd";
			this.lblGeneralEnd.Size = new System.Drawing.Size(38, 22);
			this.lblGeneralEnd.TabIndex = 6;
			this.lblGeneralEnd.Text = "Fin";
			this.lblGeneralEnd.Visible = false;
			// 
			// GeneralEndDate
			// 
			this.GeneralEndDate.CustomFormat = "yyyy-MM-dd";
			this.GeneralEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GeneralEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.GeneralEndDate.Location = new System.Drawing.Point(162, 165);
			this.GeneralEndDate.Margin = new System.Windows.Forms.Padding(2);
			this.GeneralEndDate.Name = "GeneralEndDate";
			this.GeneralEndDate.Size = new System.Drawing.Size(117, 26);
			this.GeneralEndDate.TabIndex = 8;
			this.GeneralEndDate.Visible = false;
			// 
			// chkProyectoGeneral
			// 
			this.chkProyectoGeneral.AutoSize = true;
			this.chkProyectoGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkProyectoGeneral.ForeColor = System.Drawing.Color.White;
			this.chkProyectoGeneral.Location = new System.Drawing.Point(16, 238);
			this.chkProyectoGeneral.Margin = new System.Windows.Forms.Padding(2);
			this.chkProyectoGeneral.Name = "chkProyectoGeneral";
			this.chkProyectoGeneral.Size = new System.Drawing.Size(125, 21);
			this.chkProyectoGeneral.TabIndex = 2;
			this.chkProyectoGeneral.Text = "Por proyecto:";
			this.chkProyectoGeneral.UseVisualStyleBackColor = true;
			this.chkProyectoGeneral.CheckedChanged += new System.EventHandler(this.chkProyectoGeneral_CheckedChanged);
			// 
			// cmbProyectoGeneral
			// 
			this.cmbProyectoGeneral.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProyectoGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.cmbProyectoGeneral.FormattingEnabled = true;
			this.cmbProyectoGeneral.ItemHeight = 17;
			this.cmbProyectoGeneral.Location = new System.Drawing.Point(162, 236);
			this.cmbProyectoGeneral.Margin = new System.Windows.Forms.Padding(2);
			this.cmbProyectoGeneral.Name = "cmbProyectoGeneral";
			this.cmbProyectoGeneral.Size = new System.Drawing.Size(197, 25);
			this.cmbProyectoGeneral.TabIndex = 3;
			this.cmbProyectoGeneral.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(64, 20);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "INFORME GENERAL";
			// 
			// btnRepGeneral
			// 
			this.btnRepGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
			this.btnRepGeneral.FlatAppearance.BorderSize = 0;
			this.btnRepGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
			this.btnRepGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRepGeneral.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRepGeneral.ForeColor = System.Drawing.Color.White;
			this.btnRepGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRepGeneral.Location = new System.Drawing.Point(105, 304);
			this.btnRepGeneral.Margin = new System.Windows.Forms.Padding(2);
			this.btnRepGeneral.Name = "btnRepGeneral";
			this.btnRepGeneral.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.btnRepGeneral.Size = new System.Drawing.Size(158, 41);
			this.btnRepGeneral.TabIndex = 4;
			this.btnRepGeneral.Text = "Generar";
			this.btnRepGeneral.UseVisualStyleBackColor = false;
			this.btnRepGeneral.Click += new System.EventHandler(this.btnRepGeneral_Click);
			// 
			// Empleados
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(374, 418);
			this.Controls.Add(this.tabGeneral);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Empleados";
			this.Text = "Empleados";
			this.tabRepCobroPuesto.ResumeLayout(false);
			this.tabRepCobroPuesto.PerformLayout();
			this.tabGeneral.ResumeLayout(false);
			this.tabRepGeneral.ResumeLayout(false);
			this.tabRepGeneral.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage tabRepCobroPuesto;
		public System.Windows.Forms.ComboBox cmbProyecto;
		private System.Windows.Forms.Label lblEnd;
		private System.Windows.Forms.DateTimePicker DateEnd;
		private System.Windows.Forms.Button btnCobroPuestos;
		private System.Windows.Forms.TabControl tabGeneral;
		private System.Windows.Forms.TabPage tabRepGeneral;
		private System.Windows.Forms.Button btnRepGeneral;
		private System.Windows.Forms.Label lblInicio;
		private System.Windows.Forms.DateTimePicker DateStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox chkProyectoGeneral;
		public System.Windows.Forms.ComboBox cmbProyectoGeneral;
		private System.Windows.Forms.CheckBox chkRangoFechas;
		private System.Windows.Forms.Label lblGeneralStart;
		private System.Windows.Forms.DateTimePicker GeneralStartDate;
		private System.Windows.Forms.Label lblGeneralEnd;
		private System.Windows.Forms.DateTimePicker GeneralEndDate;
	}
}