using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V1ProyectoPOO.UserControls;

namespace V1ProyectoPOO
{
    public partial class frmBiblioteca : Form
    { 
        private Button currentButton;
        private int tempIndex;
        
        public frmBiblioteca()
        {
            InitializeComponent();
        }
        
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

        private void DisableButton()
        {
            foreach (Control previousBtn in tlpMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(5, 29,64);
                    previousBtn.ForeColor = Color.White;
                }
            }
        }

        private void addUserControl(UserControl userControl)
        {
            pnlDatos.Controls.Clear();
            pnlDatos.Controls.Add(userControl);
            userControl.BringToFront();
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UC_Inicio uci = new UC_Inicio();
            addUserControl(uci);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UC_Buscar ucb = new UC_Buscar();
            addUserControl(ucb);
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UC_Eventos uce = new UC_Eventos();
            addUserControl(uce);
        }

        private void btnColecciones_Click(object sender, EventArgs e)
        {
           
            ActivateButton(sender);
            UC_Colecciones ucc = new UC_Colecciones();
            addUserControl(ucc);
        }

        private void btnEjemplares_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UC_Ejemplares ucj = new UC_Ejemplares();
            addUserControl(ucj);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UC_Usuarios ucs = new UC_Usuarios();
            addUserControl(ucs);
        }

        private void btnPrestamos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UC_Prestamos ucp = new UC_Prestamos();
            addUserControl(ucp);
        }

        private void btnReservas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            UC_Reservas ucr = new UC_Reservas();
            addUserControl(ucr);
        }
    }
}