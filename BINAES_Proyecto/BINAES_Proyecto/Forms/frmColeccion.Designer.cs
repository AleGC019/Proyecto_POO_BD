using System.ComponentModel;

namespace BINAES_Proyecto.Forms
{
    partial class frmColeccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmColeccion));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNombreColeccion = new System.Windows.Forms.TextBox();
            this.lblGeneroColeccion = new System.Windows.Forms.Label();
            this.lblTipoColeccion = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCrearColeccion = new System.Windows.Forms.Button();
            this.cmbTipoColeccion = new System.Windows.Forms.ComboBox();
            this.cmbAreaColeccion = new System.Windows.Forms.ComboBox();
            this.lblAreaColeccion = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.lblInformacionColeccion = new System.Windows.Forms.Label();
            this.lblNombreColeccion = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnEliminarColeccion = new System.Windows.Forms.Button();
            this.txtidEliminarColeccion = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbActualizarArea = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbActualizarTipo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbActualizarGenero = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtActualizarColeccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIDActualizarColeccion = new System.Windows.Forms.TextBox();
            this.btnActualizarColeccion = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.Mostrar = new System.Windows.Forms.TabPage();
            this.tlpMostrarUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMostrarUser = new System.Windows.Forms.DataGridView();
            this.btnMostrarColeccion = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.Mostrar.SuspendLayout();
            this.tlpMostrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvMostrarUser)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.Mostrar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(519, 412);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(511, 374);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Agregar Colección";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 14;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158185F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158187F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158185F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158187F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel3.Controls.Add(this.txtNombreColeccion, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblGeneroColeccion, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblTipoColeccion, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.label9, 10, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnCrearColeccion, 10, 11);
            this.tableLayoutPanel3.Controls.Add(this.cmbTipoColeccion, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.cmbAreaColeccion, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.lblAreaColeccion, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.cmbGenero, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblInformacionColeccion, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblNombreColeccion, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 16;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.641975F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.641975F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.703704F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(511, 387);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // txtNombreColeccion
            // 
            this.txtNombreColeccion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtNombreColeccion, 5);
            this.txtNombreColeccion.Location = new System.Drawing.Point(38, 74);
            this.txtNombreColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreColeccion.Name = "txtNombreColeccion";
            this.txtNombreColeccion.Size = new System.Drawing.Size(176, 20);
            this.txtNombreColeccion.TabIndex = 2;
            // 
            // lblGeneroColeccion
            // 
            this.lblGeneroColeccion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblGeneroColeccion, 4);
            this.lblGeneroColeccion.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblGeneroColeccion.Location = new System.Drawing.Point(38, 96);
            this.lblGeneroColeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGeneroColeccion.Name = "lblGeneroColeccion";
            this.lblGeneroColeccion.Size = new System.Drawing.Size(140, 24);
            this.lblGeneroColeccion.TabIndex = 3;
            this.lblGeneroColeccion.Text = "Género";
            this.lblGeneroColeccion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblTipoColeccion
            // 
            this.lblTipoColeccion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblTipoColeccion, 4);
            this.lblTipoColeccion.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTipoColeccion.Location = new System.Drawing.Point(38, 144);
            this.lblTipoColeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoColeccion.Name = "lblTipoColeccion";
            this.lblTipoColeccion.Size = new System.Drawing.Size(140, 24);
            this.lblTipoColeccion.TabIndex = 5;
            this.lblTipoColeccion.Text = "Tipo de colección";
            this.lblTipoColeccion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.label9, 4);
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(362, 24);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(147, 24);
            this.label9.TabIndex = 9;
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnCrearColeccion
            // 
            this.btnCrearColeccion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.tableLayoutPanel3.SetColumnSpan(this.btnCrearColeccion, 3);
            this.btnCrearColeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCrearColeccion.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrearColeccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearColeccion.Location = new System.Drawing.Point(362, 266);
            this.btnCrearColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearColeccion.Name = "btnCrearColeccion";
            this.btnCrearColeccion.Size = new System.Drawing.Size(104, 29);
            this.btnCrearColeccion.TabIndex = 12;
            this.btnCrearColeccion.Text = "Crear colección";
            this.btnCrearColeccion.UseVisualStyleBackColor = false;
            this.btnCrearColeccion.Click += new System.EventHandler(this.btnCrearColeccion_Click);
            // 
            // cmbTipoColeccion
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cmbTipoColeccion, 5);
            this.cmbTipoColeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoColeccion.FormattingEnabled = true;
            this.cmbTipoColeccion.Location = new System.Drawing.Point(38, 170);
            this.cmbTipoColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTipoColeccion.Name = "cmbTipoColeccion";
            this.cmbTipoColeccion.Size = new System.Drawing.Size(176, 21);
            this.cmbTipoColeccion.TabIndex = 19;
            // 
            // cmbAreaColeccion
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cmbAreaColeccion, 5);
            this.cmbAreaColeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAreaColeccion.FormattingEnabled = true;
            this.cmbAreaColeccion.Location = new System.Drawing.Point(38, 218);
            this.cmbAreaColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAreaColeccion.Name = "cmbAreaColeccion";
            this.cmbAreaColeccion.Size = new System.Drawing.Size(176, 21);
            this.cmbAreaColeccion.TabIndex = 20;
            // 
            // lblAreaColeccion
            // 
            this.lblAreaColeccion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblAreaColeccion, 4);
            this.lblAreaColeccion.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAreaColeccion.Location = new System.Drawing.Point(38, 192);
            this.lblAreaColeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAreaColeccion.Name = "lblAreaColeccion";
            this.lblAreaColeccion.Size = new System.Drawing.Size(140, 24);
            this.lblAreaColeccion.TabIndex = 10;
            this.lblAreaColeccion.Text = "Área";
            this.lblAreaColeccion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbGenero
            // 
            this.tableLayoutPanel3.SetColumnSpan(this.cmbGenero, 5);
            this.cmbGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Location = new System.Drawing.Point(38, 122);
            this.cmbGenero.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(176, 21);
            this.cmbGenero.TabIndex = 22;
            // 
            // lblInformacionColeccion
            // 
            this.lblInformacionColeccion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblInformacionColeccion, 5);
            this.lblInformacionColeccion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInformacionColeccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblInformacionColeccion.Location = new System.Drawing.Point(38, 24);
            this.lblInformacionColeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInformacionColeccion.Name = "lblInformacionColeccion";
            this.lblInformacionColeccion.Size = new System.Drawing.Size(176, 24);
            this.lblInformacionColeccion.TabIndex = 0;
            this.lblInformacionColeccion.Text = "Nueva Colección";
            // 
            // lblNombreColeccion
            // 
            this.lblNombreColeccion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblNombreColeccion, 4);
            this.lblNombreColeccion.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblNombreColeccion.Location = new System.Drawing.Point(38, 48);
            this.lblNombreColeccion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreColeccion.Name = "lblNombreColeccion";
            this.lblNombreColeccion.Size = new System.Drawing.Size(140, 24);
            this.lblNombreColeccion.TabIndex = 1;
            this.lblNombreColeccion.Text = "Nombre de la colección";
            this.lblNombreColeccion.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel4);
            this.tabPage4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(511, 374);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Editar/Eliminar";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel4.Controls.Add(this.panel3, 1, 12);
            this.tableLayoutPanel4.Controls.Add(this.panel4, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(-7, -17);
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
            this.panel3.Controls.Add(this.btnEliminarColeccion);
            this.panel3.Controls.Add(this.txtidEliminarColeccion);
            this.panel3.Location = new System.Drawing.Point(39, 313);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel4.SetRowSpan(this.panel3, 4);
            this.panel3.Size = new System.Drawing.Size(477, 96);
            this.panel3.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label21.Location = new System.Drawing.Point(25, 26);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(291, 27);
            this.label21.TabIndex = 21;
            this.label21.Text = "Ingrese el número de id de la colección a eliminar";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label20.Location = new System.Drawing.Point(139, 5);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(129, 25);
            this.label20.TabIndex = 20;
            this.label20.Text = "Eliminar Colección";
            // 
            // btnEliminarColeccion
            // 
            this.btnEliminarColeccion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarColeccion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnEliminarColeccion.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarColeccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarColeccion.Location = new System.Drawing.Point(320, 32);
            this.btnEliminarColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarColeccion.Name = "btnEliminarColeccion";
            this.btnEliminarColeccion.Size = new System.Drawing.Size(97, 31);
            this.btnEliminarColeccion.TabIndex = 16;
            this.btnEliminarColeccion.Text = "Eliminar";
            this.btnEliminarColeccion.UseVisualStyleBackColor = false;
            this.btnEliminarColeccion.Click += new System.EventHandler(this.btnEliminarColeccion_Click);
            // 
            // txtidEliminarColeccion
            // 
            this.txtidEliminarColeccion.Location = new System.Drawing.Point(133, 63);
            this.txtidEliminarColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtidEliminarColeccion.Name = "txtidEliminarColeccion";
            this.txtidEliminarColeccion.Size = new System.Drawing.Size(33, 23);
            this.txtidEliminarColeccion.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.panel4, 13);
            this.panel4.Controls.Add(this.cmbActualizarArea);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.cmbActualizarTipo);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.cmbActualizarGenero);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtActualizarColeccion);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.txtIDActualizarColeccion);
            this.panel4.Controls.Add(this.btnActualizarColeccion);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(39, 28);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel4.SetRowSpan(this.panel4, 10);
            this.panel4.Size = new System.Drawing.Size(477, 256);
            this.panel4.TabIndex = 23;
            // 
            // cmbActualizarArea
            // 
            this.cmbActualizarArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActualizarArea.FormattingEnabled = true;
            this.cmbActualizarArea.Location = new System.Drawing.Point(27, 211);
            this.cmbActualizarArea.Margin = new System.Windows.Forms.Padding(2);
            this.cmbActualizarArea.Name = "cmbActualizarArea";
            this.cmbActualizarArea.Size = new System.Drawing.Size(176, 25);
            this.cmbActualizarArea.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(27, 190);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Área";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbActualizarTipo
            // 
            this.cmbActualizarTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActualizarTipo.FormattingEnabled = true;
            this.cmbActualizarTipo.Location = new System.Drawing.Point(27, 163);
            this.cmbActualizarTipo.Margin = new System.Windows.Forms.Padding(2);
            this.cmbActualizarTipo.Name = "cmbActualizarTipo";
            this.cmbActualizarTipo.Size = new System.Drawing.Size(176, 25);
            this.cmbActualizarTipo.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(25, 146);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tipo de colección";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbActualizarGenero
            // 
            this.cmbActualizarGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActualizarGenero.FormattingEnabled = true;
            this.cmbActualizarGenero.Location = new System.Drawing.Point(27, 115);
            this.cmbActualizarGenero.Margin = new System.Windows.Forms.Padding(2);
            this.cmbActualizarGenero.Name = "cmbActualizarGenero";
            this.cmbActualizarGenero.Size = new System.Drawing.Size(176, 25);
            this.cmbActualizarGenero.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(25, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Género";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarColeccion
            // 
            this.txtActualizarColeccion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtActualizarColeccion.Location = new System.Drawing.Point(25, 62);
            this.txtActualizarColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarColeccion.Name = "txtActualizarColeccion";
            this.txtActualizarColeccion.Size = new System.Drawing.Size(177, 23);
            this.txtActualizarColeccion.TabIndex = 22;
            this.txtActualizarColeccion.TextChanged += new System.EventHandler(this.txtActualizarColeccion_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(25, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nombre de la colección";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label22.Location = new System.Drawing.Point(247, 51);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(28, 24);
            this.label22.TabIndex = 20;
            this.label22.Text = "ID";
            this.label22.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label17.Location = new System.Drawing.Point(237, -1);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(200, 49);
            this.label17.TabIndex = 19;
            this.label17.Text = "Ingrese el número de ID de la colección que desea actualizar ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtIDActualizarColeccion
            // 
            this.txtIDActualizarColeccion.Location = new System.Drawing.Point(279, 53);
            this.txtIDActualizarColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDActualizarColeccion.Name = "txtIDActualizarColeccion";
            this.txtIDActualizarColeccion.Size = new System.Drawing.Size(25, 23);
            this.txtIDActualizarColeccion.TabIndex = 18;
            // 
            // btnActualizarColeccion
            // 
            this.btnActualizarColeccion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizarColeccion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnActualizarColeccion.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarColeccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizarColeccion.Location = new System.Drawing.Point(287, 140);
            this.btnActualizarColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarColeccion.Name = "btnActualizarColeccion";
            this.btnActualizarColeccion.Size = new System.Drawing.Size(107, 45);
            this.btnActualizarColeccion.TabIndex = 17;
            this.btnActualizarColeccion.Text = "Actualizar";
            this.btnActualizarColeccion.UseVisualStyleBackColor = false;
            this.btnActualizarColeccion.Click += new System.EventHandler(this.btnActualizarColeccion_Click);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.Location = new System.Drawing.Point(25, 19);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Editar Colección";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Mostrar
            // 
            this.Mostrar.Controls.Add(this.tlpMostrarUsuario);
            this.Mostrar.Location = new System.Drawing.Point(4, 34);
            this.Mostrar.Margin = new System.Windows.Forms.Padding(2);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Padding = new System.Windows.Forms.Padding(2);
            this.Mostrar.Size = new System.Drawing.Size(511, 374);
            this.Mostrar.TabIndex = 2;
            this.Mostrar.Text = "Mostrar";
            this.Mostrar.UseVisualStyleBackColor = true;
            // 
            // tlpMostrarUsuario
            // 
            this.tlpMostrarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMostrarUsuario.ColumnCount = 4;
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.06422F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.06422F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpMostrarUsuario.Controls.Add(this.dgvMostrarUser, 1, 2);
            this.tlpMostrarUsuario.Controls.Add(this.btnMostrarColeccion, 2, 0);
            this.tlpMostrarUsuario.Location = new System.Drawing.Point(2, 2);
            this.tlpMostrarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMostrarUsuario.Name = "tlpMostrarUsuario";
            this.tlpMostrarUsuario.RowCount = 4;
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.287926F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.572755F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.73065F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25387F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.287926F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.572755F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.73065F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25387F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpMostrarUsuario.Size = new System.Drawing.Size(509, 383);
            this.tlpMostrarUsuario.TabIndex = 2;
            // 
            // dgvMostrarUser
            // 
            this.dgvMostrarUser.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpMostrarUsuario.SetColumnSpan(this.dgvMostrarUser, 2);
            this.dgvMostrarUser.Location = new System.Drawing.Point(64, 58);
            this.dgvMostrarUser.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMostrarUser.Name = "dgvMostrarUser";
            this.dgvMostrarUser.RowHeadersWidth = 62;
            this.dgvMostrarUser.RowTemplate.Height = 28;
            this.dgvMostrarUser.Size = new System.Drawing.Size(346, 259);
            this.dgvMostrarUser.TabIndex = 0;
            // 
            // btnMostrarColeccion
            // 
            this.btnMostrarColeccion.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (5)))), ((int) (((byte) (29)))), ((int) (((byte) (64)))));
            this.btnMostrarColeccion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMostrarColeccion.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMostrarColeccion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostrarColeccion.Location = new System.Drawing.Point(275, 2);
            this.btnMostrarColeccion.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarColeccion.Name = "btnMostrarColeccion";
            this.btnMostrarColeccion.Size = new System.Drawing.Size(135, 31);
            this.btnMostrarColeccion.TabIndex = 1;
            this.btnMostrarColeccion.Text = "Mostrar Colecciones";
            this.btnMostrarColeccion.UseVisualStyleBackColor = false;
            this.btnMostrarColeccion.Click += new System.EventHandler(this.btnMostrarColeccion_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.SetColumnSpan(this.textBox1, 5);
            this.textBox1.Location = new System.Drawing.Point(17, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(64, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 68);
            this.label1.TabIndex = 3;
            this.label1.Text = "Género";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(17, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de colección";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 146);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(17, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(64, 21);
            this.comboBox2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(17, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Área";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(17, 109);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(64, 21);
            this.comboBox3.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 14;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158187F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.158187F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.140301F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // frmColeccion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(519, 412);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmColeccion";
            this.Load += new System.EventHandler(this.frmColeccion_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.Mostrar.ResumeLayout(false);
            this.tlpMostrarUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvMostrarUser)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtActualizarColeccion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbActualizarGenero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbActualizarTipo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbActualizarArea;

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnEliminarColeccion;
        private System.Windows.Forms.TextBox txtidEliminarColeccion;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIDActualizarColeccion;
        private System.Windows.Forms.Button btnActualizarColeccion;
        private System.Windows.Forms.Label label12;

        private System.Windows.Forms.ComboBox cmbGenero;


        private System.Windows.Forms.ComboBox cmbTipoColeccion;
        private System.Windows.Forms.ComboBox cmbAreaColeccion;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblInformacionColeccion;
        private System.Windows.Forms.TextBox txtNombreColeccion;
        private System.Windows.Forms.Label lblNombreColeccion;
        private System.Windows.Forms.Label lblGeneroColeccion;
        private System.Windows.Forms.Label lblTipoColeccion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblAreaColeccion;
        private System.Windows.Forms.Button btnCrearColeccion;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage Mostrar;
        private System.Windows.Forms.TableLayoutPanel tlpMostrarUsuario;
        private System.Windows.Forms.DataGridView dgvMostrarUser;
        private System.Windows.Forms.Button btnMostrarColeccion;

        #endregion
    }
}