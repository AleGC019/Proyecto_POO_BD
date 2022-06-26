using System.ComponentModel;

namespace BINAES_Proyecto
{
    partial class frmActualizarAutor
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
            this.txtIDAutor = new System.Windows.Forms.TextBox();
            this.txtIdEjemplar = new System.Windows.Forms.TextBox();
            this.lblId_ejemplar = new System.Windows.Forms.Label();
            this.lblNombreAutor = new System.Windows.Forms.Label();
            this.dgvListaAutores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfoParaPalabras = new System.Windows.Forms.Label();
            this.lblidEjemplarNuevo = new System.Windows.Forms.Label();
            this.btnActualizarAutor = new System.Windows.Forms.Button();
            this.txtActualizarNombreAutor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dgvListaAutores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIDAutor
            // 
            this.txtIDAutor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDAutor.ForeColor = System.Drawing.Color.White;
            this.txtIDAutor.Location = new System.Drawing.Point(397, 581);
            this.txtIDAutor.Name = "txtIDAutor";
            this.txtIDAutor.Size = new System.Drawing.Size(18, 19);
            this.txtIDAutor.TabIndex = 20;
            // 
            // txtIdEjemplar
            // 
            this.txtIdEjemplar.Enabled = false;
            this.txtIdEjemplar.Location = new System.Drawing.Point(32, 558);
            this.txtIdEjemplar.Name = "txtIdEjemplar";
            this.txtIdEjemplar.Size = new System.Drawing.Size(178, 26);
            this.txtIdEjemplar.TabIndex = 19;
            // 
            // lblId_ejemplar
            // 
            this.lblId_ejemplar.Location = new System.Drawing.Point(32, 530);
            this.lblId_ejemplar.Name = "lblId_ejemplar";
            this.lblId_ejemplar.Size = new System.Drawing.Size(155, 25);
            this.lblId_ejemplar.TabIndex = 18;
            this.lblId_ejemplar.Text = "Número del ejemplar";
            // 
            // lblNombreAutor
            // 
            this.lblNombreAutor.Location = new System.Drawing.Point(43, 459);
            this.lblNombreAutor.Name = "lblNombreAutor";
            this.lblNombreAutor.Size = new System.Drawing.Size(155, 25);
            this.lblNombreAutor.TabIndex = 17;
            this.lblNombreAutor.Text = "Nombre del autor";
            // 
            // dgvListaAutores
            // 
            this.dgvListaAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAutores.Location = new System.Drawing.Point(13, 93);
            this.dgvListaAutores.Name = "dgvListaAutores";
            this.dgvListaAutores.RowTemplate.Height = 28;
            this.dgvListaAutores.Size = new System.Drawing.Size(455, 347);
            this.dgvListaAutores.TabIndex = 16;
            this.dgvListaAutores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaAutores_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (29)))), ((int) (((byte) (122)))));
            this.panel1.Controls.Add(this.lblInfoParaPalabras);
            this.panel1.Controls.Add(this.lblidEjemplarNuevo);
            this.panel1.Location = new System.Drawing.Point(22, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 56);
            this.panel1.TabIndex = 15;
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
            // lblidEjemplarNuevo
            // 
            this.lblidEjemplarNuevo.Location = new System.Drawing.Point(82, 78);
            this.lblidEjemplarNuevo.Name = "lblidEjemplarNuevo";
            this.lblidEjemplarNuevo.Size = new System.Drawing.Size(94, 32);
            this.lblidEjemplarNuevo.TabIndex = 2;
            // 
            // btnActualizarAutor
            // 
            this.btnActualizarAutor.Location = new System.Drawing.Point(258, 466);
            this.btnActualizarAutor.Name = "btnActualizarAutor";
            this.btnActualizarAutor.Size = new System.Drawing.Size(158, 47);
            this.btnActualizarAutor.TabIndex = 14;
            this.btnActualizarAutor.Text = "Actualizar autor";
            this.btnActualizarAutor.UseVisualStyleBackColor = true;
            this.btnActualizarAutor.Click += new System.EventHandler(this.btnActualizarAutor_Click);
            // 
            // txtActualizarNombreAutor
            // 
            this.txtActualizarNombreAutor.Location = new System.Drawing.Point(32, 487);
            this.txtActualizarNombreAutor.Name = "txtActualizarNombreAutor";
            this.txtActualizarNombreAutor.Size = new System.Drawing.Size(178, 26);
            this.txtActualizarNombreAutor.TabIndex = 13;
            // 
            // frmActualizarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 620);
            this.Controls.Add(this.txtIDAutor);
            this.Controls.Add(this.txtIdEjemplar);
            this.Controls.Add(this.lblId_ejemplar);
            this.Controls.Add(this.lblNombreAutor);
            this.Controls.Add(this.dgvListaAutores);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizarAutor);
            this.Controls.Add(this.txtActualizarNombreAutor);
            this.Name = "frmActualizarAutor";
            this.Text = "frmActualizarAutor";
            this.Load += new System.EventHandler(this.frmActualizarAutor_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvListaAutores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtIDAutor;
        private System.Windows.Forms.TextBox txtIdEjemplar;
        private System.Windows.Forms.Label lblId_ejemplar;
        private System.Windows.Forms.Label lblNombreAutor;
        private System.Windows.Forms.DataGridView dgvListaAutores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfoParaPalabras;
        private System.Windows.Forms.Label lblidEjemplarNuevo;
        private System.Windows.Forms.Button btnActualizarAutor;
        private System.Windows.Forms.TextBox txtActualizarNombreAutor;

        #endregion
    }
}