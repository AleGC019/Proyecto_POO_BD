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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearEditorial));
            this.txtNuevaEditorial = new System.Windows.Forms.TextBox();
            this.btnAgregarEditorial = new System.Windows.Forms.Button();
            this.lblNuevaEditorial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNuevaEditorial
            // 
            this.txtNuevaEditorial.Location = new System.Drawing.Point(89, 101);
            this.txtNuevaEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevaEditorial.Name = "txtNuevaEditorial";
            this.txtNuevaEditorial.Size = new System.Drawing.Size(105, 20);
            this.txtNuevaEditorial.TabIndex = 0;
            // 
            // btnAgregarEditorial
            // 
            this.btnAgregarEditorial.Location = new System.Drawing.Point(92, 144);
            this.btnAgregarEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarEditorial.Name = "btnAgregarEditorial";
            this.btnAgregarEditorial.Size = new System.Drawing.Size(114, 32);
            this.btnAgregarEditorial.TabIndex = 1;
            this.btnAgregarEditorial.Text = "Agregar Editorial";
            this.btnAgregarEditorial.UseVisualStyleBackColor = true;
            this.btnAgregarEditorial.Click += new System.EventHandler(this.btnAgregarEditorial_Click);
            // 
            // lblNuevaEditorial
            // 
            this.lblNuevaEditorial.Location = new System.Drawing.Point(85, 64);
            this.lblNuevaEditorial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNuevaEditorial.Name = "lblNuevaEditorial";
            this.lblNuevaEditorial.Size = new System.Drawing.Size(106, 14);
            this.lblNuevaEditorial.TabIndex = 2;
            this.lblNuevaEditorial.Text = "Nueva Editorial";
            // 
            // frmCrearEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 342);
            this.Controls.Add(this.lblNuevaEditorial);
            this.Controls.Add(this.btnAgregarEditorial);
            this.Controls.Add(this.txtNuevaEditorial);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCrearEditorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BINAES";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtNuevaEditorial;
        private System.Windows.Forms.Button btnAgregarEditorial;
        private System.Windows.Forms.Label lblNuevaEditorial;

        #endregion
    }
}