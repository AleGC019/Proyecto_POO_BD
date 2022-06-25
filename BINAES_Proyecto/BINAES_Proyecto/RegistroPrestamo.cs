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
    public partial class frmRegistroPrestamo : Form
    {
        public Usuario actualUser { get; set; }

        public Ejemplar eje { get; set; }

        public frmRegistroPrestamo(Usuario usuario_PrestamoGral, Ejemplar actualEjemplar)
        {
            InitializeComponent();

            actualUser = usuario_PrestamoGral;

            eje = actualEjemplar;
        }

        private void RegistroPrestamo_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            DateTime Limite = hoy.AddDays(14);
            TimeSpan timeSpan = new TimeSpan(14, 00, 00);

            dtpEntregaFecha.Value = hoy;
            dtpEntregaFecha.Enabled = false;
            
            dtpEntregaHora.Value = hoy;
            dtpEntregaHora.Enabled = false;

            dtpDevolucionFecha.Value = Limite;
            dtpDevolucionFecha.Enabled = false;

            dtpDevolucionHora.Value = Convert.ToDateTime("2pm");
            dtpDevolucionHora.Enabled = false;

            picEjemplar.Image = Image.FromFile(eje.Portada);

            txtEjemplar.Text = eje.Nombre_Ejemplar;

            MessageBox.Show("BINAES le otorgará el material por un periodo de 14 días en los que, al terminar, usted deber regresar lo prestado.");

            /*dtpEntrega.Format = DateTimePickerFormat.Custom;
            dtpEntrega.CustomFormat = "MM/dd/yyyy hh:mm:ss";

            dtpDevolucion.Format = DateTimePickerFormat.Custom;
            dtpDevolucion.CustomFormat = "MM/dd/yyyy hh:mm:ss";*/
        }
    }
}
