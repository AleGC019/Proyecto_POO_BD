using System;
using System.Windows.Forms;

namespace BINAES_Proyecto
{
    public partial class frmActualizarPalabraClave : Form
    {
        public frmActualizarPalabraClave()
        {
            InitializeComponent();
        }
        

        private void btnActualizarAgregarPalabra_Click(object sender, EventArgs e)
        {
            Palabras_Clave pc = new Palabras_Clave();
                pc.ID = Convert.ToInt32(txtIDPalabra.Text);
                pc.palabra = txtActualizarPalabra.Text;
                pc.ejemplarID_Palabra = Convert.ToInt32(txtIdEjemplar.Text);
                
                
                PalabrasClaveDAO.ActualizarPalabraClave(pc);
            
                MessageBox.Show("Actualizada con éxito");
                
            
        }


        private void frmActualizarPalabraClave_Load(object sender, EventArgs e)
        {
            dgvListaPalabras.DataSource = null;
            dgvListaPalabras.DataSource = PalabrasClaveDAO.PalabrasClave();
        }


        private void dgvListaPalabras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDPalabra.Text = dgvListaPalabras.CurrentRow.Cells[0].Value.ToString();
            txtActualizarPalabra.Text = dgvListaPalabras.CurrentRow.Cells[1].Value.ToString();
            txtIdEjemplar.Text = dgvListaPalabras.CurrentRow.Cells[2].Value.ToString();
        }
    }
}