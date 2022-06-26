﻿using System;
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

        public Ejemplar eje { get; set; }

        public List<Usuario> usuarios { get; set; }


        //Metodos de formulario

        public frmRegistroReserva(Ejemplar actualEjemplar)
        {
            InitializeComponent();

            eje = actualEjemplar;
        }

        private void frmRegistroReserva_Load(object sender, EventArgs e)
        {
            List<Usuario> poblado = new List<Usuario>();

            poblado = UsuarioDAO.MostrarUsuariosCMB();

            cmbUsuarioReserva.DataSource = null;

            cmbUsuarioReserva.DisplayMember = "UsuarioNombre";

            cmbUsuarioReserva.ValueMember = "UsuarioID";

            cmbUsuarioReserva.DataSource = poblado;

            txtEjemplarReserva.Text = eje.Nombre_Ejemplar;

            picEjemplarReserva.Image = Image.FromFile(eje.Portada);

            DateTime hoy = DateTime.Now;

            dtpFechaReserva.Value = hoy;
            dtpFechaReserva.Enabled = false;

            dtpHoraReserva.Value = hoy;
            dtpHoraReserva.Enabled = false;

            DateTime minimo = (DateTime)ReservaDAO.DisponibleAPartir(eje);

            dtpEntregaReservFecha.Value = minimo;
            dtpEntregaReservFecha.MinDate = minimo;
            dtpEntregaReservFecha.MaxDate = minimo.AddMonths(1);

            dtpDevolucionFechaReserva.Value = dtpEntregaReservFecha.Value.AddDays(1);
            dtpDevolucionFechaReserva.MinDate = dtpEntregaReservFecha.Value.AddDays(1);
            dtpDevolucionFechaReserva.MaxDate = dtpEntregaReservFecha.Value.AddDays(14);

            dtpEntregaReservaHora.Value = minimo.AddHours(1);
            dtpEntregaReservaHora.MinDate = minimo.AddHours(1);

            dtpDevolucionHoraReserva.Value = Convert.ToDateTime("2pm");
            dtpDevolucionHoraReserva.Enabled = false;
       
            MessageBox.Show("- El titulo estara disponible a partir de la hora siguiente del momento en que regrese del prestamo."
                            + Environment.NewLine + 
                            "- Solo podra ser reservado por un periodo minimo de 2 dias y maximo de 14 dias, a partir del dia que regrese del prestamo hasta 1 mes posterior a ello."
                            + Environment.NewLine + 
                            "- Debera regresar su ejemplar, a mas tardar, a las 2 p.m.", "REGLAS DE RESERVA EN BINAES", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void dtpEntregaReservFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpDevolucionFechaReserva.Value = dtpEntregaReservFecha.Value.AddDays(2);
            dtpDevolucionFechaReserva.MinDate = dtpEntregaReservFecha.Value.AddDays(1);
            dtpDevolucionFechaReserva.MaxDate = dtpEntregaReservFecha.Value.AddDays(14);
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void btnPrestarReserva_Click(object sender, EventArgs e)
        {
            DateTime momentoReserva = dtpFechaReserva.Value.Date + dtpHoraReserva.Value.TimeOfDay;

            DateTime R_entrega = dtpEntregaReservFecha.Value.Date + dtpEntregaReservaHora.Value.TimeOfDay;

            DateTime R_devolucion = dtpDevolucionFechaReserva.Value.Date + dtpDevolucionHoraReserva.Value.TimeOfDay;

            if (ReservaDAO.VerifyReserva(txtEjemplarReserva.Text, R_entrega.Date, R_devolucion.Date))
            {
                MessageBox.Show("Fechas ya reservadas. Elija otras.");
            }
            else
            {
                if (ReservaDAO.NewReserva(Convert.ToInt32(cmbUsuarioReserva.SelectedValue), eje.ID, momentoReserva, R_entrega, R_devolucion))
                {
                    MessageBox.Show("Ingreso exitoso!");

                    this.DialogResult = DialogResult.OK;

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ingreso fallido!");

                    this.DialogResult = DialogResult.Abort;

                    this.Close();
                }
            }
        }
    }
}