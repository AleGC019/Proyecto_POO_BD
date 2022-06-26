using System.ComponentModel;

namespace BINAES_Proyecto
{
    partial class frmActualizarObjetivos
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
            this.txtIDObjetivo = new System.Windows.Forms.TextBox();
            this.txtIDEvento = new System.Windows.Forms.TextBox();
            this.lblId_ejemplar = new System.Windows.Forms.Label();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.dgvListaObjetivos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfoParaPalabras = new System.Windows.Forms.Label();
            this.lblidEjemplarNuevo = new System.Windows.Forms.Label();
            this.btnActualizarObjetivo = new System.Windows.Forms.Button();
            this.txtActualizarObjetivo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize) (this.dgvListaObjetivos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIDObjetivo
            // 
            this.txtIDObjetivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIDObjetivo.ForeColor = System.Drawing.Color.White;
            this.txtIDObjetivo.Location = new System.Drawing.Point(397, 581);
            this.txtIDObjetivo.Name = "txtIDObjetivo";
            this.txtIDObjetivo.Size = new System.Drawing.Size(18, 19);
            this.txtIDObjetivo.TabIndex = 28;
            // 
            // txtIDEvento
            // 
            this.txtIDEvento.Enabled = false;
            this.txtIDEvento.Location = new System.Drawing.Point(32, 558);
            this.txtIDEvento.Name = "txtIDEvento";
            this.txtIDEvento.Size = new System.Drawing.Size(178, 26);
            this.txtIDEvento.TabIndex = 27;
            // 
            // lblId_ejemplar
            // 
            this.lblId_ejemplar.Location = new System.Drawing.Point(32, 530);
            this.lblId_ejemplar.Name = "lblId_ejemplar";
            this.lblId_ejemplar.Size = new System.Drawing.Size(155, 25);
            this.lblId_ejemplar.TabIndex = 26;
            this.lblId_ejemplar.Text = "Número del evento";
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.Location = new System.Drawing.Point(43, 459);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(155, 25);
            this.lblObjetivo.TabIndex = 25;
            this.lblObjetivo.Text = "Objetivo";
            // 
            // dgvListaObjetivos
            // 
            this.dgvListaObjetivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaObjetivos.Location = new System.Drawing.Point(13, 93);
            this.dgvListaObjetivos.Name = "dgvListaObjetivos";
            this.dgvListaObjetivos.RowTemplate.Height = 28;
            this.dgvListaObjetivos.Size = new System.Drawing.Size(455, 347);
            this.dgvListaObjetivos.TabIndex = 24;
            this.dgvListaObjetivos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaObjetivos_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (29)))), ((int) (((byte) (122)))));
            this.panel1.Controls.Add(this.lblInfoParaPalabras);
            this.panel1.Controls.Add(this.lblidEjemplarNuevo);
            this.panel1.Location = new System.Drawing.Point(22, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 56);
            this.panel1.TabIndex = 23;
            // 
            // lblInfoParaPalabras
            // 
            this.lblInfoParaPalabras.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInfoParaPalabras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoParaPalabras.Location = new System.Drawing.Point(67, 9);
            this.lblInfoParaPalabras.Name = "lblInfoParaPalabras";
            this.lblInfoParaPalabras.Size = new System.Drawing.Size(307, 47);
            this.lblInfoParaPalabras.TabIndex = 3;
            this.lblInfoParaPalabras.Text = "Actualizar Objetivos";
            this.lblInfoParaPalabras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblidEjemplarNuevo
            // 
            this.lblidEjemplarNuevo.Location = new System.Drawing.Point(82, 78);
            this.lblidEjemplarNuevo.Name = "lblidEjemplarNuevo";
            this.lblidEjemplarNuevo.Size = new System.Drawing.Size(94, 32);
            this.lblidEjemplarNuevo.TabIndex = 2;
            // 
            // btnActualizarObjetivo
            // 
            this.btnActualizarObjetivo.Location = new System.Drawing.Point(258, 466);
            this.btnActualizarObjetivo.Name = "btnActualizarObjetivo";
            this.btnActualizarObjetivo.Size = new System.Drawing.Size(158, 47);
            this.btnActualizarObjetivo.TabIndex = 22;
            this.btnActualizarObjetivo.Text = "Actualizar objetivo";
            this.btnActualizarObjetivo.UseVisualStyleBackColor = true;
            this.btnActualizarObjetivo.Click += new System.EventHandler(this.btnActualizarObjetivo_Click);
            // 
            // txtActualizarObjetivo
            // 
            this.txtActualizarObjetivo.Location = new System.Drawing.Point(32, 487);
            this.txtActualizarObjetivo.Name = "txtActualizarObjetivo";
            this.txtActualizarObjetivo.Size = new System.Drawing.Size(178, 26);
            this.txtActualizarObjetivo.TabIndex = 21;
            // 
            // frmActualizarObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 620);
            this.Controls.Add(this.txtIDObjetivo);
            this.Controls.Add(this.txtIDEvento);
            this.Controls.Add(this.lblId_ejemplar);
            this.Controls.Add(this.lblObjetivo);
            this.Controls.Add(this.dgvListaObjetivos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizarObjetivo);
            this.Controls.Add(this.txtActualizarObjetivo);
            this.Name = "frmActualizarObjetivos";
            this.Text = "frmActualizarObjetivos";
            this.Load += new System.EventHandler(this.frmActualizarObjetivos_Load);
            ((System.ComponentModel.ISupportInitialize) (this.dgvListaObjetivos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtIDObjetivo;
        private System.Windows.Forms.TextBox txtIDEvento;
        private System.Windows.Forms.Label lblId_ejemplar;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.DataGridView dgvListaObjetivos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfoParaPalabras;
        private System.Windows.Forms.Label lblidEjemplarNuevo;
        private System.Windows.Forms.Button btnActualizarObjetivo;
        private System.Windows.Forms.TextBox txtActualizarObjetivo;

        #endregion
    }
}