using System.ComponentModel;

namespace BINAES_Proyecto.Forms
{
    partial class frmReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Mostrar = new System.Windows.Forms.TabPage();
            this.tlpMostraPrestamos = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMostrarPrestamos = new System.Windows.Forms.DataGridView();
            this.btnMostrarPrestamos = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tlpMostrarReservaciones = new System.Windows.Forms.TableLayoutPanel();
            this.dgvMostrarReservaciones = new System.Windows.Forms.DataGridView();
            this.btnMostrarReservaciones = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Mostrar.SuspendLayout();
            this.tlpMostraPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPrestamos)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tlpMostrarReservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Mostrar);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(90, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(10, 8);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 4;
            // 
            // Mostrar
            // 
            this.Mostrar.Controls.Add(this.tlpMostraPrestamos);
            this.Mostrar.Location = new System.Drawing.Point(4, 34);
            this.Mostrar.Margin = new System.Windows.Forms.Padding(2);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Padding = new System.Windows.Forms.Padding(2);
            this.Mostrar.Size = new System.Drawing.Size(792, 412);
            this.Mostrar.TabIndex = 2;
            this.Mostrar.Text = "Mostrar prestamos realizados";
            this.Mostrar.UseVisualStyleBackColor = true;
            // 
            // tlpMostraPrestamos
            // 
            this.tlpMostraPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMostraPrestamos.ColumnCount = 4;
            this.tlpMostraPrestamos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tlpMostraPrestamos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.06422F));
            this.tlpMostraPrestamos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tlpMostraPrestamos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tlpMostraPrestamos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tlpMostraPrestamos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.06422F));
            this.tlpMostraPrestamos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tlpMostraPrestamos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpMostraPrestamos.Controls.Add(this.dgvMostrarPrestamos, 1, 2);
            this.tlpMostraPrestamos.Controls.Add(this.btnMostrarPrestamos, 2, 0);
            this.tlpMostraPrestamos.Location = new System.Drawing.Point(2, 4);
            this.tlpMostraPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMostraPrestamos.Name = "tlpMostraPrestamos";
            this.tlpMostraPrestamos.RowCount = 4;
            this.tlpMostraPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.287926F));
            this.tlpMostraPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.572755F));
            this.tlpMostraPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.73065F));
            this.tlpMostraPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25387F));
            this.tlpMostraPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpMostraPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.287926F));
            this.tlpMostraPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.572755F));
            this.tlpMostraPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.73065F));
            this.tlpMostraPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25387F));
            this.tlpMostraPrestamos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpMostraPrestamos.Size = new System.Drawing.Size(786, 401);
            this.tlpMostraPrestamos.TabIndex = 2;
            // 
            // dgvMostrarPrestamos
            // 
            this.dgvMostrarPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarPrestamos.BackgroundColor = System.Drawing.Color.White;
            this.dgvMostrarPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpMostraPrestamos.SetColumnSpan(this.dgvMostrarPrestamos, 2);
            this.dgvMostrarPrestamos.GridColor = System.Drawing.Color.White;
            this.dgvMostrarPrestamos.Location = new System.Drawing.Point(125, 61);
            this.dgvMostrarPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMostrarPrestamos.Name = "dgvMostrarPrestamos";
            this.dgvMostrarPrestamos.RowHeadersWidth = 62;
            this.dgvMostrarPrestamos.RowTemplate.Height = 28;
            this.dgvMostrarPrestamos.Size = new System.Drawing.Size(548, 272);
            this.dgvMostrarPrestamos.TabIndex = 0;
            // 
            // btnMostrarPrestamos
            // 
            this.btnMostrarPrestamos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.btnMostrarPrestamos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMostrarPrestamos.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarPrestamos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostrarPrestamos.Location = new System.Drawing.Point(538, 2);
            this.btnMostrarPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarPrestamos.Name = "btnMostrarPrestamos";
            this.btnMostrarPrestamos.Size = new System.Drawing.Size(135, 33);
            this.btnMostrarPrestamos.TabIndex = 1;
            this.btnMostrarPrestamos.Text = "Mostrar Prestamos";
            this.btnMostrarPrestamos.UseVisualStyleBackColor = false;
            this.btnMostrarPrestamos.Click += new System.EventHandler(this.btnMostrarPrestamos_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tlpMostrarReservaciones);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 412);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Mostrar reservaciones realizadas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tlpMostrarReservaciones
            // 
            this.tlpMostrarReservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpMostrarReservaciones.ColumnCount = 4;
            this.tlpMostrarReservaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tlpMostrarReservaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.06422F));
            this.tlpMostrarReservaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpMostrarReservaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tlpMostrarReservaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.93578F));
            this.tlpMostrarReservaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.06422F));
            this.tlpMostrarReservaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tlpMostrarReservaciones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tlpMostrarReservaciones.Controls.Add(this.dgvMostrarReservaciones, 1, 2);
            this.tlpMostrarReservaciones.Controls.Add(this.btnMostrarReservaciones, 2, 0);
            this.tlpMostrarReservaciones.Location = new System.Drawing.Point(7, 5);
            this.tlpMostrarReservaciones.Margin = new System.Windows.Forms.Padding(2);
            this.tlpMostrarReservaciones.Name = "tlpMostrarReservaciones";
            this.tlpMostrarReservaciones.RowCount = 4;
            this.tlpMostrarReservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.287926F));
            this.tlpMostrarReservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.572755F));
            this.tlpMostrarReservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.73065F));
            this.tlpMostrarReservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25387F));
            this.tlpMostrarReservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpMostrarReservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.287926F));
            this.tlpMostrarReservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.572755F));
            this.tlpMostrarReservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.73065F));
            this.tlpMostrarReservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.25387F));
            this.tlpMostrarReservaciones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tlpMostrarReservaciones.Size = new System.Drawing.Size(778, 400);
            this.tlpMostrarReservaciones.TabIndex = 3;
            // 
            // dgvMostrarReservaciones
            // 
            this.dgvMostrarReservaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMostrarReservaciones.BackgroundColor = System.Drawing.Color.White;
            this.dgvMostrarReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tlpMostrarReservaciones.SetColumnSpan(this.dgvMostrarReservaciones, 2);
            this.dgvMostrarReservaciones.Location = new System.Drawing.Point(123, 61);
            this.dgvMostrarReservaciones.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMostrarReservaciones.Name = "dgvMostrarReservaciones";
            this.dgvMostrarReservaciones.RowHeadersWidth = 62;
            this.dgvMostrarReservaciones.RowTemplate.Height = 28;
            this.dgvMostrarReservaciones.Size = new System.Drawing.Size(554, 271);
            this.dgvMostrarReservaciones.TabIndex = 0;
            // 
            // btnMostrarReservaciones
            // 
            this.btnMostrarReservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(29)))), ((int)(((byte)(64)))));
            this.btnMostrarReservaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMostrarReservaciones.Font = new System.Drawing.Font("Microsoft YaHei", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarReservaciones.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMostrarReservaciones.Location = new System.Drawing.Point(531, 2);
            this.btnMostrarReservaciones.Margin = new System.Windows.Forms.Padding(2);
            this.btnMostrarReservaciones.Name = "btnMostrarReservaciones";
            this.btnMostrarReservaciones.Size = new System.Drawing.Size(146, 33);
            this.btnMostrarReservaciones.TabIndex = 1;
            this.btnMostrarReservaciones.Text = "Mostrar Reservaciones";
            this.btnMostrarReservaciones.UseVisualStyleBackColor = false;
            this.btnMostrarReservaciones.Click += new System.EventHandler(this.btnMostrarReservaciones_Click);
            // 
            // frmReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReserva";
            this.Text = "frmReserva";
            this.tabControl1.ResumeLayout(false);
            this.Mostrar.ResumeLayout(false);
            this.tlpMostraPrestamos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarPrestamos)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tlpMostrarReservaciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrarReservaciones)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnMostrarPrestamos;
        private System.Windows.Forms.TableLayoutPanel tlpMostraPrestamos;
        private System.Windows.Forms.DataGridView dgvMostrarPrestamos;

        private System.Windows.Forms.TabPage tabPage1;

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Mostrar;
        private System.Windows.Forms.TableLayoutPanel tlpMostrarReservaciones;
        private System.Windows.Forms.DataGridView dgvMostrarReservaciones;
        private System.Windows.Forms.Button btnMostrarReservaciones;

        #endregion
    }
}