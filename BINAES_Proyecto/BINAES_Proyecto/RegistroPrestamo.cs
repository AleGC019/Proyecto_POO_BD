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
    public partial class frmRegistroPrestamo : Form
    {
        public Usuario actualUser { get; set; }

        public Ejemplar eje { get; set; }

        public List<Usuario> usuarios { get; set; }

        public frmRegistroPrestamo( Ejemplar actualEjemplar)
        {
            InitializeComponent();

            eje = actualEjemplar;
        }

        private void RegistroPrestamo_Load(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            DateTime Limite = hoy.AddDays(14);

            dtpEntregaFecha.Value = hoy;
            dtpEntregaFecha.Enabled = false;
            
            dtpEntregaHora.Value = hoy;
            dtpEntregaHora.Enabled = false;

            dtpDevolucionFecha.Value = Limite;
            dtpDevolucionFecha.Enabled = false;

            dtpDevolucionHora.Value = Convert.ToDateTime("2pm");
            dtpDevolucionHora.Enabled = false;

            picEjemplar.Image = Image.FromFile(eje.Portada);

            txtEjemplar.Text = eje.Nombre_Ejemplar;

            List<Usuario> poblado = new List<Usuario>();

            poblado = UsuarioDAO.MostrarUsuariosCMB();

            cmbUsuarioPresta.DataSource = null;

            cmbUsuarioPresta.DisplayMember = "UsuarioNombre";

            cmbUsuarioPresta.ValueMember = "UsuarioID";

            cmbUsuarioPresta.DataSource = poblado;

            MessageBox.Show("BINAES le otorgará el material por un periodo de 14 días en los que, al terminar, usted deber regresar lo prestado a mas tardar, a las 2pm.");

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void btnPrestar_Click(object sender, EventArgs e)
        {
            DateTime R_entrega = dtpEntregaFecha.Value.Date + dtpEntregaHora.Value.TimeOfDay;

            DateTime R_devolucion = dtpDevolucionFecha.Value.Date + dtpDevolucionHora.Value.TimeOfDay;

            if (PrestamoDAO.NewPrestamo(Convert.ToInt32(cmbUsuarioPresta.SelectedValue), eje.ID, R_entrega, R_devolucion))
            {
                MessageBox.Show("¡Ingreso exitoso!", "Exito en el registro de prestamo.", MessageBoxButtons.OK, MessageBoxIcon.None);

                this.DialogResult = DialogResult.OK;

                this.Close();
            }
            else
            {
                MessageBox.Show("¡Ingreso fallido!", "Falla en el registro de prestamo.", MessageBoxButtons.OK, MessageBoxIcon.None);

                this.DialogResult = DialogResult.Abort;

                this.Close();
            }
        }
    }
}
