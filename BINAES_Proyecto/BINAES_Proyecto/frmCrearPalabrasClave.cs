using System;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    public partial class frmCrearPalabrasClave : Form
    {
        public frmCrearPalabrasClave()
        {
            InitializeComponent();
        }

        private void btnAgregarPalabra_Click(object sender, EventArgs e)
        {
            Palabras_Clave pc = new Palabras_Clave();
            pc.palabra = txtAgregarPalabra.Text;
            pc.ejemplarID_Palabra = Convert.ToInt32(EjemplarDAO.nuevoidEejmplar());
            EjemplarDAO.InsertarNuevaPalabraClave(pc);
            
            MessageBox.Show("Ingresado con éxito");
        }
    }
}