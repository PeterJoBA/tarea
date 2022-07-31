using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWindsFormTAREA1
{
    public partial class frmTipoDoc : Form
    {
        public frmTipoDoc()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos()
        {
            var adaptador = new dsAppTableAdapters.TipoDocumentoTableAdapter();
            var tabla = adaptador.GetData();
            dgvDatos.DataSource = tabla;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            var frm = new frmTipoDocumentoEdit();
            frm.ShowDialog();
            cargarDatos();


        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            int id = getId();
            if (id > 0)
            {
                var frm = new frmTipoDocumentoEdit(id);
                frm.ShowDialog();
                cargarDatos();
            } else
            {
                MessageBox.Show("Selecione un ID Valido", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        private int getId()
        {
            try
            {
                    DataGridViewRow filaActual = dgvDatos.CurrentRow;
                    if (filaActual == null)
                    {
                        return 0;
                    }
                }
            catch (Exception)
            {

                return 0;
            }
            
          
        }
    }
}
