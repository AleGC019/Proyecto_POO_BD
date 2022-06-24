using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    public partial class RegistroPrestamo : Form
    {
        public Usuario usu { get; set; }

        public Ejemplar eje { get; set; }

        public RegistroPrestamo(Usuario actualUser, Ejemplar actualEjemplar)
        {
            InitializeComponent();

            usu = actualUser;

            eje = actualEjemplar;
        }

        private void RegistroPrestamo_Load(object sender, EventArgs e)
        {

        }
    }
}
