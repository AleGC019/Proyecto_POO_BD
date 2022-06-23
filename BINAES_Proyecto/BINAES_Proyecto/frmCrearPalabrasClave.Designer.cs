using System.ComponentModel;

namespace BINAES_Proyecto
{
    partial class frmCrearPalabrasClave
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
            this.txtAgregarPalabra = new System.Windows.Forms.TextBox();
            this.btnAgregarPalabra = new System.Windows.Forms.Button();
            this.lblidEjemplarNuevo = new System.Windows.Forms.Label();
            this.lblInfoParaPalabras = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAgregarPalabra
            // 
            this.txtAgregarPalabra.Location = new System.Drawing.Point(123, 237);
            this.txtAgregarPalabra.Name = "txtAgregarPalabra";
            this.txtAgregarPalabra.Size = new System.Drawing.Size(178, 26);
            this.txtAgregarPalabra.TabIndex = 0;
            // 
            // btnAgregarPalabra
            // 
            this.btnAgregarPalabra.Location = new System.Drawing.Point(107, 293);
            this.btnAgregarPalabra.Name = "btnAgregarPalabra";
            this.btnAgregarPalabra.Size = new System.Drawing.Size(209, 61);
            this.btnAgregarPalabra.TabIndex = 1;
            this.btnAgregarPalabra.Text = "Agregar palabra";
            this.btnAgregarPalabra.UseVisualStyleBackColor = true;
            this.btnAgregarPalabra.Click += new System.EventHandler(this.btnAgregarPalabra_Click);
            // 
            // lblidEjemplarNuevo
            // 
            this.lblidEjemplarNuevo.Location = new System.Drawing.Point(83, 78);
            this.lblidEjemplarNuevo.Name = "lblidEjemplarNuevo";
            this.lblidEjemplarNuevo.Size = new System.Drawing.Size(95, 32);
            this.lblidEjemplarNuevo.TabIndex = 2;
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
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 169);
            this.panel1.TabIndex = 4;
            // 
            // frmCrearPalabrasClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregarPalabra);
            this.Controls.Add(this.txtAgregarPalabra);
            this.Name = "frmCrearPalabrasClave";
            this.Text = "frmCrearPalabrasClave";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.Label lblInfoParaPalabras;

        private System.Windows.Forms.Label lblidEjemplarNuevo;

        private System.Windows.Forms.TextBox txtAgregarPalabra;
        private System.Windows.Forms.Button btnAgregarPalabra;

        #endregion
    }
}