using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BINAES_Proyecto.Forms
{
    public partial class frmEjemplar : Form
    {
        public frmEjemplar()
        {
            InitializeComponent();
        }

        private void frmEjemplar_Load(object sender, EventArgs e)
        {
            cmbColeccionEjemplar.DataSource = null;
            cmbColeccionEjemplar.ValueMember = "coleccionID";
            cmbColeccionEjemplar.DisplayMember = "coleccionNombre";
            cmbColeccionEjemplar.DataSource = EjemplarDAO.CargarDatosColeccion();

            cmbEditorial.DataSource = null;
            cmbEditorial.ValueMember = "editorialID";
            cmbEditorial.DisplayMember = "nombreEditorial";
            cmbEditorial.DataSource = EjemplarDAO.CargarDatosEditorial();

            cmbFomato.DataSource = null;
            cmbFomato.ValueMember = "formatoID";
            cmbFomato.DisplayMember = "nombreFormato";
            cmbFomato.DataSource = EjemplarDAO.CargarDatosFormato();
            
            cmbIdioma.DataSource = null;
            cmbIdioma.ValueMember = "idIdioma";
            cmbIdioma.DisplayMember = "nombreIdioma";
            cmbIdioma.DataSource = EjemplarDAO.CargarDatosIdiomas();
        }

        private void btnCrearEjemplar_Click(object sender, EventArgs e)
        {
            Ejemplar ejem = new Ejemplar();
            ejem.Nombre_Ejemplar = txtNombreEjemplar.Text;
            ejem.Fecha_de_publicacion = Convert.ToDateTime(txtFechaPublicacion.Text);
            ejem.Coleccion = cmbColeccionEjemplar.SelectedValue.ToString();
            ejem.Editorial = cmbEditorial.SelectedValue.ToString();
            ejem.Formato = cmbFomato.SelectedValue.ToString();
            ejem.Idioma = cmbIdioma.SelectedValue.ToString();
            ejem.Portada = txtFotografia.Text;
            ejem.ISBN = txtIsbn.Text;
            ejem.ISSN = txtissn.Text;
            ejem.DOI = txtDoi.Text;
            ejem.Palabras_clave = txtPalabraClave1.Text;
            ejem.Palabras_clave = txtPalabraClave2.Text;
            ejem.Palabras_clave = txtPalabraClave3.Text;
            
            
            EjemplarDAO.IngresarEjemplar(ejem);
            MessageBox.Show("Ingresado con éxito");
        }
        

        private void btnCrearEditorial_Click(object sender, EventArgs e)
        {
            Editorial edit = new Editorial();
            edit.nombreEditorial = txtNuevaEditorial.Text;
            
            
            EditorialDAO.InsertarNuevaEditorial(edit);
            MessageBox.Show("Editorial ingresada con éxito");
            Update();
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
             if(cmbOpcionesBuscar.Text == "Titulo completo") // Aqui pones el nombre que le hayas puesto a la combobox
             { 
                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorTitulo(txtBuscarEjemplar.Text.Trim());
                txtBuscarEjemplar.Clear();

                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;
                dgvResultadosBusqueda.Columns["ID"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                
                dgvResultadosBusqueda.Columns["ID"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Nombre_Ejemplar"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Coleccion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Autor"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISBN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISSN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["DOI"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Fecha_de_publicacion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Editorial"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Formato"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Idioma"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Palabras_clave"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

             }
            else if (cmbOpcionesBuscar.Text == "Titulo parcial")
            {
                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorTituloParcial(txtBuscarEjemplar.Text.Trim());
                txtBuscarEjemplar.Clear();
                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;
                
                dgvResultadosBusqueda.Columns["ID"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Nombre_Ejemplar"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Coleccion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Autor"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISBN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISSN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["DOI"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Fecha_de_publicacion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Editorial"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Formato"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Idioma"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Palabras_clave"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

            }
            else if (cmbOpcionesBuscar.Text == "Autor")
            {

                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorAutor(txtBuscarEjemplar.Text.Trim());
                txtBuscarEjemplar.Clear();
                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;
                
                dgvResultadosBusqueda.Columns["ID"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Nombre_Ejemplar"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Coleccion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Autor"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISBN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISSN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["DOI"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Fecha_de_publicacion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Editorial"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Formato"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Idioma"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Palabras_clave"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

            }
            else if (cmbOpcionesBuscar.Text == "Fisico")
            {
                txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;
                
                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorFormato(txtBuscarEjemplar.Text.Trim());
                txtBuscarEjemplar.Clear();
                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;
                
                dgvResultadosBusqueda.Columns["ID"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Nombre_Ejemplar"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Coleccion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Autor"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISBN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISSN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["DOI"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Fecha_de_publicacion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Editorial"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Formato"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Idioma"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Palabras_clave"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

            }
            else if (cmbOpcionesBuscar.Text == "Digital")
            {
                txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;
                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorFormato(txtBuscarEjemplar.Text.Trim());
                txtBuscarEjemplar.Clear();
                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;
                
                dgvResultadosBusqueda.Columns["ID"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Nombre_Ejemplar"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Coleccion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Autor"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISBN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISSN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["DOI"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Fecha_de_publicacion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Editorial"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Formato"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Idioma"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Palabras_clave"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

            }
            else if (cmbOpcionesBuscar.Text == "Mostrar todos")
            {
                txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;
                List<Ejemplar> resultado = BuscarEjemplarDAO.General();
                txtBuscarEjemplar.Clear();
                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;
                
                dgvResultadosBusqueda.Columns["ID"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Nombre_Ejemplar"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Coleccion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Autor"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISBN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISSN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["DOI"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Fecha_de_publicacion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Editorial"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Formato"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Idioma"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Palabras_clave"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

            }
            else if (cmbOpcionesBuscar.Text == "Por palabra clave")
            {

                List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorPalabraClave(txtBuscarEjemplar.Text.Trim()); // Ponele el nombre de la txt box
                txtBuscarEjemplar.Clear();
                dgvResultadosBusqueda.DataSource = null;
                dgvResultadosBusqueda.DataSource = resultado;
                
                dgvResultadosBusqueda.Columns["ID"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Nombre_Ejemplar"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Coleccion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Autor"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISBN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["ISSN"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["DOI"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Fecha_de_publicacion"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Editorial"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Formato"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Idioma"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvResultadosBusqueda.Columns["Palabras_clave"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                
            }
             else
             {
                 txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;
                 List<Ejemplar> resultado = BuscarEjemplarDAO.General();
                 txtBuscarEjemplar.Clear();
                 
                 dgvResultadosBusqueda.DataSource = null;
                 dgvResultadosBusqueda.DataSource = resultado;
                 
                 dgvResultadosBusqueda.Columns["ID"].DefaultCellStyle.Alignment =
                     DataGridViewContentAlignment.MiddleCenter;
                 dgvResultadosBusqueda.Columns["Nombre_Ejemplar"].DefaultCellStyle.Alignment =
                     DataGridViewContentAlignment.MiddleCenter;
                 dgvResultadosBusqueda.Columns["Coleccion"].DefaultCellStyle.Alignment =
                     DataGridViewContentAlignment.MiddleCenter;
                 dgvResultadosBusqueda.Columns["Autor"].DefaultCellStyle.Alignment =
                     DataGridViewContentAlignment.MiddleCenter;
                 dgvResultadosBusqueda.Columns["ISBN"].DefaultCellStyle.Alignment =
                     DataGridViewContentAlignment.MiddleCenter;
                 dgvResultadosBusqueda.Columns["ISSN"].DefaultCellStyle.Alignment =
                     DataGridViewContentAlignment.MiddleCenter;
                 dgvResultadosBusqueda.Columns["DOI"].DefaultCellStyle.Alignment =
                     DataGridViewContentAlignment.MiddleCenter;
                 dgvResultadosBusqueda.Columns["Fecha_de_publicacion"].DefaultCellStyle.Alignment =
                     DataGridViewContentAlignment.MiddleCenter;
                 dgvResultadosBusqueda.Columns["Editorial"].DefaultCellStyle.Alignment =
                     DataGridViewContentAlignment.MiddleCenter;
                 dgvResultadosBusqueda.Columns["Formato"].DefaultCellStyle.Alignment =
                     DataGridViewContentAlignment.MiddleCenter;
                 dgvResultadosBusqueda.Columns["Idioma"].DefaultCellStyle.Alignment =
                     DataGridViewContentAlignment.MiddleCenter;
                 dgvResultadosBusqueda.Columns["Palabras_clave"].DefaultCellStyle.Alignment =
                     DataGridViewContentAlignment.MiddleCenter;
                 

             }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    } 
}
