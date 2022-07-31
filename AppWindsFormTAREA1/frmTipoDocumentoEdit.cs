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
    public partial class frmTipoDocumentoEdit : Form
¨   {
        private int? Id;

        public frmTipoDocumentoEdit(int? id = null)
        {
            InitializeComponent();
            this.Id = id;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            var estado = chkEstado.Checked ? 1 : 0;
            var adaptador = new dsAppTableAdapters.TipoDocumentoTableAdapter();
            adaptador.Add(txtnom.Text, (byte)estado);
            this.Close();
        }

        private void frmTipoDocumentoEdit_Load(object sender, EventArgs e)
        {
            if (this.Id != null)
            {
                this.Text = "Editar";
                var adaptador = new dsAppTableAdapters.TipoDocumentoTableAdapter();
                var tabla =adaptador.GetDataById((int)this.Id);
                var fila = tabla.rows[0];
            }
            else
            {
                this.Text = "Nuevo";
            }
        }
    }
}
