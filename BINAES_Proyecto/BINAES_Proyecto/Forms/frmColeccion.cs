using System;
using System.Data;
using System.Windows.Forms;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto.Forms
{
    public partial class frmColeccion : Form
    {
        public frmColeccion()
        {
            InitializeComponent();

        }

        private void frmColeccion_Load(object sender, EventArgs e)
        {

            cmbGenero.DataSource = null;
            cmbGenero.ValueMember = "generoID";
            cmbGenero.DisplayMember = "generoNombre";
            cmbGenero.DataSource = GeneroDAO.CargarDatos();

            cmbTipoColeccion.DataSource = null;
            cmbTipoColeccion.ValueMember = "tipoID";
            cmbTipoColeccion.DisplayMember = "tipoNombre";
            cmbTipoColeccion.DataSource = GeneroDAO.CargarDatosTipo();

            cmbAreaColeccion.DataSource = null;
            cmbAreaColeccion.ValueMember = "areaID";
            cmbAreaColeccion.DisplayMember = "areaNombre";
            cmbAreaColeccion.DataSource = GeneroDAO.CargarDatosArea();

        }

        private void btnMostrarColeccion_Click(object sender, EventArgs e)
        {
            dgvMostrarUser.DataSource = null;
            dgvMostrarUser.DataSource = GeneroDAO.CargarDatos();
        }


        private void btnCrearColeccion_Click(object sender, EventArgs e)
        {

            Coleccion col = new Coleccion();
            col.coleccionNombre = txtNombreColeccion.Text;
            col.generoID = Convert.ToInt32(cmbGenero.SelectedValue.ToString());
            col.tipoID = Convert.ToInt32(cmbTipoColeccion.SelectedValue.ToString());
            col.areaID = Convert.ToInt32(cmbAreaColeccion.SelectedValue.ToString());
            
            GeneroDAO.IngresarColeccion(col);
            MessageBox.Show("Ingresado con éxito");
        }
    }
}
