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
        public Ejemplar Buscado { get; set; }

        public Usuario actualUser { get; set; }

        public frmPrestamo(Usuario usuarioMAIN)
        {
            InitializeComponent();

            actualUser = usuarioMAIN;
        }

        private void frmPrestamo_Load(object sender, System.EventArgs e)
        {
            pnlFoundItem_Prestamo.Visible = false;

            pnlPrestamoContainer.BackColor = Color.FromArgb(5, 29, 64);

            cmbTipoBusqueda_Prestamo.Text = "Titulo completo";

            grpVerificarExistencia_Prestamo.BackColor = Color.White;

            /*MessageBox.Show("Antes de solicitar un prestamo, se requiere buscar el ejemplar deseado para saber su existencia y disponibilidad.", "AVISO", 
                            MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void btnBuscar_Prestamo_Click(object sender, System.EventArgs e)
        {
            if (txtBusqueda_Prestamo.TextLength > 0)
            {
                switch (cmbTipoBusqueda_Prestamo.Text)
                {
                    case "Titulo completo":

                        Buscado = PrestamoDAO.TituloCompleto(txtBusqueda_Prestamo.Text.Trim());

                        if (Buscado.ID != -1)
                        {
                            MessageBox.Show("Su ejemplar si existe en la base de datos.", "CONFIRMACION DE EXISTENCIA.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            pnlFoundItem_Prestamo.Visible = true;

                            pnlFoundItem_Prestamo.BackColor = Color.White;                         

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
                        else if (Buscado.ID == -1)
                        {
                            MessageBox.Show("El parametro de busqueda brindado no coincide con ningun material." + Environment.NewLine + 
                                            "En busqueda por titulo completo, asegurese de ingresar integramente el nombre del ejemplar deseado.", "Advertencia.", 
                                            MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                    
                    
                    break;

                    case "Titulo parcial":

                        Buscado = PrestamoDAO.TituloParcial(txtBusqueda_Prestamo.Text.Trim());

                        if (Buscado.ID > 0)
                        {
                            MessageBox.Show("Su ejemplar si existe en la base de datos.", "CONFIRMACION DE EXISTENCIA.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            pnlFoundItem_Prestamo.Visible = true;

                            pnlFoundItem_Prestamo.BackColor = Color.White;

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
                        else if (Buscado.ID == -1)
                        {
                            MessageBox.Show("Los parametros de busqueda no coinciden con algun titulo de la base de datos.", "INEXISTENCIA DE MATERIAL.",
                                            MessageBoxButtons.OK, MessageBoxIcon.Question);
                        }
                        else if (Buscado.ID == 0)
                        {
                            MessageBox.Show("Existe más de un título con su palabra parcial." + Environment.NewLine + "Sea un poco más específico o intente con título completo.",
                                            "Coincidencia de resultados.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                        }

                        break;
                        
                    default:
                    break;
                }
            }
            else if (txtBusqueda_Prestamo.TextLength == 0)
            {
                MessageBox.Show("Ingrese texto en la barra de busqueda para proseguir.", "Sin parametros de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void picFoundItem_Prestamo_Click(object sender, EventArgs e)
        {
            if(PrestamoDAO.VerifyPrestamo(Buscado))
            {
                MessageBox.Show("Actualmente, el libro esta disponible. Puede prestarlo.", "Disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (frmRegistroPrestamo nuevaVentana = new frmRegistroPrestamo(actualUser, Buscado))
                {
                    nuevaVentana.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Actualmente, el libro no esta disponible. Se encuentra prestado.", "No disponible", MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);
            }
        }
    }
}