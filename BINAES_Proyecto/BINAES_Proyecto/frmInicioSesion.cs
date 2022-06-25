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


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            
            /*
            List<Usuario> ListaUsuarios = new List<Usuario>();
            
            string usuario = UsuarioDAO.AdminLoginInfo().ToString();
            
            ListaUsuarios.Add(usuario);
            
            */

            if(txtusuario.TextLength == 0 || txtContra.TextLength == 0)
            {
                MessageBox.Show("Campos de inicio de sesión no completos.", "Complete el formulario.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                string nombre = txtusuario.Text.ToString().Trim();

                string contra = txtContra.Text.ToString().Trim();

                Usuario usu = UsuarioDAO.AdminLoginInfo2(nombre, contra);

                if (usu != null)
                {
                    MessageBox.Show("Inicio de sesion correcto.", "Inicio de sesion.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    frmBinaesMain frmAux = new frmBinaesMain(usu);
                    frmAux.Show();
                }
                else
                {
                    MessageBox.Show("Credenciales erróneas!", "Blockbuster", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            

            /*
            if (txtusuario.Text == "admin" && txtContra.Text == "1234")
            {
                this.Hide();
                frmBinaesMain frmAux = new frmBinaesMain();
                frmAux.Show();
            }

            else
            {
                lblError.Text = "Credenciales no válidas.";
            }
            */
        }

        private void frmInicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmInicioSesion_Load(object sender, EventArgs e)
        {
            lblError.Text = "";
        }
    }
}