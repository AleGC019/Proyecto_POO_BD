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

namespace BINAES_Proyecto
{
    public partial class frmBinaesMain : Form
    {
        private Button currentButton;
        private int tempIndex;
        private Form ActiveForm;

        public frmBinaesMain()
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

        private void btnInicio_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmInicio(),sender);
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmBuscar(),sender);
        }

        private void btnEventos_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmEvento(),sender);
        }

        private void btnColecciones_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmColeccion(),sender);
        }

        private void btnEjemplares_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmEjemplar(),sender);
        }

        private void btnUsuarios_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmUsuario(),sender);
        }

        private void btnPrestamos_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmPrestamo(),sender);
        }

        private void btnReservas_Click_1(object sender, EventArgs e)
        {
            ActivateButton(sender);
            OpenChildForm(new Forms.frmReserva(),sender);
        }
        

        private void frmBinaesMain_Load(object sender, EventArgs e)
        {
                
        }
    }
}