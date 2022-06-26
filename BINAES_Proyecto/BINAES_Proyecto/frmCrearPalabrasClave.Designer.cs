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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearPalabrasClave));
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
            this.txtAgregarPalabra.Location = new System.Drawing.Point(82, 154);
            this.txtAgregarPalabra.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgregarPalabra.Name = "txtAgregarPalabra";
            this.txtAgregarPalabra.Size = new System.Drawing.Size(120, 20);
            this.txtAgregarPalabra.TabIndex = 0;
            // 
            // btnAgregarPalabra
            // 
            this.btnAgregarPalabra.Location = new System.Drawing.Point(71, 190);
            this.btnAgregarPalabra.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarPalabra.Name = "btnAgregarPalabra";
            this.btnAgregarPalabra.Size = new System.Drawing.Size(139, 40);
            this.btnAgregarPalabra.TabIndex = 1;
            this.btnAgregarPalabra.Text = "Agregar palabra";
            this.btnAgregarPalabra.UseVisualStyleBackColor = true;
            this.btnAgregarPalabra.Click += new System.EventHandler(this.btnAgregarPalabra_Click);
            // 
            // lblidEjemplarNuevo
            // 
            this.lblidEjemplarNuevo.Location = new System.Drawing.Point(55, 51);
            this.lblidEjemplarNuevo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblidEjemplarNuevo.Name = "lblidEjemplarNuevo";
            this.lblidEjemplarNuevo.Size = new System.Drawing.Size(63, 21);
            this.lblidEjemplarNuevo.TabIndex = 2;
            // 
            // lblInfoParaPalabras
            // 
            this.lblInfoParaPalabras.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInfoParaPalabras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoParaPalabras.Location = new System.Drawing.Point(41, 20);
            this.lblInfoParaPalabras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoParaPalabras.Name = "lblInfoParaPalabras";
            this.lblInfoParaPalabras.Size = new System.Drawing.Size(173, 72);
            this.lblInfoParaPalabras.TabIndex = 3;
            this.lblInfoParaPalabras.Text = "Por favor ingrese las palabras claves para este ejemplar";
            this.lblInfoParaPalabras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (29)))), ((int) (((byte) (122)))));
            this.panel1.Controls.Add(this.lblInfoParaPalabras);
            this.panel1.Controls.Add(this.lblidEjemplarNuevo);
            this.panel1.Location = new System.Drawing.Point(16, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 110);
            this.panel1.TabIndex = 4;
            // 
            // frmCrearPalabrasClave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(293, 342);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAgregarPalabra);
            this.Controls.Add(this.txtAgregarPalabra);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCrearPalabrasClave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BINAES";
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