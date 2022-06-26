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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoParaPalabras
            // 
            this.lblInfoParaPalabras.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInfoParaPalabras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoParaPalabras.Location = new System.Drawing.Point(61, 31);
            this.lblInfoParaPalabras.Name = "lblInfoParaPalabras";
            this.lblInfoParaPalabras.Size = new System.Drawing.Size(260, 111);
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
            this.panel1.Size = new System.Drawing.Size(394, 169);
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
            this.btnActualizarAgregarPalabra.Location = new System.Drawing.Point(117, 298);
            this.btnActualizarAgregarPalabra.Name = "btnActualizarAgregarPalabra";
            this.btnActualizarAgregarPalabra.Size = new System.Drawing.Size(208, 62);
            this.btnActualizarAgregarPalabra.TabIndex = 6;
            this.btnActualizarAgregarPalabra.Text = "Actualizar palabra";
            this.btnActualizarAgregarPalabra.UseVisualStyleBackColor = true;
            this.btnActualizarAgregarPalabra.Click += new System.EventHandler(this.btnActualizarAgregarPalabra_Click);
            // 
            // txtActualizarPalabra
            // 
            this.txtActualizarPalabra.Location = new System.Drawing.Point(129, 237);
            this.txtActualizarPalabra.Name = "txtActualizarPalabra";
            this.txtActualizarPalabra.Size = new System.Drawing.Size(178, 26);
            this.txtActualizarPalabra.TabIndex = 5;
            // 
            // frmActualizarPalabraClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnActualizarAgregarPalabra);
            this.Controls.Add(this.txtActualizarPalabra);
            this.Name = "frmActualizarPalabraClave";
            this.Text = "frmActualizarPalabraClave";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblInfoParaPalabras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblidEjemplarNuevo;
        private System.Windows.Forms.Button btnActualizarAgregarPalabra;
        private System.Windows.Forms.TextBox txtActualizarPalabra;

        #endregion
    }
}