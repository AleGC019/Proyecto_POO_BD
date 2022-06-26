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

        //En el evento load del formulario frmActualizarAutor, cargamos el data grid view con la lista de autores
        private void frmActualizarAutor_Load(object sender, EventArgs e)
        {
            dgvListaAutores.DataSource = null;
            dgvListaAutores.DataSource = AutorDAO.ListaAutor();
        }

        //Cick del botón Actualizar autor, edita la información de un ejemplar ya existente en la base de datos 

        private void btnActualizarAutor_Click(object sender, EventArgs e)
        {
            if (txtActualizarNombreAutor.TextLength > 0)
            {
                Autor autor = new Autor();
                autor.ID = Convert.ToInt32(txtIDAutor.Text);
                autor.nombreAutor = txtActualizarNombreAutor.Text;
                autor.ejemplarID = Convert.ToInt32(txtIdEjemplar.Text);
                
                
                AutorDAO.ActualizarAutor(autor);
            
                MessageBox.Show("Actualizada con éxito");  
            }
            else
            {
                MessageBox.Show("Campo vacío. Por favor ingrese el nombre del autor.", "Informacion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error  );

            }
            
        }


        //Evento CellClick, cuando el usaurio da click en una celda, los text box se autorellenan con la información en la tabla 

        private void dgvListaAutores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDAutor.Text = dgvListaAutores.CurrentRow.Cells[0].Value.ToString();
            txtActualizarNombreAutor.Text = dgvListaAutores.CurrentRow.Cells[1].Value.ToString();
            txtIdEjemplar.Text = dgvListaAutores.CurrentRow.Cells[2].Value.ToString();
        }
    }
}