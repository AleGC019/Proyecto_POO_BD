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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamo));
            this.grpVerificarExistencia_Prestamo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar_Prestamo = new System.Windows.Forms.Button();
            this.txtBusqueda_Prestamo = new System.Windows.Forms.TextBox();
            this.cmbTipoBusqueda_Prestamo = new System.Windows.Forms.ComboBox();
            this.lblTipoBusqueda_Prestamo = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnlFoundItem_Prestamo = new System.Windows.Forms.Panel();
            this.tlpFoundItem_Prestamo = new System.Windows.Forms.TableLayoutPanel();
            this.picFoundItem_Prestamo = new System.Windows.Forms.PictureBox();
            this.lblEncontrado = new System.Windows.Forms.Label();
            this.lblNombre_prestamo = new System.Windows.Forms.Label();
            this.lblID_prestamo = new System.Windows.Forms.Label();
            this.lblColeccion_prestamo = new System.Windows.Forms.Label();
            this.lblAutor_Prestamo = new System.Windows.Forms.Label();
            this.lblISBN_PRESTAMO = new System.Windows.Forms.Label();
            this.lblISSN_PRESTAMO = new System.Windows.Forms.Label();
            this.lblDOI_PRESTAMO = new System.Windows.Forms.Label();
            this.lblEditorial_Prestamo = new System.Windows.Forms.Label();
            this.lblFormato_Prestamo = new System.Windows.Forms.Label();
            this.lblIdioma_Prestamo = new System.Windows.Forms.Label();
            this.lbl_PC_prestamo = new System.Windows.Forms.Label();
            this.lblFecha_Prestamo = new System.Windows.Forms.Label();
            this.pnlPrestamoContainer = new System.Windows.Forms.Panel();
            this.tltVerificarDisponibilidad = new System.Windows.Forms.ToolTip(this.components);
            this.grpVerificarExistencia_Prestamo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlFoundItem_Prestamo.SuspendLayout();
            this.tlpFoundItem_Prestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picFoundItem_Prestamo)).BeginInit();
            this.pnlPrestamoContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpVerificarExistencia_Prestamo
            // 
            this.grpVerificarExistencia_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpVerificarExistencia_Prestamo.Controls.Add(this.tableLayoutPanel1);
            this.grpVerificarExistencia_Prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grpVerificarExistencia_Prestamo.Location = new System.Drawing.Point(11, 20);
            this.grpVerificarExistencia_Prestamo.Name = "grpVerificarExistencia_Prestamo";
            this.grpVerificarExistencia_Prestamo.Size = new System.Drawing.Size(536, 117);
            this.grpVerificarExistencia_Prestamo.TabIndex = 0;
            this.grpVerificarExistencia_Prestamo.TabStop = false;
            this.grpVerificarExistencia_Prestamo.Text = "Busqueda de material";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Controls.Add(this.btnBuscar_Prestamo, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBusqueda_Prestamo, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipoBusqueda_Prestamo, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTipoBusqueda_Prestamo, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(524, 92);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnBuscar_Prestamo
            // 
            this.btnBuscar_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar_Prestamo.Location = new System.Drawing.Point(369, 7);
            this.btnBuscar_Prestamo.Name = "btnBuscar_Prestamo";
            this.tableLayoutPanel1.SetRowSpan(this.btnBuscar_Prestamo, 3);
            this.btnBuscar_Prestamo.Size = new System.Drawing.Size(125, 76);
            this.btnBuscar_Prestamo.TabIndex = 3;
            this.btnBuscar_Prestamo.Text = "Buscar";
            this.btnBuscar_Prestamo.UseVisualStyleBackColor = true;
            this.btnBuscar_Prestamo.Click += new System.EventHandler(this.btnBuscar_Prestamo_Click);
            // 
            // txtBusqueda_Prestamo
            // 
            this.txtBusqueda_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.txtBusqueda_Prestamo, 2);
            this.txtBusqueda_Prestamo.Location = new System.Drawing.Point(29, 50);
            this.txtBusqueda_Prestamo.Name = "txtBusqueda_Prestamo";
            this.txtBusqueda_Prestamo.Size = new System.Drawing.Size(308, 20);
            this.txtBusqueda_Prestamo.TabIndex = 2;
            // 
            // cmbTipoBusqueda_Prestamo
            // 
            this.cmbTipoBusqueda_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbTipoBusqueda_Prestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoBusqueda_Prestamo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoBusqueda_Prestamo.FormattingEnabled = true;
            this.cmbTipoBusqueda_Prestamo.Items.AddRange(new object[] {"Titulo completo", "Titulo parcial"});
            this.cmbTipoBusqueda_Prestamo.Location = new System.Drawing.Point(160, 7);
            this.cmbTipoBusqueda_Prestamo.Name = "cmbTipoBusqueda_Prestamo";
            this.cmbTipoBusqueda_Prestamo.Size = new System.Drawing.Size(177, 21);
            this.cmbTipoBusqueda_Prestamo.TabIndex = 1;
            // 
            // lblTipoBusqueda_Prestamo
            // 
            this.lblTipoBusqueda_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoBusqueda_Prestamo.AutoSize = true;
            this.lblTipoBusqueda_Prestamo.Location = new System.Drawing.Point(29, 4);
            this.lblTipoBusqueda_Prestamo.Name = "lblTipoBusqueda_Prestamo";
            this.lblTipoBusqueda_Prestamo.Size = new System.Drawing.Size(125, 13);
            this.lblTipoBusqueda_Prestamo.TabIndex = 0;
            this.lblTipoBusqueda_Prestamo.Text = "Tipo de busqueda:";
            this.lblTipoBusqueda_Prestamo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlFoundItem_Prestamo
            // 
            this.pnlFoundItem_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFoundItem_Prestamo.Controls.Add(this.tlpFoundItem_Prestamo);
            this.pnlFoundItem_Prestamo.Location = new System.Drawing.Point(11, 143);
            this.pnlFoundItem_Prestamo.Name = "pnlFoundItem_Prestamo";
            this.pnlFoundItem_Prestamo.Size = new System.Drawing.Size(536, 296);
            this.pnlFoundItem_Prestamo.TabIndex = 1;
            // 
            // tlpFoundItem_Prestamo
            // 
            this.tlpFoundItem_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFoundItem_Prestamo.ColumnCount = 2;
            this.tlpFoundItem_Prestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpFoundItem_Prestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpFoundItem_Prestamo.Controls.Add(this.picFoundItem_Prestamo, 0, 2);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblEncontrado, 0, 0);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblNombre_prestamo, 1, 2);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblID_prestamo, 1, 3);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblColeccion_prestamo, 1, 4);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblAutor_Prestamo, 1, 5);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblISBN_PRESTAMO, 1, 6);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblISSN_PRESTAMO, 1, 7);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblDOI_PRESTAMO, 1, 8);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblEditorial_Prestamo, 1, 10);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblFormato_Prestamo, 1, 11);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblIdioma_Prestamo, 1, 12);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lbl_PC_prestamo, 1, 13);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblFecha_Prestamo, 1, 9);
            this.tlpFoundItem_Prestamo.Location = new System.Drawing.Point(15, 12);
            this.tlpFoundItem_Prestamo.Name = "tlpFoundItem_Prestamo";
            this.tlpFoundItem_Prestamo.RowCount = 15;
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.249999F));
            this.tlpFoundItem_Prestamo.Size = new System.Drawing.Size(506, 269);
            this.tlpFoundItem_Prestamo.TabIndex = 0;
            // 
            // picFoundItem_Prestamo
            // 
            this.picFoundItem_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.picFoundItem_Prestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFoundItem_Prestamo.Location = new System.Drawing.Point(3, 37);
            this.picFoundItem_Prestamo.Name = "picFoundItem_Prestamo";
            this.tlpFoundItem_Prestamo.SetRowSpan(this.picFoundItem_Prestamo, 12);
            this.picFoundItem_Prestamo.Size = new System.Drawing.Size(171, 198);
            this.picFoundItem_Prestamo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoundItem_Prestamo.TabIndex = 0;
            this.picFoundItem_Prestamo.TabStop = false;
            this.tltVerificarDisponibilidad.SetToolTip(this.picFoundItem_Prestamo, "Haga clic aquí para saber su disponibildiad");
            // 
            // lblEncontrado
            // 
            this.lblEncontrado.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncontrado.AutoSize = true;
            this.tlpFoundItem_Prestamo.SetColumnSpan(this.lblEncontrado, 2);
            this.lblEncontrado.Location = new System.Drawing.Point(3, 0);
            this.lblEncontrado.Name = "lblEncontrado";
            this.lblEncontrado.Size = new System.Drawing.Size(500, 17);
            this.lblEncontrado.TabIndex = 1;
            this.lblEncontrado.Text = "¡Ejemplar encontrado!";
            this.lblEncontrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre_prestamo
            // 
            this.lblNombre_prestamo.AutoSize = true;
            this.lblNombre_prestamo.Location = new System.Drawing.Point(180, 34);
            this.lblNombre_prestamo.Name = "lblNombre_prestamo";
            this.lblNombre_prestamo.Size = new System.Drawing.Size(35, 13);
            this.lblNombre_prestamo.TabIndex = 2;
            this.lblNombre_prestamo.Text = "label1";
            // 
            // lblID_prestamo
            // 
            this.lblID_prestamo.AutoSize = true;
            this.lblID_prestamo.Location = new System.Drawing.Point(180, 51);
            this.lblID_prestamo.Name = "lblID_prestamo";
            this.lblID_prestamo.Size = new System.Drawing.Size(35, 13);
            this.lblID_prestamo.TabIndex = 3;
            this.lblID_prestamo.Text = "label2";
            // 
            // lblColeccion_prestamo
            // 
            this.lblColeccion_prestamo.AutoSize = true;
            this.lblColeccion_prestamo.Location = new System.Drawing.Point(180, 68);
            this.lblColeccion_prestamo.Name = "lblColeccion_prestamo";
            this.lblColeccion_prestamo.Size = new System.Drawing.Size(35, 13);
            this.lblColeccion_prestamo.TabIndex = 4;
            this.lblColeccion_prestamo.Text = "label3";
            // 
            // lblAutor_Prestamo
            // 
            this.lblAutor_Prestamo.AutoSize = true;
            this.lblAutor_Prestamo.Location = new System.Drawing.Point(180, 85);
            this.lblAutor_Prestamo.Name = "lblAutor_Prestamo";
            this.lblAutor_Prestamo.Size = new System.Drawing.Size(35, 13);
            this.lblAutor_Prestamo.TabIndex = 5;
            this.lblAutor_Prestamo.Text = "label4";
            // 
            // lblISBN_PRESTAMO
            // 
            this.lblISBN_PRESTAMO.AutoSize = true;
            this.lblISBN_PRESTAMO.Location = new System.Drawing.Point(180, 102);
            this.lblISBN_PRESTAMO.Name = "lblISBN_PRESTAMO";
            this.lblISBN_PRESTAMO.Size = new System.Drawing.Size(35, 13);
            this.lblISBN_PRESTAMO.TabIndex = 6;
            this.lblISBN_PRESTAMO.Text = "label5";
            // 
            // lblISSN_PRESTAMO
            // 
            this.lblISSN_PRESTAMO.AutoSize = true;
            this.lblISSN_PRESTAMO.Location = new System.Drawing.Point(180, 119);
            this.lblISSN_PRESTAMO.Name = "lblISSN_PRESTAMO";
            this.lblISSN_PRESTAMO.Size = new System.Drawing.Size(35, 13);
            this.lblISSN_PRESTAMO.TabIndex = 7;
            this.lblISSN_PRESTAMO.Text = "label6";
            // 
            // lblDOI_PRESTAMO
            // 
            this.lblDOI_PRESTAMO.AutoSize = true;
            this.lblDOI_PRESTAMO.Location = new System.Drawing.Point(180, 136);
            this.lblDOI_PRESTAMO.Name = "lblDOI_PRESTAMO";
            this.lblDOI_PRESTAMO.Size = new System.Drawing.Size(35, 13);
            this.lblDOI_PRESTAMO.TabIndex = 8;
            this.lblDOI_PRESTAMO.Text = "label7";
            // 
            // lblEditorial_Prestamo
            // 
            this.lblEditorial_Prestamo.AutoSize = true;
            this.lblEditorial_Prestamo.Location = new System.Drawing.Point(180, 170);
            this.lblEditorial_Prestamo.Name = "lblEditorial_Prestamo";
            this.lblEditorial_Prestamo.Size = new System.Drawing.Size(35, 13);
            this.lblEditorial_Prestamo.TabIndex = 10;
            this.lblEditorial_Prestamo.Text = "label9";
            // 
            // lblFormato_Prestamo
            // 
            this.lblFormato_Prestamo.AutoSize = true;
            this.lblFormato_Prestamo.Location = new System.Drawing.Point(180, 187);
            this.lblFormato_Prestamo.Name = "lblFormato_Prestamo";
            this.lblFormato_Prestamo.Size = new System.Drawing.Size(41, 13);
            this.lblFormato_Prestamo.TabIndex = 11;
            this.lblFormato_Prestamo.Text = "label10";
            // 
            // lblIdioma_Prestamo
            // 
            this.lblIdioma_Prestamo.AutoSize = true;
            this.lblIdioma_Prestamo.Location = new System.Drawing.Point(180, 204);
            this.lblIdioma_Prestamo.Name = "lblIdioma_Prestamo";
            this.lblIdioma_Prestamo.Size = new System.Drawing.Size(41, 13);
            this.lblIdioma_Prestamo.TabIndex = 12;
            this.lblIdioma_Prestamo.Text = "label11";
            // 
            // lbl_PC_prestamo
            // 
            this.lbl_PC_prestamo.AutoSize = true;
            this.lbl_PC_prestamo.Location = new System.Drawing.Point(180, 221);
            this.lbl_PC_prestamo.Name = "lbl_PC_prestamo";
            this.lbl_PC_prestamo.Size = new System.Drawing.Size(41, 13);
            this.lbl_PC_prestamo.TabIndex = 13;
            this.lbl_PC_prestamo.Text = "label12";
            // 
            // lblFecha_Prestamo
            // 
            this.lblFecha_Prestamo.AutoSize = true;
            this.lblFecha_Prestamo.Location = new System.Drawing.Point(180, 153);
            this.lblFecha_Prestamo.Name = "lblFecha_Prestamo";
            this.lblFecha_Prestamo.Size = new System.Drawing.Size(35, 13);
            this.lblFecha_Prestamo.TabIndex = 14;
            this.lblFecha_Prestamo.Text = "label7";
            // 
            // pnlPrestamoContainer
            // 
            this.pnlPrestamoContainer.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPrestamoContainer.Controls.Add(this.grpVerificarExistencia_Prestamo);
            this.pnlPrestamoContainer.Controls.Add(this.pnlFoundItem_Prestamo);
            this.pnlPrestamoContainer.Location = new System.Drawing.Point(12, 12);
            this.pnlPrestamoContainer.Name = "pnlPrestamoContainer";
            this.pnlPrestamoContainer.Size = new System.Drawing.Size(560, 457);
            this.pnlPrestamoContainer.TabIndex = 2;
            // 
            // tltVerificarDisponibilidad
            // 
            this.tltVerificarDisponibilidad.IsBalloon = true;
            this.tltVerificarDisponibilidad.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tltVerificarDisponibilidad.ToolTipTitle = "Haga doble clic sobre la imagen";
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 481);
            this.Controls.Add(this.pnlPrestamoContainer);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "frmPrestamo";
            this.Text = "frmPrestamo";
            this.Load += new System.EventHandler(this.frmPrestamo_Load);
            this.grpVerificarExistencia_Prestamo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.pnlFoundItem_Prestamo.ResumeLayout(false);
            this.tlpFoundItem_Prestamo.ResumeLayout(false);
            this.tlpFoundItem_Prestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picFoundItem_Prestamo)).EndInit();
            this.pnlPrestamoContainer.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpVerificarExistencia_Prestamo;
        private BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTipoBusqueda_Prestamo;
        private System.Windows.Forms.ComboBox cmbTipoBusqueda_Prestamo;
        private System.Windows.Forms.TextBox txtBusqueda_Prestamo;
        private System.Windows.Forms.Button btnBuscar_Prestamo;
        private System.Windows.Forms.Panel pnlFoundItem_Prestamo;
        private System.Windows.Forms.Panel pnlPrestamoContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tlpFoundItem_Prestamo;
        private System.Windows.Forms.PictureBox picFoundItem_Prestamo;
        private System.Windows.Forms.Label lblEncontrado;
        private System.Windows.Forms.Label lblNombre_prestamo;
        private System.Windows.Forms.Label lblID_prestamo;
        private System.Windows.Forms.Label lblColeccion_prestamo;
        private System.Windows.Forms.Label lblAutor_Prestamo;
        private System.Windows.Forms.Label lblISBN_PRESTAMO;
        private System.Windows.Forms.Label lblISSN_PRESTAMO;
        private System.Windows.Forms.Label lblDOI_PRESTAMO;
        private System.Windows.Forms.Label lblEditorial_Prestamo;
        private System.Windows.Forms.Label lblFormato_Prestamo;
        private System.Windows.Forms.Label lblIdioma_Prestamo;
        private System.Windows.Forms.Label lbl_PC_prestamo;
        private System.Windows.Forms.Label lblFecha_Prestamo;
        private System.Windows.Forms.ToolTip tltVerificarDisponibilidad;
    }
}