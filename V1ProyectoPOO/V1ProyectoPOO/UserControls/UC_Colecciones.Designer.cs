using System.ComponentModel;

namespace V1ProyectoPOO.UserControls
{
    partial class UC_Colecciones
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
            this.lblColecciones = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblColecciones
            // 
            this.lblColecciones.Location = new System.Drawing.Point(309, 297);
            this.lblColecciones.Name = "lblColecciones";
            this.lblColecciones.Size = new System.Drawing.Size(169, 90);
            this.lblColecciones.TabIndex = 0;
            this.lblColecciones.Text = "Colecciones";
            // 
            // UC_Colecciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblColecciones);
            this.Name = "UC_Colecciones";
            this.Size = new System.Drawing.Size(781, 583);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblColecciones;

        #endregion
    }
}