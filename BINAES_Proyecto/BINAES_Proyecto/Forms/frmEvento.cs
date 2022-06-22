using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BINAES_Proyecto.Forms
{
    public partial class frmEvento : Form
    {
        public frmEvento()
        {
            InitializeComponent();
        }

        
        
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cmbEvento.Text == "Nombre del evento") // Aqui pones el nombre que le hayas puesto a la combobox
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
        
        private void btnAgregar_click(object sender, EventArgs e)
        {
            OpenFileDialog obtener = new OpenFileDialog();
            obtener.InitialDirectory = "C:\\";
            obtener.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)| *.jpg; *.jpeg; *.gif; *.bmp, *.png";
            /*
            if(obtener.ShowDialog() = DialogResult.OK)
            {
                imagen = obtener.FileName;
            }
            else
            {
                MessageBox.Show("No se ha seleccionado una foto");
            }
            */
        }


        private void frmEvento_Load(object sender, EventArgs e)
        {
            cmbEArea.DataSource = null;
            cmbEArea.ValueMember = "areaID";
            cmbEArea.DisplayMember = "areaNombre";
            cmbEArea.DataSource = EventoDAO.CargarDatosArea();




            dtpIniico.Format = DateTimePickerFormat.Time;

            dtpFinalizacion.Format = DateTimePickerFormat.Time;

        }

        private void btnAgregarE_Click(object sender, EventArgs e)
        {
            
            Evento eve = new Evento();

            eve.Titulo_Evento = txtNombreE.Text;
            eve.Cantidad_de_asistentes = Convert.ToInt32(nudCantidad.Value);
            eve.id_area = Convert.ToInt32(cmbEArea.SelectedValue);
            eve.Inicio_del_vento = Convert.ToDateTime(dtpIniico.Value);
            eve.Finalizacion_del_evento = Convert.ToDateTime(dtpFinalizacion.Value);
            eve.Portada = "0000";
            eve.Objetivos = txtobjetivo.Text;
            
            EventoDAO.IngresarEvento(eve);
            MessageBox.Show("Ingresado con exito");
        }
    }
}