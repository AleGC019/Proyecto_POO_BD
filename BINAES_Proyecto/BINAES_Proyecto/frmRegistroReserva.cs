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
    public partial class frmRegistroReserva : Form
    {
        //Propiedades de formulario

        public Ejemplar eje { get; set; } //Ejemplar buscado a reservar

        public List<Usuario> usuarios { get; set; } //Lista de puebleo de combobox


        //Metodos de formulario
        public frmRegistroReserva(Ejemplar actualEjemplar)
        {
            InitializeComponent();

            eje = actualEjemplar;
        }

        //Metodo de carga del formulario
        private void frmRegistroReserva_Load(object sender, EventArgs e)
        {
            //Poblado de la combobox de usuarios disponibles
            List<Usuario> poblado = new List<Usuario>();

            poblado = UsuarioDAO.MostrarUsuariosCMB();

            cmbUsuarioReserva.DataSource = null;

            cmbUsuarioReserva.DisplayMember = "UsuarioNombre";

            cmbUsuarioReserva.ValueMember = "UsuarioID";

            cmbUsuarioReserva.DataSource = poblado;

            txtEjemplarReserva.Text = eje.Nombre_Ejemplar;

            picEjemplarReserva.Image = Image.FromFile(eje.Portada);


            //Parametrizacion del dia en que se realiza la reserva, y la referencia de cuando podra hacerse la misma

            DateTime hoy = DateTime.Now;

            dtpFechaReserva.Value = hoy;
            dtpFechaReserva.Enabled = false;

            dtpHoraReserva.Value = hoy;
            dtpHoraReserva.Enabled = false;

            DateTime minimo = ReservaDAO.DisponibleAPartir(eje, hoy.Date);

            dtpEntregaReservFecha.Value = minimo;
            dtpEntregaReservFecha.Enabled = false;

            dtpDevolucionFechaReserva.Value = dtpEntregaReservFecha.Value.AddDays(14);
            dtpDevolucionFechaReserva.Enabled = false;

            dtpEntregaReservaHora.Value = Convert.ToDateTime("3pm");
            dtpEntregaReservaHora.Enabled = false;

            dtpDevolucionHoraReserva.Value = Convert.ToDateTime("2pm");
            dtpDevolucionHoraReserva.Enabled = false;
       
            //Impresion de reglas de reserva para el usuario
            MessageBox.Show("- El titulo estara disponible a partir de la hora siguiente del momento en que regrese del prestamo."
                            + Environment.NewLine + 
                            "- Solo podra ser reservado por un periodo de 14 dias, a partir del dia que regrese del prestamo hasta 1 mes posterior a ello."
                            + Environment.NewLine + 
                            "- Debera regresar su ejemplar, a mas tardar, a las 2 p.m.", "REGLAS DE RESERVA EN BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Metodo de boton cancelar reserva
        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }


        //Metodo de boton para confirmar reserva
        private void btnPrestarReserva_Click(object sender, EventArgs e)
        {
            DateTime momentoReserva = dtpFechaReserva.Value.Date + dtpHoraReserva.Value.TimeOfDay;

            DateTime R_entrega = dtpEntregaReservFecha.Value.Date + dtpEntregaReservaHora.Value.TimeOfDay;

            DateTime R_devolucion = dtpDevolucionFechaReserva.Value.Date + dtpDevolucionHoraReserva.Value.TimeOfDay;

                //Si esta verificacion devuelve algo falso, el ingreso de la reserva fue erroneo y no se hizo
                if (ReservaDAO.NewReserva(Convert.ToInt32(cmbUsuarioReserva.SelectedValue), eje.ID, momentoReserva, R_entrega, R_devolucion))
                {
                    MessageBox.Show("¡Ingreso exitoso!", "Exito en el registro de reserva.", MessageBoxButtons.OK, MessageBoxIcon.None);

                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("¡Ingreso fallido!", "Falla en el registro de reserva.", MessageBoxButtons.OK, MessageBoxIcon.None);

                    this.DialogResult = DialogResult.Abort;

                    this.Close();
                }
            
        }
    }
}
