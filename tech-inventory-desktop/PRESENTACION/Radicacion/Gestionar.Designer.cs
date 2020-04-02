namespace PRESENTACION.Radicacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tblRadicacionesFilter = new Zuby.ADGV.AdvancedDataGridView();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.GroupOptButton = new System.Windows.Forms.GroupBox();
            this.rbtnFactura = new System.Windows.Forms.RadioButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.rbtnNames = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnShowFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.NUMERO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FACTURA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOCUMENTO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MONTO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHA1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACIONES1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ANULADO1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRadicacionesFilter)).BeginInit();
            this.GroupOptButton.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tblRadicacionesFilter);
            this.panel2.Controls.Add(this.lblTotalRows);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.GroupOptButton);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1449, 626);
            this.panel2.TabIndex = 37;
            // 
            // tblRadicacionesFilter
            // 
            this.tblRadicacionesFilter.AllowUserToAddRows = false;
            this.tblRadicacionesFilter.AllowUserToDeleteRows = false;
            this.tblRadicacionesFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblRadicacionesFilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblRadicacionesFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.tblRadicacionesFilter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblRadicacionesFilter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblRadicacionesFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblRadicacionesFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NUMERO1,
            this.FACTURA1,
            this.DOCUMENTO1,
            this.RAZON_SOCIAL,
            this.MONTO1,
            this.FECHA1,
            this.OBSERVACIONES1,
            this.ANULADO1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblRadicacionesFilter.DefaultCellStyle = dataGridViewCellStyle3;
            this.tblRadicacionesFilter.EnableHeadersVisualStyles = false;
            this.tblRadicacionesFilter.FilterAndSortEnabled = true;
            this.tblRadicacionesFilter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.tblRadicacionesFilter.Location = new System.Drawing.Point(35, 132);
            this.tblRadicacionesFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tblRadicacionesFilter.Name = "tblRadicacionesFilter";
            this.tblRadicacionesFilter.ReadOnly = true;
            this.tblRadicacionesFilter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblRadicacionesFilter.RowHeadersVisible = false;
            this.tblRadicacionesFilter.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.tblRadicacionesFilter.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblRadicacionesFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblRadicacionesFilter.Size = new System.Drawing.Size(1387, 472);
            this.tblRadicacionesFilter.TabIndex = 81;
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRows.ForeColor = System.Drawing.Color.White;
            this.lblTotalRows.Location = new System.Drawing.Point(332, 80);
            this.lblTotalRows.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(105, 25);
            this.lblTotalRows.TabIndex = 80;
            this.lblTotalRows.Text = "totalRows";
            this.lblTotalRows.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(643, 15);
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
            this.GroupOptButton.Controls.Add(this.rbtnFactura);
            this.GroupOptButton.Controls.Add(this.lblFilter);
            this.GroupOptButton.Controls.Add(this.rbtnNames);
            this.GroupOptButton.Location = new System.Drawing.Point(35, 15);
            this.GroupOptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupOptButton.Name = "GroupOptButton";
            this.GroupOptButton.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GroupOptButton.Size = new System.Drawing.Size(277, 66);
            this.GroupOptButton.TabIndex = 27;
            this.GroupOptButton.TabStop = false;
            // 
            // rbtnFactura
            // 
            this.rbtnFactura.AutoSize = true;
            this.rbtnFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFactura.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnFactura.Location = new System.Drawing.Point(144, 26);
            this.rbtnFactura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnFactura.Name = "rbtnFactura";
            this.rbtnFactura.Size = new System.Drawing.Size(111, 24);
            this.rbtnFactura.TabIndex = 12;
            this.rbtnFactura.Text = "Factura N°";
            this.rbtnFactura.UseVisualStyleBackColor = true;
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
            this.rbtnNames.Checked = true;
            this.rbtnNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNames.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnNames.Location = new System.Drawing.Point(5, 26);
            this.rbtnNames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbtnNames.Name = "rbtnNames";
            this.rbtnNames.Size = new System.Drawing.Size(127, 24);
            this.rbtnNames.TabIndex = 1;
            this.rbtnNames.TabStop = true;
            this.rbtnNames.Text = "Razon social";
            this.rbtnNames.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSearch.Location = new System.Drawing.Point(333, 25);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(271, 26);
            this.txtSearch.TabIndex = 28;
            this.txtSearch.Text = "BUSCAR";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // btnShowFile
            // 
            this.btnShowFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnShowFile.FlatAppearance.BorderSize = 0;
            this.btnShowFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnShowFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowFile.ForeColor = System.Drawing.Color.White;
            this.btnShowFile.Location = new System.Drawing.Point(487, 22);
            this.btnShowFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnShowFile.Name = "btnShowFile";
            this.btnShowFile.Size = new System.Drawing.Size(125, 100);
            this.btnShowFile.TabIndex = 32;
            this.btnShowFile.Text = "Ver archivo";
            this.btnShowFile.UseVisualStyleBackColor = false;
            this.btnShowFile.Click += new System.EventHandler(this.btnShowFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnShowFile);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.btnNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 626);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1449, 146);
            this.panel1.TabIndex = 36;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnExport.Location = new System.Drawing.Point(337, 22);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.btnExport.Size = new System.Drawing.Size(125, 100);
            this.btnExport.TabIndex = 14;
            this.btnExport.Text = "Exportar";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCancel.Location = new System.Drawing.Point(187, 22);
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
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnNew.Location = new System.Drawing.Point(35, 22);
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
            // NUMERO1
            // 
            this.NUMERO1.DataPropertyName = "NUMERO";
            this.NUMERO1.HeaderText = "NUMERO";
            this.NUMERO1.MinimumWidth = 22;
            this.NUMERO1.Name = "NUMERO1";
            this.NUMERO1.ReadOnly = true;
            this.NUMERO1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FACTURA1
            // 
            this.FACTURA1.DataPropertyName = "FACTURA";
            this.FACTURA1.HeaderText = "FACTURA";
            this.FACTURA1.MinimumWidth = 22;
            this.FACTURA1.Name = "FACTURA1";
            this.FACTURA1.ReadOnly = true;
            this.FACTURA1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DOCUMENTO1
            // 
            this.DOCUMENTO1.DataPropertyName = "DOCUMENTO";
            this.DOCUMENTO1.HeaderText = "DOCUMENTO";
            this.DOCUMENTO1.MinimumWidth = 22;
            this.DOCUMENTO1.Name = "DOCUMENTO1";
            this.DOCUMENTO1.ReadOnly = true;
            this.DOCUMENTO1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // RAZON_SOCIAL
            // 
            this.RAZON_SOCIAL.DataPropertyName = "RAZON_SOCIAL";
            this.RAZON_SOCIAL.HeaderText = "RAZON SOCIAL";
            this.RAZON_SOCIAL.MinimumWidth = 22;
            this.RAZON_SOCIAL.Name = "RAZON_SOCIAL";
            this.RAZON_SOCIAL.ReadOnly = true;
            this.RAZON_SOCIAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // MONTO1
            // 
            this.MONTO1.DataPropertyName = "MONTO";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.MONTO1.DefaultCellStyle = dataGridViewCellStyle2;
            this.MONTO1.HeaderText = "MONTO";
            this.MONTO1.MinimumWidth = 22;
            this.MONTO1.Name = "MONTO1";
            this.MONTO1.ReadOnly = true;
            this.MONTO1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // FECHA1
            // 
            this.FECHA1.DataPropertyName = "FECHA";
            this.FECHA1.HeaderText = "FECHA";
            this.FECHA1.MinimumWidth = 22;
            this.FECHA1.Name = "FECHA1";
            this.FECHA1.ReadOnly = true;
            this.FECHA1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // OBSERVACIONES1
            // 
            this.OBSERVACIONES1.DataPropertyName = "OBSERVACIONES";
            this.OBSERVACIONES1.HeaderText = "OBSERVACIONES";
            this.OBSERVACIONES1.MinimumWidth = 22;
            this.OBSERVACIONES1.Name = "OBSERVACIONES1";
            this.OBSERVACIONES1.ReadOnly = true;
            this.OBSERVACIONES1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ANULADO1
            // 
            this.ANULADO1.DataPropertyName = "ANULADO";
            this.ANULADO1.HeaderText = "ANULADO";
            this.ANULADO1.MinimumWidth = 22;
            this.ANULADO1.Name = "ANULADO1";
            this.ANULADO1.ReadOnly = true;
            this.ANULADO1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Gestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1449, 772);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Gestionar";
            this.Text = "Radicaciones";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblRadicacionesFilter)).EndInit();
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
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnNew;
		private System.Windows.Forms.Button btnShowFile;
		private System.Windows.Forms.Button btnExport;
		private Zuby.ADGV.AdvancedDataGridView tblRadicacionesFilter;
		private System.Windows.Forms.Label lblTotalRows;
		private System.Windows.Forms.RadioButton rbtnFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FACTURA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOCUMENTO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn MONTO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHA1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACIONES1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ANULADO1;
    }
}