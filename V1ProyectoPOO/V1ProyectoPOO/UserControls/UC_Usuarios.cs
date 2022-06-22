using System;
using System.Windows.Forms;

namespace V1ProyectoPOO.UserControls
{
    public partial class UC_Usuarios : UserControl
    {
        public UC_Usuarios()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvMostrarUser.DataSource = null;
            dgvMostrarUser.DataSource = UsuarioDAO.MostrarUsuarios();
        }

        private void UC_Usuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.UsuarioID = Convert.ToInt32(txtUsuarioID.Text);
            user.UsuarioNombre = txtNombreUsuarios.Text;
            user.UserOcupacion = txtOcupacion.Text;
            user.UserDireccion = txtDireccionUsuario.Text;
            user.UserInstitucion = txtInstitucion.Text;
            user.UserTelefono = txtTelefono.Text;
            user.UserCorreo = txtCorreoUsuario.Text;
            
            UsuarioDAO.IngresarUsuario(user);
            MessageBox.Show("Ingresado con exito");
        }

        private void lblOcupacion_Click(object sender, EventArgs e)
        {
            
        }
    }
}