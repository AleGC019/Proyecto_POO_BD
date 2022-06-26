using System;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    public partial class frmActualizarPalabraClave : Form
    {
        public frmActualizarPalabraClave()
        {
            InitializeComponent();
        }

        private void btnActualizarAgregarPalabra_Click(object sender, EventArgs e)
        {
            Palabras_Clave pc = new Palabras_Clave();
                pc.palabra = txtActualizarPalabra.Text;
                pc.ejemplarID_Palabra = Convert.ToInt32(EjemplarDAO.nuevoidEejmplar());
                EjemplarDAO.InsertarNuevaPalabraClave(pc);
            
                MessageBox.Show("Ingresado con éxito");
            
        }
    }
}