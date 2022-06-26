using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using BINAES_Proyecto.Properties;

namespace BINAES_Proyecto.Forms
{
    public partial class frmEvento : Form
    {
        public frmEvento()
        {
            InitializeComponent();
        }


        //Click del botón buscar, nos permite buscar eventos
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cmbEvento.Text == "Nombre del evento") 
            {
                List<Evento> resultado = EventoDAO.NombreEvento(txtBuscarEvento.Text.Trim());
                txtBuscarEvento.Clear();

                dgvEvento.DataSource = null;
                dgvEvento.DataSource = resultado;



                dgvEvento.Columns["ID"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Titulo_Evento"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;


                dgvEvento.Columns["Portada"].Visible = false;
                dgvEvento.Columns["id_area"].Visible = false;


                dgvEvento.Columns["Cantidad_de_asistentes"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Inicio_del_vento"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Finalizacion_del_evento"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Area"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Objetivos"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;

            }

            else
            {
                List<Evento> resultado = EventoDAO.Eventos();
                txtBuscarEvento.Clear();

                dgvEvento.DataSource = null;
                dgvEvento.DataSource = resultado;

                dgvEvento.Columns["ID"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Titulo_Evento"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;


                dgvEvento.Columns["Portada"].Visible = false;
                dgvEvento.Columns["id_area"].Visible = false;


                dgvEvento.Columns["Cantidad_de_asistentes"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Inicio_del_vento"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Finalizacion_del_evento"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Area"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                dgvEvento.Columns["Objetivos"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;



            }
        }


        
        public string imagen { get; set; }
        
        
        //Click del botón agregar imagen 
        private void btnAgregar_click(object sender, EventArgs e)
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

        //En el evento load cargamos todos los comboBox que estaremos utilizando en el forumulario de eventos
        private void frmEvento_Load(object sender, EventArgs e)
        {
            cmbEArea.DataSource = null;
            cmbEArea.ValueMember = "areaID";
            cmbEArea.DisplayMember = "areaNombre";
            cmbEArea.DataSource = EventoDAO.CargarDatosArea();




            dtpIniico.Format = DateTimePickerFormat.Time;

            dtpFinalizacion.Format = DateTimePickerFormat.Time;

            //Cargando datos para tab actualizar evento 

            cmbActualizarEventoArea.DataSource = null;
            cmbActualizarEventoArea.ValueMember = "areaID";
            cmbActualizarEventoArea.DisplayMember = "areaNombre";
            cmbActualizarEventoArea.DataSource = EventoDAO.CargarDatosArea();

            dtpActualizarFechaInicio.Format = DateTimePickerFormat.Time;
            dtpActualizarFechaFin.Format = DateTimePickerFormat.Time;

        }
        
        //Click del botón agregar, con el cual podemos agregar mas eventos a la base de datos 
        private void btnAgregarE_Click(object sender, EventArgs e)
        {

            Evento eve = new Evento();

            eve.Titulo_Evento = txtNombreE.Text;
            eve.Cantidad_de_asistentes = Convert.ToInt32(nudCantidad.Value);
            eve.id_area = Convert.ToInt32(cmbEArea.SelectedValue);
            eve.Inicio_del_vento = Convert.ToDateTime(dtpIniico.Value);
            eve.Finalizacion_del_evento = Convert.ToDateTime(dtpFinalizacion.Value);
            eve.Portada = imagen;
            

            if (EventoDAO.VerificarDisponibilidadFechas(eve) == true)
            {
                EventoDAO.IngresarEvento(eve);
                MessageBox.Show("Ingresado con éxito");
            }
            else
            {
                MessageBox.Show("Este evento no puede ser ingresado, ya que el área será utilizada en ese horario");
            }


        }
            
        //Click del botón actualizar evento, nos permite actualizar la información de un evento 
        //que ya se encuentra en la base de datos 
        private void btnActualizarEvento_Click(object sender, EventArgs e)
        {
            Evento eve = new Evento();

            eve.Titulo_Evento = txtActualizarTituloEvento.Text;
            eve.Cantidad_de_asistentes = Convert.ToInt32(nudActualizarAsistentes.Value);
            eve.id_area = Convert.ToInt32(cmbActualizarEventoArea.SelectedValue);
            eve.Inicio_del_vento = Convert.ToDateTime(dtpActualizarFechaInicio.Value);
            eve.Finalizacion_del_evento = Convert.ToDateTime(dtpActualizarFechaFin.Value);
            eve.Imagen_evento = imagen;
           

            if (EventoDAO.VerificarDisponibilidadFechas(eve) == true)
            {
                EventoDAO.ActualizarEvento(eve);
                MessageBox.Show("Actualizado con éxito");
            }
            else
            {
                MessageBox.Show("Este evento no puede ser ingresado, ya que el área será utilizada en ese horario");
            }
        }
        
        //Click del botón Actualizar imagen, nos permite actualizar la imagen de un evento 

        private void btnActualizarImagenEvento_Click(object sender, EventArgs e)
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
        
        //Click del botón EliminarEvento, elimina un evento que se encuentra en la base de datos 
        // por medio del id que es ingresado por el usaurio 
        private void btnEliminarEvento_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtidEliminarEvento.Text);
            EventoDAO.EliminarEvento(id);

            MessageBox.Show("Evento con id: " + id + " eliminado con éxito");
        }

        //Click del botón Buscar ID, con este bóton regresamos la informacion asociada a un id especifico 
        private void btnBuscarIDEvento_Click(object sender, EventArgs e)
        {
            string cadena = Resources.Cadena_Conexion;
            using (SqlConnection connection = new SqlConnection(cadena))
            {

                SqlCommand command =
                    new SqlCommand(
                        "SELECT titulo, imagen, asistentes_cantidad, incio_evento_hora_fecha, finalizacion_evento_hora_fecha, id_area FROM EVENTO WHERE id = @id",
                        connection);
                command.Parameters.AddWithValue("@id", txtIDActualizarEvento.Text);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txtActualizarTituloEvento.Text = reader["titulo"].ToString();
                    imagen = reader["imagen"].ToString();
                    nudActualizarAsistentes.Value = Convert.ToInt32(reader["asistentes_cantidad"]);
                    dtpActualizarFechaInicio.Text = reader["incio_evento_hora_fecha"].ToString();
                    dtpActualizarFechaFin.Text = reader["finalizacion_evento_hora_fecha"].ToString();
                    cmbActualizarEventoArea.SelectedValue = Convert.ToInt32(reader["id_area"]);





                    connection.Close();


                }
            }
        }
        
        //Click del botón Objetivos de evento, este botón nos despliega el formulario frmObjetivos
        private void btnObjetivosEvento_Click(object sender, EventArgs e)
        {
            new frmObjetivos().Show();
        }

        //Click del botón Actualizar Objetivos, este botón nos despliega el formulario frmActualizarObjetivos
        private void btnActualizarObjetivos_Click(object sender, EventArgs e)
        {
            new frmActualizarObjetivos().Show();
        }
    }
}
