using System;
using System.Data;
using System.Data.SqlClient;
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
            //Quitar Columnas
            dgvMostrarUser.Columns["generoID"].Visible = false;
            dgvMostrarUser.Columns["tipoID"].Visible = false;
            dgvMostrarUser.Columns["areaID"].Visible = false;


        }


        private void btnCrearColeccion_Click(object sender, EventArgs e)
        {
            if(txtNombreColeccion.TextLength >0 && cmbGenero.Text.Length >0 && cmbTipoColeccion.Text.Length >0 && cmbAreaColeccion.Text.Length >0 ){
                Coleccion col = new Coleccion();
                col.Coleccion_Nombre = txtNombreColeccion.Text;
                col.generoID = Convert.ToInt32(cmbGenero.SelectedValue.ToString());
                col.tipoID = Convert.ToInt32(cmbTipoColeccion.SelectedValue.ToString());
                col.areaID = Convert.ToInt32(cmbAreaColeccion.SelectedValue.ToString());

                GeneroDAO.IngresarColeccion(col);
                MessageBox.Show("Ingresado con éxito");
            }
            else
            {
                MessageBox.Show("Por favor ingrese todos los campos requeridos", "Informacion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error  );

            }
        }


        private void btnEliminarColeccion_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtidEliminarColeccion.Text);
            GeneroDAO.EliminarColeccion(id);

            MessageBox.Show("Colección con id: " + id + " eliminada con éxito");
        }

        private void btnActualizarColeccion_Click(object sender, EventArgs e)
        {
            if (txtActualizarColeccion.TextLength > 0 && cmbActualizarGenero.Text.Length > 0 && cmbActualizarTipo.Text.Length > 0 &&
                cmbActualizarArea.Text.Length > 0)
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
            else
            {
                MessageBox.Show("Por favor ingrese todos los campos requeridos", "Informacion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error  );

            }
        }


        private void btnBuscarIDcoleccion_Click(object sender, EventArgs e)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {

                SqlCommand command =
                    new SqlCommand(
                        "SELECT nombre, id_genero, id_tipo, id_area FROM COLECCION WHERE id = @id",
                        connection);
                command.Parameters.AddWithValue("@id", txtIDActualizarColeccion.Text);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtActualizarColeccion.Text = reader["nombre"].ToString();
                    cmbActualizarGenero.SelectedValue = Convert.ToInt32(reader["id_genero"]);
                    cmbActualizarTipo.SelectedValue = Convert.ToInt32(reader["id_tipo"]);
                    cmbActualizarArea.SelectedValue = Convert.ToInt32(reader["id_area"]);
                    


                    connection.Close();


                }
            }
        }
    }
}

