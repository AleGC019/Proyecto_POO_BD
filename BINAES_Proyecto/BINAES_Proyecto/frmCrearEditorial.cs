using System;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    public partial class frmCrearEditorial : Form
    {
        public frmCrearEditorial()
        {
            InitializeComponent();
        }

        private void btnAgregarEditorial_Click(object sender, EventArgs e)
        {
            Editorial edit = new Editorial();
            edit.nombreEditorial = txtNuevaEditorial.Text;
            
            
            EditorialDAO.InsertarNuevaEditorial(edit);
            MessageBox.Show("Editorial ingresada con éxito");
            Update();
        }
    }
}