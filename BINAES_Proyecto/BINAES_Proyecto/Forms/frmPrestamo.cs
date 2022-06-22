using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using BINAES_Proyecto.Properties;
using System.Drawing;

namespace BINAES_Proyecto.Forms
{
    public partial class frmPrestamo : Form
    {
        public frmPrestamo()
        {
            InitializeComponent();
        }

        private void frmPrestamo_Load(object sender, System.EventArgs e)
        {
            MessageBox.Show("Antes de solicitar un prestamo, se requiere buscar el ejemplar deseado para saber su existencia.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            pnlFoundItem_Prestamo.Visible = false;

            cmbTipoBusqueda_Prestamo.Text = "Titulo completo";
        }

        private void btnBuscar_Prestamo_Click(object sender, System.EventArgs e)
        {
            switch (cmbTipoBusqueda_Prestamo.Text)
            {
                case "Titulo completo":

                    Ejemplar Buscado = PrestamoDAO.FiltrarPorTitulo(txtBusqueda_Prestamo.Text.Trim());

                    if(Buscado != null)
                    {
                        MessageBox.Show("Su ejemplar si existe.");

                        pnlFoundItem_Prestamo.Visible = true;

                        picFoundItem_Prestamo.Image = Image.FromFile(Buscado.Portada);
                    }
                    else 
                    {
                        MessageBox.Show("Su ejemplar no existe.");
                    }
                    
                    break;

                case "Titulo parcial":
                    break;
                case "Autor":
                    break;
                case "Fisico":
                    break;
                case "Mostrar todos":
                    break;
                default:
                    break;
            }


            if(cmbTipoBusqueda_Prestamo.Text == "Titulo completo") // Aqui pones el nombre que le hayas puesto a la combobox
            {
                /*
                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorTitulo(txtBuscarEjemplar.Text.Trim()); // Ponele el nombre de la txt box
                txtBuscarEjemplar.Clear();

                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;

            }
            else if (cmbOpcionesBuscar.Text == "Titulo parcial")
            {

                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorTituloParcial(txtBuscarEjemplar.Text.Trim());
                txtBuscarEjemplar.Clear();
                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;

            }
            else if (cmbOpcionesBuscar.Text == "Autor")
            {

                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorAutor(txtBuscarEjemplar.Text.Trim());
                txtBuscarEjemplar.Clear();
                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;

            }
            else if (cmbOpcionesBuscar.Text == "Fisico")
            {
                txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;

                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorFormato(txtBuscarEjemplar.Text.Trim());
                txtBuscarEjemplar.Clear();
                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;

            }
            else if (cmbOpcionesBuscar.Text == "Digital")
            {
                txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;
                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorFormato(txtBuscarEjemplar.Text.Trim());
                txtBuscarEjemplar.Clear();
                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;

            }
            else if (cmbOpcionesBuscar.Text == "Mostrar todos")
            {
                txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;
                List<Ejemplar> resultado = BuscarEjemplarDAO.General();
                txtBuscarEjemplar.Clear();
                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;

            }
            else
            {

                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorPalabraClave(txtBuscarEjemplar.Text.Trim()); // Ponele el nombre de la txt box
                txtBuscarEjemplar.Clear();
                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;*/
            }
        }
    }
}