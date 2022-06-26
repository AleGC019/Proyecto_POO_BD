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
        
        //Click del botón agregar palabra clave en un nuevo ejemplar, del formulario frmCrearPalabrasClave
        private void btnAgregarPalabra_Click(object sender, EventArgs e)
        {
            if (txtAgregarPalabra.TextLength > 0)
            {
                Palabras_Clave pc = new Palabras_Clave();
                pc.palabra = txtAgregarPalabra.Text;
                pc.ejemplarID_Palabra = Convert.ToInt32(EjemplarDAO.nuevoidEejmplar());
                EjemplarDAO.InsertarNuevaPalabraClave(pc);
            
                MessageBox.Show("Ingresado con éxito");
            }
            
            else
            {
                MessageBox.Show("Campo vacío. Por favor ingrese la palabra clave del ejemplar", "Informacion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error  );

            }
        }
    }
}