using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using BINAES_Proyecto.Properties;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;

namespace BINAES_Proyecto.Forms
{
    public partial class frmUsuario : Form
    {

        public string imagen { get; set; }

        public frmUsuario()
        {
            InitializeComponent();
        }


        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            if(txtNombreUsuarios.TextLength > 0 && txtOcupacion.TextLength >0 && txtDireccionUsuario.TextLength > 0 && txtInstitucion.TextLength > 0 && txtTelefono.TextLength >0 && txtCorreo.TextLength > 0 && imagen.Length > 0 && txtContrasena.TextLength> 0 && cmbRolusuario.Text.Length >0) { 
                Usuario user = new Usuario();
                user.UsuarioNombre = txtNombreUsuarios.Text;
                user.UserOcupacion = txtOcupacion.Text;
                user.UserDireccion = txtDireccionUsuario.Text;
                user.UserInstitucion = txtInstitucion.Text;
                user.UserTelefono = txtTelefono.Text;
                user.UserCorreo = txtCorreo.Text;
                user.fotoUsuario = imagen;
                user.Contra = txtContrasena.Text;
                user.id_rol = Convert.ToInt32(cmbRolusuario.SelectedValue.ToString());

                picImagenUsuario.Image = new Bitmap(imagen);

                UsuarioDAO.IngresarUsuario(user);
                MessageBox.Show("Ingresado con exito");
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los campos requeridos", "Informacion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void btnMostrar_Click_1(object sender, EventArgs e)
        {
            dgvMostrarUser.RowTemplate.Height = 50;

            dgvMostrarUser.DataSource = null;
            dgvMostrarUser.DataSource = UsuarioDAO.MostrarUsuarios();

            DataGridViewImageColumn columna = (DataGridViewImageColumn) dgvMostrarUser.Columns["fotoUsuarioAUX"];
            columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
        }

        private void btnActualizarUsuario_Click_1(object sender, EventArgs e)
        {
            if (txtNombreUsuarios.TextLength > 0 && txtOcupacion.TextLength > 0 && txtDireccionUsuario.TextLength > 0 && txtInstitucion.TextLength > 0 && txtTelefono.TextLength > 0 && txtCorreo.TextLength > 0 && imagen.Length > 0 && txtContrasena.TextLength > 0 && cmbRolusuario.Text.Length > 0)
            {
                Usuario user = new Usuario();
                user.UsuarioID = Convert.ToInt32(txtIDatualizar.Text);
                user.UsuarioNombre = txtActualizarNombre.Text;
                user.UserOcupacion = txtActualizarOcupacion.Text;
                user.UserDireccion = txtActualizarDireccion.Text;
                user.UserInstitucion = txtActualizarInstitucion.Text;
                user.UserTelefono = txtActualizarTelefono.Text;
                user.UserCorreo = txtActualizarCorreo.Text;
                user.Contra = txtActualizarContra.Text;
                user.id_rol = Convert.ToInt32(cmbActualizarRol.SelectedValue.ToString());

                UsuarioDAO.ActualizarUsuario(user);
                MessageBox.Show("Datos actualizados");
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los campos requeridos", "Informacion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnEliminarUsuario_Click_1(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdEliminar.Text);
            UsuarioDAO.EliminarUsuario(id);

            MessageBox.Show("Usuario con id: " + id + " eliminado con éxito");
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(txtValor1.Text, out qrCode);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero),
                Brushes.Black, Brushes.White);

            MemoryStream ms = new MemoryStream();

            renderer.WriteToStream(qrCode.Matrix, ImageFormat.Png, ms);
            var imageTemporal = new Bitmap(ms);
            var imagen = new Bitmap(imageTemporal, new Size(new Point(200, 200)));
            picQR.BackgroundImage = imagen;

            imagen.Save("imagen.png", ImageFormat.Png);
            btnGuardar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Image imgFinal = (Image) picQR.BackgroundImage.Clone();
            SaveFileDialog CajaDeDialogoGuardar = new SaveFileDialog();
            CajaDeDialogoGuardar.AddExtension = true;
            CajaDeDialogoGuardar.Filter = "Image PNG (*.png)|*.png";
            CajaDeDialogoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(CajaDeDialogoGuardar.FileName))
            {
                imgFinal.Save(CajaDeDialogoGuardar.FileName, ImageFormat.Png);
            }

            imgFinal.Dispose();
        }


        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog obtener = new OpenFileDialog();
            obtener.InitialDirectory = "C:\\";
            obtener.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)| *.jpg; *.jpeg; *.gif; *.bmp, *.png";

            if (obtener.ShowDialog() == DialogResult.OK)
            {
                imagen = obtener.FileName;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una foto");
            }
        }


        private void btnConfirmarIDusuario_Click(object sender, EventArgs e)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {

                SqlCommand command =
                    new SqlCommand(
                        "SELECT nombre, ocupacion, direccion, correo, fotografia, telefono, institucion  FROM USUARIO WHERE id = @id",
                        connection);
                command.Parameters.AddWithValue("@id", txtIDatualizar.Text);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtActualizarNombre.Text = reader["nombre"].ToString();
                    txtActualizarOcupacion.Text = reader["ocupacion"].ToString();
                    txtActualizarCorreo.Text = reader["correo"].ToString();
                    txtActualizarDireccion.Text = reader["direccion"].ToString();
                    imagen = reader["fotografia"].ToString();
                    txtActualizarTelefono.Text = reader["telefono"].ToString();
                    txtActualizarInstitucion.Text = reader["institucion"].ToString();




                    connection.Close();


                }
            }
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            cmbRolusuario.DataSource = null;
            cmbRolusuario.ValueMember = "id";
            cmbRolusuario.DisplayMember = "rol";
            cmbRolusuario.DataSource = UsuarioDAO.CargarDatosRol();
            
            cmbActualizarRol.DataSource = null;
            cmbActualizarRol.ValueMember = "id";
            cmbActualizarRol.DisplayMember = "rol";
            cmbActualizarRol.DataSource = UsuarioDAO.CargarDatosRol();
        }
    }
}




    
