using System.ComponentModel;

namespace BINAES_Proyecto.Forms
{
    partial class frmEvento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEvento));
            this.tbcEventos = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlpBusqueda = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvEvento = new System.Windows.Forms.DataGridView();
            this.txtBuscarEvento = new System.Windows.Forms.TextBox();
            this.cmbEvento = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.btnAgregarE = new System.Windows.Forms.Button();
            this.txtNombreE = new System.Windows.Forms.TextBox();
            this.lblnombreE = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbEArea = new System.Windows.Forms.ComboBox();
            this.dtpIniico = new System.Windows.Forms.DateTimePicker();
            this.picEvento = new System.Windows.Forms.PictureBox();
            this.lblAsistentes = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.txtobjetivo = new System.Windows.Forms.TextBox();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnEliminarEvento = new System.Windows.Forms.Button();
            this.txtidEliminarEvento = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBuscarIDEvento = new System.Windows.Forms.Button();
            this.dtpActualizarFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpActualizarFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizarEvento = new System.Windows.Forms.Button();
            this.nudActualizarAsistentes = new System.Windows.Forms.NumericUpDown();
            this.btnActualizarImagenEvento = new System.Windows.Forms.Button();
            this.txtActualaizarObjetivosEvento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbActualizarEventoArea = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtActualizarTituloEvento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtIDActualizarEvento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbcEventos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tlpBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEvento)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picEvento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudCantidad)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudActualizarAsistentes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcEventos
            // 
            this.tbcEventos.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcEventos.Controls.Add(this.tabPage1);
            this.tbcEventos.Controls.Add(this.tabPage2);
            this.tbcEventos.Controls.Add(this.tabPage3);
            this.tbcEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tbcEventos.Location = new System.Drawing.Point(18, 17);
            this.tbcEventos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbcEventos.Name = "tbcEventos";
            this.tbcEventos.SelectedIndex = 0;
            this.tbcEventos.Size = new System.Drawing.Size(879, 612);
            this.tbcEventos.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlpBusqueda);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(871, 577);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mostrar los eventos disponibles";
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
            this.tlpBusqueda.Controls.Add(this.dgvEvento, 0, 1);
            this.tlpBusqueda.Controls.Add(this.txtBuscarEvento, 1, 0);
            this.tlpBusqueda.Controls.Add(this.cmbEvento, 0, 0);
            this.tlpBusqueda.Location = new System.Drawing.Point(22, 28);
            this.tlpBusqueda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpBusqueda.Name = "tlpBusqueda";
            this.tlpBusqueda.RowCount = 3;
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.71429F));
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33333F));
            this.tlpBusqueda.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.95238F));
            this.tlpBusqueda.Size = new System.Drawing.Size(836, 518);
            this.tlpBusqueda.TabIndex = 2;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(672, 5);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(160, 45);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar Evento";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvEvento
            // 
            this.dgvEvento.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEvento.BackgroundColor = System.Drawing.Color.White;
            this.dgvEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpBusqueda.SetColumnSpan(this.dgvEvento, 3);
            this.dgvEvento.Location = new System.Drawing.Point(4, 60);
            this.dgvEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEvento.Name = "dgvEvento";
            this.dgvEvento.RowHeadersWidth = 62;
            this.dgvEvento.Size = new System.Drawing.Size(828, 421);
            this.dgvEvento.TabIndex = 0;
            // 
            // txtBuscarEvento
            // 
            this.txtBuscarEvento.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscarEvento.Location = new System.Drawing.Point(254, 5);
            this.txtBuscarEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscarEvento.Name = "txtBuscarEvento";
            this.txtBuscarEvento.Size = new System.Drawing.Size(410, 28);
            this.txtBuscarEvento.TabIndex = 3;
            // 
            // cmbEvento
            // 
            this.cmbEvento.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEvento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEvento.FormattingEnabled = true;
            this.cmbEvento.Items.AddRange(new object[] {"Eventos", "Nombre del evento"});
            this.cmbEvento.Location = new System.Drawing.Point(4, 5);
            this.cmbEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEvento.Name = "cmbEvento";
            this.cmbEvento.Size = new System.Drawing.Size(242, 30);
            this.cmbEvento.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(871, 577);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar un evento a la biblioteca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 14;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.104099F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.104101F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.344464F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.591185F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.086351F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.086351F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.079001F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.086351F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.086351F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.086351F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.086351F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.086351F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.086351F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.086351F));
            this.tableLayoutPanel3.Controls.Add(this.lblInformacion, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnAgregarE, 9, 13);
            this.tableLayoutPanel3.Controls.Add(this.txtNombreE, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblnombreE, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblarea, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.label9, 10, 1);
            this.tableLayoutPanel3.Controls.Add(this.cmbEArea, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.dtpIniico, 1, 7);
            this.tableLayoutPanel3.Controls.Add(this.picEvento, 8, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblAsistentes, 9, 10);
            this.tableLayoutPanel3.Controls.Add(this.btnAgregar, 9, 9);
            this.tableLayoutPanel3.Controls.Add(this.lblFinal, 1, 8);
            this.tableLayoutPanel3.Controls.Add(this.lblInicio, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.dtpFinalizacion, 1, 9);
            this.tableLayoutPanel3.Controls.Add(this.txtobjetivo, 1, 13);
            this.tableLayoutPanel3.Controls.Add(this.lblObjetivo, 1, 12);
            this.tableLayoutPanel3.Controls.Add(this.nudCantidad, 9, 11);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 15;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.386052F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.386052F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.386052F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.386052F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.386052F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.386052F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.917661F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.386052F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.954874F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.791209F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.67033F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.868132F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.318681F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.967033F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.386052F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(863, 567);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // lblInformacion
            // 
            this.lblInformacion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblInformacion, 6);
            this.lblInformacion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInformacion.Location = new System.Drawing.Point(64, 36);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(365, 36);
            this.lblInformacion.TabIndex = 0;
            this.lblInformacion.Text = "Información del nuevo evento";
            // 
            // btnAgregarE
            // 
            this.btnAgregarE.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarE.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.tableLayoutPanel3.SetColumnSpan(this.btnAgregarE, 4);
            this.btnAgregarE.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregarE.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarE.Location = new System.Drawing.Point(557, 483);
            this.btnAgregarE.Name = "btnAgregarE";
            this.btnAgregarE.Size = new System.Drawing.Size(238, 39);
            this.btnAgregarE.TabIndex = 17;
            this.btnAgregarE.Text = "Agregar Evento";
            this.btnAgregarE.UseVisualStyleBackColor = false;
            this.btnAgregarE.Click += new System.EventHandler(this.btnAgregarE_Click);
            // 
            // txtNombreE
            // 
            this.txtNombreE.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtNombreE, 5);
            this.txtNombreE.Location = new System.Drawing.Point(64, 111);
            this.txtNombreE.Name = "txtNombreE";
            this.txtNombreE.Size = new System.Drawing.Size(296, 28);
            this.txtNombreE.TabIndex = 2;
            // 
            // lblnombreE
            // 
            this.lblnombreE.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblnombreE, 4);
            this.lblnombreE.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblnombreE.Location = new System.Drawing.Point(64, 72);
            this.lblnombreE.Name = "lblnombreE";
            this.lblnombreE.Size = new System.Drawing.Size(235, 36);
            this.lblnombreE.TabIndex = 1;
            this.lblnombreE.Text = "Título del evento: ";
            this.lblnombreE.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblarea
            // 
            this.lblarea.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblarea, 4);
            this.lblarea.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblarea.Location = new System.Drawing.Point(64, 144);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(235, 36);
            this.lblarea.TabIndex = 3;
            this.lblarea.Text = " Área del evento";
            this.lblarea.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.label9, 2);
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(618, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 36);
            this.label9.TabIndex = 9;
            this.label9.Text = "Fotografía";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // cmbEArea
            // 
            this.cmbEArea.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.cmbEArea, 5);
            this.cmbEArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEArea.FormattingEnabled = true;
            this.cmbEArea.Location = new System.Drawing.Point(65, 185);
            this.cmbEArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEArea.Name = "cmbEArea";
            this.cmbEArea.Size = new System.Drawing.Size(294, 30);
            this.cmbEArea.TabIndex = 18;
            // 
            // dtpIniico
            // 
            this.dtpIniico.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.dtpIniico, 6);
            this.dtpIniico.Location = new System.Drawing.Point(65, 260);
            this.dtpIniico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpIniico.Name = "dtpIniico";
            this.dtpIniico.Size = new System.Drawing.Size(363, 28);
            this.dtpIniico.TabIndex = 19;
            // 
            // picEvento
            // 
            this.picEvento.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.picEvento, 6);
            this.picEvento.Location = new System.Drawing.Point(497, 113);
            this.picEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picEvento.Name = "picEvento";
            this.tableLayoutPanel3.SetRowSpan(this.picEvento, 5);
            this.picEvento.Size = new System.Drawing.Size(362, 173);
            this.picEvento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEvento.TabIndex = 22;
            this.picEvento.TabStop = false;
            // 
            // lblAsistentes
            // 
            this.lblAsistentes.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblAsistentes, 4);
            this.lblAsistentes.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAsistentes.Location = new System.Drawing.Point(557, 380);
            this.lblAsistentes.Name = "lblAsistentes";
            this.lblAsistentes.Size = new System.Drawing.Size(238, 26);
            this.lblAsistentes.TabIndex = 14;
            this.lblAsistentes.Text = "Cantidad de asistentes";
            this.lblAsistentes.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.SystemColors.Highlight;
            this.tableLayoutPanel3.SetColumnSpan(this.btnAgregar, 4);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(558, 335);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(236, 40);
            this.btnAgregar.TabIndex = 23;
            this.btnAgregar.Text = "Agregar Imagen";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_click);
            // 
            // lblFinal
            // 
            this.lblFinal.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblFinal, 5);
            this.lblFinal.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFinal.Location = new System.Drawing.Point(64, 291);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(296, 39);
            this.lblFinal.TabIndex = 10;
            this.lblFinal.Text = "Hora y fecha de finalización";
            this.lblFinal.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblInicio
            // 
            this.lblInicio.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblInicio, 4);
            this.lblInicio.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInicio.Location = new System.Drawing.Point(64, 216);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(235, 39);
            this.lblInicio.TabIndex = 5;
            this.lblInicio.Text = "Hora y fecha de inicio ";
            this.lblInicio.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dtpFinalizacion
            // 
            this.dtpFinalizacion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.dtpFinalizacion, 6);
            this.dtpFinalizacion.Location = new System.Drawing.Point(65, 335);
            this.dtpFinalizacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpFinalizacion.Name = "dtpFinalizacion";
            this.dtpFinalizacion.Size = new System.Drawing.Size(363, 28);
            this.dtpFinalizacion.TabIndex = 20;
            // 
            // txtobjetivo
            // 
            this.txtobjetivo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.txtobjetivo, 5);
            this.txtobjetivo.Location = new System.Drawing.Point(64, 483);
            this.txtobjetivo.Name = "txtobjetivo";
            this.txtobjetivo.Size = new System.Drawing.Size(296, 28);
            this.txtobjetivo.TabIndex = 25;
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.lblObjetivo, 5);
            this.lblObjetivo.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblObjetivo.Location = new System.Drawing.Point(64, 445);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(296, 35);
            this.lblObjetivo.TabIndex = 24;
            this.lblObjetivo.Text = "Ingrese el objetivo del evento";
            this.lblObjetivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.SetColumnSpan(this.nudCantidad, 4);
            this.nudCantidad.Location = new System.Drawing.Point(558, 411);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCantidad.Maximum = new decimal(new int[] {400, 0, 0, 0});
            this.nudCantidad.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(236, 28);
            this.nudCantidad.TabIndex = 21;
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidad.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel4);
            this.tabPage3.Location = new System.Drawing.Point(4, 31);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(871, 577);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Editar o Eliminar";
            this.tabPage3.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 5);
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(866, 563);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.panel3, 13);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.btnEliminarEvento);
            this.panel3.Controls.Add(this.txtidEliminarEvento);
            this.panel3.Location = new System.Drawing.Point(64, 421);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel4.SetRowSpan(this.panel3, 4);
            this.panel3.Size = new System.Drawing.Size(799, 139);
            this.panel3.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label21.Location = new System.Drawing.Point(82, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(396, 37);
            this.label21.TabIndex = 21;
            this.label21.Text = "Ingrese el número de ID del evento a eliminar";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label20.Location = new System.Drawing.Point(208, 8);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(158, 32);
            this.label20.TabIndex = 20;
            this.label20.Text = "Eliminar evento";
            // 
            // btnEliminarEvento
            // 
            this.btnEliminarEvento.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnEliminarEvento.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarEvento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarEvento.Location = new System.Drawing.Point(574, 62);
            this.btnEliminarEvento.Name = "btnEliminarEvento";
            this.btnEliminarEvento.Size = new System.Drawing.Size(184, 43);
            this.btnEliminarEvento.TabIndex = 16;
            this.btnEliminarEvento.Text = "Eliminar";
            this.btnEliminarEvento.UseVisualStyleBackColor = false;
            this.btnEliminarEvento.Click += new System.EventHandler(this.btnEliminarEvento_Click);
            // 
            // txtidEliminarEvento
            // 
            this.txtidEliminarEvento.Location = new System.Drawing.Point(248, 77);
            this.txtidEliminarEvento.Name = "txtidEliminarEvento";
            this.txtidEliminarEvento.Size = new System.Drawing.Size(48, 28);
            this.txtidEliminarEvento.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.panel4, 13);
            this.panel4.Controls.Add(this.btnBuscarIDEvento);
            this.panel4.Controls.Add(this.dtpActualizarFechaFin);
            this.panel4.Controls.Add(this.dtpActualizarFechaInicio);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnActualizarEvento);
            this.panel4.Controls.Add(this.nudActualizarAsistentes);
            this.panel4.Controls.Add(this.btnActualizarImagenEvento);
            this.panel4.Controls.Add(this.txtActualaizarObjetivosEvento);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.cmbActualizarEventoArea);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txtActualizarTituloEvento);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.txtIDActualizarEvento);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Location = new System.Drawing.Point(64, 38);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel4.SetRowSpan(this.panel4, 11);
            this.panel4.Size = new System.Drawing.Size(799, 377);
            this.panel4.TabIndex = 23;
            // 
            // btnBuscarIDEvento
            // 
            this.btnBuscarIDEvento.Location = new System.Drawing.Point(668, 77);
            this.btnBuscarIDEvento.Name = "btnBuscarIDEvento";
            this.btnBuscarIDEvento.Size = new System.Drawing.Size(91, 28);
            this.btnBuscarIDEvento.TabIndex = 37;
            this.btnBuscarIDEvento.Text = "Buscar";
            this.btnBuscarIDEvento.UseVisualStyleBackColor = true;
            this.btnBuscarIDEvento.Click += new System.EventHandler(this.btnBuscarIDEvento_Click);
            // 
            // dtpActualizarFechaFin
            // 
            this.dtpActualizarFechaFin.Location = new System.Drawing.Point(44, 295);
            this.dtpActualizarFechaFin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpActualizarFechaFin.Name = "dtpActualizarFechaFin";
            this.dtpActualizarFechaFin.Size = new System.Drawing.Size(363, 28);
            this.dtpActualizarFechaFin.TabIndex = 36;
            // 
            // dtpActualizarFechaInicio
            // 
            this.dtpActualizarFechaInicio.Location = new System.Drawing.Point(44, 216);
            this.dtpActualizarFechaInicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpActualizarFechaInicio.Name = "dtpActualizarFechaInicio";
            this.dtpActualizarFechaInicio.Size = new System.Drawing.Size(363, 28);
            this.dtpActualizarFechaInicio.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(454, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 28);
            this.label2.TabIndex = 34;
            this.label2.Text = "Cantidad de asistentes";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnActualizarEvento
            // 
            this.btnActualizarEvento.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnActualizarEvento.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarEvento.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizarEvento.Location = new System.Drawing.Point(755, 264);
            this.btnActualizarEvento.Name = "btnActualizarEvento";
            this.btnActualizarEvento.Size = new System.Drawing.Size(166, 40);
            this.btnActualizarEvento.TabIndex = 17;
            this.btnActualizarEvento.Text = "Actualizar";
            this.btnActualizarEvento.UseVisualStyleBackColor = false;
            this.btnActualizarEvento.Click += new System.EventHandler(this.btnActualizarEvento_Click);
            // 
            // nudActualizarAsistentes
            // 
            this.nudActualizarAsistentes.Location = new System.Drawing.Point(459, 272);
            this.nudActualizarAsistentes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudActualizarAsistentes.Maximum = new decimal(new int[] {400, 0, 0, 0});
            this.nudActualizarAsistentes.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudActualizarAsistentes.Name = "nudActualizarAsistentes";
            this.nudActualizarAsistentes.Size = new System.Drawing.Size(243, 28);
            this.nudActualizarAsistentes.TabIndex = 33;
            this.nudActualizarAsistentes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudActualizarAsistentes.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // btnActualizarImagenEvento
            // 
            this.btnActualizarImagenEvento.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnActualizarImagenEvento.ForeColor = System.Drawing.Color.White;
            this.btnActualizarImagenEvento.Location = new System.Drawing.Point(459, 197);
            this.btnActualizarImagenEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizarImagenEvento.Name = "btnActualizarImagenEvento";
            this.btnActualizarImagenEvento.Size = new System.Drawing.Size(243, 38);
            this.btnActualizarImagenEvento.TabIndex = 32;
            this.btnActualizarImagenEvento.Text = "Actualizar Imagen";
            this.btnActualizarImagenEvento.UseVisualStyleBackColor = false;
            this.btnActualizarImagenEvento.Click += new System.EventHandler(this.btnActualizarImagenEvento_Click);
            // 
            // txtActualaizarObjetivosEvento
            // 
            this.txtActualaizarObjetivosEvento.Location = new System.Drawing.Point(459, 152);
            this.txtActualaizarObjetivosEvento.Name = "txtActualaizarObjetivosEvento";
            this.txtActualaizarObjetivosEvento.Size = new System.Drawing.Size(248, 28);
            this.txtActualaizarObjetivosEvento.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(454, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 28);
            this.label1.TabIndex = 30;
            this.label1.Text = "Ingrese el objetivo del evento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbActualizarEventoArea
            // 
            this.cmbActualizarEventoArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbActualizarEventoArea.FormattingEnabled = true;
            this.cmbActualizarEventoArea.Location = new System.Drawing.Point(44, 140);
            this.cmbActualizarEventoArea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbActualizarEventoArea.Name = "cmbActualizarEventoArea";
            this.cmbActualizarEventoArea.Size = new System.Drawing.Size(270, 30);
            this.cmbActualizarEventoArea.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(44, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(246, 28);
            this.label7.TabIndex = 27;
            this.label7.Text = "Hora y fecha de finalización";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(44, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 28);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hora y fecha de inicio ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(44, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 28);
            this.label5.TabIndex = 23;
            this.label5.Text = "Área del evento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarTituloEvento
            // 
            this.txtActualizarTituloEvento.Location = new System.Drawing.Point(42, 66);
            this.txtActualizarTituloEvento.Name = "txtActualizarTituloEvento";
            this.txtActualizarTituloEvento.Size = new System.Drawing.Size(271, 28);
            this.txtActualizarTituloEvento.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(42, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(218, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "Título del evento";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label22.Location = new System.Drawing.Point(454, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 28);
            this.label22.TabIndex = 20;
            this.label22.Text = "ID";
            this.label22.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label17.Location = new System.Drawing.Point(452, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(308, 58);
            this.label17.TabIndex = 19;
            this.label17.Text = "Ingrese el número de ID de la colección que desea actualizar ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtIDActualizarEvento
            // 
            this.txtIDActualizarEvento.Location = new System.Drawing.Point(549, 78);
            this.txtIDActualizarEvento.Name = "txtIDActualizarEvento";
            this.txtIDActualizarEvento.Size = new System.Drawing.Size(79, 28);
            this.txtIDActualizarEvento.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.Location = new System.Drawing.Point(40, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(166, 38);
            this.label12.TabIndex = 0;
            this.label12.Text = "Editar evento";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 634);
            this.Controls.Add(this.tbcEventos);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmEvento";
            this.Text = "frmEvento";
            this.Load += new System.EventHandler(this.frmEvento_Load);
            this.tbcEventos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tlpBusqueda.ResumeLayout(false);
            this.tlpBusqueda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEvento)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picEvento)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudCantidad)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudActualizarAsistentes)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnBuscarIDEvento;

        private System.Windows.Forms.DateTimePicker dtpActualizarFechaInicio;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActualaizarObjetivosEvento;
        private System.Windows.Forms.Button btnActualizarImagenEvento;
        private System.Windows.Forms.NumericUpDown nudActualizarAsistentes;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox cmbActualizarEventoArea;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnEliminarEvento;
        private System.Windows.Forms.TextBox txtidEliminarEvento;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtActualizarTituloEvento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIDActualizarEvento;
        private System.Windows.Forms.Button btnActualizarEvento;
        private System.Windows.Forms.Label label12;

        

        private System.Windows.Forms.DateTimePicker dtpActualizarFechaFin;

        private System.Windows.Forms.TabPage tabPage3;

        private System.Windows.Forms.TableLayoutPanel tlpBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbEvento;
        private System.Windows.Forms.DataGridView dgvEvento;
        private System.Windows.Forms.TextBox txtBuscarEvento;

        private System.Windows.Forms.TabControl tbcEventos;

        
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button btnAgregarE;
        private System.Windows.Forms.TextBox txtNombreE;
        private System.Windows.Forms.Label lblnombreE;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbEArea;
        private System.Windows.Forms.DateTimePicker dtpIniico;
        private System.Windows.Forms.PictureBox picEvento;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblAsistentes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpFinalizacion;
        private System.Windows.Forms.TextBox txtobjetivo;
        private System.Windows.Forms.Label lblObjetivo;
    }
}