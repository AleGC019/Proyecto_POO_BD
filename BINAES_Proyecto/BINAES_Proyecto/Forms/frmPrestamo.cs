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
            pnlFoundItem_Prestamo.Visible = false;

            cmbTipoBusqueda_Prestamo.Text = "Titulo completo";

            pnlPrestamoContainer.BackColor = Color.FromArgb(5, 29, 64);

            grpVerificarExistencia_Prestamo.BackColor = Color.White;

            MessageBox.Show("Antes de solicitar un prestamo, se requiere buscar el ejemplar deseado para saber su existencia y disponibilidad.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscar_Prestamo_Click(object sender, System.EventArgs e)
        {
            switch (cmbTipoBusqueda_Prestamo.Text)
            {
                case "Titulo completo":

                    if(txtBusqueda_Prestamo.TextLength != 0)
                    {
                        Ejemplar Buscado = new Ejemplar();

                        Buscado = PrestamoDAO.TituloCompleto(txtBusqueda_Prestamo.Text.Trim());

                        if (Buscado.ID != -1)
                        {
                            MessageBox.Show("Su ejemplar si existe.");

                            pnlFoundItem_Prestamo.BackColor = Color.White;

                            pnlFoundItem_Prestamo.Visible = true;

                            picFoundItem_Prestamo.Image = Image.FromFile(Buscado.Portada);

                            lblNombre_prestamo.Text = "Titulo: " + Buscado.Nombre_Ejemplar;

                            lblID_prestamo.Text = "ID de libro: " + Buscado.ID.ToString();

                            lblColeccion_prestamo.Text = "Coleccion a la que pertenece: " + Buscado.Coleccion;

                            lblAutor_Prestamo.Text = "Autor(es): " + Buscado.Autor;

                            lblISBN_PRESTAMO.Text = "ISBN: " + Buscado.ISBN;

                            lblISSN_PRESTAMO.Text = "ISSN: " + Buscado.ISSN; 
                            
                            lblDOI_PRESTAMO.Text= "DOI: " + Buscado.DOI;

                            lblFecha_Prestamo.Text = "Fecha de publicacion: " + Buscado.Fecha_de_publicacion.ToShortDateString();

                            lblEditorial_Prestamo.Text = "Editorial: " + Buscado.Editorial;

                            lblFormato_Prestamo.Text = "Formato del material: " + Buscado.Formato;

                            lblIdioma_Prestamo.Text = "Idioma: " + Buscado.Idioma;

                            lbl_PC_prestamo.Text = "Palabras claves asociadas: " + Buscado.Palabras_clave;

                        }
                        else
                        {
                            MessageBox.Show("Su ejemplar no existe.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese texto en su barra de busqueda.");
                    }
                    
                    break;

                case "Titulo parcial":

                    if (txtBusqueda_Prestamo.TextLength != 0)
                    {
                        Ejemplar Buscado = new Ejemplar();

                        Buscado = PrestamoDAO.TituloParcial(txtBusqueda_Prestamo.Text.Trim());

                        if (Buscado.ID != -1)
                        {
                            MessageBox.Show("Su ejemplar si existe.");

                            pnlFoundItem_Prestamo.BackColor = Color.White;

                            pnlFoundItem_Prestamo.Visible = true;

                            picFoundItem_Prestamo.Image = Image.FromFile(Buscado.Portada);

                            lblNombre_prestamo.Text = "Titulo: " + Buscado.Nombre_Ejemplar;

                            lblID_prestamo.Text = "ID de libro: " + Buscado.ID.ToString();

                            lblColeccion_prestamo.Text = "Coleccion a la que pertenece: " + Buscado.Coleccion;

                            lblAutor_Prestamo.Text = "Autor(es): " + Buscado.Autor;

                            lblISBN_PRESTAMO.Text = "ISBN: " + Buscado.ISBN;

                            lblISSN_PRESTAMO.Text = "ISSN: " + Buscado.ISSN;

                            lblDOI_PRESTAMO.Text = "DOI: " + Buscado.DOI;

                            lblFecha_Prestamo.Text = "Fecha de publicacion: " + Buscado.Fecha_de_publicacion.ToShortDateString();

                            lblEditorial_Prestamo.Text = "Editorial: " + Buscado.Editorial;

                            lblFormato_Prestamo.Text = "Formato del material: " + Buscado.Formato;

                            lblIdioma_Prestamo.Text = "Idioma: " + Buscado.Idioma;

                            lbl_PC_prestamo.Text = "Palabras claves asociadas: " + Buscado.Palabras_clave;

                        }
                        else
                        {
                            MessageBox.Show("Su ejemplar no existe.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese texto en su barra de busqueda.");
                    }


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