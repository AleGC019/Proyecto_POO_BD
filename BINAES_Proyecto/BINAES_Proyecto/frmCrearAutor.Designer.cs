using System.ComponentModel;

namespace BINAES_Proyecto
{
    partial class frmCrearAutor
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
            this.txtAgregarAutor = new System.Windows.Forms.TextBox();
            this.lblAgregarAutor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfoParaPalabras = new System.Windows.Forms.Label();
            this.lblidEjemplarNuevo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAgregarAutor
            // 
            this.txtAgregarAutor.Location = new System.Drawing.Point(140, 221);
            this.txtAgregarAutor.Name = "txtAgregarAutor";
            this.txtAgregarAutor.Size = new System.Drawing.Size(150, 26);
            this.txtAgregarAutor.TabIndex = 0;
            // 
            // lblAgregarAutor
            // 
            this.lblAgregarAutor.Location = new System.Drawing.Point(129, 273);
            this.lblAgregarAutor.Name = "lblAgregarAutor";
            this.lblAgregarAutor.Size = new System.Drawing.Size(177, 61);
            this.lblAgregarAutor.TabIndex = 1;
            this.lblAgregarAutor.Text = "Agregar Autor";
            this.lblAgregarAutor.UseVisualStyleBackColor = true;
            this.lblAgregarAutor.Click += new System.EventHandler(this.lblAgregarAutor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (29)))), ((int) (((byte) (122)))));
            this.panel1.Controls.Add(this.lblInfoParaPalabras);
            this.panel1.Controls.Add(this.lblidEjemplarNuevo);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 169);
            this.panel1.TabIndex = 5;
            // 
            // lblInfoParaPalabras
            // 
            this.lblInfoParaPalabras.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInfoParaPalabras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoParaPalabras.Location = new System.Drawing.Point(65, 31);
            this.lblInfoParaPalabras.Name = "lblInfoParaPalabras";
            this.lblInfoParaPalabras.Size = new System.Drawing.Size(260, 111);
            this.lblInfoParaPalabras.TabIndex = 3;
            this.lblInfoParaPalabras.Text = "Por favor ingrese los nombres de los autores para este ejemplar";
            this.lblInfoParaPalabras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblidEjemplarNuevo
            // 
            this.lblidEjemplarNuevo.Location = new System.Drawing.Point(83, 78);
            this.lblidEjemplarNuevo.Name = "lblidEjemplarNuevo";
            this.lblidEjemplarNuevo.Size = new System.Drawing.Size(95, 32);
            this.lblidEjemplarNuevo.TabIndex = 2;
            // 
            // frmCrearAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAgregarAutor);
            this.Controls.Add(this.txtAgregarAutor);
            this.Name = "frmCrearAutor";
            this.Text = "frmCrearAutor";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfoParaPalabras;
        private System.Windows.Forms.Label lblidEjemplarNuevo;

        private System.Windows.Forms.TextBox txtAgregarAutor;
        private System.Windows.Forms.Button lblAgregarAutor;

        #endregion
    }
}