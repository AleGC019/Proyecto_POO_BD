using System.ComponentModel;

namespace BINAES_Proyecto
{
    partial class frmObjetivos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfoParaPalabras = new System.Windows.Forms.Label();
            this.lblidEjemplarNuevo = new System.Windows.Forms.Label();
            this.btnAgregarObjetivo = new System.Windows.Forms.Button();
            this.txtAgregarObjetivo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (29)))), ((int) (((byte) (122)))));
            this.panel1.Controls.Add(this.lblInfoParaPalabras);
            this.panel1.Controls.Add(this.lblidEjemplarNuevo);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 169);
            this.panel1.TabIndex = 8;
            // 
            // lblInfoParaPalabras
            // 
            this.lblInfoParaPalabras.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInfoParaPalabras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoParaPalabras.Location = new System.Drawing.Point(67, 31);
            this.lblInfoParaPalabras.Name = "lblInfoParaPalabras";
            this.lblInfoParaPalabras.Size = new System.Drawing.Size(260, 111);
            this.lblInfoParaPalabras.TabIndex = 3;
            this.lblInfoParaPalabras.Text = "Por favor ingrese los objetivos de su evento.";
            this.lblInfoParaPalabras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblidEjemplarNuevo
            // 
            this.lblidEjemplarNuevo.Location = new System.Drawing.Point(82, 78);
            this.lblidEjemplarNuevo.Name = "lblidEjemplarNuevo";
            this.lblidEjemplarNuevo.Size = new System.Drawing.Size(94, 32);
            this.lblidEjemplarNuevo.TabIndex = 2;
            // 
            // btnAgregarObjetivo
            // 
            this.btnAgregarObjetivo.Location = new System.Drawing.Point(130, 334);
            this.btnAgregarObjetivo.Name = "btnAgregarObjetivo";
            this.btnAgregarObjetivo.Size = new System.Drawing.Size(177, 62);
            this.btnAgregarObjetivo.TabIndex = 7;
            this.btnAgregarObjetivo.Text = "Agregar Autor";
            this.btnAgregarObjetivo.UseVisualStyleBackColor = true;
            this.btnAgregarObjetivo.Click += new System.EventHandler(this.btnAgregarObjetivo_Click);
            // 
            // txtAgregarObjetivo
            // 
            this.txtAgregarObjetivo.Location = new System.Drawing.Point(140, 265);
            this.txtAgregarObjetivo.Name = "txtAgregarObjetivo";
            this.txtAgregarObjetivo.Size = new System.Drawing.Size(150, 26);
            this.txtAgregarObjetivo.TabIndex = 6;
            // 
            // frmObjetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregarObjetivo);
            this.Controls.Add(this.txtAgregarObjetivo);
            this.Name = "frmObjetivos";
            this.Text = "frmObjetivos";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfoParaPalabras;
        private System.Windows.Forms.Label lblidEjemplarNuevo;
        private System.Windows.Forms.Button btnAgregarObjetivo;
        private System.Windows.Forms.TextBox txtAgregarObjetivo;

        #endregion
    }
}