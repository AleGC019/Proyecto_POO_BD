using System.ComponentModel;

namespace BINAES_Proyecto
{
    partial class frmCrearEditorial
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
            this.txtNuevaEditorial = new System.Windows.Forms.TextBox();
            this.btnAgregarEditorial = new System.Windows.Forms.Button();
            this.lblNuevaEditorial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNuevaEditorial
            // 
            this.txtNuevaEditorial.Location = new System.Drawing.Point(133, 155);
            this.txtNuevaEditorial.Name = "txtNuevaEditorial";
            this.txtNuevaEditorial.Size = new System.Drawing.Size(155, 26);
            this.txtNuevaEditorial.TabIndex = 0;
            // 
            // btnAgregarEditorial
            // 
            this.btnAgregarEditorial.Location = new System.Drawing.Point(138, 221);
            this.btnAgregarEditorial.Name = "btnAgregarEditorial";
            this.btnAgregarEditorial.Size = new System.Drawing.Size(171, 50);
            this.btnAgregarEditorial.TabIndex = 1;
            this.btnAgregarEditorial.Text = "Agregar Editorial";
            this.btnAgregarEditorial.UseVisualStyleBackColor = true;
            this.btnAgregarEditorial.Click += new System.EventHandler(this.btnAgregarEditorial_Click);
            // 
            // lblNuevaEditorial
            // 
            this.lblNuevaEditorial.Location = new System.Drawing.Point(128, 99);
            this.lblNuevaEditorial.Name = "lblNuevaEditorial";
            this.lblNuevaEditorial.Size = new System.Drawing.Size(159, 21);
            this.lblNuevaEditorial.TabIndex = 2;
            this.lblNuevaEditorial.Text = "Nueva Editorial";
            // 
            // frmCrearEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 526);
            this.Controls.Add(this.lblNuevaEditorial);
            this.Controls.Add(this.btnAgregarEditorial);
            this.Controls.Add(this.txtNuevaEditorial);
            this.Name = "frmCrearEditorial";
            this.Text = "CrearEditorial";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNuevaEditorial;
        private System.Windows.Forms.Button btnAgregarEditorial;
        private System.Windows.Forms.Label lblNuevaEditorial;

        #endregion
    }
}