namespace PRESENTACION.Empleados
{
	partial class Gestionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.GroupOptButton = new System.Windows.Forms.GroupBox();
            this.rbtnIngreso = new System.Windows.Forms.RadioButton();
            this.rbtnSalida = new System.Windows.Forms.RadioButton();
            this.rbtnSede = new System.Windows.Forms.RadioButton();
            this.rbtnProyecto = new System.Windows.Forms.RadioButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.tblEmployesFilter = new Zuby.ADGV.AdvancedDataGridView();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROYECTO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROYECTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEDE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBICACION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBICACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO_N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMP_CORREO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAMODIFI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUMODIFI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TECLADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MOUSE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BASE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MALETIN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MORRAL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CORREO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.pnlButton.SuspendLayout();
            this.GroupOptButton.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployesFilter)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnImport);
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Controls.Add(this.btnUpdate);
            this.pnlButton.Controls.Add(this.btnDelete);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 516);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1152, 117);
            this.pnlButton.TabIndex = 24;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.btnImport.FlatAppearance.BorderSize = 0;
            this.btnImport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.ForeColor = System.Drawing.Color.White;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnImport.Location = new System.Drawing.Point(144, 18);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnImport.Size = new System.Drawing.Size(94, 81);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "Importar";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.Location = new System.Drawing.Point(35, 18);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnNew.Size = new System.Drawing.Size(94, 81);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Agregar";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpdate.Location = new System.Drawing.Point(364, 18);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnUpdate.Size = new System.Drawing.Size(94, 81);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDelete.Location = new System.Drawing.Point(255, 18);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnDelete.Size = new System.Drawing.Size(94, 81);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Borrar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(679, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 32);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSearch.Location = new System.Drawing.Point(431, 13);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 23);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.Text = "BUSCAR";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // GroupOptButton
            // 
            this.GroupOptButton.Controls.Add(this.rbtnIngreso);
            this.GroupOptButton.Controls.Add(this.rbtnSalida);
            this.GroupOptButton.Controls.Add(this.rbtnSede);
            this.GroupOptButton.Controls.Add(this.rbtnProyecto);
            this.GroupOptButton.Controls.Add(this.lblFilter);
            this.GroupOptButton.Controls.Add(this.rbtnName);
            this.GroupOptButton.Controls.Add(this.rbtnId);
            this.GroupOptButton.Location = new System.Drawing.Point(35, 2);
            this.GroupOptButton.Margin = new System.Windows.Forms.Padding(2);
            this.GroupOptButton.Name = "GroupOptButton";
            this.GroupOptButton.Padding = new System.Windows.Forms.Padding(2);
            this.GroupOptButton.Size = new System.Drawing.Size(358, 75);
            this.GroupOptButton.TabIndex = 22;
            this.GroupOptButton.TabStop = false;
            // 
            // rbtnIngreso
            // 
            this.rbtnIngreso.AutoSize = true;
            this.rbtnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIngreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnIngreso.Location = new System.Drawing.Point(232, 21);
            this.rbtnIngreso.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnIngreso.Name = "rbtnIngreso";
            this.rbtnIngreso.Size = new System.Drawing.Size(73, 21);
            this.rbtnIngreso.TabIndex = 15;
            this.rbtnIngreso.Text = "Ingreso";
            this.rbtnIngreso.UseVisualStyleBackColor = true;
            // 
            // rbtnSalida
            // 
            this.rbtnSalida.AutoSize = true;
            this.rbtnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSalida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnSalida.Location = new System.Drawing.Point(232, 46);
            this.rbtnSalida.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnSalida.Name = "rbtnSalida";
            this.rbtnSalida.Size = new System.Drawing.Size(65, 21);
            this.rbtnSalida.TabIndex = 14;
            this.rbtnSalida.Text = "Salida";
            this.rbtnSalida.UseVisualStyleBackColor = true;
            // 
            // rbtnSede
            // 
            this.rbtnSede.AutoSize = true;
            this.rbtnSede.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSede.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnSede.Location = new System.Drawing.Point(137, 21);
            this.rbtnSede.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnSede.Name = "rbtnSede";
            this.rbtnSede.Size = new System.Drawing.Size(59, 21);
            this.rbtnSede.TabIndex = 13;
            this.rbtnSede.Text = "Sede";
            this.rbtnSede.UseVisualStyleBackColor = true;
            // 
            // rbtnProyecto
            // 
            this.rbtnProyecto.AutoSize = true;
            this.rbtnProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnProyecto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnProyecto.Location = new System.Drawing.Point(137, 46);
            this.rbtnProyecto.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnProyecto.Name = "rbtnProyecto";
            this.rbtnProyecto.Size = new System.Drawing.Size(82, 21);
            this.rbtnProyecto.TabIndex = 12;
            this.rbtnProyecto.Text = "Proyecto";
            this.rbtnProyecto.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFilter.Location = new System.Drawing.Point(-2, 2);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(81, 17);
            this.lblFilter.TabIndex = 11;
            this.lblFilter.Text = "Buscar por:";
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Checked = true;
            this.rbtnName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnName.Location = new System.Drawing.Point(19, 46);
            this.rbtnName.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(76, 21);
            this.rbtnName.TabIndex = 1;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "Nombre";
            this.rbtnName.UseVisualStyleBackColor = true;
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnId.Location = new System.Drawing.Point(19, 21);
            this.rbtnId.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(98, 21);
            this.rbtnId.TabIndex = 0;
            this.rbtnId.Text = "Documento";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.lblTotalRows);
            this.pnlContainer.Controls.Add(this.tblEmployesFilter);
            this.pnlContainer.Controls.Add(this.btnSearch);
            this.pnlContainer.Controls.Add(this.GroupOptButton);
            this.pnlContainer.Controls.Add(this.txtSearch);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1152, 516);
            this.pnlContainer.TabIndex = 27;
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRows.ForeColor = System.Drawing.Color.White;
            this.lblTotalRows.Location = new System.Drawing.Point(427, 57);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(89, 20);
            this.lblTotalRows.TabIndex = 72;
            this.lblTotalRows.Text = "totalRows";
            // 
            // tblEmployesFilter
            // 
            this.tblEmployesFilter.AllowUserToAddRows = false;
            this.tblEmployesFilter.AllowUserToDeleteRows = false;
            this.tblEmployesFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEmployesFilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblEmployesFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.tblEmployesFilter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblEmployesFilter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblEmployesFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEmployesFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOCUMENTO,
            this.CODIGO,
            this.NOMBRE1,
            this.NOMBRE2,
            this.APELLIDO1,
            this.APELLIDO2,
            this.NOMBRES,
            this.PROYECTO_ID,
            this.PROYECTO,
            this.SEDE_ID,
            this.SEDE,
            this.UBICACION_ID,
            this.UBICACION,
            this.PUESTO_N,
            this.EMP_CORREO,
            this.TELEFONO,
            this.INGRESO,
            this.SALIDA,
            this.OBSERVACION,
            this.FECHAMODIFI,
            this.USUMODIFI,
            this.TECLADO,
            this.MOUSE,
            this.PUESTO,
            this.BASE,
            this.MALETIN,
            this.MORRAL,
            this.CORREO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblEmployesFilter.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblEmployesFilter.EnableHeadersVisualStyles = false;
            this.tblEmployesFilter.FilterAndSortEnabled = true;
            this.tblEmployesFilter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.tblEmployesFilter.Location = new System.Drawing.Point(10, 91);
            this.tblEmployesFilter.Name = "tblEmployesFilter";
            this.tblEmployesFilter.ReadOnly = true;
            this.tblEmployesFilter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblEmployesFilter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblEmployesFilter.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.tblEmployesFilter.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblEmployesFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblEmployesFilter.Size = new System.Drawing.Size(1125, 401);
            this.tblEmployesFilter.TabIndex = 26;
            this.tblEmployesFilter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblEmployesFilter_CellDoubleClick);
            // 
            // DOCUMENTO
            // 
            this.DOCUMENTO.DataPropertyName = "DOCUMENTO";
            this.DOCUMENTO.HeaderText = "DOCUMENTO";
            this.DOCUMENTO.MinimumWidth = 22;
            this.DOCUMENTO.Name = "DOCUMENTO";
            this.DOCUMENTO.ReadOnly = true;
            this.DOCUMENTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.MinimumWidth = 22;
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // NOMBRE1
            // 
            this.NOMBRE1.DataPropertyName = "NOMBRE1";
            this.NOMBRE1.HeaderText = "NOMBRE1";
            this.NOMBRE1.MinimumWidth = 22;
            this.NOMBRE1.Name = "NOMBRE1";
            this.NOMBRE1.ReadOnly = true;
            this.NOMBRE1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NOMBRE1.Visible = false;
            // 
            // NOMBRE2
            // 
            this.NOMBRE2.DataPropertyName = "NOMBRE2";
            this.NOMBRE2.HeaderText = "NOMBRE2";
            this.NOMBRE2.MinimumWidth = 22;
            this.NOMBRE2.Name = "NOMBRE2";
            this.NOMBRE2.ReadOnly = true;
            this.NOMBRE2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NOMBRE2.Visible = false;
            // 
            // APELLIDO1
            // 
            this.APELLIDO1.DataPropertyName = "APELLIDO1";
            this.APELLIDO1.HeaderText = "APELLIDO1";
            this.APELLIDO1.MinimumWidth = 22;
            this.APELLIDO1.Name = "APELLIDO1";
            this.APELLIDO1.ReadOnly = true;
            this.APELLIDO1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.APELLIDO1.Visible = false;
            // 
            // APELLIDO2
            // 
            this.APELLIDO2.DataPropertyName = "APELLIDO2";
            this.APELLIDO2.HeaderText = "APELLIDO2";
            this.APELLIDO2.MinimumWidth = 22;
            this.APELLIDO2.Name = "APELLIDO2";
            this.APELLIDO2.ReadOnly = true;
            this.APELLIDO2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.APELLIDO2.Visible = false;
            // 
            // NOMBRES
            // 
            this.NOMBRES.DataPropertyName = "NOMBRES";
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.MinimumWidth = 22;
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.ReadOnly = true;
            this.NOMBRES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PROYECTO_ID
            // 
            this.PROYECTO_ID.DataPropertyName = "PROYECTO_ID";
            this.PROYECTO_ID.HeaderText = "PROYECTO_ID";
            this.PROYECTO_ID.MinimumWidth = 22;
            this.PROYECTO_ID.Name = "PROYECTO_ID";
            this.PROYECTO_ID.ReadOnly = true;
            this.PROYECTO_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PROYECTO_ID.Visible = false;
            // 
            // PROYECTO
            // 
            this.PROYECTO.DataPropertyName = "PROYECTO";
            this.PROYECTO.HeaderText = "PROYECTO";
            this.PROYECTO.MinimumWidth = 22;
            this.PROYECTO.Name = "PROYECTO";
            this.PROYECTO.ReadOnly = true;
            this.PROYECTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // SEDE_ID
            // 
            this.SEDE_ID.DataPropertyName = "SEDE_ID";
            this.SEDE_ID.HeaderText = "SEDE_ID";
            this.SEDE_ID.MinimumWidth = 22;
            this.SEDE_ID.Name = "SEDE_ID";
            this.SEDE_ID.ReadOnly = true;
            this.SEDE_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.SEDE_ID.Visible = false;
            // 
            // SEDE
            // 
            this.SEDE.DataPropertyName = "SEDE";
            this.SEDE.HeaderText = "SEDE";
            this.SEDE.MinimumWidth = 22;
            this.SEDE.Name = "SEDE";
            this.SEDE.ReadOnly = true;
            this.SEDE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // UBICACION_ID
            // 
            this.UBICACION_ID.DataPropertyName = "UBICACION_ID";
            this.UBICACION_ID.HeaderText = "UBICACION_ID";
            this.UBICACION_ID.MinimumWidth = 22;
            this.UBICACION_ID.Name = "UBICACION_ID";
            this.UBICACION_ID.ReadOnly = true;
            this.UBICACION_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.UBICACION_ID.Visible = false;
            // 
            // UBICACION
            // 
            this.UBICACION.DataPropertyName = "UBICACION";
            this.UBICACION.HeaderText = "UBICACION";
            this.UBICACION.MinimumWidth = 22;
            this.UBICACION.Name = "UBICACION";
            this.UBICACION.ReadOnly = true;
            this.UBICACION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PUESTO_N
            // 
            this.PUESTO_N.DataPropertyName = "PUESTO_N";
            this.PUESTO_N.HeaderText = "PUESTO";
            this.PUESTO_N.MinimumWidth = 22;
            this.PUESTO_N.Name = "PUESTO_N";
            this.PUESTO_N.ReadOnly = true;
            this.PUESTO_N.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // EMP_CORREO
            // 
            this.EMP_CORREO.DataPropertyName = "EMP_CORREO";
            this.EMP_CORREO.HeaderText = "CORREO";
            this.EMP_CORREO.MinimumWidth = 22;
            this.EMP_CORREO.Name = "EMP_CORREO";
            this.EMP_CORREO.ReadOnly = true;
            this.EMP_CORREO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // TELEFONO
            // 
            this.TELEFONO.DataPropertyName = "TELEFONO";
            this.TELEFONO.HeaderText = "TELEFONO";
            this.TELEFONO.MinimumWidth = 22;
            this.TELEFONO.Name = "TELEFONO";
            this.TELEFONO.ReadOnly = true;
            this.TELEFONO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // INGRESO
            // 
            this.INGRESO.DataPropertyName = "INGRESO";
            this.INGRESO.HeaderText = "INGRESO";
            this.INGRESO.MinimumWidth = 22;
            this.INGRESO.Name = "INGRESO";
            this.INGRESO.ReadOnly = true;
            this.INGRESO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // SALIDA
            // 
            this.SALIDA.DataPropertyName = "SALIDA";
            this.SALIDA.HeaderText = "SALIDA";
            this.SALIDA.MinimumWidth = 22;
            this.SALIDA.Name = "SALIDA";
            this.SALIDA.ReadOnly = true;
            this.SALIDA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // OBSERVACION
            // 
            this.OBSERVACION.DataPropertyName = "OBSERVACION";
            this.OBSERVACION.HeaderText = "OBSERVACION";
            this.OBSERVACION.MinimumWidth = 22;
            this.OBSERVACION.Name = "OBSERVACION";
            this.OBSERVACION.ReadOnly = true;
            this.OBSERVACION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FECHAMODIFI
            // 
            this.FECHAMODIFI.DataPropertyName = "FECHAMODIFI";
            this.FECHAMODIFI.HeaderText = "FECHAMODIFI";
            this.FECHAMODIFI.MinimumWidth = 22;
            this.FECHAMODIFI.Name = "FECHAMODIFI";
            this.FECHAMODIFI.ReadOnly = true;
            this.FECHAMODIFI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.FECHAMODIFI.Visible = false;
            // 
            // USUMODIFI
            // 
            this.USUMODIFI.DataPropertyName = "USUMODIFI";
            this.USUMODIFI.HeaderText = "USUMODIFI";
            this.USUMODIFI.MinimumWidth = 22;
            this.USUMODIFI.Name = "USUMODIFI";
            this.USUMODIFI.ReadOnly = true;
            this.USUMODIFI.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.USUMODIFI.Visible = false;
            // 
            // TECLADO
            // 
            this.TECLADO.DataPropertyName = "TECLADO";
            this.TECLADO.HeaderText = "TECLADO";
            this.TECLADO.MinimumWidth = 22;
            this.TECLADO.Name = "TECLADO";
            this.TECLADO.ReadOnly = true;
            this.TECLADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.TECLADO.Visible = false;
            // 
            // MOUSE
            // 
            this.MOUSE.DataPropertyName = "MOUSE";
            this.MOUSE.HeaderText = "MOUSE";
            this.MOUSE.MinimumWidth = 22;
            this.MOUSE.Name = "MOUSE";
            this.MOUSE.ReadOnly = true;
            this.MOUSE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MOUSE.Visible = false;
            // 
            // PUESTO
            // 
            this.PUESTO.DataPropertyName = "PUESTO";
            this.PUESTO.HeaderText = "PUESTO";
            this.PUESTO.MinimumWidth = 22;
            this.PUESTO.Name = "PUESTO";
            this.PUESTO.ReadOnly = true;
            this.PUESTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PUESTO.Visible = false;
            // 
            // BASE
            // 
            this.BASE.DataPropertyName = "BASE";
            this.BASE.HeaderText = "BASE";
            this.BASE.MinimumWidth = 22;
            this.BASE.Name = "BASE";
            this.BASE.ReadOnly = true;
            this.BASE.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.BASE.Visible = false;
            // 
            // MALETIN
            // 
            this.MALETIN.DataPropertyName = "MALETIN";
            this.MALETIN.HeaderText = "MALETIN";
            this.MALETIN.MinimumWidth = 22;
            this.MALETIN.Name = "MALETIN";
            this.MALETIN.ReadOnly = true;
            this.MALETIN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MALETIN.Visible = false;
            // 
            // MORRAL
            // 
            this.MORRAL.DataPropertyName = "MORRAL";
            this.MORRAL.HeaderText = "MORRAL";
            this.MORRAL.MinimumWidth = 22;
            this.MORRAL.Name = "MORRAL";
            this.MORRAL.ReadOnly = true;
            this.MORRAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MORRAL.Visible = false;
            // 
            // CORREO
            // 
            this.CORREO.DataPropertyName = "CORREO";
            this.CORREO.HeaderText = "CORREO";
            this.CORREO.MinimumWidth = 22;
            this.CORREO.Name = "CORREO";
            this.CORREO.ReadOnly = true;
            this.CORREO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.CORREO.Visible = false;
            // 
            // Gestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1152, 633);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestionar";
            this.Text = "Empleados";
            this.pnlButton.ResumeLayout(false);
            this.GroupOptButton.ResumeLayout(false);
            this.GroupOptButton.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmployesFilter)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlButton;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.TextBox txtSearch;
		public System.Windows.Forms.GroupBox GroupOptButton;
		private System.Windows.Forms.Label lblFilter;
		private System.Windows.Forms.RadioButton rbtnName;
		private System.Windows.Forms.RadioButton rbtnId;
		private System.Windows.Forms.Panel pnlContainer;
		private System.Windows.Forms.Button btnImport;
		private System.Windows.Forms.RadioButton rbtnProyecto;
		private System.Windows.Forms.RadioButton rbtnSede;
		private System.Windows.Forms.RadioButton rbtnIngreso;
		private System.Windows.Forms.RadioButton rbtnSalida;
		private Zuby.ADGV.AdvancedDataGridView tblEmployesFilter;
		private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE2;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO2;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROYECTO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROYECTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEDE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBICACION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBICACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO_N;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMP_CORREO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn INGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAMODIFI;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUMODIFI;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TECLADO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MOUSE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PUESTO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BASE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MALETIN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MORRAL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CORREO;
    }
}