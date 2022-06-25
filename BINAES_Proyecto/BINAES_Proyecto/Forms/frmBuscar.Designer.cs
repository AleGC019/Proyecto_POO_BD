using System.ComponentModel;

namespace BINAES_Proyecto.Forms
{
    partial class frmBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBuscar));
            this.tlpBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFoundItem_PrestamoBuscar = new System.Windows.Forms.Panel();
            this.tlpFoundItem_Prestamo = new System.Windows.Forms.TableLayoutPanel();
            this.picFoundItem_Prestamo = new System.Windows.Forms.PictureBox();
            this.lblEncontrado = new System.Windows.Forms.Label();
            this.lblNombre_prestamoBuscar = new System.Windows.Forms.Label();
            this.lblID_prestamoBuscar = new System.Windows.Forms.Label();
            this.lblColeccion_prestamoBuscar = new System.Windows.Forms.Label();
            this.lblAutor_PrestamoBuscar = new System.Windows.Forms.Label();
            this.lblISBN_PRESTAMOBuscar = new System.Windows.Forms.Label();
            this.lblISSN_PRESTAMOBuscar = new System.Windows.Forms.Label();
            this.lblDOI_PRESTAMOBuscar = new System.Windows.Forms.Label();
            this.lblEditorial_PrestamoBuscar = new System.Windows.Forms.Label();
            this.lblFormato_PrestamoBuscar = new System.Windows.Forms.Label();
            this.lblIdioma_PrestamoBuscar = new System.Windows.Forms.Label();
            this.lbl_PC_prestamoBuscar = new System.Windows.Forms.Label();
            this.lblFecha_PrestamoBuscar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbOpcionesBuscar = new System.Windows.Forms.ComboBox();
            this.dgvResultadosBusqueda = new System.Windows.Forms.DataGridView();
            this.txtBuscarEjemplar = new System.Windows.Forms.TextBox();
            this.tlpBusqueda.SuspendLayout();
            this.pnlFoundItem_PrestamoBuscar.SuspendLayout();
            this.tlpFoundItem_Prestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picFoundItem_Prestamo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvResultadosBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpBusqueda
            // 
            this.tlpBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBusqueda.ColumnCount = 3;
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBusqueda.Controls.Add(this.pnlFoundItem_PrestamoBuscar, 0, 2);
            this.tlpBusqueda.Controls.Add(this.btnBuscar, 2, 0);
            this.tlpBusqueda.Controls.Add(this.cmbOpcionesBuscar, 0, 0);
            this.tlpBusqueda.Controls.Add(this.dgvResultadosBusqueda, 0, 1);
            this.tlpBusqueda.Controls.Add(this.txtBuscarEjemplar, 1, 0);
            this.tlpBusqueda.Location = new System.Drawing.Point(18, 18);
            this.tlpBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpBusqueda.Name = "tlpBusqueda";
            this.tlpBusqueda.RowCount = 3;
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 39.38053F));
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBusqueda.Size = new System.Drawing.Size(867, 678);
            this.tlpBusqueda.TabIndex = 1;
            // 
            // pnlFoundItem_PrestamoBuscar
            // 
            this.pnlFoundItem_PrestamoBuscar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBusqueda.SetColumnSpan(this.pnlFoundItem_PrestamoBuscar, 3);
            this.pnlFoundItem_PrestamoBuscar.Controls.Add(this.tlpFoundItem_Prestamo);
            this.pnlFoundItem_PrestamoBuscar.Location = new System.Drawing.Point(4, 343);
            this.pnlFoundItem_PrestamoBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlFoundItem_PrestamoBuscar.Name = "pnlFoundItem_PrestamoBuscar";
            this.pnlFoundItem_PrestamoBuscar.Size = new System.Drawing.Size(859, 330);
            this.pnlFoundItem_PrestamoBuscar.TabIndex = 4;
            // 
            // tlpFoundItem_Prestamo
            // 
            this.tlpFoundItem_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpFoundItem_Prestamo.ColumnCount = 2;
            this.tlpFoundItem_Prestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tlpFoundItem_Prestamo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tlpFoundItem_Prestamo.Controls.Add(this.picFoundItem_Prestamo, 0, 2);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblEncontrado, 0, 0);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblNombre_prestamoBuscar, 1, 2);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblID_prestamoBuscar, 1, 3);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblColeccion_prestamoBuscar, 1, 4);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblAutor_PrestamoBuscar, 1, 5);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblISBN_PRESTAMOBuscar, 1, 6);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblISSN_PRESTAMOBuscar, 1, 7);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblDOI_PRESTAMOBuscar, 1, 8);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblEditorial_PrestamoBuscar, 1, 10);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblFormato_PrestamoBuscar, 1, 11);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblIdioma_PrestamoBuscar, 1, 12);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lbl_PC_prestamoBuscar, 1, 13);
            this.tlpFoundItem_Prestamo.Controls.Add(this.lblFecha_PrestamoBuscar, 1, 9);
            this.tlpFoundItem_Prestamo.Location = new System.Drawing.Point(22, 18);
            this.tlpFoundItem_Prestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
            this.tlpFoundItem_Prestamo.Size = new System.Drawing.Size(814, 289);
            this.tlpFoundItem_Prestamo.TabIndex = 0;
            // 
            // picFoundItem_Prestamo
            // 
            this.picFoundItem_Prestamo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.picFoundItem_Prestamo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFoundItem_Prestamo.Location = new System.Drawing.Point(4, 43);
            this.picFoundItem_Prestamo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFoundItem_Prestamo.Name = "picFoundItem_Prestamo";
            this.tlpFoundItem_Prestamo.SetRowSpan(this.picFoundItem_Prestamo, 12);
            this.picFoundItem_Prestamo.Size = new System.Drawing.Size(276, 218);
            this.picFoundItem_Prestamo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoundItem_Prestamo.TabIndex = 0;
            this.picFoundItem_Prestamo.TabStop = false;
            // 
            // lblEncontrado
            // 
            this.lblEncontrado.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEncontrado.AutoSize = true;
            this.tlpFoundItem_Prestamo.SetColumnSpan(this.lblEncontrado, 2);
            this.lblEncontrado.Location = new System.Drawing.Point(4, 0);
            this.lblEncontrado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncontrado.Name = "lblEncontrado";
            this.lblEncontrado.Size = new System.Drawing.Size(806, 19);
            this.lblEncontrado.TabIndex = 1;
            this.lblEncontrado.Text = "¡Ejemplar encontrado!";
            this.lblEncontrado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNombre_prestamoBuscar
            // 
            this.lblNombre_prestamoBuscar.AutoSize = true;
            this.lblNombre_prestamoBuscar.Location = new System.Drawing.Point(288, 38);
            this.lblNombre_prestamoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre_prestamoBuscar.Name = "lblNombre_prestamoBuscar";
            this.lblNombre_prestamoBuscar.Size = new System.Drawing.Size(51, 19);
            this.lblNombre_prestamoBuscar.TabIndex = 2;
            this.lblNombre_prestamoBuscar.Text = "label1";
            // 
            // lblID_prestamoBuscar
            // 
            this.lblID_prestamoBuscar.AutoSize = true;
            this.lblID_prestamoBuscar.Location = new System.Drawing.Point(288, 57);
            this.lblID_prestamoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID_prestamoBuscar.Name = "lblID_prestamoBuscar";
            this.lblID_prestamoBuscar.Size = new System.Drawing.Size(51, 19);
            this.lblID_prestamoBuscar.TabIndex = 3;
            this.lblID_prestamoBuscar.Text = "label2";
            // 
            // lblColeccion_prestamoBuscar
            // 
            this.lblColeccion_prestamoBuscar.AutoSize = true;
            this.lblColeccion_prestamoBuscar.Location = new System.Drawing.Point(288, 76);
            this.lblColeccion_prestamoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColeccion_prestamoBuscar.Name = "lblColeccion_prestamoBuscar";
            this.lblColeccion_prestamoBuscar.Size = new System.Drawing.Size(51, 19);
            this.lblColeccion_prestamoBuscar.TabIndex = 4;
            this.lblColeccion_prestamoBuscar.Text = "label3";
            // 
            // lblAutor_PrestamoBuscar
            // 
            this.lblAutor_PrestamoBuscar.AutoSize = true;
            this.lblAutor_PrestamoBuscar.Location = new System.Drawing.Point(288, 95);
            this.lblAutor_PrestamoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAutor_PrestamoBuscar.Name = "lblAutor_PrestamoBuscar";
            this.lblAutor_PrestamoBuscar.Size = new System.Drawing.Size(51, 19);
            this.lblAutor_PrestamoBuscar.TabIndex = 5;
            this.lblAutor_PrestamoBuscar.Text = "label4";
            // 
            // lblISBN_PRESTAMOBuscar
            // 
            this.lblISBN_PRESTAMOBuscar.AutoSize = true;
            this.lblISBN_PRESTAMOBuscar.Location = new System.Drawing.Point(288, 114);
            this.lblISBN_PRESTAMOBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISBN_PRESTAMOBuscar.Name = "lblISBN_PRESTAMOBuscar";
            this.lblISBN_PRESTAMOBuscar.Size = new System.Drawing.Size(51, 19);
            this.lblISBN_PRESTAMOBuscar.TabIndex = 6;
            this.lblISBN_PRESTAMOBuscar.Text = "label5";
            // 
            // lblISSN_PRESTAMOBuscar
            // 
            this.lblISSN_PRESTAMOBuscar.AutoSize = true;
            this.lblISSN_PRESTAMOBuscar.Location = new System.Drawing.Point(288, 133);
            this.lblISSN_PRESTAMOBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISSN_PRESTAMOBuscar.Name = "lblISSN_PRESTAMOBuscar";
            this.lblISSN_PRESTAMOBuscar.Size = new System.Drawing.Size(51, 19);
            this.lblISSN_PRESTAMOBuscar.TabIndex = 7;
            this.lblISSN_PRESTAMOBuscar.Text = "label6";
            // 
            // lblDOI_PRESTAMOBuscar
            // 
            this.lblDOI_PRESTAMOBuscar.AutoSize = true;
            this.lblDOI_PRESTAMOBuscar.Location = new System.Drawing.Point(288, 152);
            this.lblDOI_PRESTAMOBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOI_PRESTAMOBuscar.Name = "lblDOI_PRESTAMOBuscar";
            this.lblDOI_PRESTAMOBuscar.Size = new System.Drawing.Size(51, 19);
            this.lblDOI_PRESTAMOBuscar.TabIndex = 8;
            this.lblDOI_PRESTAMOBuscar.Text = "label7";
            // 
            // lblEditorial_PrestamoBuscar
            // 
            this.lblEditorial_PrestamoBuscar.AutoSize = true;
            this.lblEditorial_PrestamoBuscar.Location = new System.Drawing.Point(288, 190);
            this.lblEditorial_PrestamoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEditorial_PrestamoBuscar.Name = "lblEditorial_PrestamoBuscar";
            this.lblEditorial_PrestamoBuscar.Size = new System.Drawing.Size(51, 19);
            this.lblEditorial_PrestamoBuscar.TabIndex = 10;
            this.lblEditorial_PrestamoBuscar.Text = "label9";
            // 
            // lblFormato_PrestamoBuscar
            // 
            this.lblFormato_PrestamoBuscar.AutoSize = true;
            this.lblFormato_PrestamoBuscar.Location = new System.Drawing.Point(288, 209);
            this.lblFormato_PrestamoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormato_PrestamoBuscar.Name = "lblFormato_PrestamoBuscar";
            this.lblFormato_PrestamoBuscar.Size = new System.Drawing.Size(60, 19);
            this.lblFormato_PrestamoBuscar.TabIndex = 11;
            this.lblFormato_PrestamoBuscar.Text = "label10";
            // 
            // lblIdioma_PrestamoBuscar
            // 
            this.lblIdioma_PrestamoBuscar.AutoSize = true;
            this.lblIdioma_PrestamoBuscar.Location = new System.Drawing.Point(288, 228);
            this.lblIdioma_PrestamoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdioma_PrestamoBuscar.Name = "lblIdioma_PrestamoBuscar";
            this.lblIdioma_PrestamoBuscar.Size = new System.Drawing.Size(60, 19);
            this.lblIdioma_PrestamoBuscar.TabIndex = 12;
            this.lblIdioma_PrestamoBuscar.Text = "label11";
            // 
            // lbl_PC_prestamoBuscar
            // 
            this.lbl_PC_prestamoBuscar.AutoSize = true;
            this.lbl_PC_prestamoBuscar.Location = new System.Drawing.Point(288, 247);
            this.lbl_PC_prestamoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PC_prestamoBuscar.Name = "lbl_PC_prestamoBuscar";
            this.lbl_PC_prestamoBuscar.Size = new System.Drawing.Size(60, 19);
            this.lbl_PC_prestamoBuscar.TabIndex = 13;
            this.lbl_PC_prestamoBuscar.Text = "label12";
            // 
            // lblFecha_PrestamoBuscar
            // 
            this.lblFecha_PrestamoBuscar.AutoSize = true;
            this.lblFecha_PrestamoBuscar.Location = new System.Drawing.Point(288, 171);
            this.lblFecha_PrestamoBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha_PrestamoBuscar.Name = "lblFecha_PrestamoBuscar";
            this.lblFecha_PrestamoBuscar.Size = new System.Drawing.Size(51, 19);
            this.lblFecha_PrestamoBuscar.TabIndex = 14;
            this.lblFecha_PrestamoBuscar.Text = "label7";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(697, 5);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(166, 62);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Elemento";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // cmbOpcionesBuscar
            // 
            this.cmbOpcionesBuscar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOpcionesBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesBuscar.FormattingEnabled = true;
            this.cmbOpcionesBuscar.Items.AddRange(new object[] {"Titulo completo", "Titulo parcial ", "Autor", "Por palabra clave", "Digital", "Fisico", "Mostrar todos"});
            this.cmbOpcionesBuscar.Location = new System.Drawing.Point(4, 5);
            this.cmbOpcionesBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbOpcionesBuscar.Name = "cmbOpcionesBuscar";
            this.cmbOpcionesBuscar.Size = new System.Drawing.Size(252, 28);
            this.cmbOpcionesBuscar.TabIndex = 2;
            // 
            // dgvResultadosBusqueda
            // 
            this.dgvResultadosBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultadosBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultadosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpBusqueda.SetColumnSpan(this.dgvResultadosBusqueda, 3);
            this.dgvResultadosBusqueda.Location = new System.Drawing.Point(4, 77);
            this.dgvResultadosBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvResultadosBusqueda.Name = "dgvResultadosBusqueda";
            this.dgvResultadosBusqueda.Size = new System.Drawing.Size(859, 256);
            this.dgvResultadosBusqueda.TabIndex = 0;
            // 
            // txtBuscarEjemplar
            // 
            this.txtBuscarEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarEjemplar.Location = new System.Drawing.Point(264, 5);
            this.txtBuscarEjemplar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarEjemplar.Name = "txtBuscarEjemplar";
            this.txtBuscarEjemplar.Size = new System.Drawing.Size(425, 26);
            this.txtBuscarEjemplar.TabIndex = 3;
            // 
            // frmBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 715);
            this.Controls.Add(this.tlpBusqueda);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "frmBuscar";
            this.Text = "frmBuscar";
            this.Load += new System.EventHandler(this.frmBuscar_Load);
            this.tlpBusqueda.ResumeLayout(false);
            this.tlpBusqueda.PerformLayout();
            this.pnlFoundItem_PrestamoBuscar.ResumeLayout(false);
            this.tlpFoundItem_Prestamo.ResumeLayout(false);
            this.tlpFoundItem_Prestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picFoundItem_Prestamo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dgvResultadosBusqueda)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlFoundItem_PrestamoBuscar;
        private System.Windows.Forms.TableLayoutPanel tlpFoundItem_Prestamo;
        private System.Windows.Forms.PictureBox picFoundItem_Prestamo;
        private System.Windows.Forms.Label lblEncontrado;
        private System.Windows.Forms.Label lblNombre_prestamoBuscar;
        private System.Windows.Forms.Label lblID_prestamoBuscar;
        private System.Windows.Forms.Label lblColeccion_prestamoBuscar;
        private System.Windows.Forms.Label lblAutor_PrestamoBuscar;
        private System.Windows.Forms.Label lblISBN_PRESTAMOBuscar;
        private System.Windows.Forms.Label lblISSN_PRESTAMOBuscar;
        private System.Windows.Forms.Label lblDOI_PRESTAMOBuscar;
        private System.Windows.Forms.Label lblEditorial_PrestamoBuscar;
        private System.Windows.Forms.Label lblFormato_PrestamoBuscar;
        private System.Windows.Forms.Label lblIdioma_PrestamoBuscar;
        private System.Windows.Forms.Label lbl_PC_prestamoBuscar;
        private System.Windows.Forms.Label lblFecha_PrestamoBuscar;

        private System.Windows.Forms.TableLayoutPanel tlpBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbOpcionesBuscar;
        private System.Windows.Forms.DataGridView dgvResultadosBusqueda;
        private System.Windows.Forms.TextBox txtBuscarEjemplar;

        #endregion
    }
}