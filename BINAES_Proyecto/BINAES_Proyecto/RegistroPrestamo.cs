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
        // Instancias a usar dentro de programa
        public Ejemplar eje { get; set; } //Ejemplar encontrado sujeto a prestamo

        public List<Usuario> usuarios { get; set; } //Lista ara poblar de usuarios la combobox

        //Creacion de formulario
        public frmRegistroPrestamo( Ejemplar actualEjemplar)
        {
            InitializeComponent();

            eje = actualEjemplar;
        }

        //Carga de formulario
        private void RegistroPrestamo_Load(object sender, EventArgs e)
        {
            //Asignaciones en frio de parametros a mostrar para las fechas de prestamo

            DateTime hoy = DateTime.Now;
            DateTime Limite = hoy.AddDays(14); //El prestamo puede hacerse un maximo de 14 dias a partir del dia en que se hace

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


            //Poblado de combobox de usuario
            List<Usuario> poblado = new List<Usuario>();

            poblado = UsuarioDAO.MostrarUsuariosCMB();

            cmbUsuarioPresta.DataSource = null;

            cmbUsuarioPresta.DisplayMember = "UsuarioNombre";

            cmbUsuarioPresta.ValueMember = "UsuarioID";

            cmbUsuarioPresta.DataSource = poblado;


            //Aviso de funcion
            MessageBox.Show("BINAES le otorgará el material por un periodo de 14 días en los que, al terminar, usted deber regresar lo prestado a mas tardar, a las 2pm.");

        }

        //Metodo de boton cancelar registro de prestamo
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }


        //Metodo de boton de registrar prestamo
        private void btnPrestar_Click(object sender, EventArgs e)
        {
            DateTime R_entrega = dtpEntregaFecha.Value.Date + dtpEntregaHora.Value.TimeOfDay;

            DateTime R_devolucion = dtpDevolucionFecha.Value.Date + dtpDevolucionHora.Value.TimeOfDay;


            //Si la funcion de la DAO devuelve true, el ingreso del registro fue exitoso.
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
