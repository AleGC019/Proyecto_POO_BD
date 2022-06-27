using System;
using System.Collections.Generic;
using System.Windows.Forms; 

namespace BINAES_Proyecto.Forms
{
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }
        
        /*Click del botón Buscar, El evento clic nos permite acceder a traves de un switch a los
        diferentes accesos de busqueda dentro de nuestra clase BuscarEjemplarDAO*/
        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            switch (cmbOpcionesBuscar.Text.Trim())
            {
                // En razon del texto de nuestra combobox entraremos en una de las condiciones de nuestro switch
                case "Titulo completo":
                {
                    List<Ejemplar> resultado = BuscarEjemplarDAO.FiltrarPorTitulo(txtBuscarEjemplar.Text.Trim()); // Ponele el nombre de la txt box
                    txtBuscarEjemplar.Clear();
                    dgvResultadosBusqueda.RowTemplate.Height = 150;
                    dgvResultadosBusqueda.DataSource = null;
                    dgvResultadosBusqueda.DataSource = resultado;
                    
                   
                    // A partados de formato general de las tablas a mostrar en la DataGridView
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

        
    }
}
