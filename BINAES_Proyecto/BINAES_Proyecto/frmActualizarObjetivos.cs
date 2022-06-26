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

        private void frmActualizarObjetivos_Load(object sender, EventArgs e)
        {
            dgvListaObjetivos.DataSource = null;
            dgvListaObjetivos.DataSource = ObjetivosDAO.ListaObjetivos();

        }

        private void btnActualizarObjetivo_Click(object sender, EventArgs e)
        {
            Objetivos obj = new Objetivos();
            obj.ID = Convert.ToInt32(txtIDObjetivo.Text);
            obj.objetivo = txtActualizarObjetivo.Text;
            obj.id_evento_objetivos = Convert.ToInt32(txtIDEvento.Text);
                
                
           ObjetivosDAO.ActualizarObjetivos(obj);
            
            MessageBox.Show("Actualizado con éxito");
           
        }

        private void dgvListaObjetivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDObjetivo.Text = dgvListaObjetivos.CurrentRow.Cells[0].Value.ToString();
            txtActualizarObjetivo.Text = dgvListaObjetivos.CurrentRow.Cells[2].Value.ToString();
            txtIDEvento.Text = dgvListaObjetivos.CurrentRow.Cells[1].Value.ToString();
        }
    }
}