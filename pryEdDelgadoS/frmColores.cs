using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdDelgadoS
{
    public partial class frmColores : Form
    {
        public frmColores()
        {
            InitializeComponent();
        }

        private void lstColores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
           clsArchivo x = new clsArchivo();
            x.Grabar(txtNombreColor.Text);
            MessageBox.Show("Datos Grabado!");
            txtNombreColor.Text = "";
        }

        private void txtNombreColor_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreColor.Text == "")
            {
                cmdGrabar.Enabled = false;
            }
            else
            { 
                cmdGrabar.Enabled = true;
            }
        }

        private void frmColores_Load(object sender, EventArgs e)
        {
            cmdGrabar.Enabled = false;
        }
    }
}
