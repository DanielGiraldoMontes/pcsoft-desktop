namespace PRESENTACION.Equipos.Modelos
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
			this.txtModelo = new System.Windows.Forms.TextBox();
			this.cmbMarcas = new System.Windows.Forms.ComboBox();
			this.lblModelo = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtModelo
			// 
			this.txtModelo.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtModelo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.txtModelo.Location = new System.Drawing.Point(500, 50);
			this.txtModelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.txtModelo.Name = "txtModelo";
			this.txtModelo.Size = new System.Drawing.Size(241, 26);
			this.txtModelo.TabIndex = 15;
			// 
			// cmbMarcas
			// 
			this.cmbMarcas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cmbMarcas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
			this.cmbMarcas.FormattingEnabled = true;
			this.cmbMarcas.Location = new System.Drawing.Point(24, 48);
			this.cmbMarcas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.cmbMarcas.Name = "cmbMarcas";
			this.cmbMarcas.Size = new System.Drawing.Size(347, 28);
			this.cmbMarcas.TabIndex = 14;
			// 
			// lblModelo
			// 
			this.lblModelo.AutoSize = true;
			this.lblModelo.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblModelo.ForeColor = System.Drawing.Color.White;
			this.lblModelo.Location = new System.Drawing.Point(421, 50);
			this.lblModelo.Name = "lblModelo";
			this.lblModelo.Size = new System.Drawing.Size(72, 24);
			this.lblModelo.TabIndex = 13;
			this.lblModelo.Text = "Modelo:";
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(68)))), ((int)(((byte)(0)))));
			this.btnSave.FlatAppearance.BorderSize = 0;
			this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
			this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSave.ForeColor = System.Drawing.Color.White;
			this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
			this.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnSave.Location = new System.Drawing.Point(329, 131);
			this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnSave.Name = "btnSave";
			this.btnSave.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
			this.btnSave.Size = new System.Drawing.Size(125, 100);
			this.btnSave.TabIndex = 16;
			this.btnSave.Text = "Guardar";
			this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// Agregar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
			this.ClientSize = new System.Drawing.Size(776, 267);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.txtModelo);
			this.Controls.Add(this.cmbMarcas);
			this.Controls.Add(this.lblModelo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Agregar";
			this.Text = "Agregar modelo";
			this.Load += new System.EventHandler(this.Agregar_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox txtModelo;
		public System.Windows.Forms.ComboBox cmbMarcas;
		private System.Windows.Forms.Label lblModelo;
		private System.Windows.Forms.Button btnSave;
	}
}