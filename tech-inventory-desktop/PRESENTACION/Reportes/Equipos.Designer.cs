namespace PRESENTACION.Reportes
{
	partial class Equipos
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Equipos));
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
			this.lblInicio = new System.Windows.Forms.Label();
			this.btnRepGeneral = new System.Windows.Forms.Button();
			this.tabMovimientos = new System.Windows.Forms.TabPage();
			this.chkMovimientoRangoFechas = new System.Windows.Forms.CheckBox();
			this.lblMovimientoStartDate = new System.Windows.Forms.Label();
			this.MovimientoStartDate = new System.Windows.Forms.DateTimePicker();
			this.lblMovimientoEndDate = new System.Windows.Forms.Label();
			this.MovimientoEndDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRepMovimientos = new System.Windows.Forms.Button();
			this.tabFacturacion = new System.Windows.Forms.TabPage();
			this.label4 = new System.Windows.Forms.Label();
			this.DateStart = new System.Windows.Forms.DateTimePicker();
			this.lblEnd = new System.Windows.Forms.Label();
			this.DateEnd = new System.Windows.Forms.DateTimePicker();
			this.label3 = new System.Windows.Forms.Label();
			this.btnCruceFacturacion = new System.Windows.Forms.Button();
			this.tabCobroPuestos = new System.Windows.Forms.TabPage();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.DateStartRep = new System.Windows.Forms.DateTimePicker();
			this.cmbProyecto = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.DateEndRep = new System.Windows.Forms.DateTimePicker();
			this.btnCobroPuestos = new System.Windows.Forms.Button();
			this.tabGeneral.SuspendLayout();
			this.tabRepGeneral.SuspendLayout();
			this.tabMovimientos.SuspendLayout();
			this.tabFacturacion.SuspendLayout();
			this.tabCobroPuestos.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabGeneral
			// 
			this.tabGeneral.Controls.Add(this.tabRepGeneral);
			this.tabGeneral.Controls.Add(this.tabMovimientos);
			this.tabGeneral.Controls.Add(this.tabFacturacion);
			this.tabGeneral.Controls.Add(this.tabCobroPuestos);
			this.tabGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabGeneral.Location = new System.Drawing.Point(0, 0);
			this.tabGeneral.Margin = new System.Windows.Forms.Padding(2);
			this.tabGeneral.Name = "tabGeneral";
			this.tabGeneral.SelectedIndex = 0;
			this.tabGeneral.Size = new System.Drawing.Size(411, 429);
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
			this.tabRepGeneral.Controls.Add(this.lblInicio);
			this.tabRepGeneral.Controls.Add(this.btnRepGeneral);
			this.tabRepGeneral.Location = new System.Drawing.Point(4, 22);
			this.tabRepGeneral.Margin = new System.Windows.Forms.Padding(2);
			this.tabRepGeneral.Name = "tabRepGeneral";
			this.tabRepGeneral.Padding = new System.Windows.Forms.Padding(2);
			this.tabRepGeneral.Size = new System.Drawing.Size(403, 403);
			this.tabRepGeneral.TabIndex = 1;
			this.tabRepGeneral.Text = "General";
			// 
			// chkRangoFechas
			// 
			this.chkRangoFechas.AutoSize = true;
			this.chkRangoFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkRangoFechas.ForeColor = System.Drawing.Color.White;
			this.chkRangoFechas.Location = new System.Drawing.Point(32, 89);
			this.chkRangoFechas.Margin = new System.Windows.Forms.Padding(2);
			this.chkRangoFechas.Name = "chkRangoFechas";
			this.chkRangoFechas.Size = new System.Drawing.Size(155, 21);
			this.chkRangoFechas.TabIndex = 63;
			this.chkRangoFechas.Text = "Rango de fechas:";
			this.chkRangoFechas.UseVisualStyleBackColor = true;
			this.chkRangoFechas.CheckedChanged += new System.EventHandler(this.chkRangoFechas_CheckedChanged);
			// 
			// lblGeneralStart
			// 
			this.lblGeneralStart.AutoSize = true;
			this.lblGeneralStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGeneralStart.ForeColor = System.Drawing.Color.White;
			this.lblGeneralStart.Location = new System.Drawing.Point(51, 137);
			this.lblGeneralStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblGeneralStart.Name = "lblGeneralStart";
			this.lblGeneralStart.Size = new System.Drawing.Size(63, 22);
			this.lblGeneralStart.TabIndex = 59;
			this.lblGeneralStart.Text = "Inicio:";
			this.lblGeneralStart.Visible = false;
			// 
			// GeneralStartDate
			// 
			this.GeneralStartDate.CustomFormat = "yyyy-MM-dd";
			this.GeneralStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GeneralStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.GeneralStartDate.Location = new System.Drawing.Point(178, 132);
			this.GeneralStartDate.Margin = new System.Windows.Forms.Padding(2);
			this.GeneralStartDate.Name = "GeneralStartDate";
			this.GeneralStartDate.Size = new System.Drawing.Size(117, 26);
			this.GeneralStartDate.TabIndex = 61;
			this.GeneralStartDate.Visible = false;
			// 
			// lblGeneralEnd
			// 
			this.lblGeneralEnd.AutoSize = true;
			this.lblGeneralEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblGeneralEnd.ForeColor = System.Drawing.Color.White;
			this.lblGeneralEnd.Location = new System.Drawing.Point(51, 185);
			this.lblGeneralEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblGeneralEnd.Name = "lblGeneralEnd";
			this.lblGeneralEnd.Size = new System.Drawing.Size(38, 22);
			this.lblGeneralEnd.TabIndex = 60;
			this.lblGeneralEnd.Text = "Fin";
			this.lblGeneralEnd.Visible = false;
			// 
			// GeneralEndDate
			// 
			this.GeneralEndDate.CustomFormat = "yyyy-MM-dd";
			this.GeneralEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GeneralEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.GeneralEndDate.Location = new System.Drawing.Point(178, 180);
			this.GeneralEndDate.Margin = new System.Windows.Forms.Padding(2);
			this.GeneralEndDate.Name = "GeneralEndDate";
			this.GeneralEndDate.Size = new System.Drawing.Size(117, 26);
			this.GeneralEndDate.TabIndex = 62;
			this.GeneralEndDate.Visible = false;
			// 
			// chkProyectoGeneral
			// 
			this.chkProyectoGeneral.AutoSize = true;
			this.chkProyectoGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkProyectoGeneral.ForeColor = System.Drawing.Color.White;
			this.chkProyectoGeneral.Location = new System.Drawing.Point(32, 253);
			this.chkProyectoGeneral.Margin = new System.Windows.Forms.Padding(2);
			this.chkProyectoGeneral.Name = "chkProyectoGeneral";
			this.chkProyectoGeneral.Size = new System.Drawing.Size(125, 21);
			this.chkProyectoGeneral.TabIndex = 57;
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
			this.cmbProyectoGeneral.Location = new System.Drawing.Point(178, 251);
			this.cmbProyectoGeneral.Margin = new System.Windows.Forms.Padding(2);
			this.cmbProyectoGeneral.Name = "cmbProyectoGeneral";
			this.cmbProyectoGeneral.Size = new System.Drawing.Size(197, 25);
			this.cmbProyectoGeneral.TabIndex = 58;
			this.cmbProyectoGeneral.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(80, 50);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(240, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "INFORME GENERAL";
			// 
			// lblInicio
			// 
			this.lblInicio.AutoSize = true;
			this.lblInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblInicio.ForeColor = System.Drawing.Color.White;
			this.lblInicio.Location = new System.Drawing.Point(89, 37);
			this.lblInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblInicio.Name = "lblInicio";
			this.lblInicio.Size = new System.Drawing.Size(0, 26);
			this.lblInicio.TabIndex = 56;
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
			this.btnRepGeneral.Location = new System.Drawing.Point(120, 330);
			this.btnRepGeneral.Margin = new System.Windows.Forms.Padding(2);
			this.btnRepGeneral.Name = "btnRepGeneral";
			this.btnRepGeneral.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.btnRepGeneral.Size = new System.Drawing.Size(158, 41);
			this.btnRepGeneral.TabIndex = 2;
			this.btnRepGeneral.Text = "Generar";
			this.btnRepGeneral.UseVisualStyleBackColor = false;
			this.btnRepGeneral.Click += new System.EventHandler(this.btnRepGeneral_Click);
			// 
			// tabMovimientos
			// 
			this.tabMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.tabMovimientos.Controls.Add(this.chkMovimientoRangoFechas);
			this.tabMovimientos.Controls.Add(this.lblMovimientoStartDate);
			this.tabMovimientos.Controls.Add(this.MovimientoStartDate);
			this.tabMovimientos.Controls.Add(this.lblMovimientoEndDate);
			this.tabMovimientos.Controls.Add(this.MovimientoEndDate);
			this.tabMovimientos.Controls.Add(this.label2);
			this.tabMovimientos.Controls.Add(this.btnRepMovimientos);
			this.tabMovimientos.Location = new System.Drawing.Point(4, 22);
			this.tabMovimientos.Margin = new System.Windows.Forms.Padding(2);
			this.tabMovimientos.Name = "tabMovimientos";
			this.tabMovimientos.Padding = new System.Windows.Forms.Padding(2);
			this.tabMovimientos.Size = new System.Drawing.Size(403, 403);
			this.tabMovimientos.TabIndex = 2;
			this.tabMovimientos.Text = "Movimientos";
			// 
			// chkMovimientoRangoFechas
			// 
			this.chkMovimientoRangoFechas.AutoSize = true;
			this.chkMovimientoRangoFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chkMovimientoRangoFechas.ForeColor = System.Drawing.Color.White;
			this.chkMovimientoRangoFechas.Location = new System.Drawing.Point(47, 106);
			this.chkMovimientoRangoFechas.Margin = new System.Windows.Forms.Padding(2);
			this.chkMovimientoRangoFechas.Name = "chkMovimientoRangoFechas";
			this.chkMovimientoRangoFechas.Size = new System.Drawing.Size(155, 21);
			this.chkMovimientoRangoFechas.TabIndex = 68;
			this.chkMovimientoRangoFechas.Text = "Rango de fechas:";
			this.chkMovimientoRangoFechas.UseVisualStyleBackColor = true;
			this.chkMovimientoRangoFechas.CheckedChanged += new System.EventHandler(this.chkMovimientoRangoFechas_CheckedChanged);
			// 
			// lblMovimientoStartDate
			// 
			this.lblMovimientoStartDate.AutoSize = true;
			this.lblMovimientoStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMovimientoStartDate.ForeColor = System.Drawing.Color.White;
			this.lblMovimientoStartDate.Location = new System.Drawing.Point(66, 154);
			this.lblMovimientoStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMovimientoStartDate.Name = "lblMovimientoStartDate";
			this.lblMovimientoStartDate.Size = new System.Drawing.Size(63, 22);
			this.lblMovimientoStartDate.TabIndex = 64;
			this.lblMovimientoStartDate.Text = "Inicio:";
			this.lblMovimientoStartDate.Visible = false;
			// 
			// MovimientoStartDate
			// 
			this.MovimientoStartDate.CustomFormat = "yyyy-MM-dd";
			this.MovimientoStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MovimientoStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.MovimientoStartDate.Location = new System.Drawing.Point(193, 149);
			this.MovimientoStartDate.Margin = new System.Windows.Forms.Padding(2);
			this.MovimientoStartDate.Name = "MovimientoStartDate";
			this.MovimientoStartDate.Size = new System.Drawing.Size(117, 26);
			this.MovimientoStartDate.TabIndex = 66;
			this.MovimientoStartDate.Visible = false;
			// 
			// lblMovimientoEndDate
			// 
			this.lblMovimientoEndDate.AutoSize = true;
			this.lblMovimientoEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMovimientoEndDate.ForeColor = System.Drawing.Color.White;
			this.lblMovimientoEndDate.Location = new System.Drawing.Point(66, 202);
			this.lblMovimientoEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lblMovimientoEndDate.Name = "lblMovimientoEndDate";
			this.lblMovimientoEndDate.Size = new System.Drawing.Size(38, 22);
			this.lblMovimientoEndDate.TabIndex = 65;
			this.lblMovimientoEndDate.Text = "Fin";
			this.lblMovimientoEndDate.Visible = false;
			// 
			// MovimientoEndDate
			// 
			this.MovimientoEndDate.CustomFormat = "yyyy-MM-dd";
			this.MovimientoEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MovimientoEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.MovimientoEndDate.Location = new System.Drawing.Point(193, 197);
			this.MovimientoEndDate.Margin = new System.Windows.Forms.Padding(2);
			this.MovimientoEndDate.Name = "MovimientoEndDate";
			this.MovimientoEndDate.Size = new System.Drawing.Size(117, 26);
			this.MovimientoEndDate.TabIndex = 67;
			this.MovimientoEndDate.Visible = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(107, 50);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(185, 26);
			this.label2.TabIndex = 0;
			this.label2.Text = "MOVIMIENTOS ";
			// 
			// btnRepMovimientos
			// 
			this.btnRepMovimientos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
			this.btnRepMovimientos.FlatAppearance.BorderSize = 0;
			this.btnRepMovimientos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
			this.btnRepMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRepMovimientos.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRepMovimientos.ForeColor = System.Drawing.Color.White;
			this.btnRepMovimientos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRepMovimientos.Location = new System.Drawing.Point(118, 330);
			this.btnRepMovimientos.Margin = new System.Windows.Forms.Padding(2);
			this.btnRepMovimientos.Name = "btnRepMovimientos";
			this.btnRepMovimientos.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.btnRepMovimientos.Size = new System.Drawing.Size(158, 41);
			this.btnRepMovimientos.TabIndex = 2;
			this.btnRepMovimientos.Text = "Generar";
			this.btnRepMovimientos.UseVisualStyleBackColor = false;
			this.btnRepMovimientos.Click += new System.EventHandler(this.btnRepMovimientos_Click);
			// 
			// tabFacturacion
			// 
			this.tabFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.tabFacturacion.Controls.Add(this.label4);
			this.tabFacturacion.Controls.Add(this.DateStart);
			this.tabFacturacion.Controls.Add(this.lblEnd);
			this.tabFacturacion.Controls.Add(this.DateEnd);
			this.tabFacturacion.Controls.Add(this.label3);
			this.tabFacturacion.Controls.Add(this.btnCruceFacturacion);
			this.tabFacturacion.Location = new System.Drawing.Point(4, 22);
			this.tabFacturacion.Margin = new System.Windows.Forms.Padding(2);
			this.tabFacturacion.Name = "tabFacturacion";
			this.tabFacturacion.Padding = new System.Windows.Forms.Padding(2);
			this.tabFacturacion.Size = new System.Drawing.Size(403, 403);
			this.tabFacturacion.TabIndex = 3;
			this.tabFacturacion.Text = "Cruce facturación";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(50, 109);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 22);
			this.label4.TabIndex = 0;
			this.label4.Text = "Inicio de cobro:";
			// 
			// DateStart
			// 
			this.DateStart.CustomFormat = "yyyy-MM-dd";
			this.DateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateStart.Location = new System.Drawing.Point(225, 109);
			this.DateStart.Margin = new System.Windows.Forms.Padding(2);
			this.DateStart.Name = "DateStart";
			this.DateStart.Size = new System.Drawing.Size(117, 26);
			this.DateStart.TabIndex = 2;
			// 
			// lblEnd
			// 
			this.lblEnd.AutoSize = true;
			this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblEnd.ForeColor = System.Drawing.Color.White;
			this.lblEnd.Location = new System.Drawing.Point(50, 157);
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
			this.DateEnd.Location = new System.Drawing.Point(225, 157);
			this.DateEnd.Margin = new System.Windows.Forms.Padding(2);
			this.DateEnd.Name = "DateEnd";
			this.DateEnd.Size = new System.Drawing.Size(117, 26);
			this.DateEnd.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(57, 50);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(312, 26);
			this.label3.TabIndex = 0;
			this.label3.Text = "CRUCE DE FACTURACIÓN";
			// 
			// btnCruceFacturacion
			// 
			this.btnCruceFacturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(95)))));
			this.btnCruceFacturacion.FlatAppearance.BorderSize = 0;
			this.btnCruceFacturacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
			this.btnCruceFacturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCruceFacturacion.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCruceFacturacion.ForeColor = System.Drawing.Color.White;
			this.btnCruceFacturacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCruceFacturacion.Location = new System.Drawing.Point(118, 330);
			this.btnCruceFacturacion.Margin = new System.Windows.Forms.Padding(2);
			this.btnCruceFacturacion.Name = "btnCruceFacturacion";
			this.btnCruceFacturacion.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.btnCruceFacturacion.Size = new System.Drawing.Size(158, 41);
			this.btnCruceFacturacion.TabIndex = 4;
			this.btnCruceFacturacion.Text = "Generar";
			this.btnCruceFacturacion.UseVisualStyleBackColor = false;
			this.btnCruceFacturacion.Click += new System.EventHandler(this.btnCruceFacturacion_Click);
			// 
			// tabCobroPuestos
			// 
			this.tabCobroPuestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.tabCobroPuestos.Controls.Add(this.label7);
			this.tabCobroPuestos.Controls.Add(this.label5);
			this.tabCobroPuestos.Controls.Add(this.DateStartRep);
			this.tabCobroPuestos.Controls.Add(this.cmbProyecto);
			this.tabCobroPuestos.Controls.Add(this.label6);
			this.tabCobroPuestos.Controls.Add(this.DateEndRep);
			this.tabCobroPuestos.Controls.Add(this.btnCobroPuestos);
			this.tabCobroPuestos.Location = new System.Drawing.Point(4, 22);
			this.tabCobroPuestos.Name = "tabCobroPuestos";
			this.tabCobroPuestos.Padding = new System.Windows.Forms.Padding(3);
			this.tabCobroPuestos.Size = new System.Drawing.Size(403, 403);
			this.tabCobroPuestos.TabIndex = 4;
			this.tabCobroPuestos.Text = "Cobro de puestos";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(80, 50);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(257, 26);
			this.label7.TabIndex = 13;
			this.label7.Text = "COBRO DE PUESTOS";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(50, 109);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(147, 22);
			this.label5.TabIndex = 7;
			this.label5.Text = "Inicio de cobro:";
			// 
			// DateStartRep
			// 
			this.DateStartRep.CustomFormat = "yyyy-MM-dd";
			this.DateStartRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateStartRep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateStartRep.Location = new System.Drawing.Point(225, 109);
			this.DateStartRep.Margin = new System.Windows.Forms.Padding(2);
			this.DateStartRep.Name = "DateStartRep";
			this.DateStartRep.Size = new System.Drawing.Size(117, 26);
			this.DateStartRep.TabIndex = 9;
			// 
			// cmbProyecto
			// 
			this.cmbProyecto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProyecto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.cmbProyecto.FormattingEnabled = true;
			this.cmbProyecto.Location = new System.Drawing.Point(95, 230);
			this.cmbProyecto.Margin = new System.Windows.Forms.Padding(2);
			this.cmbProyecto.Name = "cmbProyecto";
			this.cmbProyecto.Size = new System.Drawing.Size(197, 25);
			this.cmbProyecto.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(50, 157);
			this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(128, 22);
			this.label6.TabIndex = 8;
			this.label6.Text = "Fin de cobro:";
			// 
			// DateEndRep
			// 
			this.DateEndRep.CustomFormat = "yyyy-MM-dd";
			this.DateEndRep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateEndRep.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateEndRep.Location = new System.Drawing.Point(225, 157);
			this.DateEndRep.Margin = new System.Windows.Forms.Padding(2);
			this.DateEndRep.Name = "DateEndRep";
			this.DateEndRep.Size = new System.Drawing.Size(117, 26);
			this.DateEndRep.TabIndex = 10;
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
			this.btnCobroPuestos.Location = new System.Drawing.Point(120, 330);
			this.btnCobroPuestos.Margin = new System.Windows.Forms.Padding(2);
			this.btnCobroPuestos.Name = "btnCobroPuestos";
			this.btnCobroPuestos.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
			this.btnCobroPuestos.Size = new System.Drawing.Size(158, 41);
			this.btnCobroPuestos.TabIndex = 12;
			this.btnCobroPuestos.Text = "Generar";
			this.btnCobroPuestos.UseVisualStyleBackColor = false;
			this.btnCobroPuestos.Click += new System.EventHandler(this.btnCobroPuestos_Click);
			// 
			// Equipos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
			this.ClientSize = new System.Drawing.Size(411, 429);
			this.Controls.Add(this.tabGeneral);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Equipos";
			this.Text = "Equipos";
			this.tabGeneral.ResumeLayout(false);
			this.tabRepGeneral.ResumeLayout(false);
			this.tabRepGeneral.PerformLayout();
			this.tabMovimientos.ResumeLayout(false);
			this.tabMovimientos.PerformLayout();
			this.tabFacturacion.ResumeLayout(false);
			this.tabFacturacion.PerformLayout();
			this.tabCobroPuestos.ResumeLayout(false);
			this.tabCobroPuestos.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabGeneral;
		private System.Windows.Forms.TabPage tabRepGeneral;
		private System.Windows.Forms.Label lblInicio;
		private System.Windows.Forms.Button btnRepGeneral;
		private System.Windows.Forms.TabPage tabMovimientos;
		private System.Windows.Forms.Button btnRepMovimientos;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage tabFacturacion;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnCruceFacturacion;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker DateStart;
		private System.Windows.Forms.Label lblEnd;
		private System.Windows.Forms.DateTimePicker DateEnd;
		private System.Windows.Forms.TabPage tabCobroPuestos;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker DateStartRep;
		public System.Windows.Forms.ComboBox cmbProyecto;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DateTimePicker DateEndRep;
		private System.Windows.Forms.Button btnCobroPuestos;
		private System.Windows.Forms.CheckBox chkRangoFechas;
		private System.Windows.Forms.Label lblGeneralStart;
		private System.Windows.Forms.DateTimePicker GeneralStartDate;
		private System.Windows.Forms.Label lblGeneralEnd;
		private System.Windows.Forms.DateTimePicker GeneralEndDate;
		private System.Windows.Forms.CheckBox chkProyectoGeneral;
		public System.Windows.Forms.ComboBox cmbProyectoGeneral;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.CheckBox chkMovimientoRangoFechas;
		private System.Windows.Forms.Label lblMovimientoStartDate;
		private System.Windows.Forms.DateTimePicker MovimientoStartDate;
		private System.Windows.Forms.Label lblMovimientoEndDate;
		private System.Windows.Forms.DateTimePicker MovimientoEndDate;
	}
}