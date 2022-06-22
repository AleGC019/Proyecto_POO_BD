using System.ComponentModel;

namespace BINAES_Proyecto.Forms
{
    partial class frmPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamo));
            this.grpVerificarExistencia_Prestamo = new System.Windows.Forms.GroupBox();
            this.tlpBusqueda_Prestamo = new System.Windows.Forms.TableLayoutPanel();
            this.lblTipoBusqueda_Prestamo = new System.Windows.Forms.Label();
            this.cmbTipoBusqueda_Prestamo = new System.Windows.Forms.ComboBox();
            this.txtBusqueda_Prestamo = new System.Windows.Forms.TextBox();
            this.btnBuscar_Prestamo = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlFoundItem_Prestamo = new System.Windows.Forms.Panel();
            this.picFoundItem_Prestamo = new System.Windows.Forms.PictureBox();
            this.grpVerificarExistencia_Prestamo.SuspendLayout();
            this.tlpBusqueda_Prestamo.SuspendLayout();
            this.pnlFoundItem_Prestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoundItem_Prestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpVerificarExistencia_Prestamo
            // 
            this.grpVerificarExistencia_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVerificarExistencia_Prestamo.Controls.Add(this.tlpBusqueda_Prestamo);
            this.grpVerificarExistencia_Prestamo.Location = new System.Drawing.Point(12, 12);
            this.grpVerificarExistencia_Prestamo.Name = "grpVerificarExistencia_Prestamo";
            this.grpVerificarExistencia_Prestamo.Size = new System.Drawing.Size(1016, 286);
            this.grpVerificarExistencia_Prestamo.TabIndex = 0;
            this.grpVerificarExistencia_Prestamo.TabStop = false;
            this.grpVerificarExistencia_Prestamo.Text = "Busqueda de material";
            // 
            // tlpBusqueda_Prestamo
            // 
            this.tlpBusqueda_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBusqueda_Prestamo.ColumnCount = 7;
            this.tlpBusqueda_Prestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpBusqueda_Prestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBusqueda_Prestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpBusqueda_Prestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBusqueda_Prestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpBusqueda_Prestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBusqueda_Prestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpBusqueda_Prestamo.Controls.Add(this.lblTipoBusqueda_Prestamo, 1, 1);
            this.tlpBusqueda_Prestamo.Controls.Add(this.cmbTipoBusqueda_Prestamo, 1, 3);
            this.tlpBusqueda_Prestamo.Controls.Add(this.txtBusqueda_Prestamo, 3, 3);
            this.tlpBusqueda_Prestamo.Controls.Add(this.btnBuscar_Prestamo, 5, 2);
            this.tlpBusqueda_Prestamo.Location = new System.Drawing.Point(6, 19);
            this.tlpBusqueda_Prestamo.Name = "tlpBusqueda_Prestamo";
            this.tlpBusqueda_Prestamo.RowCount = 4;
            this.tlpBusqueda_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpBusqueda_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBusqueda_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpBusqueda_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpBusqueda_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBusqueda_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBusqueda_Prestamo.Size = new System.Drawing.Size(1004, 261);
            this.tlpBusqueda_Prestamo.TabIndex = 2;
            // 
            // lblTipoBusqueda_Prestamo
            // 
            this.lblTipoBusqueda_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoBusqueda_Prestamo.AutoSize = true;
            this.lblTipoBusqueda_Prestamo.Location = new System.Drawing.Point(53, 13);
            this.lblTipoBusqueda_Prestamo.Name = "lblTipoBusqueda_Prestamo";
            this.lblTipoBusqueda_Prestamo.Size = new System.Drawing.Size(94, 52);
            this.lblTipoBusqueda_Prestamo.TabIndex = 0;
            this.lblTipoBusqueda_Prestamo.Text = "Tipo de busqueda;";
            this.lblTipoBusqueda_Prestamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTipoBusqueda_Prestamo
            // 
            this.cmbTipoBusqueda_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTipoBusqueda_Prestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBusqueda_Prestamo.FormattingEnabled = true;
            this.cmbTipoBusqueda_Prestamo.Items.AddRange(new object[] {
            "Titulo completo"});
            this.cmbTipoBusqueda_Prestamo.Location = new System.Drawing.Point(53, 81);
            this.cmbTipoBusqueda_Prestamo.Name = "cmbTipoBusqueda_Prestamo";
            this.cmbTipoBusqueda_Prestamo.Size = new System.Drawing.Size(94, 21);
            this.cmbTipoBusqueda_Prestamo.TabIndex = 1;
            // 
            // txtBusqueda_Prestamo
            // 
            this.txtBusqueda_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBusqueda_Prestamo.Location = new System.Drawing.Point(203, 81);
            this.txtBusqueda_Prestamo.Name = "txtBusqueda_Prestamo";
            this.txtBusqueda_Prestamo.Size = new System.Drawing.Size(496, 20);
            this.txtBusqueda_Prestamo.TabIndex = 2;
            // 
            // btnBuscar_Prestamo
            // 
            this.btnBuscar_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar_Prestamo.Location = new System.Drawing.Point(755, 68);
            this.btnBuscar_Prestamo.Name = "btnBuscar_Prestamo";
            this.tlpBusqueda_Prestamo.SetRowSpan(this.btnBuscar_Prestamo, 2);
            this.btnBuscar_Prestamo.Size = new System.Drawing.Size(194, 43);
            this.btnBuscar_Prestamo.TabIndex = 3;
            this.btnBuscar_Prestamo.Text = "Buscar";
            this.btnBuscar_Prestamo.UseVisualStyleBackColor = true;
            this.btnBuscar_Prestamo.Click += new System.EventHandler(this.btnBuscar_Prestamo_Click);
            // 
            // pnlFoundItem_Prestamo
            // 
            this.pnlFoundItem_Prestamo.Controls.Add(this.picFoundItem_Prestamo);
            this.pnlFoundItem_Prestamo.Location = new System.Drawing.Point(18, 304);
            this.pnlFoundItem_Prestamo.Name = "pnlFoundItem_Prestamo";
            this.pnlFoundItem_Prestamo.Size = new System.Drawing.Size(1010, 275);
            this.pnlFoundItem_Prestamo.TabIndex = 1;
            // 
            // picFoundItem_Prestamo
            // 
            this.picFoundItem_Prestamo.Location = new System.Drawing.Point(13, 15);
            this.picFoundItem_Prestamo.Name = "picFoundItem_Prestamo";
            this.picFoundItem_Prestamo.Size = new System.Drawing.Size(150, 244);
            this.picFoundItem_Prestamo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoundItem_Prestamo.TabIndex = 0;
            this.picFoundItem_Prestamo.TabStop = false;
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 591);
            this.Controls.Add(this.pnlFoundItem_Prestamo);
            this.Controls.Add(this.grpVerificarExistencia_Prestamo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrestamo";
            this.Text = "frmPrestamo";
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            this.grpVerificarExistencia_Prestamo.ResumeLayout(false);
            this.tlpBusqueda_Prestamo.ResumeLayout(false);
            this.tlpBusqueda_Prestamo.PerformLayout();
            this.pnlFoundItem_Prestamo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoundItem_Prestamo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpVerificarExistencia_Prestamo;
        private BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TableLayoutPanel tlpBusqueda_Prestamo;
        private System.Windows.Forms.Label lblTipoBusqueda_Prestamo;
        private System.Windows.Forms.ComboBox cmbTipoBusqueda_Prestamo;
        private System.Windows.Forms.TextBox txtBusqueda_Prestamo;
        private System.Windows.Forms.Button btnBuscar_Prestamo;
        private System.Windows.Forms.Panel pnlFoundItem_Prestamo;
        private System.Windows.Forms.PictureBox picFoundItem_Prestamo;
    }
}