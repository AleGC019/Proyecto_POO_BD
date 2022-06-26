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

        private void btnAgregarObjetivo_Click(object sender, EventArgs e)
        {
            Objetivos obj = new Objetivos();
            obj.objetivo = txtAgregarObjetivo.Text;
            obj.id_evento_objetivos = Convert.ToInt32(EventoDAO.nuevoidEvento());
            
            EventoDAO.InsertarNuevoObjetivo(obj);
            
            MessageBox.Show("Ingresado con éxito");
        }
    }
}