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
    public partial class frmMeses : Form
    {
        public frmMeses()
        {
            InitializeComponent();
        }

        private void frmMeses_Load(object sender, EventArgs e)
        {

        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo meses = new clsArchivo();
            meses.NomArchi = "Meses.txt";
            meses.Grabar(txtNombreMes.Text);
            MessageBox.Show("Datos Grabados");
            meses.Recorrer(lstMeses);
            txtNombreMes.Text = "";
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo meses = new clsArchivo();
            meses.NomArchi = "Meses.txt";
            meses.BorrarTodo();
            meses.Recorrer(lstMeses);
            MessageBox.Show("Datos Borrados");
            txtNombreMes.Clear();
        }

        private void txtNombreMes_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreMes.Text.Trim() != "")
            {
                cmdGrabar.Enabled = true;
            }
            else
            {
                cmdGrabar.Enabled = false;
            }
        }
    }
}
