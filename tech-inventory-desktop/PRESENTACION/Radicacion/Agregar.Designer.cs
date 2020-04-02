namespace PRESENTACION.Radicacion
{
	partial class Agregar
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
			this.btnFile = new System.Windows.Forms.Button();
			this.txtFile = new System.Windows.Forms.TextBox();
			this.lblFile = new System.Windows.Forms.Label();
			this.DateSelect = new System.Windows.Forms.DateTimePicker();
			this.lblDate = new System.Windows.Forms.Label();
			this.txtNumero = new System.Windows.Forms.TextBox();
			this.lblFacturaNumero = new System.Windows.Forms.Label();
			this.lblDetail = new System.Windows.Forms.Label();
			this.txtObservaciones = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.txtMonto = new System.Windows.Forms.TextBox();
			this.lblMonto = new System.Windows.Forms.Label();
			this.cmbProveedor = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btnFile
			// 
			this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFile.Location = new System.Drawing.Point(1019, 178);
			this.btnFile.Margin = new System.Windows.Forms.Padding(4);
			this.btnFile.Name = "btnFile";
			this.btnFile.Size = new System.Drawing.Size(57, 28);
			this.btnFile.TabIndex = 4;
			this.btnFile.Text = "...";
			this.btnFile.UseVisualStyleBackColor = true;
			this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
			// 
			// txtFile
			// 
			this.txtFile.Enabled = false;
			this.txtFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtFile.Location = new System.Drawing.Point(609, 178);
			this.txtFile.Margin = new System.Windows.Forms.Padding(4);
			this.txtFile.Name = "txtFile";
			this.txtFile.ReadOnly = true;
			this.txtFile.Size = new System.Drawing.Size(381, 27);
			this.txtFile.TabIndex = 8;
			// 
			// lblFile
			// 
			this.lblFile.AutoSize = true;
			this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFile.ForeColor = System.Drawing.Color.White;
			this.lblFile.Location = new System.Drawing.Point(504, 178);
			this.lblFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.lblFile.Name = "lblFile";
			this.lblFile.Size = new System.Drawing.Size(92, 25);
			this.lblFile.TabIndex = 0;
			this.lblFile.Text = "Archivo:";
			// 
			// DateSelect
			// 
			this.DateSelect.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateSelect.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.DateSelect.CustomFormat = "yyyy-MM-dd";
			this.DateSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DateSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.DateSelect.Location = new System.Drawing.Point(241, 42);
			this.DateSelect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.DateSelect.Name = "DateSelect";
			this.DateSelect.Size = new System.Drawing.Size(187, 27);
			this.DateSelect.TabIndex = 1;
			this.DateSelect.Value = new System.DateTime(2018, 7, 24, 16, 27, 47, 0);
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDate.ForeColor = System.Drawing.Color.White;
			this.lblDate.Location = new System.Drawing.Point(16, 42);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(73, 25);
			this.lblDate.TabIndex = 0;
			this.lblDate.Text = "Fecha:";
			// 
			// txtNumero
			// 
			this.txtNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.txtNumero.Location = new System.Drawing.Point(241, 175);
			this.txtNumero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtNumero.Name = "txtNumero";
			this.txtNumero.Size = new System.Drawing.Size(187, 27);
			this.txtNumero.TabIndex = 3;
			// 
			// lblFacturaNumero
			// 
			this.lblFacturaNumero.AutoSize = true;
			this.lblFacturaNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblFacturaNumero.ForeColor = System.Drawing.Color.White;
			this.lblFacturaNumero.Location = new System.Drawing.Point(16, 175);
			this.lblFacturaNumero.Name = "lblFacturaNumero";
			this.lblFacturaNumero.Size = new System.Drawing.Size(178, 25);
			this.lblFacturaNumero.TabIndex = 0;
			this.lblFacturaNumero.Text = "Número de factura:";
			// 
			// lblDetail
			// 
			this.lblDetail.AutoSize = true;
			this.lblDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblDetail.ForeColor = System.Drawing.Color.White;
			this.lblDetail.Location = new System.Drawing.Point(16, 324);
			this.lblDetail.Name = "lblDetail";
			this.lblDetail.Size = new System.Drawing.Size(164, 25);
			this.lblDetail.TabIndex = 0;
			this.lblDetail.Text = "Observaciones:";
			// 
			// txtObservaciones
			// 
			this.txtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtObservaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.txtObservaciones.Location = new System.Drawing.Point(241, 324);
			this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtObservaciones.Multiline = true;
			this.txtObservaciones.Name = "txtObservaciones";
			this.txtObservaciones.Size = new System.Drawing.Size(427, 104);
			this.txtObservaciones.TabIndex = 6;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSave.Location = new System.Drawing.Point(951, 530);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.btnSave.Size = new System.Drawing.Size(125, 100);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Guardar";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtMonto
			// 
			this.txtMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.txtMonto.Location = new System.Drawing.Point(241, 255);
			this.txtMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtMonto.Name = "txtMonto";
			this.txtMonto.Size = new System.Drawing.Size(187, 27);
			this.txtMonto.TabIndex = 5;
			// 
			// lblMonto
			// 
			this.lblMonto.AutoSize = true;
			this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMonto.ForeColor = System.Drawing.Color.White;
			this.lblMonto.Location = new System.Drawing.Point(16, 255);
			this.lblMonto.Name = "lblMonto";
			this.lblMonto.Size = new System.Drawing.Size(73, 25);
			this.lblMonto.TabIndex = 0;
			this.lblMonto.Text = "Monto:";
			// 
			// cmbProveedor
			// 
			this.cmbProveedor.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.cmbProveedor.FormattingEnabled = true;
			this.cmbProveedor.Location = new System.Drawing.Point(609, 46);
			this.cmbProveedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbProveedor.Name = "cmbProveedor";
			this.cmbProveedor.Size = new System.Drawing.Size(467, 28);
			this.cmbProveedor.TabIndex = 2;
			// 
			// Agregar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
			this.ClientSize = new System.Drawing.Size(1109, 660);
			this.Controls.Add(this.cmbProveedor);
			this.Controls.Add(this.txtMonto);
			this.Controls.Add(this.lblMonto);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.lblDetail);
			this.Controls.Add(this.txtObservaciones);
			this.Controls.Add(this.txtNumero);
			this.Controls.Add(this.lblFacturaNumero);
			this.Controls.Add(this.DateSelect);
			this.Controls.Add(this.lblDate);
			this.Controls.Add(this.btnFile);
			this.Controls.Add(this.txtFile);
			this.Controls.Add(this.lblFile);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "Agregar";
			this.Text = "Radicar factura";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnFile;
		private System.Windows.Forms.TextBox txtFile;
		private System.Windows.Forms.Label lblFile;
		public System.Windows.Forms.DateTimePicker DateSelect;
		private System.Windows.Forms.Label lblDate;
		public System.Windows.Forms.TextBox txtNumero;
		private System.Windows.Forms.Label lblFacturaNumero;
		private System.Windows.Forms.Label lblDetail;
		public System.Windows.Forms.TextBox txtObservaciones;
		public System.Windows.Forms.Button btnSave;
		public System.Windows.Forms.TextBox txtMonto;
		private System.Windows.Forms.Label lblMonto;
		public System.Windows.Forms.ComboBox cmbProveedor;
	}
}