namespace PRESENTACION.Equipos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gestionar));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblTotalRows = new System.Windows.Forms.Label();
            this.tblEquiposFilter = new Zuby.ADGV.AdvancedDataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.GroupOptButton = new System.Windows.Forms.GroupBox();
            this.rbtnObservaciones = new System.Windows.Forms.RadioButton();
            this.rbtnSalida = new System.Windows.Forms.RadioButton();
            this.rbtnIngreso = new System.Windows.Forms.RadioButton();
            this.rbtnProveedor = new System.Windows.Forms.RadioButton();
            this.rbtnDescripcion = new System.Windows.Forms.RadioButton();
            this.lblFilter = new System.Windows.Forms.Label();
            this.rbtnId = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR_NIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROVEEDOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MARCA_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MODELO_DESC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SERIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.INGRESO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SALIDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PROYECTO_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEDE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UBICACION_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PUESTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OBSERVACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FECHAMODIFI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUMODIFI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquiposFilter)).BeginInit();
            this.GroupOptButton.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.lblTotalRows);
            this.pnlContainer.Controls.Add(this.tblEquiposFilter);
            this.pnlContainer.Controls.Add(this.btnSearch);
            this.pnlContainer.Controls.Add(this.GroupOptButton);
            this.pnlContainer.Controls.Add(this.txtSearch);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1106, 513);
            this.pnlContainer.TabIndex = 29;
            // 
            // lblTotalRows
            // 
            this.lblTotalRows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalRows.AutoSize = true;
            this.lblTotalRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRows.ForeColor = System.Drawing.Color.White;
            this.lblTotalRows.Location = new System.Drawing.Point(466, 60);
            this.lblTotalRows.Name = "lblTotalRows";
            this.lblTotalRows.Size = new System.Drawing.Size(89, 20);
            this.lblTotalRows.TabIndex = 70;
            this.lblTotalRows.Text = "totalRows";
            // 
            // tblEquiposFilter
            // 
            this.tblEquiposFilter.AllowUserToAddRows = false;
            this.tblEquiposFilter.AllowUserToDeleteRows = false;
            this.tblEquiposFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tblEquiposFilter.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblEquiposFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.tblEquiposFilter.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblEquiposFilter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tblEquiposFilter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblEquiposFilter.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.DESCRIPCION,
            this.PROVEEDOR_NIT,
            this.PROVEEDOR,
            this.MARCA_ID,
            this.MARCA_DESC,
            this.MODELO_ID,
            this.MODELO_DESC,
            this.SERIAL,
            this.INGRESO,
            this.SALIDA,
            this.ESTADO,
            this.PROYECTO_ID,
            this.SEDE_ID,
            this.UBICACION_ID,
            this.PUESTO,
            this.OBSERVACION,
            this.FECHAMODIFI,
            this.USUMODIFI});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tblEquiposFilter.DefaultCellStyle = dataGridViewCellStyle2;
            this.tblEquiposFilter.EnableHeadersVisualStyles = false;
            this.tblEquiposFilter.FilterAndSortEnabled = true;
            this.tblEquiposFilter.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.tblEquiposFilter.Location = new System.Drawing.Point(11, 98);
            this.tblEquiposFilter.Margin = new System.Windows.Forms.Padding(2);
            this.tblEquiposFilter.Name = "tblEquiposFilter";
            this.tblEquiposFilter.ReadOnly = true;
            this.tblEquiposFilter.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblEquiposFilter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tblEquiposFilter.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.tblEquiposFilter.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tblEquiposFilter.RowTemplate.Height = 24;
            this.tblEquiposFilter.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblEquiposFilter.Size = new System.Drawing.Size(1077, 391);
            this.tblEquiposFilter.TabIndex = 26;
            this.tblEquiposFilter.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblEquiposFilter_CellDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(691, 11);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 32);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Buscar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GroupOptButton
            // 
            this.GroupOptButton.Controls.Add(this.rbtnObservaciones);
            this.GroupOptButton.Controls.Add(this.rbtnSalida);
            this.GroupOptButton.Controls.Add(this.rbtnIngreso);
            this.GroupOptButton.Controls.Add(this.rbtnProveedor);
            this.GroupOptButton.Controls.Add(this.rbtnDescripcion);
            this.GroupOptButton.Controls.Add(this.lblFilter);
            this.GroupOptButton.Controls.Add(this.rbtnId);
            this.GroupOptButton.Location = new System.Drawing.Point(35, 11);
            this.GroupOptButton.Margin = new System.Windows.Forms.Padding(2);
            this.GroupOptButton.Name = "GroupOptButton";
            this.GroupOptButton.Padding = new System.Windows.Forms.Padding(2);
            this.GroupOptButton.Size = new System.Drawing.Size(396, 69);
            this.GroupOptButton.TabIndex = 22;
            this.GroupOptButton.TabStop = false;
            // 
            // rbtnObservaciones
            // 
            this.rbtnObservaciones.AutoSize = true;
            this.rbtnObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnObservaciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnObservaciones.Location = new System.Drawing.Point(10, 19);
            this.rbtnObservaciones.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnObservaciones.Name = "rbtnObservaciones";
            this.rbtnObservaciones.Size = new System.Drawing.Size(121, 21);
            this.rbtnObservaciones.TabIndex = 16;
            this.rbtnObservaciones.Text = "Observaciones";
            this.rbtnObservaciones.UseVisualStyleBackColor = true;
            // 
            // rbtnSalida
            // 
            this.rbtnSalida.AutoSize = true;
            this.rbtnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnSalida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnSalida.Location = new System.Drawing.Point(254, 46);
            this.rbtnSalida.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnSalida.Name = "rbtnSalida";
            this.rbtnSalida.Size = new System.Drawing.Size(65, 21);
            this.rbtnSalida.TabIndex = 15;
            this.rbtnSalida.Text = "Salida";
            this.rbtnSalida.UseVisualStyleBackColor = true;
            // 
            // rbtnIngreso
            // 
            this.rbtnIngreso.AutoSize = true;
            this.rbtnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIngreso.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnIngreso.Location = new System.Drawing.Point(254, 19);
            this.rbtnIngreso.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnIngreso.Name = "rbtnIngreso";
            this.rbtnIngreso.Size = new System.Drawing.Size(73, 21);
            this.rbtnIngreso.TabIndex = 14;
            this.rbtnIngreso.Text = "Ingreso";
            this.rbtnIngreso.UseVisualStyleBackColor = true;
            // 
            // rbtnProveedor
            // 
            this.rbtnProveedor.AutoSize = true;
            this.rbtnProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnProveedor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnProveedor.Location = new System.Drawing.Point(144, 19);
            this.rbtnProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnProveedor.Name = "rbtnProveedor";
            this.rbtnProveedor.Size = new System.Drawing.Size(92, 21);
            this.rbtnProveedor.TabIndex = 13;
            this.rbtnProveedor.Text = "Proveedor";
            this.rbtnProveedor.UseVisualStyleBackColor = true;
            // 
            // rbtnDescripcion
            // 
            this.rbtnDescripcion.AutoSize = true;
            this.rbtnDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDescripcion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnDescripcion.Location = new System.Drawing.Point(144, 46);
            this.rbtnDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnDescripcion.Name = "rbtnDescripcion";
            this.rbtnDescripcion.Size = new System.Drawing.Size(100, 21);
            this.rbtnDescripcion.TabIndex = 12;
            this.rbtnDescripcion.Text = "Descripcion";
            this.rbtnDescripcion.UseVisualStyleBackColor = true;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFilter.Location = new System.Drawing.Point(-3, -2);
            this.lblFilter.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(81, 17);
            this.lblFilter.TabIndex = 11;
            this.lblFilter.Text = "Buscar por:";
            // 
            // rbtnId
            // 
            this.rbtnId.AutoSize = true;
            this.rbtnId.Checked = true;
            this.rbtnId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rbtnId.Location = new System.Drawing.Point(10, 44);
            this.rbtnId.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnId.Name = "rbtnId";
            this.rbtnId.Size = new System.Drawing.Size(70, 21);
            this.rbtnId.TabIndex = 0;
            this.rbtnId.TabStop = true;
            this.rbtnId.Text = "Codigo";
            this.rbtnId.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.Info;
            this.txtSearch.Location = new System.Drawing.Point(470, 20);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(204, 23);
            this.txtSearch.TabIndex = 23;
            this.txtSearch.Text = "BUSCAR";
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnImport);
            this.pnlButton.Controls.Add(this.btnNew);
            this.pnlButton.Controls.Add(this.btnUpdate);
            this.pnlButton.Controls.Add(this.btnDelete);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 513);
            this.pnlButton.Margin = new System.Windows.Forms.Padding(2);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(1106, 117);
            this.pnlButton.TabIndex = 28;
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
            this.btnImport.Location = new System.Drawing.Point(21, 18);
            this.btnImport.Margin = new System.Windows.Forms.Padding(2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnImport.Size = new System.Drawing.Size(94, 81);
            this.btnImport.TabIndex = 16;
            this.btnImport.Text = "Importar";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.btnNew.Location = new System.Drawing.Point(130, 18);
            this.btnNew.Margin = new System.Windows.Forms.Padding(2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnNew.Size = new System.Drawing.Size(94, 81);
            this.btnNew.TabIndex = 6;
            this.btnNew.Text = "Agregar";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Visible = false;
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
            this.btnUpdate.Location = new System.Drawing.Point(350, 18);
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
            this.btnDelete.Location = new System.Drawing.Point(241, 18);
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
            // CODIGO
            // 
            this.CODIGO.DataPropertyName = "CODIGO";
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.MinimumWidth = 22;
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            this.CODIGO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.DataPropertyName = "DESCRIPCION";
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.MinimumWidth = 22;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // PROVEEDOR_NIT
            // 
            this.PROVEEDOR_NIT.DataPropertyName = "PROVEEDOR_NIT";
            this.PROVEEDOR_NIT.HeaderText = "PROVEEDOR_NIT";
            this.PROVEEDOR_NIT.MinimumWidth = 22;
            this.PROVEEDOR_NIT.Name = "PROVEEDOR_NIT";
            this.PROVEEDOR_NIT.ReadOnly = true;
            this.PROVEEDOR_NIT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.PROVEEDOR_NIT.Visible = false;
            // 
            // PROVEEDOR
            // 
            this.PROVEEDOR.DataPropertyName = "PROVEEDOR";
            this.PROVEEDOR.HeaderText = "PROVEEDOR";
            this.PROVEEDOR.MinimumWidth = 22;
            this.PROVEEDOR.Name = "PROVEEDOR";
            this.PROVEEDOR.ReadOnly = true;
            this.PROVEEDOR.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // MARCA_ID
            // 
            this.MARCA_ID.DataPropertyName = "MARCA_ID";
            this.MARCA_ID.HeaderText = "MARCA_ID";
            this.MARCA_ID.MinimumWidth = 22;
            this.MARCA_ID.Name = "MARCA_ID";
            this.MARCA_ID.ReadOnly = true;
            this.MARCA_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MARCA_ID.Visible = false;
            // 
            // MARCA_DESC
            // 
            this.MARCA_DESC.DataPropertyName = "MARCA_DESC";
            this.MARCA_DESC.HeaderText = "MARCA_DESC";
            this.MARCA_DESC.MinimumWidth = 22;
            this.MARCA_DESC.Name = "MARCA_DESC";
            this.MARCA_DESC.ReadOnly = true;
            this.MARCA_DESC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MARCA_DESC.Visible = false;
            // 
            // MODELO_ID
            // 
            this.MODELO_ID.DataPropertyName = "MODELO_ID";
            this.MODELO_ID.HeaderText = "MODELO_ID";
            this.MODELO_ID.MinimumWidth = 22;
            this.MODELO_ID.Name = "MODELO_ID";
            this.MODELO_ID.ReadOnly = true;
            this.MODELO_ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MODELO_ID.Visible = false;
            // 
            // MODELO_DESC
            // 
            this.MODELO_DESC.DataPropertyName = "MODELO_DESC";
            this.MODELO_DESC.HeaderText = "MODELO_DESC";
            this.MODELO_DESC.MinimumWidth = 22;
            this.MODELO_DESC.Name = "MODELO_DESC";
            this.MODELO_DESC.ReadOnly = true;
            this.MODELO_DESC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.MODELO_DESC.Visible = false;
            // 
            // SERIAL
            // 
            this.SERIAL.DataPropertyName = "SERIAL";
            this.SERIAL.HeaderText = "SERIAL";
            this.SERIAL.MinimumWidth = 22;
            this.SERIAL.Name = "SERIAL";
            this.SERIAL.ReadOnly = true;
            this.SERIAL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "ESTADO";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.MinimumWidth = 22;
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
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
            // Gestionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.ClientSize = new System.Drawing.Size(1106, 630);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Gestionar";
            this.Text = "Equipos";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquiposFilter)).EndInit();
            this.GroupOptButton.ResumeLayout(false);
            this.GroupOptButton.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Button btnSearch;
        public System.Windows.Forms.GroupBox GroupOptButton;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.RadioButton rbtnId;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.RadioButton rbtnObservaciones;
        private System.Windows.Forms.RadioButton rbtnSalida;
        private System.Windows.Forms.RadioButton rbtnIngreso;
        private System.Windows.Forms.RadioButton rbtnProveedor;
        private System.Windows.Forms.RadioButton rbtnDescripcion;
        private Zuby.ADGV.AdvancedDataGridView tblEquiposFilter;
        private System.Windows.Forms.Label lblTotalRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR_NIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROVEEDOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCA_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MODELO_DESC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SERIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn INGRESO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALIDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn PROYECTO_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEDE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UBICACION_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PUESTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn OBSERVACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn FECHAMODIFI;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUMODIFI;
    }
}