using System.ComponentModel;

namespace BINAES_Proyecto
{
    partial class frmActualizarPalabraClave
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lblInfoParaPalabras = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblidEjemplarNuevo = new System.Windows.Forms.Label();
            this.btnActualizarAgregarPalabra = new System.Windows.Forms.Button();
            this.txtActualizarPalabra = new System.Windows.Forms.TextBox();
            this.dgvListaPalabras = new System.Windows.Forms.DataGridView();
            this.lblPalabraClaveActual = new System.Windows.Forms.Label();
            this.lblId_ejemplar = new System.Windows.Forms.Label();
            this.txtIdEjemplar = new System.Windows.Forms.TextBox();
            this.txtIDPalabra = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvListaPalabras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfoParaPalabras
            // 
            this.lblInfoParaPalabras.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInfoParaPalabras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoParaPalabras.Location = new System.Drawing.Point(45, 14);
            this.lblInfoParaPalabras.Name = "lblInfoParaPalabras";
            this.lblInfoParaPalabras.Size = new System.Drawing.Size(307, 47);
            this.lblInfoParaPalabras.TabIndex = 3;
            this.lblInfoParaPalabras.Text = "Por favor ingrese las palabras claves para este ejemplar";
            this.lblInfoParaPalabras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (29)))), ((int) (((byte) (122)))));
            this.panel1.Controls.Add(this.lblInfoParaPalabras);
            this.panel1.Controls.Add(this.lblidEjemplarNuevo);
            this.panel1.Location = new System.Drawing.Point(23, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 56);
            this.panel1.TabIndex = 7;
            // 
            // lblidEjemplarNuevo
            // 
            this.lblidEjemplarNuevo.Location = new System.Drawing.Point(82, 78);
            this.lblidEjemplarNuevo.Name = "lblidEjemplarNuevo";
            this.lblidEjemplarNuevo.Size = new System.Drawing.Size(94, 32);
            this.lblidEjemplarNuevo.TabIndex = 2;
            // 
            // btnActualizarAgregarPalabra
            // 
            this.btnActualizarAgregarPalabra.Location = new System.Drawing.Point(259, 458);
            this.btnActualizarAgregarPalabra.Name = "btnActualizarAgregarPalabra";
            this.btnActualizarAgregarPalabra.Size = new System.Drawing.Size(158, 47);
            this.btnActualizarAgregarPalabra.TabIndex = 6;
            this.btnActualizarAgregarPalabra.Text = "Actualizar palabra";
            this.btnActualizarAgregarPalabra.UseVisualStyleBackColor = true;
            this.btnActualizarAgregarPalabra.Click += new System.EventHandler(this.btnActualizarAgregarPalabra_Click);
            // 
            // txtActualizarPalabra
            // 
            this.txtActualizarPalabra.Location = new System.Drawing.Point(33, 479);
            this.txtActualizarPalabra.Name = "txtActualizarPalabra";
            this.txtActualizarPalabra.Size = new System.Drawing.Size(178, 26);
            this.txtActualizarPalabra.TabIndex = 5;
            // 
            // dgvListaPalabras
            // 
            this.dgvListaPalabras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPalabras.Location = new System.Drawing.Point(14, 85);
            this.dgvListaPalabras.Name = "dgvListaPalabras";
            this.dgvListaPalabras.RowTemplate.Height = 28;
            this.dgvListaPalabras.Size = new System.Drawing.Size(455, 347);
            this.dgvListaPalabras.TabIndex = 8;
            this.dgvListaPalabras.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPalabras_CellClick);
            // 
            // lblPalabraClaveActual
            // 
            this.lblPalabraClaveActual.Location = new System.Drawing.Point(43, 443);
            this.lblPalabraClaveActual.Name = "lblPalabraClaveActual";
            this.lblPalabraClaveActual.Size = new System.Drawing.Size(155, 25);
            this.lblPalabraClaveActual.TabIndex = 9;
            this.lblPalabraClaveActual.Text = "Palaba clave";
            // 
            // lblId_ejemplar
            // 
            this.lblId_ejemplar.Location = new System.Drawing.Point(33, 522);
            this.lblId_ejemplar.Name = "lblId_ejemplar";
            this.lblId_ejemplar.Size = new System.Drawing.Size(155, 25);
            this.lblId_ejemplar.TabIndex = 10;
            this.lblId_ejemplar.Text = "Número del ejemplar";
            // 
            // txtIdEjemplar
            // 
            this.txtIdEjemplar.Enabled = false;
            this.txtIdEjemplar.Location = new System.Drawing.Point(33, 550);
            this.txtIdEjemplar.Name = "txtIdEjemplar";
            this.txtIdEjemplar.Size = new System.Drawing.Size(178, 26);
            this.txtIdEjemplar.TabIndex = 11;
            // 
            // txtIDPalabra
            // 
            this.txtIDPalabra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDPalabra.ForeColor = System.Drawing.Color.White;
            this.txtIDPalabra.Location = new System.Drawing.Point(398, 573);
            this.txtIDPalabra.Name = "txtIDPalabra";
            this.txtIDPalabra.Size = new System.Drawing.Size(18, 19);
            this.txtIDPalabra.TabIndex = 12;
            // 
            // frmActualizarPalabraClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 620);
            this.Controls.Add(this.txtIDPalabra);
            this.Controls.Add(this.txtIdEjemplar);
            this.Controls.Add(this.lblId_ejemplar);
            this.Controls.Add(this.lblPalabraClaveActual);
            this.Controls.Add(this.dgvListaPalabras);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizarAgregarPalabra);
            this.Controls.Add(this.txtActualizarPalabra);
            this.Name = "frmActualizarPalabraClave";
            this.Text = "frmActualizarPalabraClave";
            this.Load += new System.EventHandler(this.frmActualizarPalabraClave_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvListaPalabras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtIDPalabra;

        private System.Windows.Forms.Label lblPalabraClaveActual;
        private System.Windows.Forms.Label lblId_ejemplar;
        private System.Windows.Forms.TextBox txtIdEjemplar;

        private System.Windows.Forms.DataGridView dgvListaPalabras;

        private System.Windows.Forms.Label lblInfoParaPalabras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblidEjemplarNuevo;
        private System.Windows.Forms.Button btnActualizarAgregarPalabra;
        private System.Windows.Forms.TextBox txtActualizarPalabra;

        #endregion
    }
}