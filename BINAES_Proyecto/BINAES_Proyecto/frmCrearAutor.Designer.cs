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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearAutor));
            this.txtAgregarAutor = new System.Windows.Forms.TextBox();
            this.lblAgregarAutor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfoObjetivos = new System.Windows.Forms.Label();
            this.lblInfoParaPalabras = new System.Windows.Forms.Label();
            this.lblidEjemplarNuevo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAgregarAutor
            // 
            this.txtAgregarAutor.Location = new System.Drawing.Point(139, 260);
            this.txtAgregarAutor.Name = "txtAgregarAutor";
            this.txtAgregarAutor.Size = new System.Drawing.Size(150, 26);
            this.txtAgregarAutor.TabIndex = 0;
            // 
            // lblAgregarAutor
            // 
            this.lblAgregarAutor.Location = new System.Drawing.Point(130, 322);
            this.lblAgregarAutor.Name = "lblAgregarAutor";
            this.lblAgregarAutor.Size = new System.Drawing.Size(177, 62);
            this.lblAgregarAutor.TabIndex = 1;
            this.lblAgregarAutor.Text = "Agregar Autor";
            this.lblAgregarAutor.UseVisualStyleBackColor = true;
            this.lblAgregarAutor.Click += new System.EventHandler(this.lblAgregarAutor_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (36)))), ((int) (((byte) (29)))), ((int) (((byte) (122)))));
            this.panel1.Controls.Add(this.lblInfoObjetivos);
            this.panel1.Controls.Add(this.lblInfoParaPalabras);
            this.panel1.Controls.Add(this.lblidEjemplarNuevo);
            this.panel1.Location = new System.Drawing.Point(24, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 190);
            this.panel1.TabIndex = 5;
            // 
            // lblInfoObjetivos
            // 
            this.lblInfoObjetivos.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInfoObjetivos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoObjetivos.Location = new System.Drawing.Point(45, 78);
            this.lblInfoObjetivos.Name = "lblInfoObjetivos";
            this.lblInfoObjetivos.Size = new System.Drawing.Size(331, 98);
            this.lblInfoObjetivos.TabIndex = 5;
            this.lblInfoObjetivos.Text = "Por favor ingrese los nombres de los autores del ejemplar uno por uno, después de" + " ingresa un objetivo recurde dar click en el botón agregar autor.";
            // 
            // lblInfoParaPalabras
            // 
            this.lblInfoParaPalabras.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInfoParaPalabras.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInfoParaPalabras.Location = new System.Drawing.Point(62, 0);
            this.lblInfoParaPalabras.Name = "lblInfoParaPalabras";
            this.lblInfoParaPalabras.Size = new System.Drawing.Size(260, 69);
            this.lblInfoParaPalabras.TabIndex = 3;
            this.lblInfoParaPalabras.Text = "AUTORES";
            this.lblInfoParaPalabras.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblidEjemplarNuevo
            // 
            this.lblidEjemplarNuevo.Location = new System.Drawing.Point(82, 78);
            this.lblidEjemplarNuevo.Name = "lblidEjemplarNuevo";
            this.lblidEjemplarNuevo.Size = new System.Drawing.Size(94, 32);
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
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "frmCrearAutor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BINAES";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblInfoObjetivos;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfoParaPalabras;
        private System.Windows.Forms.Label lblidEjemplarNuevo;

        private System.Windows.Forms.TextBox txtAgregarAutor;
        private System.Windows.Forms.Button lblAgregarAutor;

        #endregion
    }
}