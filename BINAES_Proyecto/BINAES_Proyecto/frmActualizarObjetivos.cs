using System;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    public partial class frmActualizarObjetivos : Form
    {
        public frmActualizarObjetivos()
        {
            InitializeComponent();
        }

        //En el evento load del formulario frmActualizarObjetivos, cargamos el data grid view con la lista de objetivos
        private void frmActualizarObjetivos_Load(object sender, EventArgs e)
        {
            dgvListaObjetivos.DataSource = null;
            dgvListaObjetivos.DataSource = ObjetivosDAO.ListaObjetivos();

        }

       //Cick del botón Actualizar objetivos, edita la información de un ejemplar ya existente en la base de datos 

        private void btnActualizarObjetivo_Click(object sender, EventArgs e)
        {
            if (txtActualizarObjetivo.TextLength > 0)
            {
                Objetivos obj = new Objetivos();
                obj.ID = Convert.ToInt32(txtIDObjetivo.Text);
                obj.objetivo = txtActualizarObjetivo.Text;
                obj.id_evento_objetivos = Convert.ToInt32(txtIDEvento.Text);
                
                
                ObjetivosDAO.ActualizarObjetivos(obj);
            
                MessageBox.Show("Actualizado con éxito");
            }
            else
            {
                MessageBox.Show("Campo vacío. Por favor ingrese uno de los objetivos del evento", "Informacion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error  );

            }
           
           
        }

        //Evento CellClick, cuando el usaurio da click en una celda, los text box se autorellenan con la información en la tabla 

        private void dgvListaObjetivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDObjetivo.Text = dgvListaObjetivos.CurrentRow.Cells[0].Value.ToString();
            txtActualizarObjetivo.Text = dgvListaObjetivos.CurrentRow.Cells[2].Value.ToString();
            txtIDEvento.Text = dgvListaObjetivos.CurrentRow.Cells[1].Value.ToString();
        }
    }
}