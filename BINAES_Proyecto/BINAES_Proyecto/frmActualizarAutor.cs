using System;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    public partial class frmActualizarAutor : Form
    {
        public frmActualizarAutor()
        {
            InitializeComponent();
        }

        private void frmActualizarAutor_Load(object sender, EventArgs e)
        {
            dgvListaAutores.DataSource = null;
            dgvListaAutores.DataSource = AutorDAO.ListaAutor();
        }

        private void btnActualizarAutor_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor();
            autor.ID = Convert.ToInt32(txtIDAutor.Text);
            autor.nombreAutor = txtActualizarNombreAutor.Text;
            autor.ejemplarID = Convert.ToInt32(txtIdEjemplar.Text);
                
                
            AutorDAO.ActualizarAutor(autor);
            
            MessageBox.Show("Actualizada con éxito");
        }


        private void dgvListaAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDAutor.Text = dgvListaAutores.CurrentRow.Cells[0].Value.ToString();
            txtActualizarNombreAutor.Text = dgvListaAutores.CurrentRow.Cells[1].Value.ToString();
            txtIdEjemplar.Text = dgvListaAutores.CurrentRow.Cells[2].Value.ToString();
        }
    }
}