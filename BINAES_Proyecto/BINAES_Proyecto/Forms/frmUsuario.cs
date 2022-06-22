using System;
using System.Windows.Forms;

namespace BINAES_Proyecto.Forms
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }
        

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.UsuarioNombre = txtNombreUsuarios.Text;
            user.UserOcupacion = txtOcupacion.Text;
            user.UserDireccion = txtDireccionUsuario.Text;
            user.UserInstitucion = txtInstitucion.Text;
            user.UserTelefono = txtTelefono.Text;
            user.UserCorreo = txt.Text;
    
            UsuarioDAO.IngresarUsuario(user);
            MessageBox.Show("Ingresado con exito");

        }


        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            dgvMostrarUser.DataSource = null;
            dgvMostrarUser.DataSource = UsuarioDAO.MostrarUsuarios();
        }
        
        private void btnActualizarUsuario_Click_1(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.UsuarioID = Convert.ToInt32(txtIDatualizar.Text);
            user.UsuarioNombre = txtActualizarNombre.Text;
            user.UserOcupacion = txtActualizarOcupacion.Text;
            user.UserDireccion = txtActualizarDireccion.Text;
            user.UserInstitucion = txtActualizarInstitucion.Text;
            user.UserTelefono = txtActualizarTelefono.Text;
            user.UserCorreo = txtActualizarCorreo.Text;
            
            UsuarioDAO.ActualizarUsuario(user);
            MessageBox.Show("datos actualizados");
        }

        private void btnEliminarUsuario_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdEliminar.Text);
            UsuarioDAO.EliminarUsuario(id);

            MessageBox.Show("Usuario con id: " + id + " eliminado con éxito");
        }
    }
}


    
