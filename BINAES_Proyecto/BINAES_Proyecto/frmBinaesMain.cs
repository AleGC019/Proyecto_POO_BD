using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BINAES_Proyecto.Forms;
using System.IO;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto
{
    public partial class frmBinaesMain : Form
    {
        private Button currentButton;
        private int tempIndex;
        private Form ActiveForm;

        public Usuario actualUser { get; set; }

        public frmBinaesMain()
        {
            InitializeComponent();
            
        }
        
        
        //Esta función permite que el color del botón donde se esta dando click sea actualizado al color Bisque.
        private void ActivateButton(Object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button) btnSender)
                {
                    DisableButton();
                    currentButton = (Button) btnSender;
                    currentButton.BackColor = Color.Bisque;
                    currentButton.ForeColor = Color.Black;
                }
            }
        }

        //Esta función regresa al botón a su color original.
        private void DisableButton()
        {
            foreach (Control previousBtn in tlpMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(5, 29, 64);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (ActiveForm != null)
            {
                ActiveForm.Close();
            }
            ActivateButton(btnSender);
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlDatos.Controls.Add(childForm);
            this.pnlDatos.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        /*Click del botón Inicio, este evento click activa el color del botón donde estamos seleccionando
         utilizando la funcion ActivateButton y abre el formulario frmInicio
        */
        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmInicio(),sender);
        }
        
        /*Click del botón Buscar, este evento click activa el color del botón donde estamos seleccionando
         utilizando la funcion ActivateButton y abre el formulario frmBuscar
        */
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmBuscar(),sender);
        }

        /*Click del botón Eventos, este evento click activa el color del botón donde estamos seleccionando
         utilizando la funcion ActivateButton y abre el formulario frmEvento
        */
        private void btnEventos_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmEvento(),sender);
        }
        
        /*Click del botón Colecciones, este evento click activa el color del botón donde estamos seleccionando
         utilizando la funcion ActivateButton y abre el formulario frmColeccion 
        */
        private void btnColecciones_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmColeccion(),sender);
        }
        
        /*Click del botón Ejemplares, este evento click activa el color del botón donde estamos seleccionando
         utilizando la funcion ActivateButton y abre el formulario frmEjemplar
        */
        private void btnEjemplares_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmEjemplar(),sender);
        }

        /*Click del botón Usuario, este evento click activa el color del botón donde estamos seleccionando
         utilizando la funcion ActivateButton y abre el formulario frmUsuario
        */
        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmUsuario(),sender);
        }

        /*Click del botón Prestamos, este evento click activa el color del botón donde estamos seleccionando
          utilizando la funcion ActivateButton y abre el formulario frmPrestamo
         */
        private void btnPrestamos_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmPrestamo(),sender);
        }
        
        /*Click del botón Reserva, este evento click activa el color del botón donde estamos seleccionando
         utilizando la funcion ActivateButton y abre el formulario frmReserva
         Nota: El texto de este botón fue modificado a: Mostrar los ejemplares prestados o reservados
        */
        private void btnReservas_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmReserva(),sender);
        }
        
        //Evento load del formulario BinaesMain, se cargan las imagenes que serán utilizadas en el programa
        private void frmBinaesMain_Load(object sender, EventArgs e)
        {
            try
            {
                imgDAO.CargaInicialIMG();


            }
            catch(Exception E)
            {
                MessageBox.Show("Error en carga de imagenes en base de datos.");
            }
        }

        //Función Application.Exit() para cerrar todas las ventas que puedan seguir corriendo de nuestro programa
        private void frmBinaesMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        
        //Click del botón Salir, nos permite salir de la aplicación y abre nuevamente el formulario de inicio de sesión 

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInicioSesion frmAux = new frmInicioSesion();
            frmAux.Show();
        }
    }
}