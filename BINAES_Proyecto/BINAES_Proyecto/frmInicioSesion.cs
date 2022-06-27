using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        
        //Evento click del botón Login, lo que no permitira acceder a nuestro formulario principal
        private void btnLogIn_Click(object sender, EventArgs e)
        {   
            //Utilizamos la condicional if para validar la información del usuario 
            if(txtusuario.TextLength == 0 || txtContra.TextLength == 0)
            {
                MessageBox.Show("Campos de inicio de sesión no completos.", "Complete el formulario.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string nombre = txtusuario.Text.ToString().Trim();

                string contra = txtContra.Text.ToString().Trim();

                Usuario usu = UsuarioDAO.AdminLoginInfo2(nombre, contra);

                if (usu != null  && usu.id_rol == 1)
                {
                    MessageBox.Show("Inicio de sesion correcto.", "Inicio de sesion.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    frmBinaesMain frmAux = new frmBinaesMain();
                    frmAux.Show();
                }
                else if(usu != null  && usu.id_rol == 2)
                {
                    MessageBox.Show("Inicio de sesion correcto.", "Inicio de sesion.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    frmBinaesUsuario frmAux = new frmBinaesUsuario();
                    frmAux.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales erróneas!", "BINAES", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
            
        }
        
        //Cerramos aplicación utilizando el evento FormClosed
        private void frmInicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        
        //En el evento load de nuestro formulario InicioSesion, configuramos el label de error.
        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
    }
}