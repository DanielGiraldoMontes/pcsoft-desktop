namespace PRESENTACION.Asignaciones.Devolver
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar));
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblDevolucionesFilter = new Zuby.ADGV.AdvancedDataGridView();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.btnActa = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.GroupOptButton = new System.Windows.Forms.GroupBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.rbtnNames = new System.Windows.Forms.RadioButton();
            this.rbtnNumber = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpFile = new System.Windows.Forms.Button();
            this.btnShowFile = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TECLADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MOUSE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BASE = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MALETIN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.MORRAL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CORREO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ANULADO = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OBSERVACIONES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAMODIFI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUMODIFI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUDOCUMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUNOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevolucionesFilter)).BeginInit();
            this.GroupOptButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tblDevolucionesFilter);
            this.panel2.Controls.Add(this.lblTotalRows);
            this.panel2.Controls.Add(this.btnActa);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.GroupOptButton);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1501, 642);
            this.panel2.TabIndex = 35;
            // 
            // tblDevolucionesFilter
            // 
            this.tblDevolucionesFilter.AllowUserToAddRows = false;
            this.tblDevolucionesFilter.AllowUserToDeleteRows = false;
            this.tblDevolucionesFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblDevolucionesFilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblDevolucionesFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.tblDevolucionesFilter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDevolucionesFilter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblDevolucionesFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblDevolucionesFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMERO,
            this.CODIGO,
            this.DOCUMENTO,
            this.NOMBRES,
            this.FECHA,
            this.TECLADO,
            this.MOUSE,
            this.PUESTO,
            this.BASE,
            this.MALETIN,
            this.MORRAL,
            this.CORREO,
            this.ANULADO,
            this.OBSERVACIONES,
            this.FECHAMODIFI,
            this.USUMODIFI,
            this.USUDOCUMENTO,
            this.USUNOMBRES});
            this.tblDevolucionesFilter.EnableHeadersVisualStyles = false;
            this.tblDevolucionesFilter.FilterAndSortEnabled = true;
            this.tblDevolucionesFilter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.tblDevolucionesFilter.Location = new System.Drawing.Point(11, 127);
            this.tblDevolucionesFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblDevolucionesFilter.Name = "tblDevolucionesFilter";
            this.tblDevolucionesFilter.ReadOnly = true;
            this.tblDevolucionesFilter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblDevolucionesFilter.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tblDevolucionesFilter.RowHeadersVisible = false;
            this.tblDevolucionesFilter.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.tblDevolucionesFilter.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.tblDevolucionesFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblDevolucionesFilter.Size = new System.Drawing.Size(1479, 495);
            this.tblDevolucionesFilter.TabIndex = 75;
            this.tblDevolucionesFilter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblDevolucionesFilter_CellDoubleClick);
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRows.ForeColor = System.Drawing.Color.White;
            this.lblTotalRows.Location = new System.Drawing.Point(359, 65);
            this.lblTotalRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(105, 25);
            this.lblTotalRows.TabIndex = 74;
            this.lblTotalRows.Text = "totalRows";
            // 
            // btnActa
            // 
            this.btnActa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(39)))));
            this.btnActa.FlatAppearance.BorderSize = 0;
            this.btnActa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActa.ForeColor = System.Drawing.Color.White;
            this.btnActa.Location = new System.Drawing.Point(840, 14);
            this.btnActa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnActa.Name = "btnActa";
            this.btnActa.Size = new System.Drawing.Size(139, 39);
            this.btnActa.TabIndex = 33;
            this.btnActa.Text = "Generar";
            this.btnActa.UseVisualStyleBackColor = false;
            this.btnActa.Click += new System.EventHandler(this.btnActa_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(39)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(672, 12);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(139, 39);
            this.btnSearch.TabIndex = 31;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GroupOptButton
            // 
            this.GroupOptButton.Controls.Add(this.lblFilter);
            this.GroupOptButton.Controls.Add(this.rbtnNames);
            this.GroupOptButton.Controls.Add(this.rbtnNumber);
            this.GroupOptButton.Location = new System.Drawing.Point(15, 4);
            this.GroupOptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupOptButton.Name = "GroupOptButton";
            this.GroupOptButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupOptButton.Size = new System.Drawing.Size(313, 63);
            this.GroupOptButton.TabIndex = 27;
            this.GroupOptButton.TabStop = false;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFilter.Location = new System.Drawing.Point(-3, 2);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(97, 20);
            this.lblFilter.TabIndex = 11;
            this.lblFilter.Text = "Buscar por:";
            // 
            // rbtnNames
            // 
            this.rbtnNames.AutoSize = true;
            this.rbtnNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNames.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnNames.Location = new System.Drawing.Point(163, 26);
            this.rbtnNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNames.Name = "rbtnNames";
            this.rbtnNames.Size = new System.Drawing.Size(98, 24);
            this.rbtnNames.TabIndex = 1;
            this.rbtnNames.Text = "Nombres";
            this.rbtnNames.UseVisualStyleBackColor = true;
            // 
            // rbtnNumber
            // 
            this.rbtnNumber.AutoSize = true;
            this.rbtnNumber.Checked = true;
            this.rbtnNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNumber.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnNumber.Location = new System.Drawing.Point(25, 26);
            this.rbtnNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNumber.Name = "rbtnNumber";
            this.rbtnNumber.Size = new System.Drawing.Size(89, 24);
            this.rbtnNumber.TabIndex = 0;
            this.rbtnNumber.TabStop = true;
            this.rbtnNumber.Text = "Numero";
            this.rbtnNumber.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSearch.Location = new System.Drawing.Point(364, 14);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(271, 26);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.Text = "BUSCAR";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpFile);
            this.panel1.Controls.Add(this.btnShowFile);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 642);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1501, 143);
            this.panel1.TabIndex = 34;
            // 
            // btnUpFile
            // 
            this.btnUpFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(39)))));
            this.btnUpFile.FlatAppearance.BorderSize = 0;
            this.btnUpFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnUpFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpFile.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpFile.ForeColor = System.Drawing.Color.White;
            this.btnUpFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnUpFile.Location = new System.Drawing.Point(459, 18);
            this.btnUpFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpFile.Name = "btnUpFile";
            this.btnUpFile.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnUpFile.Size = new System.Drawing.Size(125, 100);
            this.btnUpFile.TabIndex = 17;
            this.btnUpFile.Text = "Cargar acta";
            this.btnUpFile.UseVisualStyleBackColor = false;
            this.btnUpFile.Click += new System.EventHandler(this.btnUpFile_Click);
            // 
            // btnShowFile
            // 
            this.btnShowFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(39)))));
            this.btnShowFile.FlatAppearance.BorderSize = 0;
            this.btnShowFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnShowFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFile.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFile.ForeColor = System.Drawing.Color.White;
            this.btnShowFile.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnShowFile.Location = new System.Drawing.Point(316, 18);
            this.btnShowFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowFile.Name = "btnShowFile";
            this.btnShowFile.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnShowFile.Size = new System.Drawing.Size(125, 100);
            this.btnShowFile.TabIndex = 16;
            this.btnShowFile.Text = "Ver acta";
            this.btnShowFile.UseVisualStyleBackColor = false;
            this.btnShowFile.Click += new System.EventHandler(this.btnShowFile_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(39)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(171, 18);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnCancel.Size = new System.Drawing.Size(125, 100);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Anular";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(158)))), ((int)(((byte)(39)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.Location = new System.Drawing.Point(24, 18);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnNew.Size = new System.Drawing.Size(125, 100);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "Agregar";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // NUMERO
            // 
            this.NUMERO.DataPropertyName = "NUMERO";
            this.NUMERO.HeaderText = "NUMERO";
            this.NUMERO.MinimumWidth = 22;
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.ReadOnly = true;
            this.NUMERO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // DOCUMENTO
            // 
            this.DOCUMENTO.DataPropertyName = "DOCUMENTO";
            this.DOCUMENTO.HeaderText = "DOCUMENTO";
            this.DOCUMENTO.MinimumWidth = 22;
            this.DOCUMENTO.Name = "DOCUMENTO";
            this.DOCUMENTO.ReadOnly = true;
            this.DOCUMENTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // FECHA
            // 
            this.FECHA.DataPropertyName = "FECHA";
            this.FECHA.HeaderText = "FECHA";
            this.FECHA.MinimumWidth = 22;
            this.FECHA.Name = "FECHA";
            this.FECHA.ReadOnly = true;
            this.FECHA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // ANULADO
            // 
            this.ANULADO.DataPropertyName = "ANULADO";
            this.ANULADO.HeaderText = "ANULADO";
            this.ANULADO.MinimumWidth = 22;
            this.ANULADO.Name = "ANULADO";
            this.ANULADO.ReadOnly = true;
            this.ANULADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // OBSERVACIONES
            // 
            this.OBSERVACIONES.DataPropertyName = "OBSERVACIONES";
            this.OBSERVACIONES.HeaderText = "OBSERVACIONES";
            this.OBSERVACIONES.MinimumWidth = 22;
            this.OBSERVACIONES.Name = "OBSERVACIONES";
            this.OBSERVACIONES.ReadOnly = true;
            this.OBSERVACIONES.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.OBSERVACIONES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // USUDOCUMENTO
            // 
            this.USUDOCUMENTO.DataPropertyName = "USUDOCUMENTO";
            this.USUDOCUMENTO.HeaderText = "USUDOCUMENTO";
            this.USUDOCUMENTO.MinimumWidth = 22;
            this.USUDOCUMENTO.Name = "USUDOCUMENTO";
            this.USUDOCUMENTO.ReadOnly = true;
            this.USUDOCUMENTO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.USUDOCUMENTO.Visible = false;
            // 
            // USUNOMBRES
            // 
            this.USUNOMBRES.DataPropertyName = "USUNOMBRES";
            this.USUNOMBRES.HeaderText = "USUNOMBRES";
            this.USUNOMBRES.MinimumWidth = 22;
            this.USUNOMBRES.Name = "USUNOMBRES";
            this.USUNOMBRES.ReadOnly = true;
            this.USUNOMBRES.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.USUNOMBRES.Visible = false;
            // 
            // Gestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1501, 785);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Gestionar";
            this.Text = "Devoluciones";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblDevolucionesFilter)).EndInit();
            this.GroupOptButton.ResumeLayout(false);
            this.GroupOptButton.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnSearch;
		public System.Windows.Forms.GroupBox GroupOptButton;
		private System.Windows.Forms.Label lblFilter;
		private System.Windows.Forms.RadioButton rbtnNames;
		private System.Windows.Forms.RadioButton rbtnNumber;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnActa;
		private System.Windows.Forms.Button btnUpFile;
		private System.Windows.Forms.Button btnShowFile;
		private System.Windows.Forms.Label lblTotalRows;
		private Zuby.ADGV.AdvancedDataGridView tblDevolucionesFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA;
        private System.Windows.Forms.DataGridViewCheckBoxColumn TECLADO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MOUSE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PUESTO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BASE;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MALETIN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn MORRAL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CORREO;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ANULADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAMODIFI;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUMODIFI;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUDOCUMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUNOMBRES;
    }
}