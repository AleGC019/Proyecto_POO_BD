using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
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
            Usuario user = new Usuario();
            user.UsuarioNombre = txtNombreUsuarios.Text;
            user.UserOcupacion = txtOcupacion.Text;
            user.UserDireccion = txtDireccionUsuario.Text;
            user.UserInstitucion = txtInstitucion.Text;
            user.UserTelefono = txtTelefono.Text;
            user.UserCorreo = txt.Text;
            user.fotoUsuario = imagen;

            picImagenUsuario.Image = new Bitmap(imagen);
    
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            QrEncoder qrEncoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qrCode = new QrCode();
            qrEncoder.TryEncode(txtValor1.Text,out qrCode);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero),Brushes.Black,Brushes.White);

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
            Image imgFinal = (Image)picQR.BackgroundImage.Clone();
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
            
            if(obtener.ShowDialog() == DialogResult.OK)
            {
                imagen = obtener.FileName;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una foto");
            }
        }

        
    }
}


    
