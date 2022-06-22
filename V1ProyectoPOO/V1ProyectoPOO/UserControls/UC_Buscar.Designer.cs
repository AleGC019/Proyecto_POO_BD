using System.ComponentModel;

namespace V1ProyectoPOO.UserControls
{
    partial class UC_Buscar
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
            this.tlpBuscar = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTopBuscar = new System.Windows.Forms.Panel();
            this.cmbOpcionesBuscar = new System.Windows.Forms.ComboBox();
            this.dgvResultadosBusqueda = new System.Windows.Forms.DataGridView();
            this.txtBuscarEjemplar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTipodeBusqueda = new System.Windows.Forms.Label();
            this.tlpBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBuscar
            // 
            this.tlpBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBuscar.AutoSize = true;
            this.tlpBuscar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpBuscar.ColumnCount = 7;
            this.tlpBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.988353F));
            this.tlpBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.95341F));
            this.tlpBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.53461F));
            this.tlpBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.07155F));
            this.tlpBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.492513F));
            this.tlpBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlpBuscar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpBuscar.Controls.Add(this.pnlTopBuscar, 0, 0);
            this.tlpBuscar.Controls.Add(this.cmbOpcionesBuscar, 1, 2);
            this.tlpBuscar.Controls.Add(this.dgvResultadosBusqueda, 1, 3);
            this.tlpBuscar.Controls.Add(this.txtBuscarEjemplar, 3, 2);
            this.tlpBuscar.Controls.Add(this.btnBuscar, 5, 2);
            this.tlpBuscar.Controls.Add(this.lblTipodeBusqueda, 1, 1);
            this.tlpBuscar.Location = new System.Drawing.Point(2, 0);
            this.tlpBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlpBuscar.Name = "tlpBuscar";
            this.tlpBuscar.RowCount = 5;
            this.tlpBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.51203F));
            this.tlpBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.4811F));
            this.tlpBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.04124F));
            this.tlpBuscar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpBuscar.Size = new System.Drawing.Size(505, 385);
            this.tlpBuscar.TabIndex = 0;
            // 
            // pnlTopBuscar
            // 
            this.pnlTopBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tlpBuscar.SetColumnSpan(this.pnlTopBuscar, 6);
            this.pnlTopBuscar.Location = new System.Drawing.Point(2, 2);
            this.pnlTopBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlTopBuscar.Name = "pnlTopBuscar";
            this.pnlTopBuscar.Size = new System.Drawing.Size(459, 30);
            this.pnlTopBuscar.TabIndex = 0;
            // 
            // cmbOpcionesBuscar
            // 
            this.cmbOpcionesBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOpcionesBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesBuscar.FormattingEnabled = true;
            this.cmbOpcionesBuscar.Items.AddRange(new object[] {
            "Titulo completo",
            "Titulo parcial ",
            "Autor",
            "Por palabra clave",
            "Digital",
            "Fisico",
            "Mostrar todos"});
            this.cmbOpcionesBuscar.Location = new System.Drawing.Point(29, 75);
            this.cmbOpcionesBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbOpcionesBuscar.Name = "cmbOpcionesBuscar";
            this.cmbOpcionesBuscar.Size = new System.Drawing.Size(104, 21);
            this.cmbOpcionesBuscar.TabIndex = 3;
            // 
            // dgvResultadosBusqueda
            // 
            this.dgvResultadosBusqueda.AllowUserToDeleteRows = false;
            this.dgvResultadosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpBuscar.SetColumnSpan(this.dgvResultadosBusqueda, 5);
            this.dgvResultadosBusqueda.Location = new System.Drawing.Point(29, 111);
            this.dgvResultadosBusqueda.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvResultadosBusqueda.Name = "dgvResultadosBusqueda";
            this.dgvResultadosBusqueda.ReadOnly = true;
            this.dgvResultadosBusqueda.RowHeadersWidth = 62;
            this.dgvResultadosBusqueda.RowTemplate.Height = 28;
            this.dgvResultadosBusqueda.Size = new System.Drawing.Size(407, 231);
            this.dgvResultadosBusqueda.TabIndex = 2;
            // 
            // txtBuscarEjemplar
            // 
            this.txtBuscarEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarEjemplar.Location = new System.Drawing.Point(150, 75);
            this.txtBuscarEjemplar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscarEjemplar.Name = "txtBuscarEjemplar";
            this.txtBuscarEjemplar.Size = new System.Drawing.Size(217, 20);
            this.txtBuscarEjemplar.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.Location = new System.Drawing.Point(388, 75);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 32);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTipodeBusqueda
            // 
            this.lblTipodeBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipodeBusqueda.AutoSize = true;
            this.lblTipodeBusqueda.Location = new System.Drawing.Point(29, 34);
            this.lblTipodeBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipodeBusqueda.Name = "lblTipodeBusqueda";
            this.lblTipodeBusqueda.Size = new System.Drawing.Size(104, 39);
            this.lblTipodeBusqueda.TabIndex = 5;
            this.lblTipodeBusqueda.Text = "Selccionar tipo de busqueda:";
            this.lblTipodeBusqueda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpBuscar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_Buscar";
            this.Size = new System.Drawing.Size(521, 395);
            this.tlpBuscar.ResumeLayout(false);
            this.tlpBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosBusqueda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBuscar;
        private System.Windows.Forms.Panel pnlTopBuscar;
        private System.Windows.Forms.ComboBox cmbOpcionesBuscar;
        private System.Windows.Forms.DataGridView dgvResultadosBusqueda;
        private System.Windows.Forms.TextBox txtBuscarEjemplar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTipodeBusqueda;
    }
}