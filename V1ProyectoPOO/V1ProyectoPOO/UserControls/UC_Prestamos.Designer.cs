using System.ComponentModel;

namespace V1ProyectoPOO.UserControls
{
    partial class UC_Prestamos
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
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.Location = new System.Drawing.Point(312, 270);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(366, 198);
            this.lblPrestamos.TabIndex = 0;
            this.lblPrestamos.Text = "Préstamos";
            // 
            // UC_Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblPrestamos);
            this.Name = "UC_Prestamos";
            this.Size = new System.Drawing.Size(781, 583);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblPrestamos;

        #endregion
    }
}