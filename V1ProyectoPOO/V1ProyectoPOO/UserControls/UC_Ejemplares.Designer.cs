using System.ComponentModel;

namespace V1ProyectoPOO.UserControls
{
    partial class UC_Ejemplares
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
            this.lblEjemplares = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblEjemplares
            // 
            this.lblEjemplares.Location = new System.Drawing.Point(330, 264);
            this.lblEjemplares.Name = "lblEjemplares";
            this.lblEjemplares.Size = new System.Drawing.Size(237, 126);
            this.lblEjemplares.TabIndex = 0;
            this.lblEjemplares.Text = "Ejemplares";
            // 
            // UC_Ejemplares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEjemplares);
            this.Name = "UC_Ejemplares";
            this.Size = new System.Drawing.Size(781, 583);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblEjemplares;

        #endregion
    }
}