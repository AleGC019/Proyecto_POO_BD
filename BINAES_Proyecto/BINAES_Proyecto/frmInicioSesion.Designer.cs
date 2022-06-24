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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicioSesion));
            this.lblError = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblContra = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.picLogoInicio = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.picLogoInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblError.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblError.Location = new System.Drawing.Point(262, 327);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(214, 27);
            this.lblError.TabIndex = 13;
            this.lblError.Text = "Mensaje";
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogIn.Location = new System.Drawing.Point(227, 369);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(143, 27);
            this.btnLogIn.TabIndex = 12;
            this.btnLogIn.Text = "INICIAR SESION\r\n";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblContra
            // 
            this.lblContra.BackColor = System.Drawing.Color.Transparent;
            this.lblContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblContra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblContra.Location = new System.Drawing.Point(111, 289);
            this.lblContra.Name = "lblContra";
            this.lblContra.Size = new System.Drawing.Size(123, 27);
            this.lblContra.TabIndex = 11;
            this.lblContra.Text = "Constraseña: ";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUsuario.Location = new System.Drawing.Point(146, 252);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(88, 19);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario:";
            // 
            // txtContra
            // 
            this.txtContra.Location = new System.Drawing.Point(262, 294);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(202, 20);
            this.txtContra.TabIndex = 9;
            this.txtContra.UseSystemPasswordChar = true;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(262, 252);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(202, 20);
            this.txtusuario.TabIndex = 8;
            // 
            // picLogoInicio
            // 
            this.picLogoInicio.Image = global::BINAES_Proyecto.Properties.Resources._1;
            this.picLogoInicio.Location = new System.Drawing.Point(19, 23);
            this.picLogoInicio.Name = "picLogoInicio";
            this.picLogoInicio.Size = new System.Drawing.Size(548, 188);
            this.picLogoInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoInicio.TabIndex = 7;
            this.picLogoInicio.TabStop = false;
            // 
            // frmInicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(586, 419);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.lblContra);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.picLogoInicio);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "frmInicioSesion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BINAES";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmInicioSesion_FormClosed);
            this.Load += new System.EventHandler(this.frmInicioSesion_Load);
            ((System.ComponentModel.ISupportInitialize) (this.picLogoInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.PictureBox picLogoInicio;

        private System.Windows.Forms.Label lblContra;

        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Label lblUsuario;

        #endregion
    }
}