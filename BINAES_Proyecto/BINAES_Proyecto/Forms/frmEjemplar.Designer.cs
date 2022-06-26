using System.ComponentModel;

namespace BINAES_Proyecto.Forms
{
    partial class frmEjemplar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEjemplar));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tlpEjemplar = new System.Windows.Forms.TableLayoutPanel();
            this.lblNombreEjemplar = new System.Windows.Forms.Label();
            this.txtNombreEjemplar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.cmbColeccionEjemplar = new System.Windows.Forms.ComboBox();
            this.lblInfoEjemplar = new System.Windows.Forms.Label();
            this.txtFechaPublicacion = new System.Windows.Forms.TextBox();
            this.picImagenEjemplar = new System.Windows.Forms.PictureBox();
            this.btnCrearEjemplar = new System.Windows.Forms.Button();
            this.btnCrearAutor = new System.Windows.Forms.Button();
            this.btnCrearPalabrasClave = new System.Windows.Forms.Button();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.btnAgregarImagenEjemplar = new System.Windows.Forms.Button();
            this.lblDoi = new System.Windows.Forms.Label();
            this.lblissn = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtissn = new System.Windows.Forms.TextBox();
            this.txtDoi = new System.Windows.Forms.TextBox();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.lblidioma = new System.Windows.Forms.Label();
            this.cmbFomato = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.btnCrearEditorial = new System.Windows.Forms.Button();
            this.lblColeccionEjemplar = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bntConfirmarID = new System.Windows.Forms.Button();
            this.btnActualizarImagen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtActualizarISB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtActualizarISSN = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtActualizarDOI = new System.Windows.Forms.TextBox();
            this.btnActualizarAutor = new System.Windows.Forms.Button();
            this.btnActualizarPalabrasClave = new System.Windows.Forms.Button();
            this.cmbActualizarIdioma = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbActualizarFormato = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbActualizarEditorial = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbColeccionActualizar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActualizarFechaEjemplar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtActualizarNombreEjemplar = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtIDActualizarEjemplar = new System.Windows.Forms.TextBox();
            this.btnActualizarEejmplar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnEliminarEjemplar = new System.Windows.Forms.Button();
            this.txtidEliminarEjemplar = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlpBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbOpcionesBuscar = new System.Windows.Forms.ComboBox();
            this.dgvResultadosBusqueda = new System.Windows.Forms.DataGridView();
            this.txtBuscarEjemplar = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tlpEjemplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picImagenEjemplar)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvResultadosBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 436);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tlpEjemplar);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(632, 398);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Agregar ejemplar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tlpEjemplar
            // 
            this.tlpEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.ColumnCount = 11;
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158185F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158187F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.Controls.Add(this.lblNombreEjemplar, 1, 1);
            this.tlpEjemplar.Controls.Add(this.txtNombreEjemplar, 1, 2);
            this.tlpEjemplar.Controls.Add(this.label5, 1, 3);
            this.tlpEjemplar.Controls.Add(this.lblEditorial, 1, 7);
            this.tlpEjemplar.Controls.Add(this.cmbColeccionEjemplar, 1, 6);
            this.tlpEjemplar.Controls.Add(this.lblInfoEjemplar, 1, 0);
            this.tlpEjemplar.Controls.Add(this.txtFechaPublicacion, 1, 4);
            this.tlpEjemplar.Controls.Add(this.picImagenEjemplar, 7, 1);
            this.tlpEjemplar.Controls.Add(this.btnCrearEjemplar, 1, 14);
            this.tlpEjemplar.Controls.Add(this.btnCrearAutor, 4, 14);
            this.tlpEjemplar.Controls.Add(this.btnCrearPalabrasClave, 7, 14);
            this.tlpEjemplar.Controls.Add(this.cmbEditorial, 1, 8);
            this.tlpEjemplar.Controls.Add(this.btnAgregarImagenEjemplar, 1, 12);
            this.tlpEjemplar.Controls.Add(this.lblDoi, 5, 12);
            this.tlpEjemplar.Controls.Add(this.lblissn, 5, 11);
            this.tlpEjemplar.Controls.Add(this.lblISBN, 5, 10);
            this.tlpEjemplar.Controls.Add(this.txtIsbn, 6, 10);
            this.tlpEjemplar.Controls.Add(this.txtissn, 6, 11);
            this.tlpEjemplar.Controls.Add(this.txtDoi, 6, 12);
            this.tlpEjemplar.Controls.Add(this.cmbIdioma, 6, 8);
            this.tlpEjemplar.Controls.Add(this.lblidioma, 6, 7);
            this.tlpEjemplar.Controls.Add(this.cmbFomato, 6, 6);
            this.tlpEjemplar.Controls.Add(this.lblFormato, 6, 5);
            this.tlpEjemplar.Controls.Add(this.btnCrearEditorial, 1, 10);
            this.tlpEjemplar.Controls.Add(this.lblColeccionEjemplar, 1, 5);
            this.tlpEjemplar.Location = new System.Drawing.Point(0, 4);
            this.tlpEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.tlpEjemplar.Name = "tlpEjemplar";
            this.tlpEjemplar.RowCount = 15;
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.59322F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.949152F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.152542F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.457627F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.305085F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.050848F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.152542F));
            this.tlpEjemplar.Size = new System.Drawing.Size(634, 407);
            this.tlpEjemplar.TabIndex = 0;
            // 
            // lblNombreEjemplar
            // 
            this.lblNombreEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblNombreEjemplar, 4);
            this.lblNombreEjemplar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNombreEjemplar.Location = new System.Drawing.Point(59, 25);
            this.lblNombreEjemplar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEjemplar.Name = "lblNombreEjemplar";
            this.lblNombreEjemplar.Size = new System.Drawing.Size(224, 22);
            this.lblNombreEjemplar.TabIndex = 1;
            this.lblNombreEjemplar.Text = "Nombre del ejemplar";
            this.lblNombreEjemplar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNombreEjemplar
            // 
            this.txtNombreEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtNombreEjemplar, 5);
            this.txtNombreEjemplar.Location = new System.Drawing.Point(59, 49);
            this.txtNombreEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEjemplar.Name = "txtNombreEjemplar";
            this.txtNombreEjemplar.Size = new System.Drawing.Size(281, 20);
            this.txtNombreEjemplar.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.label5, 4);
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(59, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fecha de publicación";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblEditorial
            // 
            this.lblEditorial.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblEditorial, 4);
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEditorial.Location = new System.Drawing.Point(59, 175);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(224, 25);
            this.lblEditorial.TabIndex = 18;
            this.lblEditorial.Text = "Editorial";
            this.lblEditorial.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbColeccionEjemplar
            // 
            this.tlpEjemplar.SetColumnSpan(this.cmbColeccionEjemplar, 4);
            this.cmbColeccionEjemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColeccionEjemplar.FormattingEnabled = true;
            this.cmbColeccionEjemplar.Location = new System.Drawing.Point(59, 152);
            this.cmbColeccionEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbColeccionEjemplar.Name = "cmbColeccionEjemplar";
            this.cmbColeccionEjemplar.Size = new System.Drawing.Size(137, 21);
            this.cmbColeccionEjemplar.TabIndex = 34;
            // 
            // lblInfoEjemplar
            // 
            this.lblInfoEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblInfoEjemplar, 5);
            this.lblInfoEjemplar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInfoEjemplar.Location = new System.Drawing.Point(59, 0);
            this.lblInfoEjemplar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoEjemplar.Name = "lblInfoEjemplar";
            this.lblInfoEjemplar.Size = new System.Drawing.Size(281, 25);
            this.lblInfoEjemplar.TabIndex = 0;
            this.lblInfoEjemplar.Text = "Información del ejemplar";
            // 
            // txtFechaPublicacion
            // 
            this.tlpEjemplar.SetColumnSpan(this.txtFechaPublicacion, 3);
            this.txtFechaPublicacion.Location = new System.Drawing.Point(59, 102);
            this.txtFechaPublicacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaPublicacion.Name = "txtFechaPublicacion";
            this.txtFechaPublicacion.Size = new System.Drawing.Size(109, 20);
            this.txtFechaPublicacion.TabIndex = 41;
            // 
            // picImagenEjemplar
            // 
            this.picImagenEjemplar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpEjemplar.SetColumnSpan(this.picImagenEjemplar, 4);
            this.picImagenEjemplar.Location = new System.Drawing.Point(401, 27);
            this.picImagenEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.picImagenEjemplar.Name = "picImagenEjemplar";
            this.tlpEjemplar.SetRowSpan(this.picImagenEjemplar, 4);
            this.picImagenEjemplar.Size = new System.Drawing.Size(133, 90);
            this.picImagenEjemplar.TabIndex = 55;
            this.picImagenEjemplar.TabStop = false;
            // 
            // btnCrearEjemplar
            // 
            this.btnCrearEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearEjemplar.BackColor = System.Drawing.Color.Green;
            this.tlpEjemplar.SetColumnSpan(this.btnCrearEjemplar, 2);
            this.btnCrearEjemplar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrearEjemplar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearEjemplar.Location = new System.Drawing.Point(59, 364);
            this.btnCrearEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearEjemplar.Name = "btnCrearEjemplar";
            this.btnCrearEjemplar.Size = new System.Drawing.Size(110, 41);
            this.btnCrearEjemplar.TabIndex = 12;
            this.btnCrearEjemplar.Text = "Crear Ejemplar";
            this.btnCrearEjemplar.UseVisualStyleBackColor = false;
            this.btnCrearEjemplar.Click += new System.EventHandler(this.btnCrearEjemplar_Click);
            // 
            // btnCrearAutor
            // 
            this.btnCrearAutor.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearAutor.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.tlpEjemplar.SetColumnSpan(this.btnCrearAutor, 2);
            this.btnCrearAutor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrearAutor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearAutor.Location = new System.Drawing.Point(230, 364);
            this.btnCrearAutor.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearAutor.Name = "btnCrearAutor";
            this.btnCrearAutor.Size = new System.Drawing.Size(110, 41);
            this.btnCrearAutor.TabIndex = 33;
            this.btnCrearAutor.Text = "Autor";
            this.btnCrearAutor.UseVisualStyleBackColor = false;
            this.btnCrearAutor.Click += new System.EventHandler(this.btnCrearAutor_Click);
            // 
            // btnCrearPalabrasClave
            // 
            this.btnCrearPalabrasClave.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearPalabrasClave.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.tlpEjemplar.SetColumnSpan(this.btnCrearPalabrasClave, 2);
            this.btnCrearPalabrasClave.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrearPalabrasClave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearPalabrasClave.Location = new System.Drawing.Point(401, 364);
            this.btnCrearPalabrasClave.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearPalabrasClave.Name = "btnCrearPalabrasClave";
            this.btnCrearPalabrasClave.Size = new System.Drawing.Size(110, 41);
            this.btnCrearPalabrasClave.TabIndex = 43;
            this.btnCrearPalabrasClave.Text = "Palabras Clave";
            this.btnCrearPalabrasClave.UseVisualStyleBackColor = false;
            this.btnCrearPalabrasClave.Click += new System.EventHandler(this.btnCrearPalabrasClave_Click);
            // 
            // cmbEditorial
            // 
            this.tlpEjemplar.SetColumnSpan(this.cmbEditorial, 4);
            this.cmbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(59, 202);
            this.cmbEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(137, 21);
            this.cmbEditorial.TabIndex = 31;
            // 
            // btnAgregarImagenEjemplar
            // 
            this.btnAgregarImagenEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarImagenEjemplar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.tlpEjemplar.SetColumnSpan(this.btnAgregarImagenEjemplar, 2);
            this.btnAgregarImagenEjemplar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregarImagenEjemplar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarImagenEjemplar.Location = new System.Drawing.Point(59, 319);
            this.btnAgregarImagenEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarImagenEjemplar.Name = "btnAgregarImagenEjemplar";
            this.btnAgregarImagenEjemplar.Size = new System.Drawing.Size(110, 29);
            this.btnAgregarImagenEjemplar.TabIndex = 54;
            this.btnAgregarImagenEjemplar.Text = "Agregar Imagen";
            this.btnAgregarImagenEjemplar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAgregarImagenEjemplar.UseVisualStyleBackColor = false;
            this.btnAgregarImagenEjemplar.Click += new System.EventHandler(this.btnAgregarImagenEjemplar_Click);
            // 
            // lblDoi
            // 
            this.lblDoi.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoi.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblDoi.Location = new System.Drawing.Point(287, 317);
            this.lblDoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoi.Name = "lblDoi";
            this.lblDoi.Size = new System.Drawing.Size(53, 33);
            this.lblDoi.TabIndex = 20;
            this.lblDoi.Text = "doi";
            this.lblDoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblissn
            // 
            this.lblissn.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblissn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblissn.Location = new System.Drawing.Point(287, 287);
            this.lblissn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblissn.Name = "lblissn";
            this.lblissn.Size = new System.Drawing.Size(53, 30);
            this.lblissn.TabIndex = 7;
            this.lblissn.Text = "issn";
            this.lblissn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblISBN
            // 
            this.lblISBN.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblISBN.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblISBN.Location = new System.Drawing.Point(287, 250);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(53, 37);
            this.lblISBN.TabIndex = 10;
            this.lblISBN.Text = "isbn";
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtIsbn, 3);
            this.txtIsbn.Location = new System.Drawing.Point(344, 252);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(167, 20);
            this.txtIsbn.TabIndex = 11;
            // 
            // txtissn
            // 
            this.txtissn.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtissn, 3);
            this.txtissn.Location = new System.Drawing.Point(344, 289);
            this.txtissn.Margin = new System.Windows.Forms.Padding(2);
            this.txtissn.Name = "txtissn";
            this.txtissn.Size = new System.Drawing.Size(167, 20);
            this.txtissn.TabIndex = 22;
            // 
            // txtDoi
            // 
            this.txtDoi.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtDoi, 3);
            this.txtDoi.Location = new System.Drawing.Point(344, 319);
            this.txtDoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoi.Name = "txtDoi";
            this.txtDoi.Size = new System.Drawing.Size(167, 20);
            this.txtDoi.TabIndex = 23;
            // 
            // cmbIdioma
            // 
            this.tlpEjemplar.SetColumnSpan(this.cmbIdioma, 3);
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(344, 202);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(135, 21);
            this.cmbIdioma.TabIndex = 27;
            // 
            // lblidioma
            // 
            this.lblidioma.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblidioma, 4);
            this.lblidioma.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblidioma.Location = new System.Drawing.Point(344, 175);
            this.lblidioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblidioma.Name = "lblidioma";
            this.lblidioma.Size = new System.Drawing.Size(224, 25);
            this.lblidioma.TabIndex = 14;
            this.lblidioma.Text = "Idioma";
            this.lblidioma.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbFomato
            // 
            this.tlpEjemplar.SetColumnSpan(this.cmbFomato, 4);
            this.cmbFomato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFomato.FormattingEnabled = true;
            this.cmbFomato.Location = new System.Drawing.Point(344, 152);
            this.cmbFomato.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFomato.Name = "cmbFomato";
            this.cmbFomato.Size = new System.Drawing.Size(135, 21);
            this.cmbFomato.TabIndex = 32;
            // 
            // lblFormato
            // 
            this.lblFormato.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblFormato, 4);
            this.lblFormato.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFormato.Location = new System.Drawing.Point(344, 125);
            this.lblFormato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(224, 25);
            this.lblFormato.TabIndex = 21;
            this.lblFormato.Text = "Formato";
            this.lblFormato.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCrearEditorial
            // 
            this.btnCrearEditorial.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.tlpEjemplar.SetColumnSpan(this.btnCrearEditorial, 2);
            this.btnCrearEditorial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearEditorial.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrearEditorial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearEditorial.Location = new System.Drawing.Point(59, 252);
            this.btnCrearEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearEditorial.Name = "btnCrearEditorial";
            this.btnCrearEditorial.Size = new System.Drawing.Size(110, 33);
            this.btnCrearEditorial.TabIndex = 42;
            this.btnCrearEditorial.Text = "Crear Editorial";
            this.btnCrearEditorial.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCrearEditorial.UseVisualStyleBackColor = false;
            this.btnCrearEditorial.Click += new System.EventHandler(this.btnCrearEditorial_Click);
            // 
            // lblColeccionEjemplar
            // 
            this.lblColeccionEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblColeccionEjemplar, 2);
            this.lblColeccionEjemplar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblColeccionEjemplar.Location = new System.Drawing.Point(59, 125);
            this.lblColeccionEjemplar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColeccionEjemplar.Name = "lblColeccionEjemplar";
            this.lblColeccionEjemplar.Size = new System.Drawing.Size(110, 25);
            this.lblColeccionEjemplar.TabIndex = 3;
            this.lblColeccionEjemplar.Text = "Colección";
            this.lblColeccionEjemplar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(632, 398);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Editar ejemplar ";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 14;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158185F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158187F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 12);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(23, 1);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 14;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.44743F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.95599F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.95599F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.557457F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.60391F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(613, 409);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.panel4, 13);
            this.panel4.Controls.Add(this.bntConfirmarID);
            this.panel4.Controls.Add(this.btnActualizarImagen);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtActualizarISB);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.txtActualizarISSN);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtActualizarDOI);
            this.panel4.Controls.Add(this.btnActualizarAutor);
            this.panel4.Controls.Add(this.btnActualizarPalabrasClave);
            this.panel4.Controls.Add(this.cmbActualizarIdioma);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.cmbActualizarFormato);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cmbActualizarEditorial);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cmbColeccionActualizar);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtActualizarFechaEjemplar);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtActualizarNombreEjemplar);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.txtIDActualizarEjemplar);
            this.panel4.Controls.Add(this.btnActualizarEejmplar);
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel4.SetRowSpan(this.panel4, 10);
            this.panel4.Size = new System.Drawing.Size(555, 276);
            this.panel4.TabIndex = 23;
            // 
            // bntConfirmarID
            // 
            this.bntConfirmarID.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (61)))), ((int) (((byte) (143)))), ((int) (((byte) (61)))));
            this.bntConfirmarID.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.bntConfirmarID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bntConfirmarID.Location = new System.Drawing.Point(432, 38);
            this.bntConfirmarID.Margin = new System.Windows.Forms.Padding(2);
            this.bntConfirmarID.Name = "bntConfirmarID";
            this.bntConfirmarID.Size = new System.Drawing.Size(107, 25);
            this.bntConfirmarID.TabIndex = 54;
            this.bntConfirmarID.Text = "Confirmar";
            this.bntConfirmarID.UseVisualStyleBackColor = false;
            this.bntConfirmarID.Click += new System.EventHandler(this.bntConfirmarID_Click);
            // 
            // btnActualizarImagen
            // 
            this.btnActualizarImagen.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnActualizarImagen.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarImagen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizarImagen.Location = new System.Drawing.Point(8, 213);
            this.btnActualizarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarImagen.Name = "btnActualizarImagen";
            this.btnActualizarImagen.Size = new System.Drawing.Size(132, 30);
            this.btnActualizarImagen.TabIndex = 53;
            this.btnActualizarImagen.Text = "Actualizar imagen";
            this.btnActualizarImagen.UseVisualStyleBackColor = false;
            this.btnActualizarImagen.Click += new System.EventHandler(this.btnActualizarImagen_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(336, 66);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "isbn";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarISB
            // 
            this.txtActualizarISB.Location = new System.Drawing.Point(389, 67);
            this.txtActualizarISB.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarISB.Name = "txtActualizarISB";
            this.txtActualizarISB.Size = new System.Drawing.Size(106, 20);
            this.txtActualizarISB.TabIndex = 46;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(336, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "issn";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarISSN
            // 
            this.txtActualizarISSN.Location = new System.Drawing.Point(389, 97);
            this.txtActualizarISSN.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarISSN.Name = "txtActualizarISSN";
            this.txtActualizarISSN.Size = new System.Drawing.Size(106, 20);
            this.txtActualizarISSN.TabIndex = 49;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(336, 122);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "doi";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarDOI
            // 
            this.txtActualizarDOI.Location = new System.Drawing.Point(389, 122);
            this.txtActualizarDOI.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarDOI.Name = "txtActualizarDOI";
            this.txtActualizarDOI.Size = new System.Drawing.Size(106, 20);
            this.txtActualizarDOI.TabIndex = 50;
            // 
            // btnActualizarAutor
            // 
            this.btnActualizarAutor.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnActualizarAutor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarAutor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizarAutor.Location = new System.Drawing.Point(277, 209);
            this.btnActualizarAutor.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarAutor.Name = "btnActualizarAutor";
            this.btnActualizarAutor.Size = new System.Drawing.Size(107, 34);
            this.btnActualizarAutor.TabIndex = 51;
            this.btnActualizarAutor.Text = "Autor";
            this.btnActualizarAutor.UseVisualStyleBackColor = false;
            // 
            // btnActualizarPalabrasClave
            // 
            this.btnActualizarPalabrasClave.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnActualizarPalabrasClave.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarPalabrasClave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizarPalabrasClave.Location = new System.Drawing.Point(161, 209);
            this.btnActualizarPalabrasClave.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarPalabrasClave.Name = "btnActualizarPalabrasClave";
            this.btnActualizarPalabrasClave.Size = new System.Drawing.Size(88, 47);
            this.btnActualizarPalabrasClave.TabIndex = 52;
            this.btnActualizarPalabrasClave.Text = "Palabras Clave";
            this.btnActualizarPalabrasClave.UseVisualStyleBackColor = false;
            // 
            // cmbActualizarIdioma
            // 
            this.cmbActualizarIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActualizarIdioma.FormattingEnabled = true;
            this.cmbActualizarIdioma.Location = new System.Drawing.Point(389, 151);
            this.cmbActualizarIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbActualizarIdioma.Name = "cmbActualizarIdioma";
            this.cmbActualizarIdioma.Size = new System.Drawing.Size(106, 21);
            this.cmbActualizarIdioma.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(317, 148);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 40;
            this.label7.Text = "Idioma";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbActualizarFormato
            // 
            this.cmbActualizarFormato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActualizarFormato.FormattingEnabled = true;
            this.cmbActualizarFormato.Location = new System.Drawing.Point(11, 188);
            this.cmbActualizarFormato.Margin = new System.Windows.Forms.Padding(2);
            this.cmbActualizarFormato.Name = "cmbActualizarFormato";
            this.cmbActualizarFormato.Size = new System.Drawing.Size(109, 21);
            this.cmbActualizarFormato.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(11, 168);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 14);
            this.label6.TabIndex = 38;
            this.label6.Text = "Formato*";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbActualizarEditorial
            // 
            this.cmbActualizarEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActualizarEditorial.FormattingEnabled = true;
            this.cmbActualizarEditorial.Location = new System.Drawing.Point(137, 145);
            this.cmbActualizarEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.cmbActualizarEditorial.Name = "cmbActualizarEditorial";
            this.cmbActualizarEditorial.Size = new System.Drawing.Size(106, 21);
            this.cmbActualizarEditorial.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(137, 129);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 14);
            this.label4.TabIndex = 36;
            this.label4.Text = "Editorial*";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbColeccionActualizar
            // 
            this.cmbColeccionActualizar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColeccionActualizar.FormattingEnabled = true;
            this.cmbColeccionActualizar.Location = new System.Drawing.Point(13, 145);
            this.cmbColeccionActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbColeccionActualizar.Name = "cmbColeccionActualizar";
            this.cmbColeccionActualizar.Size = new System.Drawing.Size(106, 21);
            this.cmbColeccionActualizar.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(13, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Colección*";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarFechaEjemplar
            // 
            this.txtActualizarFechaEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarFechaEjemplar.Location = new System.Drawing.Point(13, 97);
            this.txtActualizarFechaEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarFechaEjemplar.Name = "txtActualizarFechaEjemplar";
            this.txtActualizarFechaEjemplar.Size = new System.Drawing.Size(175, 20);
            this.txtActualizarFechaEjemplar.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(13, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 14);
            this.label2.TabIndex = 27;
            this.label2.Text = "Fecha de publicación*";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label17.Location = new System.Drawing.Point(261, 8);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(283, 28);
            this.label17.TabIndex = 24;
            this.label17.Text = "Número de ID de la colección que desea actualizar ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.Location = new System.Drawing.Point(43, 12);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "Editar ejemplar";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nombre del ejemplar*";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarNombreEjemplar
            // 
            this.txtActualizarNombreEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarNombreEjemplar.Location = new System.Drawing.Point(15, 53);
            this.txtActualizarNombreEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarNombreEjemplar.Name = "txtActualizarNombreEjemplar";
            this.txtActualizarNombreEjemplar.Size = new System.Drawing.Size(173, 20);
            this.txtActualizarNombreEjemplar.TabIndex = 22;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label22.Location = new System.Drawing.Point(336, 45);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 14);
            this.label22.TabIndex = 20;
            this.label22.Text = "ID";
            this.label22.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtIDActualizarEjemplar
            // 
            this.txtIDActualizarEjemplar.Location = new System.Drawing.Point(389, 42);
            this.txtIDActualizarEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDActualizarEjemplar.Name = "txtIDActualizarEjemplar";
            this.txtIDActualizarEjemplar.Size = new System.Drawing.Size(25, 20);
            this.txtIDActualizarEjemplar.TabIndex = 18;
            // 
            // btnActualizarEejmplar
            // 
            this.btnActualizarEejmplar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (61)))), ((int) (((byte) (143)))), ((int) (((byte) (61)))));
            this.btnActualizarEejmplar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarEejmplar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizarEejmplar.Location = new System.Drawing.Point(405, 210);
            this.btnActualizarEejmplar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarEejmplar.Name = "btnActualizarEejmplar";
            this.btnActualizarEejmplar.Size = new System.Drawing.Size(106, 33);
            this.btnActualizarEejmplar.TabIndex = 17;
            this.btnActualizarEejmplar.Text = "Actualizar";
            this.btnActualizarEejmplar.UseVisualStyleBackColor = false;
            this.btnActualizarEejmplar.Click += new System.EventHandler(this.btnActualizarEejmplar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.panel3, 13);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.btnEliminarEjemplar);
            this.panel3.Controls.Add(this.txtidEliminarEjemplar);
            this.panel3.Location = new System.Drawing.Point(2, 298);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel4.SetRowSpan(this.panel3, 2);
            this.panel3.Size = new System.Drawing.Size(555, 73);
            this.panel3.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label21.Location = new System.Drawing.Point(41, 24);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(323, 14);
            this.label21.TabIndex = 21;
            this.label21.Text = "Ingrese el número de ID del ejemplar a eliminar";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label20.Location = new System.Drawing.Point(158, 6);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 27);
            this.label20.TabIndex = 20;
            this.label20.Text = "Eliminar usuario";
            // 
            // btnEliminarEjemplar
            // 
            this.btnEliminarEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEjemplar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnEliminarEjemplar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarEjemplar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarEjemplar.Location = new System.Drawing.Point(405, 13);
            this.btnEliminarEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarEjemplar.Name = "btnEliminarEjemplar";
            this.btnEliminarEjemplar.Size = new System.Drawing.Size(106, 36);
            this.btnEliminarEjemplar.TabIndex = 16;
            this.btnEliminarEjemplar.Text = "Eliminar";
            this.btnEliminarEjemplar.UseVisualStyleBackColor = false;
            // 
            // txtidEliminarEjemplar
            // 
            this.txtidEliminarEjemplar.Location = new System.Drawing.Point(171, 40);
            this.txtidEliminarEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.txtidEliminarEjemplar.Name = "txtidEliminarEjemplar";
            this.txtidEliminarEjemplar.Size = new System.Drawing.Size(33, 20);
            this.txtidEliminarEjemplar.TabIndex = 19;
            this.txtidEliminarEjemplar.TextChanged += new System.EventHandler(this.txtidEliminarEjemplar_TextChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlpBusqueda);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 398);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Mostar ejemplares disponibles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlpBusqueda
            // 
            this.tlpBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBusqueda.ColumnCount = 3;
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBusqueda.Controls.Add(this.btnBuscar, 2, 0);
            this.tlpBusqueda.Controls.Add(this.cmbOpcionesBuscar, 0, 0);
            this.tlpBusqueda.Controls.Add(this.dgvResultadosBusqueda, 0, 1);
            this.tlpBusqueda.Controls.Add(this.txtBuscarEjemplar, 1, 0);
            this.tlpBusqueda.Location = new System.Drawing.Point(3, 3);
            this.tlpBusqueda.Name = "tlpBusqueda";
            this.tlpBusqueda.RowCount = 3;
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.95238F));
            this.tlpBusqueda.Size = new System.Drawing.Size(632, 408);
            this.tlpBusqueda.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(508, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(121, 37);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Elemento";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbOpcionesBuscar
            // 
            this.cmbOpcionesBuscar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbOpcionesBuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOpcionesBuscar.FormattingEnabled = true;
            this.cmbOpcionesBuscar.Items.AddRange(new object[] {"Titulo completo", "Titulo parcial ", "Autor", "Por palabra clave", "Digital", "Fisico", "Mostrar todos"});
            this.cmbOpcionesBuscar.Location = new System.Drawing.Point(3, 3);
            this.cmbOpcionesBuscar.Name = "cmbOpcionesBuscar";
            this.cmbOpcionesBuscar.Size = new System.Drawing.Size(183, 21);
            this.cmbOpcionesBuscar.TabIndex = 2;
            // 
            // dgvResultadosBusqueda
            // 
            this.dgvResultadosBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultadosBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultadosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpBusqueda.SetColumnSpan(this.dgvResultadosBusqueda, 3);
            this.dgvResultadosBusqueda.Location = new System.Drawing.Point(3, 46);
            this.dgvResultadosBusqueda.Name = "dgvResultadosBusqueda";
            this.dgvResultadosBusqueda.RowHeadersWidth = 62;
            this.dgvResultadosBusqueda.Size = new System.Drawing.Size(626, 334);
            this.dgvResultadosBusqueda.TabIndex = 0;
            // 
            // txtBuscarEjemplar
            // 
            this.txtBuscarEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarEjemplar.Location = new System.Drawing.Point(192, 3);
            this.txtBuscarEjemplar.Name = "txtBuscarEjemplar";
            this.txtBuscarEjemplar.Size = new System.Drawing.Size(310, 20);
            this.txtBuscarEjemplar.TabIndex = 3;
            // 
            // frmEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 436);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEjemplar";
            this.Text = "frmEjemplar";
            this.Load += new System.EventHandler(this.frmEjemplar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tlpEjemplar.ResumeLayout(false);
            this.tlpEjemplar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picImagenEjemplar)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tlpBusqueda.ResumeLayout(false);
            this.tlpBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvResultadosBusqueda)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bntConfirmarID;

        private System.Windows.Forms.PictureBox picImagenEjemplar;

        private System.Windows.Forms.Button btnActualizarImagen;
        private System.Windows.Forms.Button btnAgregarImagenEjemplar;

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtActualizarISB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtActualizarISSN;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtActualizarDOI;
        private System.Windows.Forms.Button btnActualizarAutor;
        private System.Windows.Forms.Button btnActualizarPalabrasClave;

        private System.Windows.Forms.ComboBox cmbActualizarIdioma;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbColeccionActualizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbActualizarEditorial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbActualizarFormato;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtActualizarFechaEjemplar;

        private System.Windows.Forms.Label label17;

        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.Button btnCrearPalabrasClave;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActualizarNombreEjemplar;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnEliminarEjemplar;
        private System.Windows.Forms.TextBox txtidEliminarEjemplar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtIDActualizarEjemplar;
        private System.Windows.Forms.Button btnActualizarEejmplar;

        private System.Windows.Forms.TextBox txtBuscarEjemplar;

        private System.Windows.Forms.ComboBox cmbOpcionesBuscar;

        private System.Windows.Forms.Button btnBuscar;

        private System.Windows.Forms.DataGridView dgvResultadosBusqueda;

        private System.Windows.Forms.TableLayoutPanel tlpBusqueda;

        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.Button btnCrearEditorial;

        private System.Windows.Forms.TextBox txtFechaPublicacion;

        private System.Windows.Forms.ComboBox cmbColeccionEjemplar;

        private System.Windows.Forms.Button btnCrearAutor;

        private System.Windows.Forms.ComboBox cmbFomato;

        private System.Windows.Forms.ComboBox cmbEditorial;

        private System.Windows.Forms.ComboBox cmbIdioma;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tlpEjemplar;
        private System.Windows.Forms.Label lblInfoEjemplar;
        private System.Windows.Forms.TextBox txtNombreEjemplar;
        private System.Windows.Forms.Label lblNombreEjemplar;
        private System.Windows.Forms.Label lblColeccionEjemplar;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Button btnCrearEjemplar;
        private System.Windows.Forms.Label lblissn;
        private System.Windows.Forms.Label lblidioma;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblDoi;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.TextBox txtissn;
        private System.Windows.Forms.TextBox txtDoi;
        private System.Windows.Forms.TabPage tabPage4;

        #endregion
    }
}