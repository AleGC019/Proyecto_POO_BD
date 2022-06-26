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

        //Click para botón agregar un nuevo autor en el ejemplar
        private void lblAgregarAutor_Click(object sender, EventArgs e)
        {
            if (txtAgregarAutor.TextLength >0 )
            {
                Autor autor = new Autor();
                autor.nombreAutor = txtAgregarAutor.Text;
                autor.ejemplarID = Convert.ToInt32(EjemplarDAO.nuevoidEejmplar());
            
                EjemplarDAO.InsertarNuevoAutor(autor);
            
                MessageBox.Show("Ingresado con éxito");
            }
            
            else
            {
                MessageBox.Show("Campo vacío. Por favor ingrese el nombre del autor", "Informacion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error  );

            }
            
        }
    }
}