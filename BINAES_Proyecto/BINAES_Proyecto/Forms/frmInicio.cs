using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto.Forms
{
    public partial class frmInicio : Form
    {
        private List<Bitmap> listaImagenes;
        public frmInicio()
        {
            InitializeComponent();
            listaImagenes = new List<Bitmap>();
            listaImagenes.Add(Resources._1);
            listaImagenes.Add(Resources._2);
            listaImagenes.Add(Resources._3__1_);
            listaImagenes.Add(Resources._4);
            listaImagenes.Add(Resources._5);
            listaImagenes.Add(Resources._6);
            listaImagenes.Add(Resources._7);
            
        }

        private void picBienvenido_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private int contadorInicio = 0;
        private void trmInicio_Tick(object sender, EventArgs e)
        {
            if (contadorInicio < listaImagenes.Count)
            {
                picBienvenido.Image = listaImagenes[contadorInicio];
                contadorInicio++;

                if (contadorInicio == listaImagenes.Count)
                {
                    contadorInicio = 0;
                }

            }
        }
    }
}