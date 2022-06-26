using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto.Forms
{
    public partial class frmEjemplar : Form
    {
        public string imagen { get; set; }

        public frmEjemplar()
        {
            InitializeComponent();
        }

        private void frmEjemplar_Load(object sender, EventArgs e)
        {
            cmbColeccionEjemplar.DataSource = null;
            cmbColeccionEjemplar.ValueMember = "Coleccion_ID";
            cmbColeccionEjemplar.DisplayMember = "Coleccion_Nombre";
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

            //cargar combos para la tab de editar 
            cmbColeccionActualizar.DataSource = null;
            cmbColeccionActualizar.ValueMember = "Coleccion_ID";
            cmbColeccionActualizar.DisplayMember = "Coleccion_Nombre";
            cmbColeccionActualizar.DataSource = EjemplarDAO.CargarDatosColeccion();

            cmbActualizarEditorial.DataSource = null;
            cmbActualizarEditorial.ValueMember = "editorialID";
            cmbActualizarEditorial.DisplayMember = "nombreEditorial";
            cmbActualizarEditorial.DataSource = EjemplarDAO.CargarDatosEditorial();

            cmbActualizarFormato.DataSource = null;
            cmbActualizarFormato.ValueMember = "formatoID";
            cmbActualizarFormato.DisplayMember = "nombreFormato";
            cmbActualizarFormato.DataSource = EjemplarDAO.CargarDatosFormato();

            cmbActualizarIdioma.DataSource = null;
            cmbActualizarIdioma.ValueMember = "idIdioma";
            cmbActualizarIdioma.DisplayMember = "nombreIdioma";
            cmbActualizarIdioma.DataSource = EjemplarDAO.CargarDatosIdiomas();
        }

        private void btnCrearEjemplar_Click(object sender, EventArgs e)
        {
            if(txtNombreEjemplar.TextLength > 0 && txtFechaPublicacion.TextLength >0 && cmbColeccionEjemplar.Text.Length > 0 && cmbEditorial.Text.Length >0 && cmbFomato.Text.Length >0 && cmbIdioma.Text.Length > 0 && imagen.Length > 0 && (txtIsbn.TextLength>0 || txtissn.TextLength > 0 || txtDoi.TextLength >0 )){
            Ejemplar ejem = new Ejemplar();
            ejem.Nombre_Ejemplar = txtNombreEjemplar.Text;
            ejem.Fecha_de_publicacion = Convert.ToDateTime(txtFechaPublicacion.Text);
            ejem.Coleccion = cmbColeccionEjemplar.SelectedValue.ToString();
            ejem.Editorial = cmbEditorial.SelectedValue.ToString();
            ejem.Formato = cmbFomato.SelectedValue.ToString();
            ejem.Idioma = cmbIdioma.SelectedValue.ToString();
            ejem.Portada = imagen;
            ejem.ISBN = txtIsbn.Text;
            ejem.ISSN = txtissn.Text;
            ejem.DOI = txtDoi.Text;

            picImagenEjemplar.Image = new Bitmap(imagen);

            EjemplarDAO.IngresarEjemplar(ejem);
            MessageBox.Show("Ingresado con éxito el numero de id de este ejemplar es " + EjemplarDAO.nuevoidEejmplar());
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los campos requeridos", "Informacion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error  );

            }
            
        }


        private void btnCrearEditorial_Click(object sender, EventArgs e)
        {
            new frmCrearEditorial().Show();

        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            switch (cmbOpcionesBuscar.Text.Trim())
            {
                // Aqui pones el nombre que le hayas puesto a la combobox
                case "Titulo completo":
                {
                    List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorTitulo(txtBuscarEjemplar.Text.Trim()); // Ponele el nombre de la txt box
                    txtBuscarEjemplar.Clear();
                    dgvResultadosBusqueda.RowTemplate.Height = 150;
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

                    dgvResultadosBusqueda.Columns["Portada"].Visible = false;
                    
                    DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvResultadosBusqueda.Columns["fotoEjemplarAUX"];
                    columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    
                    
                    
                    break;
                }
                case "Titulo parcial":
                {
                    List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorTituloParcial(txtBuscarEjemplar.Text.Trim());
                    txtBuscarEjemplar.Clear();
                    dgvResultadosBusqueda.RowTemplate.Height = 150;
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
                    
                    dgvResultadosBusqueda.Columns["Portada"].Visible = false;
                    
                    DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvResultadosBusqueda.Columns["fotoEjemplarAUX"];
                    columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
                case "Autor":
                {
                    List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorAutor(txtBuscarEjemplar.Text.Trim());
                    txtBuscarEjemplar.Clear();
                    dgvResultadosBusqueda.RowTemplate.Height = 150;
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
                    
                    dgvResultadosBusqueda.Columns["Portada"].Visible = false;
                    DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvResultadosBusqueda.Columns["fotoEjemplarAUX"];
                    columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
                case "Fisico":
                {
                    txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;
                
                    List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorFormato(txtBuscarEjemplar.Text.Trim());
                    txtBuscarEjemplar.Clear();
                    dgvResultadosBusqueda.RowTemplate.Height = 150;
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
                    dgvResultadosBusqueda.Columns["Portada"].Visible = false;
                    DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvResultadosBusqueda.Columns["fotoEjemplarAUX"];
                    columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
                case "Digital":
                {
                    txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;
                    List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorFormato(txtBuscarEjemplar.Text.Trim());
                    txtBuscarEjemplar.Clear();
                    dgvResultadosBusqueda.RowTemplate.Height = 150;
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
                    dgvResultadosBusqueda.Columns["Portada"].Visible = false;
                    DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvResultadosBusqueda.Columns["fotoEjemplarAUX"];
                    columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
                case "Mostrar todos":
                {
                    txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;
                    List<Ejemplar> resultado = BuscarEjemplarDAO.General();
                    txtBuscarEjemplar.Clear();
                    
                    dgvResultadosBusqueda.RowTemplate.Height = 150;
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
                    dgvResultadosBusqueda.Columns["Portada"].Visible = false;
                    DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvResultadosBusqueda.Columns["fotoEjemplarAUX"];
                    columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
                case "Por palabra clave":
                {
                    List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorPalabraClave(txtBuscarEjemplar.Text.Trim()); // Ponele el nombre de la txt box
                    txtBuscarEjemplar.Clear();
                    
                    dgvResultadosBusqueda.RowTemplate.Height = 150;
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
                    dgvResultadosBusqueda.Columns["Portada"].Visible = false;
                    DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvResultadosBusqueda.Columns["fotoEjemplarAUX"];
                    columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
                default:
                {
                    txtBuscarEjemplar.Text = cmbOpcionesBuscar.Text;
                    List<Ejemplar> resultado = BuscarEjemplarDAO.General();
                    
                    dgvResultadosBusqueda.RowTemplate.Height = 150;
                    
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
                    
                    dgvResultadosBusqueda.Columns["Portada"].Visible = false;
                    DataGridViewImageColumn columna = (DataGridViewImageColumn)dgvResultadosBusqueda.Columns["fotoEjemplarAUX"];
                    columna.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }


        private void btnCrearPalabrasClave_Click(object sender, EventArgs e)
        {
            new frmCrearPalabrasClave().Show();
        }

        private void btnCrearAutor_Click(object sender, EventArgs e)
        {
            new frmCrearAutor().Show();
        }

        private void btnAgregarImagenEjemplar_Click(object sender, EventArgs e)
        {
            OpenFileDialog obtener = new OpenFileDialog();
            obtener.InitialDirectory = "C:\\";
            obtener.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)| *.jpg; *.jpeg; *.gif; *.bmp, *.png";

            if (obtener.ShowDialog() == DialogResult.OK)
            {
                imagen = obtener.FileName;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una foto");
            }
        }

        private void btnActualizarEejmplar_Click(object sender, EventArgs e)
        {
            Ejemplar ejem = new Ejemplar();
            ejem.ID = Convert.ToInt32(txtIDActualizarEjemplar.Text);
            ejem.Nombre_Ejemplar = txtActualizarNombreEjemplar.Text;
            ejem.Fecha_de_publicacion = Convert.ToDateTime(txtActualizarFechaEjemplar.Text);
            ejem.Idioma = cmbActualizarIdioma.SelectedValue.ToString();
            ejem.Editorial = cmbActualizarEditorial.SelectedValue.ToString();
            ejem.Coleccion = cmbColeccionEjemplar.SelectedValue.ToString();
            ejem.Formato = cmbActualizarFormato.SelectedValue.ToString();
            ejem.ISBN = txtissn.Text;
            ejem.ISSN = txtissn.Text;
            ejem.DOI = txtDoi.Text;
            ejem.Portada = imagen;


            EjemplarDAO.ActualizarEjemplar(ejem);
            MessageBox.Show("datos actualizados");

        }

        private void btnActualizarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog obtener = new OpenFileDialog();
            obtener.InitialDirectory = "C:\\";
            obtener.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)| *.jpg; *.jpeg; *.gif; *.bmp, *.png";

            if (obtener.ShowDialog() == DialogResult.OK)
            {
                imagen = obtener.FileName;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una foto");
            }
        }

        private void bntConfirmarID_Click(object sender, EventArgs e)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {

                SqlCommand command =
                    new SqlCommand(
                        "SELECT nombre,fecha_publicada,imagen_portada, id_idioma, id_editorial,id_formato,isbn,issn,doi, id_coleccion  FROM EJEMPLAR WHERE id = @id", connection);
                command.Parameters.AddWithValue("@id", txtIDActualizarEjemplar.Text);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtActualizarNombreEjemplar.Text = reader["nombre"].ToString();
                    txtActualizarFechaEjemplar.Text = reader["fecha_publicada"].ToString();
                    cmbColeccionActualizar.SelectedValue = Convert.ToInt32(reader["id_coleccion"]);
                    cmbActualizarEditorial.SelectedValue = Convert.ToInt32(reader["id_editorial"]);
                    cmbActualizarFormato.SelectedValue = Convert.ToInt32(reader["id_formato"]);
                    cmbActualizarEditorial.SelectedValue = Convert.ToInt32(reader["id_editorial"]);
                    cmbActualizarIdioma.SelectedValue = Convert.ToInt32(reader["id_idioma"]);
                    txtActualizarISB.Text = reader["isbn"].ToString();
                    txtActualizarISSN.Text = reader["issn"].ToString();
                    txtActualizarDOI.Text = reader["doi"].ToString();
                    imagen = reader["imagen_portada"].ToString();
                }



                
                connection.Close();


            }
        }

        private void txtidEliminarEjemplar_TextChanged(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void btnActualizarPalabrasClave_Click(object sender, EventArgs e)
        {
            new frmActualizarPalabraClave().Show();
        }


        private void btnActualizarAutor_Click(object sender, EventArgs e)
        {
            new frmActualizarAutor().Show();
        }
    }
}
