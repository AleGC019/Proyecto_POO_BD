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
        //Instancias a usar dentro del formulario
        public Ejemplar Buscado { get; set; } //Ejemplar a buscar dentro de los metodos

        //Creacion del formulario
        public frmPrestamo()
        {
            InitializeComponent();
        }

        //Metodo de carga del formulario 
        private void frmPrestamo_Load(object sender, System.EventArgs e)
        {
            //Invisibilizacion de campos no deseados hasta que se encuentre el ejemplar
            pnlFoundItem_Prestamo.Visible = false;

            pnlPrestamoContainer.BackColor = Color.FromArgb(5, 29, 64);

            cmbTipoBusqueda_Prestamo.Text = "Titulo completo";

            grpVerificarExistencia_Prestamo.BackColor = Color.White;
        }

        //Metodo de busqueda de ejemplar al presionar el boton Buscar
        private void btnBuscar_Prestamo_Click(object sender, System.EventArgs e)
        {
            //Validaciones de txt vacias
            if (txtBusqueda_Prestamo.TextLength > 0)
            {
                switch (cmbTipoBusqueda_Prestamo.Text)
                {
                    case "Titulo completo":

                        Buscado = PrestamoDAO.TituloCompleto(txtBusqueda_Prestamo.Text.Trim()); //Asignacion de campos del ejemplar buscado

                        if (Buscado.ID != -1) //Parametro personalizado para verificacion de existencia.
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
                            MessageBox.Show("Existe mas de un titulo con su palabra parcial." + Environment.NewLine + "Sea un poco m�s espec�fico o intente con t�tulo completo.",
                                            "Coincidencia de resultados.", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);

                        }

                        break;
                        
                    default:
                    break;
                }
            }
            else if (txtBusqueda_Prestamo.TextLength == 0) //Si la barra de busqueda esta vacia, pedir texto antes de correr el programa
            {
                MessageBox.Show("Ingrese texto en la barra de busqueda para proseguir.", "Sin parametros de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Una vez encontrado el ejemplar, hacer clic en la imagnen para verificar si esta disponible para prestamo o reserva
        private void picFoundItem_Prestamo_Click(object sender, EventArgs e)
        {
            if(PrestamoDAO.VerifyPrestamo(Buscado, DateTime.Now)) //El tiempo a comparar es el del momento en el que la aplicacion esta corriendo
            {
                MessageBox.Show("Actualmente, el libro no esta disponible. Se encuentra prestado, pero puede reservarlo", "No disponible",
                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Exclamation);

                using (frmRegistroReserva nuevaVentana = new frmRegistroReserva(Buscado))
                {
                    nuevaVentana.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Actualmente, el libro esta disponible. Puede prestarlo.", "Disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);

                using (frmRegistroPrestamo nuevaVentana = new frmRegistroPrestamo(Buscado))
                {
                    nuevaVentana.ShowDialog();
                }
            }
        }
    }
}