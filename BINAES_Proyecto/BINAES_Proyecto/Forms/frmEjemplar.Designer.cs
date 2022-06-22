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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tlpEjemplar = new System.Windows.Forms.TableLayoutPanel();
            this.txtEjemplarID = new System.Windows.Forms.TextBox();
            this.lblNombreEjemplar = new System.Windows.Forms.Label();
            this.txtNombreEjemplar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblColeccionEjemplar = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.lblFormato = new System.Windows.Forms.Label();
            this.cmbFomato = new System.Windows.Forms.ComboBox();
            this.lblidioma = new System.Windows.Forms.Label();
            this.cmbIdioma = new System.Windows.Forms.ComboBox();
            this.cmbColeccionEjemplar = new System.Windows.Forms.ComboBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.lblissn = new System.Windows.Forms.Label();
            this.txtissn = new System.Windows.Forms.TextBox();
            this.lblDoi = new System.Windows.Forms.Label();
            this.txtDoi = new System.Windows.Forms.TextBox();
            this.lblPalabrasClaves = new System.Windows.Forms.Label();
            this.txtPalabraClave1 = new System.Windows.Forms.TextBox();
            this.txtPalabraClave2 = new System.Windows.Forms.TextBox();
            this.txtPalabraClave3 = new System.Windows.Forms.TextBox();
            this.lblPortadaEejmplar = new System.Windows.Forms.Label();
            this.btnCrearEjemplar = new System.Windows.Forms.Button();
            this.txtNuevaEditorial = new System.Windows.Forms.TextBox();
            this.lblEditorialNueva = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.btnCrearAutor = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.lblInfoEjemplar = new System.Windows.Forms.Label();
            this.txtFotografia = new System.Windows.Forms.TextBox();
            this.dtpFechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.txtFechaPublicacion = new System.Windows.Forms.TextBox();
            this.btnCrearEditorial = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnEliminarEjemplar = new System.Windows.Forms.Button();
            this.txtidEliminarEjemplar = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.txtIDatualizar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnActualizarEejmplar = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtActualizarOcupacion = new System.Windows.Forms.TextBox();
            this.txtActualizarCorreo = new System.Windows.Forms.TextBox();
            this.txtActualizarInstitucion = new System.Windows.Forms.TextBox();
            this.txtActualizarTelefono = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtActualizarDireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlpBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbOpcionesBuscar = new System.Windows.Forms.ComboBox();
            this.dgvResultadosBusqueda = new System.Windows.Forms.DataGridView();
            this.txtBuscarEjemplar = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tlpEjemplar.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosBusqueda)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(578, 448);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tlpEjemplar);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(570, 410);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Agregar ejemplar";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tlpEjemplar
            // 
            this.tlpEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.ColumnCount = 14;
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
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tlpEjemplar.Controls.Add(this.txtEjemplarID, 7, 2);
            this.tlpEjemplar.Controls.Add(this.lblNombreEjemplar, 1, 1);
            this.tlpEjemplar.Controls.Add(this.txtNombreEjemplar, 1, 2);
            this.tlpEjemplar.Controls.Add(this.label5, 1, 3);
            this.tlpEjemplar.Controls.Add(this.lblColeccionEjemplar, 1, 5);
            this.tlpEjemplar.Controls.Add(this.lblEditorial, 1, 7);
            this.tlpEjemplar.Controls.Add(this.cmbEditorial, 1, 8);
            this.tlpEjemplar.Controls.Add(this.lblFormato, 1, 9);
            this.tlpEjemplar.Controls.Add(this.cmbFomato, 1, 10);
            this.tlpEjemplar.Controls.Add(this.lblidioma, 1, 11);
            this.tlpEjemplar.Controls.Add(this.cmbIdioma, 1, 12);
            this.tlpEjemplar.Controls.Add(this.cmbColeccionEjemplar, 1, 6);
            this.tlpEjemplar.Controls.Add(this.lblISBN, 6, 3);
            this.tlpEjemplar.Controls.Add(this.txtIsbn, 6, 4);
            this.tlpEjemplar.Controls.Add(this.lblissn, 6, 5);
            this.tlpEjemplar.Controls.Add(this.txtissn, 6, 6);
            this.tlpEjemplar.Controls.Add(this.lblDoi, 6, 7);
            this.tlpEjemplar.Controls.Add(this.txtDoi, 6, 8);
            this.tlpEjemplar.Controls.Add(this.lblPalabrasClaves, 6, 9);
            this.tlpEjemplar.Controls.Add(this.txtPalabraClave1, 6, 10);
            this.tlpEjemplar.Controls.Add(this.txtPalabraClave2, 6, 11);
            this.tlpEjemplar.Controls.Add(this.txtPalabraClave3, 6, 12);
            this.tlpEjemplar.Controls.Add(this.lblPortadaEejmplar, 1, 13);
            this.tlpEjemplar.Controls.Add(this.btnCrearEjemplar, 6, 13);
            this.tlpEjemplar.Controls.Add(this.txtNuevaEditorial, 10, 11);
            this.tlpEjemplar.Controls.Add(this.lblEditorialNueva, 10, 10);
            this.tlpEjemplar.Controls.Add(this.txtAutor, 10, 5);
            this.tlpEjemplar.Controls.Add(this.lblAutor, 10, 4);
            this.tlpEjemplar.Controls.Add(this.btnCrearAutor, 10, 7);
            this.tlpEjemplar.Controls.Add(this.textBox5, 10, 6);
            this.tlpEjemplar.Controls.Add(this.textBox6, 12, 5);
            this.tlpEjemplar.Controls.Add(this.lblInfoEjemplar, 1, 0);
            this.tlpEjemplar.Controls.Add(this.txtFotografia, 1, 14);
            this.tlpEjemplar.Controls.Add(this.dtpFechaPublicacion, 8, 1);
            this.tlpEjemplar.Controls.Add(this.txtFechaPublicacion, 1, 4);
            this.tlpEjemplar.Controls.Add(this.btnCrearEditorial, 10, 13);
            this.tlpEjemplar.Location = new System.Drawing.Point(0, 4);
            this.tlpEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.tlpEjemplar.Name = "tlpEjemplar";
            this.tlpEjemplar.RowCount = 16;
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.372549F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tlpEjemplar.Size = new System.Drawing.Size(572, 419);
            this.tlpEjemplar.TabIndex = 0;
            // 
            // txtEjemplarID
            // 
            this.txtEjemplarID.Location = new System.Drawing.Point(282, 54);
            this.txtEjemplarID.Margin = new System.Windows.Forms.Padding(2);
            this.txtEjemplarID.Name = "txtEjemplarID";
            this.txtEjemplarID.Size = new System.Drawing.Size(33, 20);
            this.txtEjemplarID.TabIndex = 13;
            // 
            // lblNombreEjemplar
            // 
            this.lblNombreEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblNombreEjemplar, 4);
            this.lblNombreEjemplar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEjemplar.Location = new System.Drawing.Point(42, 26);
            this.lblNombreEjemplar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEjemplar.Name = "lblNombreEjemplar";
            this.lblNombreEjemplar.Size = new System.Drawing.Size(156, 26);
            this.lblNombreEjemplar.TabIndex = 1;
            this.lblNombreEjemplar.Text = "Nombre del ejemplar";
            this.lblNombreEjemplar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNombreEjemplar
            // 
            this.txtNombreEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtNombreEjemplar, 5);
            this.txtNombreEjemplar.Location = new System.Drawing.Point(42, 54);
            this.txtNombreEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreEjemplar.Name = "txtNombreEjemplar";
            this.txtNombreEjemplar.Size = new System.Drawing.Size(196, 20);
            this.txtNombreEjemplar.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.label5, 4);
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 26);
            this.label5.TabIndex = 26;
            this.label5.Text = "Fecha de publicación";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblColeccionEjemplar
            // 
            this.lblColeccionEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblColeccionEjemplar, 4);
            this.lblColeccionEjemplar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColeccionEjemplar.Location = new System.Drawing.Point(42, 130);
            this.lblColeccionEjemplar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColeccionEjemplar.Name = "lblColeccionEjemplar";
            this.lblColeccionEjemplar.Size = new System.Drawing.Size(156, 26);
            this.lblColeccionEjemplar.TabIndex = 3;
            this.lblColeccionEjemplar.Text = "Colección a la que pertenece";
            this.lblColeccionEjemplar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblEditorial
            // 
            this.lblEditorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblEditorial, 4);
            this.lblEditorial.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(42, 182);
            this.lblEditorial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(156, 26);
            this.lblEditorial.TabIndex = 18;
            this.lblEditorial.Text = "Editorial";
            this.lblEditorial.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbEditorial
            // 
            this.tlpEjemplar.SetColumnSpan(this.cmbEditorial, 4);
            this.cmbEditorial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Location = new System.Drawing.Point(42, 210);
            this.cmbEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(147, 21);
            this.cmbEditorial.TabIndex = 31;
            // 
            // lblFormato
            // 
            this.lblFormato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblFormato, 4);
            this.lblFormato.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormato.Location = new System.Drawing.Point(42, 234);
            this.lblFormato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFormato.Name = "lblFormato";
            this.lblFormato.Size = new System.Drawing.Size(156, 26);
            this.lblFormato.TabIndex = 21;
            this.lblFormato.Text = "Formato";
            this.lblFormato.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbFomato
            // 
            this.tlpEjemplar.SetColumnSpan(this.cmbFomato, 4);
            this.cmbFomato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFomato.FormattingEnabled = true;
            this.cmbFomato.Location = new System.Drawing.Point(42, 262);
            this.cmbFomato.Margin = new System.Windows.Forms.Padding(2);
            this.cmbFomato.Name = "cmbFomato";
            this.cmbFomato.Size = new System.Drawing.Size(147, 21);
            this.cmbFomato.TabIndex = 32;
            // 
            // lblidioma
            // 
            this.lblidioma.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblidioma, 4);
            this.lblidioma.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidioma.Location = new System.Drawing.Point(42, 286);
            this.lblidioma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblidioma.Name = "lblidioma";
            this.lblidioma.Size = new System.Drawing.Size(156, 26);
            this.lblidioma.TabIndex = 14;
            this.lblidioma.Text = "Idioma";
            this.lblidioma.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbIdioma
            // 
            this.tlpEjemplar.SetColumnSpan(this.cmbIdioma, 3);
            this.cmbIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdioma.FormattingEnabled = true;
            this.cmbIdioma.Location = new System.Drawing.Point(42, 314);
            this.cmbIdioma.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdioma.Name = "cmbIdioma";
            this.cmbIdioma.Size = new System.Drawing.Size(109, 21);
            this.cmbIdioma.TabIndex = 27;
            // 
            // cmbColeccionEjemplar
            // 
            this.tlpEjemplar.SetColumnSpan(this.cmbColeccionEjemplar, 4);
            this.cmbColeccionEjemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColeccionEjemplar.FormattingEnabled = true;
            this.cmbColeccionEjemplar.Location = new System.Drawing.Point(42, 158);
            this.cmbColeccionEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.cmbColeccionEjemplar.Name = "cmbColeccionEjemplar";
            this.cmbColeccionEjemplar.Size = new System.Drawing.Size(147, 21);
            this.cmbColeccionEjemplar.TabIndex = 34;
            // 
            // lblISBN
            // 
            this.lblISBN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblISBN, 2);
            this.lblISBN.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(242, 78);
            this.lblISBN.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(76, 26);
            this.lblISBN.TabIndex = 10;
            this.lblISBN.Text = "isbn";
            this.lblISBN.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtIsbn
            // 
            this.txtIsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtIsbn, 3);
            this.txtIsbn.Location = new System.Drawing.Point(242, 106);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(2);
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(116, 20);
            this.txtIsbn.TabIndex = 11;
            // 
            // lblissn
            // 
            this.lblissn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblissn, 4);
            this.lblissn.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblissn.Location = new System.Drawing.Point(242, 130);
            this.lblissn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblissn.Name = "lblissn";
            this.lblissn.Size = new System.Drawing.Size(156, 26);
            this.lblissn.TabIndex = 7;
            this.lblissn.Text = "issn";
            this.lblissn.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtissn
            // 
            this.txtissn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtissn, 3);
            this.txtissn.Location = new System.Drawing.Point(242, 158);
            this.txtissn.Margin = new System.Windows.Forms.Padding(2);
            this.txtissn.Name = "txtissn";
            this.txtissn.Size = new System.Drawing.Size(116, 20);
            this.txtissn.TabIndex = 22;
            // 
            // lblDoi
            // 
            this.lblDoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblDoi, 4);
            this.lblDoi.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoi.Location = new System.Drawing.Point(242, 182);
            this.lblDoi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDoi.Name = "lblDoi";
            this.lblDoi.Size = new System.Drawing.Size(156, 26);
            this.lblDoi.TabIndex = 20;
            this.lblDoi.Text = "doi";
            this.lblDoi.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDoi
            // 
            this.txtDoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtDoi, 3);
            this.txtDoi.Location = new System.Drawing.Point(242, 210);
            this.txtDoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtDoi.Name = "txtDoi";
            this.txtDoi.Size = new System.Drawing.Size(116, 20);
            this.txtDoi.TabIndex = 23;
            // 
            // lblPalabrasClaves
            // 
            this.lblPalabrasClaves.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblPalabrasClaves, 4);
            this.lblPalabrasClaves.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabrasClaves.Location = new System.Drawing.Point(242, 234);
            this.lblPalabrasClaves.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPalabrasClaves.Name = "lblPalabrasClaves";
            this.lblPalabrasClaves.Size = new System.Drawing.Size(156, 26);
            this.lblPalabrasClaves.TabIndex = 25;
            this.lblPalabrasClaves.Text = "Palabras Claves";
            this.lblPalabrasClaves.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtPalabraClave1
            // 
            this.txtPalabraClave1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtPalabraClave1, 3);
            this.txtPalabraClave1.Location = new System.Drawing.Point(242, 262);
            this.txtPalabraClave1.Margin = new System.Windows.Forms.Padding(2);
            this.txtPalabraClave1.Name = "txtPalabraClave1";
            this.txtPalabraClave1.Size = new System.Drawing.Size(116, 20);
            this.txtPalabraClave1.TabIndex = 24;
            // 
            // txtPalabraClave2
            // 
            this.txtPalabraClave2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtPalabraClave2, 3);
            this.txtPalabraClave2.Location = new System.Drawing.Point(242, 288);
            this.txtPalabraClave2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPalabraClave2.Name = "txtPalabraClave2";
            this.txtPalabraClave2.Size = new System.Drawing.Size(116, 20);
            this.txtPalabraClave2.TabIndex = 28;
            // 
            // txtPalabraClave3
            // 
            this.txtPalabraClave3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtPalabraClave3, 3);
            this.txtPalabraClave3.Location = new System.Drawing.Point(242, 314);
            this.txtPalabraClave3.Margin = new System.Windows.Forms.Padding(2);
            this.txtPalabraClave3.Name = "txtPalabraClave3";
            this.txtPalabraClave3.Size = new System.Drawing.Size(116, 20);
            this.txtPalabraClave3.TabIndex = 29;
            // 
            // lblPortadaEejmplar
            // 
            this.lblPortadaEejmplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblPortadaEejmplar, 4);
            this.lblPortadaEejmplar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortadaEejmplar.Location = new System.Drawing.Point(42, 336);
            this.lblPortadaEejmplar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPortadaEejmplar.Name = "lblPortadaEejmplar";
            this.lblPortadaEejmplar.Size = new System.Drawing.Size(156, 26);
            this.lblPortadaEejmplar.TabIndex = 9;
            this.lblPortadaEejmplar.Text = "Fotografia";
            this.lblPortadaEejmplar.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCrearEjemplar
            // 
            this.btnCrearEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearEjemplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(129)))), ((int)(((byte)(239)))));
            this.tlpEjemplar.SetColumnSpan(this.btnCrearEjemplar, 3);
            this.btnCrearEjemplar.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEjemplar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearEjemplar.Location = new System.Drawing.Point(242, 338);
            this.btnCrearEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearEjemplar.Name = "btnCrearEjemplar";
            this.btnCrearEjemplar.Size = new System.Drawing.Size(116, 22);
            this.btnCrearEjemplar.TabIndex = 12;
            this.btnCrearEjemplar.Text = "Crear Ejemplar";
            this.btnCrearEjemplar.UseVisualStyleBackColor = false;
            this.btnCrearEjemplar.Click += new System.EventHandler(this.btnCrearEjemplar_Click);
            // 
            // txtNuevaEditorial
            // 
            this.tlpEjemplar.SetColumnSpan(this.txtNuevaEditorial, 3);
            this.txtNuevaEditorial.Location = new System.Drawing.Point(402, 288);
            this.txtNuevaEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.txtNuevaEditorial.Name = "txtNuevaEditorial";
            this.txtNuevaEditorial.Size = new System.Drawing.Size(106, 20);
            this.txtNuevaEditorial.TabIndex = 36;
            // 
            // lblEditorialNueva
            // 
            this.lblEditorialNueva.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblEditorialNueva, 4);
            this.lblEditorialNueva.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorialNueva.Location = new System.Drawing.Point(402, 260);
            this.lblEditorialNueva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEditorialNueva.Name = "lblEditorialNueva";
            this.lblEditorialNueva.Size = new System.Drawing.Size(168, 26);
            this.lblEditorialNueva.TabIndex = 35;
            this.lblEditorialNueva.Text = "Nueva Editorial";
            this.lblEditorialNueva.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.txtAutor, 2);
            this.txtAutor.Location = new System.Drawing.Point(402, 132);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(76, 20);
            this.txtAutor.TabIndex = 6;
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblAutor, 4);
            this.lblAutor.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(402, 104);
            this.lblAutor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(168, 26);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Text = "Autor (es)";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCrearAutor
            // 
            this.btnCrearAutor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearAutor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(129)))), ((int)(((byte)(239)))));
            this.tlpEjemplar.SetColumnSpan(this.btnCrearAutor, 3);
            this.btnCrearAutor.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearAutor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearAutor.Location = new System.Drawing.Point(402, 184);
            this.btnCrearAutor.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearAutor.Name = "btnCrearAutor";
            this.btnCrearAutor.Size = new System.Drawing.Size(116, 22);
            this.btnCrearAutor.TabIndex = 33;
            this.btnCrearAutor.Text = "Autor";
            this.btnCrearAutor.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.textBox5, 2);
            this.textBox5.Location = new System.Drawing.Point(402, 158);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 20);
            this.textBox5.TabIndex = 37;
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.textBox6, 2);
            this.textBox6.Location = new System.Drawing.Point(482, 132);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(88, 20);
            this.textBox6.TabIndex = 38;
            // 
            // lblInfoEjemplar
            // 
            this.lblInfoEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpEjemplar.SetColumnSpan(this.lblInfoEjemplar, 5);
            this.lblInfoEjemplar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEjemplar.Location = new System.Drawing.Point(42, 0);
            this.lblInfoEjemplar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInfoEjemplar.Name = "lblInfoEjemplar";
            this.lblInfoEjemplar.Size = new System.Drawing.Size(196, 26);
            this.lblInfoEjemplar.TabIndex = 0;
            this.lblInfoEjemplar.Text = "Información del ejemplar";
            // 
            // txtFotografia
            // 
            this.tlpEjemplar.SetColumnSpan(this.txtFotografia, 3);
            this.txtFotografia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtFotografia.Location = new System.Drawing.Point(42, 364);
            this.txtFotografia.Margin = new System.Windows.Forms.Padding(2);
            this.txtFotografia.Name = "txtFotografia";
            this.txtFotografia.ReadOnly = true;
            this.txtFotografia.Size = new System.Drawing.Size(109, 20);
            this.txtFotografia.TabIndex = 40;
            this.txtFotografia.DoubleClick += new System.EventHandler(this.txtFotografia_DoubleClick);
            // 
            // dtpFechaPublicacion
            // 
            this.tlpEjemplar.SetColumnSpan(this.dtpFechaPublicacion, 4);
            this.dtpFechaPublicacion.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaPublicacion.Location = new System.Drawing.Point(322, 28);
            this.dtpFechaPublicacion.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            this.dtpFechaPublicacion.Size = new System.Drawing.Size(147, 20);
            this.dtpFechaPublicacion.TabIndex = 30;
            // 
            // txtFechaPublicacion
            // 
            this.tlpEjemplar.SetColumnSpan(this.txtFechaPublicacion, 3);
            this.txtFechaPublicacion.Location = new System.Drawing.Point(42, 106);
            this.txtFechaPublicacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtFechaPublicacion.Name = "txtFechaPublicacion";
            this.txtFechaPublicacion.Size = new System.Drawing.Size(109, 20);
            this.txtFechaPublicacion.TabIndex = 41;
            // 
            // btnCrearEditorial
            // 
            this.btnCrearEditorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearEditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(129)))), ((int)(((byte)(239)))));
            this.tlpEjemplar.SetColumnSpan(this.btnCrearEditorial, 3);
            this.btnCrearEditorial.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearEditorial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearEditorial.Location = new System.Drawing.Point(402, 338);
            this.btnCrearEditorial.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearEditorial.Name = "btnCrearEditorial";
            this.btnCrearEditorial.Size = new System.Drawing.Size(116, 22);
            this.btnCrearEditorial.TabIndex = 42;
            this.btnCrearEditorial.Text = "Crear Editorial";
            this.btnCrearEditorial.UseVisualStyleBackColor = false;
            this.btnCrearEditorial.Click += new System.EventHandler(this.btnCrearEditorial_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(570, 410);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Editar ejemplar ";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.tableLayoutPanel4.Controls.Add(this.panel3, 1, 12);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(23, 1);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 16;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.018518F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.777778F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.864198F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.03086F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(527, 421);
            this.tableLayoutPanel4.TabIndex = 3;
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
            this.panel3.Location = new System.Drawing.Point(39, 313);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel4.SetRowSpan(this.panel3, 4);
            this.panel3.Size = new System.Drawing.Size(477, 96);
            this.panel3.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(25, 26);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(243, 27);
            this.label21.TabIndex = 21;
            this.label21.Text = "Ingrese el numero de id del usuario a eliminar";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(159, 1);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(555, 25);
            this.label20.TabIndex = 20;
            this.label20.Text = "Eliminar usuario";
            // 
            // btnEliminarEjemplar
            // 
            this.btnEliminarEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarEjemplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(129)))), ((int)(((byte)(239)))));
            this.btnEliminarEjemplar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarEjemplar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarEjemplar.Location = new System.Drawing.Point(320, 32);
            this.btnEliminarEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarEjemplar.Name = "btnEliminarEjemplar";
            this.btnEliminarEjemplar.Size = new System.Drawing.Size(97, 31);
            this.btnEliminarEjemplar.TabIndex = 16;
            this.btnEliminarEjemplar.Text = "Eliminar";
            this.btnEliminarEjemplar.UseVisualStyleBackColor = false;
            // 
            // txtidEliminarEjemplar
            // 
            this.txtidEliminarEjemplar.Location = new System.Drawing.Point(133, 63);
            this.txtidEliminarEjemplar.Margin = new System.Windows.Forms.Padding(2);
            this.txtidEliminarEjemplar.Name = "txtidEliminarEjemplar";
            this.txtidEliminarEjemplar.Size = new System.Drawing.Size(33, 20);
            this.txtidEliminarEjemplar.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.panel4, 13);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.txtIDatualizar);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.btnActualizarEejmplar);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.txtActualizarOcupacion);
            this.panel4.Controls.Add(this.txtActualizarCorreo);
            this.panel4.Controls.Add(this.txtActualizarInstitucion);
            this.panel4.Controls.Add(this.txtActualizarTelefono);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.txtActualizarDireccion);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(39, 28);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel4.SetRowSpan(this.panel4, 10);
            this.panel4.Size = new System.Drawing.Size(477, 256);
            this.panel4.TabIndex = 23;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(247, 51);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 24);
            this.label22.TabIndex = 20;
            this.label22.Text = "ID";
            this.label22.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtIDatualizar
            // 
            this.txtIDatualizar.Location = new System.Drawing.Point(279, 53);
            this.txtIDatualizar.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDatualizar.Name = "txtIDatualizar";
            this.txtIDatualizar.Size = new System.Drawing.Size(25, 20);
            this.txtIDatualizar.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(13, 83);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 22);
            this.label15.TabIndex = 5;
            this.label15.Text = "Direccion";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnActualizarEejmplar
            // 
            this.btnActualizarEejmplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarEejmplar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(129)))), ((int)(((byte)(239)))));
            this.btnActualizarEejmplar.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEejmplar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizarEejmplar.Location = new System.Drawing.Point(309, 198);
            this.btnActualizarEejmplar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarEejmplar.Name = "btnActualizarEejmplar";
            this.btnActualizarEejmplar.Size = new System.Drawing.Size(107, 45);
            this.btnActualizarEejmplar.TabIndex = 17;
            this.btnActualizarEejmplar.Text = "Actualizar";
            this.btnActualizarEejmplar.UseVisualStyleBackColor = false;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 179);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(144, 25);
            this.label18.TabIndex = 10;
            this.label18.Text = "Institucion";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(247, 132);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 22);
            this.label16.TabIndex = 7;
            this.label16.Text = "Telefono";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarOcupacion
            // 
            this.txtActualizarOcupacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarOcupacion.Location = new System.Drawing.Point(13, 161);
            this.txtActualizarOcupacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarOcupacion.Name = "txtActualizarOcupacion";
            this.txtActualizarOcupacion.Size = new System.Drawing.Size(183, 20);
            this.txtActualizarOcupacion.TabIndex = 8;
            // 
            // txtActualizarCorreo
            // 
            this.txtActualizarCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarCorreo.Location = new System.Drawing.Point(247, 108);
            this.txtActualizarCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarCorreo.Name = "txtActualizarCorreo";
            this.txtActualizarCorreo.Size = new System.Drawing.Size(183, 20);
            this.txtActualizarCorreo.TabIndex = 11;
            // 
            // txtActualizarInstitucion
            // 
            this.txtActualizarInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarInstitucion.Location = new System.Drawing.Point(13, 213);
            this.txtActualizarInstitucion.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarInstitucion.Name = "txtActualizarInstitucion";
            this.txtActualizarInstitucion.Size = new System.Drawing.Size(183, 20);
            this.txtActualizarInstitucion.TabIndex = 4;
            // 
            // txtActualizarTelefono
            // 
            this.txtActualizarTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarTelefono.Location = new System.Drawing.Point(247, 161);
            this.txtActualizarTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarTelefono.Name = "txtActualizarTelefono";
            this.txtActualizarTelefono.Size = new System.Drawing.Size(183, 20);
            this.txtActualizarTelefono.TabIndex = 15;
            // 
            // label19
            // 
            this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(247, 83);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 22);
            this.label19.TabIndex = 14;
            this.label19.Text = "Correo Electronico";
            this.label19.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarDireccion
            // 
            this.txtActualizarDireccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarDireccion.Location = new System.Drawing.Point(13, 108);
            this.txtActualizarDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarDireccion.Name = "txtActualizarDireccion";
            this.txtActualizarDireccion.Size = new System.Drawing.Size(183, 20);
            this.txtActualizarDireccion.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 127);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 27);
            this.label14.TabIndex = 3;
            this.label14.Text = "Ocupacion";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlpBusqueda);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 410);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Mostar ejemplares disponibles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlpBusqueda
            // 
            this.tlpBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBusqueda.ColumnCount = 3;
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBusqueda.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpBusqueda.Controls.Add(this.btnBuscar, 2, 0);
            this.tlpBusqueda.Controls.Add(this.cmbOpcionesBuscar, 0, 0);
            this.tlpBusqueda.Controls.Add(this.dgvResultadosBusqueda, 0, 1);
            this.tlpBusqueda.Controls.Add(this.txtBuscarEjemplar, 1, 0);
            this.tlpBusqueda.Location = new System.Drawing.Point(8, 9);
            this.tlpBusqueda.Name = "tlpBusqueda";
            this.tlpBusqueda.RowCount = 3;
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.95238F));
            this.tlpBusqueda.Size = new System.Drawing.Size(556, 393);
            this.tlpBusqueda.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(447, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 36);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Elemento";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
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
            this.cmbOpcionesBuscar.Location = new System.Drawing.Point(3, 3);
            this.cmbOpcionesBuscar.Name = "cmbOpcionesBuscar";
            this.cmbOpcionesBuscar.Size = new System.Drawing.Size(160, 21);
            this.cmbOpcionesBuscar.TabIndex = 2;
            // 
            // dgvResultadosBusqueda
            // 
            this.dgvResultadosBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultadosBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultadosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpBusqueda.SetColumnSpan(this.dgvResultadosBusqueda, 3);
            this.dgvResultadosBusqueda.Location = new System.Drawing.Point(3, 45);
            this.dgvResultadosBusqueda.Name = "dgvResultadosBusqueda";
            this.dgvResultadosBusqueda.Size = new System.Drawing.Size(550, 321);
            this.dgvResultadosBusqueda.TabIndex = 0;
            // 
            // txtBuscarEjemplar
            // 
            this.txtBuscarEjemplar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarEjemplar.Location = new System.Drawing.Point(169, 3);
            this.txtBuscarEjemplar.Name = "txtBuscarEjemplar";
            this.txtBuscarEjemplar.Size = new System.Drawing.Size(272, 20);
            this.txtBuscarEjemplar.TabIndex = 3;
            // 
            // frmEjemplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 448);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmEjemplar";
            this.Text = "frmEjemplar";
            this.Load += new System.EventHandler(this.frmEjemplar_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tlpEjemplar.ResumeLayout(false);
            this.tlpEjemplar.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tlpBusqueda.ResumeLayout(false);
            this.tlpBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnEliminarEjemplar;
        private System.Windows.Forms.TextBox txtidEliminarEjemplar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtIDatualizar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnActualizarEejmplar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtActualizarOcupacion;
        private System.Windows.Forms.TextBox txtActualizarCorreo;
        private System.Windows.Forms.TextBox txtActualizarInstitucion;
        private System.Windows.Forms.TextBox txtActualizarTelefono;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtActualizarDireccion;
        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.TextBox txtBuscarEjemplar;

        private System.Windows.Forms.ComboBox cmbOpcionesBuscar;

        private System.Windows.Forms.Button btnBuscar;

        private System.Windows.Forms.DataGridView dgvResultadosBusqueda;

        private System.Windows.Forms.TableLayoutPanel tlpBusqueda;

        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.Button btnCrearEditorial;

        private System.Windows.Forms.TextBox txtFechaPublicacion;

        private System.Windows.Forms.TextBox txtFotografia;

        private System.Windows.Forms.Label lblEditorialNueva;
        private System.Windows.Forms.TextBox txtNuevaEditorial;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;

        private System.Windows.Forms.ComboBox cmbColeccionEjemplar;

        private System.Windows.Forms.Button btnCrearAutor;

        private System.Windows.Forms.ComboBox cmbFomato;

        private System.Windows.Forms.ComboBox cmbEditorial;

        private System.Windows.Forms.DateTimePicker dtpFechaPublicacion;

        private System.Windows.Forms.TextBox txtPalabraClave2;
        private System.Windows.Forms.TextBox txtPalabraClave3;

        private System.Windows.Forms.ComboBox cmbIdioma;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tlpEjemplar;
        private System.Windows.Forms.Label lblInfoEjemplar;
        private System.Windows.Forms.TextBox txtNombreEjemplar;
        private System.Windows.Forms.Label lblNombreEjemplar;
        private System.Windows.Forms.Label lblColeccionEjemplar;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblPortadaEejmplar;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Button btnCrearEjemplar;
        private System.Windows.Forms.Label lblissn;
        private System.Windows.Forms.TextBox txtEjemplarID;
        private System.Windows.Forms.Label lblidioma;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.Label lblDoi;
        private System.Windows.Forms.Label lblFormato;
        private System.Windows.Forms.TextBox txtissn;
        private System.Windows.Forms.TextBox txtDoi;
        private System.Windows.Forms.TextBox txtPalabraClave1;
        private System.Windows.Forms.Label lblPalabrasClaves;
        private System.Windows.Forms.TabPage tabPage4;

        #endregion
    }
}