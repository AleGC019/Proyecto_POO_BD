using System.ComponentModel;

namespace V1ProyectoPOO.UserControls
{
    partial class UC_Eventos
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblEventos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEventos
            // 
            this.lblEventos.Location = new System.Drawing.Point(322, 228);
            this.lblEventos.Name = "lblEventos";
            this.lblEventos.Size = new System.Drawing.Size(217, 135);
            this.lblEventos.TabIndex = 0;
            this.lblEventos.Text = "Eventos";
            // 
            // UC_Eventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEventos);
            this.Name = "UC_Eventos";
            this.Size = new System.Drawing.Size(781, 583);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblEventos;

        #endregion
    }
}