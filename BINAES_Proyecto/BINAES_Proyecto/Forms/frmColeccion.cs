using System;
using System.Data;
using System.Windows.Forms;
using BINAES_Proyecto.BINAES_Proyecto;
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


            cmbActualizarGenero.DataSource = null;
            cmbActualizarGenero.ValueMember = "generoID";
            cmbActualizarGenero.DisplayMember = "generoNombre";
            cmbActualizarGenero.DataSource = GeneroDAO.CargarDatos();
            
            cmbActualizarTipo.DataSource = null;
            cmbActualizarTipo.ValueMember = "tipoID";
            cmbActualizarTipo.DisplayMember = "tipoNombre";
            cmbActualizarTipo.DataSource = GeneroDAO.CargarDatosTipo();

            cmbActualizarArea.DataSource = null;
            cmbActualizarArea.ValueMember = "areaID";
            cmbActualizarArea.DisplayMember = "areaNombre";
            cmbActualizarArea.DataSource = GeneroDAO.CargarDatosArea();

        }

        private void btnMostrarColeccion_Click(object sender, EventArgs e)
        {

      
                    dgvMostrarUser.DataSource = null;
                    dgvMostrarUser.DataSource = ColeccionDAO.MostrarColeccion();
               
             
        }


        private void btnCrearColeccion_Click(object sender, EventArgs e)
        {

            Coleccion col = new Coleccion();
            col.Coleccion_Nombre = txtNombreColeccion.Text;
            col.generoID = Convert.ToInt32(cmbGenero.SelectedValue.ToString());
            col.tipoID = Convert.ToInt32(cmbTipoColeccion.SelectedValue.ToString());
            col.areaID = Convert.ToInt32(cmbAreaColeccion.SelectedValue.ToString());
            
            GeneroDAO.IngresarColeccion(col);
            MessageBox.Show("Ingresado con éxito");
        }


        private void btnEliminarColeccion_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtidEliminarColeccion.Text);
            GeneroDAO.EliminarColeccion(id);

            MessageBox.Show("Colección con id: " + id + " eliminada con éxito");
        }

        private void btnActualizarColeccion_Click(object sender, EventArgs e)
        {
            Coleccion col = new Coleccion();
            col.Coleccion_ID = Convert.ToInt32(txtIDActualizarColeccion.Text);
            col.Coleccion_Nombre = txtActualizarColeccion.Text;
            col.generoID = Convert.ToInt32(cmbActualizarGenero.SelectedValue);
            col.tipoID = Convert.ToInt32(cmbActualizarTipo.SelectedValue);
            col.areaID = Convert.ToInt32(cmbActualizarArea.SelectedValue);
            
            GeneroDAO.ActualizarColeccion(col);
            MessageBox.Show("datos actualizados");
        }

        
    }
}
