using System.ComponentModel;

namespace V1ProyectoPOO.UserControls
{
    partial class UC_Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Inicio));
            this.lblInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Timers.Timer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tlpBienvenido = new System.Windows.Forms.TableLayoutPanel();
            this.picBienvenido = new System.Windows.Forms.PictureBox();
            this.tlpFotos = new System.Windows.Forms.TableLayoutPanel();
            this.picFotos1 = new System.Windows.Forms.PictureBox();
            this.picFoto2 = new System.Windows.Forms.PictureBox();
            this.picFoto3 = new System.Windows.Forms.PictureBox();
            this.picFoto4 = new System.Windows.Forms.PictureBox();
            this.picFoto5 = new System.Windows.Forms.PictureBox();
            this.picFoto6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tlpBienvenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picBienvenido)).BeginInit();
            this.tlpFotos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picFotos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picFoto2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picFoto3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picFoto4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picFoto5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.picFoto6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.Font = new System.Drawing.Font("Ravie", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInicio.Location = new System.Drawing.Point(585, 158);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(15, 15);
            this.lblInicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(585, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 45);
            this.label1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::V1ProyectoPOO.Properties.Resources.Conia;
            this.pictureBox2.Location = new System.Drawing.Point(124, 454);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 15);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 200D;
            this.timer1.SynchronizingObject = this;
            this.timer1.Elapsed += new System.Timers.ElapsedEventHandler(this.timer1_Elapsed);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::V1ProyectoPOO.Properties.Resources.conia31;
            this.pictureBox1.Location = new System.Drawing.Point(606, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // tlpBienvenido
            // 
            this.tlpBienvenido.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBienvenido.ColumnCount = 1;
            this.tlpBienvenido.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBienvenido.Controls.Add(this.picBienvenido, 0, 0);
            this.tlpBienvenido.Location = new System.Drawing.Point(0, -2);
            this.tlpBienvenido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpBienvenido.Name = "tlpBienvenido";
            this.tlpBienvenido.RowCount = 1;
            this.tlpBienvenido.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBienvenido.Size = new System.Drawing.Size(782, 171);
            this.tlpBienvenido.TabIndex = 5;
            // 
            // picBienvenido
            // 
            this.picBienvenido.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.picBienvenido.Image = ((System.Drawing.Image) (resources.GetObject("picBienvenido.Image")));
            this.picBienvenido.Location = new System.Drawing.Point(4, 5);
            this.picBienvenido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picBienvenido.Name = "picBienvenido";
            this.picBienvenido.Size = new System.Drawing.Size(774, 161);
            this.picBienvenido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBienvenido.TabIndex = 0;
            this.picBienvenido.TabStop = false;
            // 
            // tlpFotos
            // 
            this.tlpFotos.ColumnCount = 3;
            this.tlpFotos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFotos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 291F));
            this.tlpFotos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 228F));
            this.tlpFotos.Controls.Add(this.picFotos1, 0, 0);
            this.tlpFotos.Controls.Add(this.picFoto2, 1, 0);
            this.tlpFotos.Controls.Add(this.picFoto3, 2, 0);
            this.tlpFotos.Controls.Add(this.picFoto4, 0, 1);
            this.tlpFotos.Controls.Add(this.picFoto5, 1, 1);
            this.tlpFotos.Controls.Add(this.picFoto6, 2, 1);
            this.tlpFotos.Location = new System.Drawing.Point(0, 158);
            this.tlpFotos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpFotos.Name = "tlpFotos";
            this.tlpFotos.RowCount = 2;
            this.tlpFotos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpFotos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.tlpFotos.Size = new System.Drawing.Size(782, 425);
            this.tlpFotos.TabIndex = 6;
            // 
            // picFotos1
            // 
            this.picFotos1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (206)))), ((int) (((byte) (236)))));
            this.picFotos1.Image = ((System.Drawing.Image) (resources.GetObject("picFotos1.Image")));
            this.picFotos1.Location = new System.Drawing.Point(4, 5);
            this.picFotos1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFotos1.Name = "picFotos1";
            this.picFotos1.Size = new System.Drawing.Size(254, 195);
            this.picFotos1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotos1.TabIndex = 0;
            this.picFotos1.TabStop = false;
            // 
            // picFoto2
            // 
            this.picFoto2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.picFoto2.Image = ((System.Drawing.Image) (resources.GetObject("picFoto2.Image")));
            this.picFoto2.Location = new System.Drawing.Point(267, 5);
            this.picFoto2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFoto2.Name = "picFoto2";
            this.picFoto2.Size = new System.Drawing.Size(282, 195);
            this.picFoto2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto2.TabIndex = 1;
            this.picFoto2.TabStop = false;
            // 
            // picFoto3
            // 
            this.picFoto3.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (224)))), ((int) (((byte) (135)))));
            this.picFoto3.Image = ((System.Drawing.Image) (resources.GetObject("picFoto3.Image")));
            this.picFoto3.Location = new System.Drawing.Point(558, 5);
            this.picFoto3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFoto3.Name = "picFoto3";
            this.picFoto3.Size = new System.Drawing.Size(219, 195);
            this.picFoto3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto3.TabIndex = 2;
            this.picFoto3.TabStop = false;
            // 
            // picFoto4
            // 
            this.picFoto4.Image = ((System.Drawing.Image) (resources.GetObject("picFoto4.Image")));
            this.picFoto4.Location = new System.Drawing.Point(4, 210);
            this.picFoto4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFoto4.Name = "picFoto4";
            this.picFoto4.Size = new System.Drawing.Size(254, 210);
            this.picFoto4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto4.TabIndex = 3;
            this.picFoto4.TabStop = false;
            // 
            // picFoto5
            // 
            this.picFoto5.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (248)))), ((int) (((byte) (232)))), ((int) (((byte) (197)))));
            this.picFoto5.Image = ((System.Drawing.Image) (resources.GetObject("picFoto5.Image")));
            this.picFoto5.Location = new System.Drawing.Point(267, 210);
            this.picFoto5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFoto5.Name = "picFoto5";
            this.picFoto5.Size = new System.Drawing.Size(254, 187);
            this.picFoto5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto5.TabIndex = 4;
            this.picFoto5.TabStop = false;
            // 
            // picFoto6
            // 
            this.picFoto6.Image = ((System.Drawing.Image) (resources.GetObject("picFoto6.Image")));
            this.picFoto6.Location = new System.Drawing.Point(558, 210);
            this.picFoto6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picFoto6.Name = "picFoto6";
            this.picFoto6.Size = new System.Drawing.Size(191, 187);
            this.picFoto6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFoto6.TabIndex = 5;
            this.picFoto6.TabStop = false;
            // 
            // UC_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.tlpFotos);
            this.Controls.Add(this.tlpBienvenido);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblInicio);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "UC_Inicio";
            this.Size = new System.Drawing.Size(778, 579);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.timer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tlpBienvenido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picBienvenido)).EndInit();
            this.tlpFotos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picFotos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picFoto2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picFoto3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picFoto4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picFoto5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.picFoto6)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picFoto3;
        private System.Windows.Forms.PictureBox picFoto4;
        private System.Windows.Forms.PictureBox picFoto5;
        private System.Windows.Forms.PictureBox picFoto6;

        private System.Windows.Forms.PictureBox picFoto2;

        private System.Windows.Forms.PictureBox picFotos1;

        private System.Windows.Forms.TableLayoutPanel tlpBienvenido;

        private System.Windows.Forms.PictureBox picBienvenido;

        private System.Windows.Forms.TableLayoutPanel tlpFotos;

        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Timers.Timer timer1;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lblInicio;

        #endregion
    }
}