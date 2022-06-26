using System.ComponentModel;

namespace BINAES_Proyecto.Forms
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCorreoUsuario = new System.Windows.Forms.TextBox();
            this.lblCorreoUsuario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tc1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.picImagenUsuario = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDireccionUsuario = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOcupacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInstitucion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.btnAgregarImagen = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreUsuarios = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnConfirmarIDusuario = new System.Windows.Forms.Button();
            this.btnActualizarImagen = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIDatualizar = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnActualizarUsuario = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtActualizarOcupacion = new System.Windows.Forms.TextBox();
            this.txtActualizarCorreo = new System.Windows.Forms.TextBox();
            this.txtActualizarInstitucion = new System.Windows.Forms.TextBox();
            this.txtActualizarNombre = new System.Windows.Forms.TextBox();
            this.txtActualizarTelefono = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtActualizarDireccion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.txtIdEliminar = new System.Windows.Forms.TextBox();
            this.Mostrar = new System.Windows.Forms.TabPage();
            this.tlpMostrarUsuario = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMostrarUser = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.picQR = new System.Windows.Forms.PictureBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tc1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picImagenUsuario)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.Mostrar.SuspendLayout();
            this.tlpMostrarUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvMostrarUser)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.panelResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picQR)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 46);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.txtCorreoUsuario, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.lblCorreoUsuario, 0, 7);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // txtCorreoUsuario
            // 
            this.txtCorreoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCorreoUsuario.Location = new System.Drawing.Point(103, 3);
            this.txtCorreoUsuario.Name = "txtCorreoUsuario";
            this.txtCorreoUsuario.Size = new System.Drawing.Size(94, 20);
            this.txtCorreoUsuario.TabIndex = 15;
            // 
            // lblCorreoUsuario
            // 
            this.lblCorreoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreoUsuario.Location = new System.Drawing.Point(3, 0);
            this.lblCorreoUsuario.Name = "lblCorreoUsuario";
            this.lblCorreoUsuario.Size = new System.Drawing.Size(94, 100);
            this.lblCorreoUsuario.TabIndex = 14;
            this.lblCorreoUsuario.Text = "Correo: ";
            this.lblCorreoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 114);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(0, 0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(200, 100);
            this.tabPage1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Location = new System.Drawing.Point(2, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(764, 46);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(103, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 100);
            this.label2.TabIndex = 14;
            this.label2.Text = "Correo: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 114);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nombre:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(0, 0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(200, 100);
            this.tabPage2.TabIndex = 0;
            // 
            // tc1
            // 
            this.tc1.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tc1.Controls.Add(this.tabPage3);
            this.tc1.Controls.Add(this.tabPage4);
            this.tc1.Controls.Add(this.Mostrar);
            this.tc1.Controls.Add(this.tabPage5);
            this.tc1.ItemSize = new System.Drawing.Size(90, 30);
            this.tc1.Location = new System.Drawing.Point(0, 0);
            this.tc1.Margin = new System.Windows.Forms.Padding(2);
            this.tc1.Name = "tc1";
            this.tc1.Padding = new System.Drawing.Point(10, 8);
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(585, 412);
            this.tc1.TabIndex = 2;
            this.tc1.Tag = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(577, 374);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Agregar Usuario";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.picImagenUsuario);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.txtDireccionUsuario);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtTelefono);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtOcupacion);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.txt);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.txtInstitucion);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.btnCrearUsuario);
            this.panel5.Controls.Add(this.btnAgregarImagen);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.txtNombreUsuarios);
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(516, 388);
            this.panel5.TabIndex = 23;
            // 
            // picImagenUsuario
            // 
            this.picImagenUsuario.Location = new System.Drawing.Point(336, 17);
            this.picImagenUsuario.Name = "picImagenUsuario";
            this.picImagenUsuario.Size = new System.Drawing.Size(175, 147);
            this.picImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImagenUsuario.TabIndex = 22;
            this.picImagenUsuario.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(20, 151);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 14);
            this.label7.TabIndex = 5;
            this.label7.Text = "Dirección";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtDireccionUsuario
            // 
            this.txtDireccionUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDireccionUsuario.Location = new System.Drawing.Point(23, 166);
            this.txtDireccionUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtDireccionUsuario.Name = "txtDireccionUsuario";
            this.txtDireccionUsuario.Size = new System.Drawing.Size(181, 20);
            this.txtDireccionUsuario.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(219, 261);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Teléfono";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefono.Location = new System.Drawing.Point(221, 281);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(98, 20);
            this.txtTelefono.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(20, 99);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 14);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ocupación";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtOcupacion
            // 
            this.txtOcupacion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOcupacion.Location = new System.Drawing.Point(23, 115);
            this.txtOcupacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtOcupacion.Name = "txtOcupacion";
            this.txtOcupacion.Size = new System.Drawing.Size(181, 20);
            this.txtOcupacion.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.Location = new System.Drawing.Point(20, 256);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 16);
            this.label11.TabIndex = 14;
            this.label11.Text = "Correo Electrónico";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Location = new System.Drawing.Point(23, 281);
            this.txt.Margin = new System.Windows.Forms.Padding(2);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(141, 20);
            this.txt.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(20, 202);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 18);
            this.label10.TabIndex = 10;
            this.label10.Text = "Institución";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtInstitucion
            // 
            this.txtInstitucion.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInstitucion.Location = new System.Drawing.Point(23, 224);
            this.txtInstitucion.Margin = new System.Windows.Forms.Padding(2);
            this.txtInstitucion.Name = "txtInstitucion";
            this.txtInstitucion.Size = new System.Drawing.Size(181, 20);
            this.txtInstitucion.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(19, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Información del usuario";
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnCrearUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCrearUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCrearUsuario.Location = new System.Drawing.Point(347, 274);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(145, 27);
            this.btnCrearUsuario.TabIndex = 12;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // btnAgregarImagen
            // 
            this.btnAgregarImagen.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregarImagen.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnAgregarImagen.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregarImagen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarImagen.Location = new System.Drawing.Point(347, 217);
            this.btnAgregarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarImagen.Name = "btnAgregarImagen";
            this.btnAgregarImagen.Size = new System.Drawing.Size(145, 27);
            this.btnAgregarImagen.TabIndex = 21;
            this.btnAgregarImagen.Text = "Agregar";
            this.btnAgregarImagen.UseVisualStyleBackColor = false;
            this.btnAgregarImagen.Click += new System.EventHandler(this.btnAgregarImagen_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(20, 49);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nombre y apellido";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtNombreUsuarios
            // 
            this.txtNombreUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombreUsuarios.Location = new System.Drawing.Point(23, 67);
            this.txtNombreUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreUsuarios.Name = "txtNombreUsuarios";
            this.txtNombreUsuarios.Size = new System.Drawing.Size(181, 20);
            this.txtNombreUsuarios.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tableLayoutPanel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(577, 374);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Editar Usuario";
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
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 11);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(1, 1);
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
            this.tableLayoutPanel4.Size = new System.Drawing.Size(574, 373);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.panel4, 13);
            this.panel4.Controls.Add(this.btnConfirmarIDusuario);
            this.panel4.Controls.Add(this.btnActualizarImagen);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.txtIDatualizar);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.btnActualizarUsuario);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label16);
            this.panel4.Controls.Add(this.txtActualizarOcupacion);
            this.panel4.Controls.Add(this.txtActualizarCorreo);
            this.panel4.Controls.Add(this.txtActualizarInstitucion);
            this.panel4.Controls.Add(this.txtActualizarNombre);
            this.panel4.Controls.Add(this.txtActualizarTelefono);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Controls.Add(this.txtActualizarDireccion);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Location = new System.Drawing.Point(2, 2);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.tableLayoutPanel4.SetRowSpan(this.panel4, 10);
            this.panel4.Size = new System.Drawing.Size(518, 226);
            this.panel4.TabIndex = 23;
            // 
            // btnConfirmarIDusuario
            // 
            this.btnConfirmarIDusuario.Location = new System.Drawing.Point(159, 46);
            this.btnConfirmarIDusuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmarIDusuario.Name = "btnConfirmarIDusuario";
            this.btnConfirmarIDusuario.Size = new System.Drawing.Size(97, 25);
            this.btnConfirmarIDusuario.TabIndex = 22;
            this.btnConfirmarIDusuario.Text = "Buscar";
            this.btnConfirmarIDusuario.UseVisualStyleBackColor = true;
            this.btnConfirmarIDusuario.Click += new System.EventHandler(this.btnConfirmarIDusuario_Click);
            // 
            // btnActualizarImagen
            // 
            this.btnActualizarImagen.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnActualizarImagen.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarImagen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarImagen.Location = new System.Drawing.Point(401, 92);
            this.btnActualizarImagen.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarImagen.Name = "btnActualizarImagen";
            this.btnActualizarImagen.Size = new System.Drawing.Size(97, 29);
            this.btnActualizarImagen.TabIndex = 21;
            this.btnActualizarImagen.Text = "Agregar imagen";
            this.btnActualizarImagen.UseVisualStyleBackColor = false;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label22.Location = new System.Drawing.Point(44, 46);
            this.label22.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(25, 23);
            this.label22.TabIndex = 20;
            this.label22.Text = "ID";
            this.label22.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label17.Location = new System.Drawing.Point(44, 15);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(329, 23);
            this.label17.TabIndex = 19;
            this.label17.Text = "Ingrese el número de ID del usuario que desea actualizar ";
            this.label17.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label12.Location = new System.Drawing.Point(24, 1);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 23);
            this.label12.TabIndex = 0;
            this.label12.Text = "Editar usuario";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtIDatualizar
            // 
            this.txtIDatualizar.Location = new System.Drawing.Point(73, 54);
            this.txtIDatualizar.Margin = new System.Windows.Forms.Padding(2);
            this.txtIDatualizar.Name = "txtIDatualizar";
            this.txtIDatualizar.Size = new System.Drawing.Size(25, 20);
            this.txtIDatualizar.TabIndex = 18;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label15.Location = new System.Drawing.Point(44, 166);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 14);
            this.label15.TabIndex = 5;
            this.label15.Text = "Dirección";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnActualizarUsuario
            // 
            this.btnActualizarUsuario.BackColor = System.Drawing.Color.Green;
            this.btnActualizarUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnActualizarUsuario.Location = new System.Drawing.Point(394, 137);
            this.btnActualizarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizarUsuario.Name = "btnActualizarUsuario";
            this.btnActualizarUsuario.Size = new System.Drawing.Size(118, 33);
            this.btnActualizarUsuario.TabIndex = 17;
            this.btnActualizarUsuario.Text = "Actualizar";
            this.btnActualizarUsuario.UseVisualStyleBackColor = false;
            this.btnActualizarUsuario.Click += new System.EventHandler(this.btnActualizarUsuario_Click_1);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label18.Location = new System.Drawing.Point(233, 70);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 21);
            this.label18.TabIndex = 10;
            this.label18.Text = "Institución";
            this.label18.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label16.Location = new System.Drawing.Point(233, 119);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(81, 17);
            this.label16.TabIndex = 7;
            this.label16.Text = "Teléfono";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarOcupacion
            // 
            this.txtActualizarOcupacion.Location = new System.Drawing.Point(44, 140);
            this.txtActualizarOcupacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarOcupacion.Name = "txtActualizarOcupacion";
            this.txtActualizarOcupacion.Size = new System.Drawing.Size(135, 20);
            this.txtActualizarOcupacion.TabIndex = 8;
            // 
            // txtActualizarCorreo
            // 
            this.txtActualizarCorreo.Location = new System.Drawing.Point(233, 181);
            this.txtActualizarCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarCorreo.Name = "txtActualizarCorreo";
            this.txtActualizarCorreo.Size = new System.Drawing.Size(126, 20);
            this.txtActualizarCorreo.TabIndex = 11;
            // 
            // txtActualizarInstitucion
            // 
            this.txtActualizarInstitucion.Location = new System.Drawing.Point(233, 97);
            this.txtActualizarInstitucion.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarInstitucion.Name = "txtActualizarInstitucion";
            this.txtActualizarInstitucion.Size = new System.Drawing.Size(126, 20);
            this.txtActualizarInstitucion.TabIndex = 4;
            // 
            // txtActualizarNombre
            // 
            this.txtActualizarNombre.Location = new System.Drawing.Point(44, 97);
            this.txtActualizarNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarNombre.Name = "txtActualizarNombre";
            this.txtActualizarNombre.Size = new System.Drawing.Size(135, 20);
            this.txtActualizarNombre.TabIndex = 2;
            // 
            // txtActualizarTelefono
            // 
            this.txtActualizarTelefono.Location = new System.Drawing.Point(233, 140);
            this.txtActualizarTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarTelefono.Name = "txtActualizarTelefono";
            this.txtActualizarTelefono.Size = new System.Drawing.Size(126, 20);
            this.txtActualizarTelefono.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label13.Location = new System.Drawing.Point(44, 73);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 18);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nombre y apellido";
            this.label13.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label19.Location = new System.Drawing.Point(233, 164);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(104, 15);
            this.label19.TabIndex = 14;
            this.label19.Text = "Correo Electrónico";
            this.label19.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txtActualizarDireccion
            // 
            this.txtActualizarDireccion.Location = new System.Drawing.Point(44, 181);
            this.txtActualizarDireccion.Margin = new System.Windows.Forms.Padding(2);
            this.txtActualizarDireccion.Name = "txtActualizarDireccion";
            this.txtActualizarDireccion.Size = new System.Drawing.Size(135, 20);
            this.txtActualizarDireccion.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label14.Location = new System.Drawing.Point(44, 121);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 17);
            this.label14.TabIndex = 3;
            this.label14.Text = "Ocupación";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.panel3, 13);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.btnEliminarUsuario);
            this.panel3.Controls.Add(this.txtIdEliminar);
            this.panel3.Location = new System.Drawing.Point(2, 255);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.tableLayoutPanel4.SetRowSpan(this.panel3, 4);
            this.panel3.Size = new System.Drawing.Size(518, 86);
            this.panel3.TabIndex = 22;
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label21.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label21.Location = new System.Drawing.Point(17, 32);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(207, 17);
            this.label21.TabIndex = 21;
            this.label21.Text = "Número de ID del usuario a eliminar";
            this.label21.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label20.Location = new System.Drawing.Point(159, 1);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(596, 15);
            this.label20.TabIndex = 20;
            this.label20.Text = "Eliminar usuario";
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (54)))), ((int) (((byte) (129)))), ((int) (((byte) (239)))));
            this.btnEliminarUsuario.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEliminarUsuario.Location = new System.Drawing.Point(360, 24);
            this.btnEliminarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(138, 29);
            this.btnEliminarUsuario.TabIndex = 16;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = false;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click_1);
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIdEliminar.Location = new System.Drawing.Point(106, 51);
            this.txtIdEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(30, 20);
            this.txtIdEliminar.TabIndex = 19;
            // 
            // Mostrar
            // 
            this.Mostrar.Controls.Add(this.tlpMostrarUsuario);
            this.Mostrar.Location = new System.Drawing.Point(4, 34);
            this.Mostrar.Margin = new System.Windows.Forms.Padding(2);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Padding = new System.Windows.Forms.Padding(2);
            this.Mostrar.Size = new System.Drawing.Size(577, 374);
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
            this.tlpMostrarUsuario.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 134F));
            this.tlpMostrarUsuario.Controls.Add(this.dgvMostrarUser, 1, 2);
            this.tlpMostrarUsuario.Controls.Add(this.btnMostrar, 2, 0);
            this.tlpMostrarUsuario.Location = new System.Drawing.Point(2, 2);
            this.tlpMostrarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMostrarUsuario.Name = "tlpMostrarUsuario";
            this.tlpMostrarUsuario.RowCount = 4;
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.287926F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.572755F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.73065F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25387F));
            this.tlpMostrarUsuario.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpMostrarUsuario.Size = new System.Drawing.Size(576, 384);
            this.tlpMostrarUsuario.TabIndex = 2;
            // 
            // dgvMostrarUser
            // 
            this.dgvMostrarUser.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpMostrarUsuario.SetColumnSpan(this.dgvMostrarUser, 2);
            this.dgvMostrarUser.Location = new System.Drawing.Point(71, 58);
            this.dgvMostrarUser.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMostrarUser.Name = "dgvMostrarUser";
            this.dgvMostrarUser.RowHeadersWidth = 62;
            this.dgvMostrarUser.RowTemplate.Height = 28;
            this.dgvMostrarUser.Size = new System.Drawing.Size(368, 260);
            this.dgvMostrarUser.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (5)))), ((int) (((byte) (29)))), ((int) (((byte) (64)))));
            this.btnMostrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMostrar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostrar.Location = new System.Drawing.Point(304, 2);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(135, 31);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "Mostrar Usuarios";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.comboBox1);
            this.tabPage5.Controls.Add(this.panelResultado);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(577, 374);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "Código QR";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(477, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(10, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Visible = false;
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (192)))));
            this.panelResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResultado.Controls.Add(this.lblUsuario);
            this.panelResultado.Controls.Add(this.txtValor1);
            this.panelResultado.Controls.Add(this.picQR);
            this.panelResultado.Controls.Add(this.btnGuardar);
            this.panelResultado.Controls.Add(this.btnGenerar);
            this.panelResultado.Location = new System.Drawing.Point(82, 23);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(324, 311);
            this.panelResultado.TabIndex = 0;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(64, 229);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(201, 17);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Ingrese el nombre del usuario";
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(64, 249);
            this.txtValor1.MaxLength = 50;
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(184, 20);
            this.txtValor1.TabIndex = 3;
            // 
            // picQR
            // 
            this.picQR.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.picQR.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picQR.Location = new System.Drawing.Point(64, 34);
            this.picQR.Name = "picQR";
            this.picQR.Size = new System.Drawing.Size(183, 184);
            this.picQR.TabIndex = 2;
            this.picQR.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.LightCyan;
            this.btnGuardar.Location = new System.Drawing.Point(164, 272);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 27);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar ";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.LightCyan;
            this.btnGenerar.Location = new System.Drawing.Point(74, 272);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(71, 27);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 412);
            this.Controls.Add(this.tc1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tc1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picImagenUsuario)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.Mostrar.ResumeLayout(false);
            this.tlpMostrarUsuario.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvMostrarUser)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picQR)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnActualizarImagen;
        private System.Windows.Forms.Button btnConfirmarIDusuario;

        private System.Windows.Forms.Label lblUsuario;

        private System.Windows.Forms.Button btnAgregarImagen;
        private System.Windows.Forms.PictureBox picImagenUsuario;

        private System.Windows.Forms.TextBox txtValor1;

        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.PictureBox picQR;

        private System.Windows.Forms.ComboBox comboBox1;

        private System.Windows.Forms.Panel panel5;

        private System.Windows.Forms.TabPage tabPage5;

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.TextBox txtIdEliminar;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtIDatualizar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnActualizarUsuario;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtActualizarOcupacion;
        private System.Windows.Forms.TextBox txtActualizarCorreo;
        private System.Windows.Forms.TextBox txtActualizarInstitucion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtActualizarNombre;
        private System.Windows.Forms.TextBox txtActualizarTelefono;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtActualizarDireccion;
        private System.Windows.Forms.Label label14;

        private System.Windows.Forms.Button btnMostrar;

        private System.Windows.Forms.DataGridView dgvMostrarUser;

        private System.Windows.Forms.TableLayoutPanel tlpMostrarUsuario;

        private System.Windows.Forms.TextBox txt;

        private System.Windows.Forms.Label label11;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccionUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInstitucion;
        private System.Windows.Forms.Button btnCrearUsuario;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOcupacion;

        private System.Windows.Forms.TextBox txtNombreUsuarios;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label4;

        public System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage Mostrar;

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtCorreoUsuario;
        private System.Windows.Forms.Label lblCorreoUsuario;
        private System.Windows.Forms.Label label1;

        #endregion
    }
}