using System.ComponentModel;

namespace BINAES_Proyecto
{
    partial class frmInicioSesion
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
            this.picLogoInicio = new System.Windows.Forms.PictureBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // picLogoInicio
            // 
            this.picLogoInicio.Image = global::BINAES_Proyecto.Properties.Resources._1;
            this.picLogoInicio.Location = new System.Drawing.Point(23, 34);
            this.picLogoInicio.Name = "picLogoInicio";
            this.picLogoInicio.Size = new System.Drawing.Size(548, 188);
            this.picLogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoInicio.TabIndex = 0;
            this.picLogoInicio.TabStop = false;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(174, 278);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(397, 20);
            this.txtusuario.TabIndex = 1;
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(174, 330);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(397, 20);
            this.txtContra.TabIndex = 2;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Location = new System.Drawing.Point(45, 278);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(101, 19);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblContra
            // 
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContra.Location = new System.Drawing.Point(23, 325);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(123, 27);
            this.lblContra.TabIndex = 4;
            this.lblContra.Text = "Constraseña: ";
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(586, 387);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.picLogoInicio);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmInicioSesion";
            this.Text = "frmInicioSesion";
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblContra;

        private System.Windows.Forms.PictureBox picLogoInicio;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblUsuario;

        #endregion
    }
}