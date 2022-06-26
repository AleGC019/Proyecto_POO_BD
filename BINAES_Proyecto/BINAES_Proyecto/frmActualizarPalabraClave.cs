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
        
        //Cick del botón Actualizar agregar palabra, edita la información de un ejemplar ya existente en la base de datos 
        private void btnActualizarAgregarPalabra_Click(object sender, EventArgs e)
        {
            if (txtActualizarPalabra.TextLength >0)
            {
                Palabras_Clave pc = new Palabras_Clave();
                pc.ID = Convert.ToInt32(txtIDPalabra.Text);
                pc.palabra = txtActualizarPalabra.Text;
                pc.ejemplarID_Palabra = Convert.ToInt32(txtIdEjemplar.Text);
                
                
                PalabrasClaveDAO.ActualizarPalabraClave(pc);
            
                MessageBox.Show("Actualizada con éxito");
            }
            else
            {
                MessageBox.Show("Campo vacío. Por favor ingrese la palabra clave del ejemplar", "Informacion invalida.", MessageBoxButtons.OK, MessageBoxIcon.Error  );

            }
            
                
            
        }

        //En el evento load del formulario frmActualizarPalabraClave, cargamos el data grid view con la lista de palabras claves
        private void frmActualizarPalabraClave_Load(object sender, EventArgs e)
        {
            dgvListaPalabras.DataSource = null;
            dgvListaPalabras.DataSource = PalabrasClaveDAO.PalabrasClave();
        }

        //Evento CellClick, cuando el usaurio da click en una celda, los text box se autorellenan con la información en la tabla 
        
        private void dgvListaPalabras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDPalabra.Text = dgvListaPalabras.CurrentRow.Cells[0].Value.ToString();
            txtActualizarPalabra.Text = dgvListaPalabras.CurrentRow.Cells[1].Value.ToString();
            txtIdEjemplar.Text = dgvListaPalabras.CurrentRow.Cells[2].Value.ToString();
        }
    }
}