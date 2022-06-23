using System.Drawing;

namespace BINAES_Proyecto
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string UsuarioNombre { get; set; }
        
        public string Contra { get; set; }
        public string UserOcupacion { get; set; }
        public string UserDireccion { get; set; }
        public string UserCorreo { get; set; }
        
        public string fotoUsuario { get; set; }
        
        public Bitmap fotoUsuarioAUX { get; set; }
        public string UserTelefono { get; set; }
        public string UserInstitucion { get; set; }


    }
}