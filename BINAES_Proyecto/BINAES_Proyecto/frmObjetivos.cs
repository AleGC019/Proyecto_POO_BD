using System;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    public partial class frmObjetivos : Form
    {
        public frmObjetivos()
        {
            InitializeComponent();
        }

        //Click dek botón agregar nuevo objetivo en un evento, en el formulario frmObjetivos
        private void btnAgregarObjetivo_Click(object sender, EventArgs e)
        {
            if (txtAgregarObjetivo.TextLength > 0 )
            {
                Objetivos obj = new Objetivos();
                obj.objetivo = txtAgregarObjetivo.Text;
                obj.id_evento_objetivos = Convert.ToInt32(EventoDAO.nuevoidEvento());
            
                EventoDAO.InsertarNuevoObjetivo(obj);
            
                MessageBox.Show("Ingresado con éxito"); 
            }

            else
            {
                MessageBox.Show("Campo vacío. Por favor ingrese uno de los objetivos de su evento", "Informacion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error  );

            }
            
        }
    }
}