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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdGrabarCliente_Click(object sender, EventArgs e)
        {
            clsArchivo clientes = new clsArchivo();
            clientes.NomArchi = "Clientes.csv";
            clientes.Grabar(txtCaodigo.Text, txtNombreCliente.Text, txtDeuda.Text);
            MessageBox.Show("Datos Grabados");
            //clientes.Recorrer(lstCarreras);
            //txtCarrera.Text = "";
        }
    }
}
