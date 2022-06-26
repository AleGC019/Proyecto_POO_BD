using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BINAES_Proyecto.Forms
{
    public partial class frmReserva : Form
    {
        public frmReserva()
        {
            InitializeComponent();
        }

        private void btnMostrarPrestamos_Click(object sender, EventArgs e)
        {
            List<PrestamoEjemplar> resultado = PrestamoDAO.MostrarTodo(); // Ponele el nombre de la txt box

            
            dgvMostrarPrestamos.DataSource = null;
            dgvMostrarPrestamos.DataSource = resultado;
            dgvMostrarPrestamos.Columns["FechaReserva"].Visible = false;
            
            dgvMostrarPrestamos.Columns["Nombre"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnMostrarReservaciones_Click(object sender, EventArgs e)
        {
            List<PrestamoEjemplar> resultado = PrestamoDAO.MostrarTodoReservaciones(); // Ponele el nombre de la txt box
            
            dgvMostrarReservaciones.DataSource = null;
            dgvMostrarReservaciones.DataSource = resultado;
        }
    }
}