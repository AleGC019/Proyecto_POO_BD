using System;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    public partial class frmCrearAutor : Form
    {
        public frmCrearAutor()
        {
            InitializeComponent();
        }

        private void lblAgregarAutor_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            autor.nombreAutor = txtAgregarAutor.Text;
            autor.ejemplarID = Convert.ToInt32(EjemplarDAO.nuevoidEejmplar());
            
            EjemplarDAO.InsertarNuevoAutor(autor);
            
            MessageBox.Show("Ingresado con éxito");
        }
    }
}