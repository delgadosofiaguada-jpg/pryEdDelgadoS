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
            Validar();
        }

        private void cmdGrabarCliente_Click(object sender, EventArgs e)
        {
            clsArchivo clientes = new clsArchivo();
            clientes.NomArchi = "Clientes.csv";
            clientes.Grabar(mtbCodigoCliente.Text, txtNombreCliente.Text, txtDeuda.Text);
            clientes.Recorrer(dgvClientes);

        }
        private void Validar()
        {

            if (mtbCodigoCliente.Text != "" &&
                txtNombreCliente.Text != "" &&
                txtDeuda.Text != "")
            {
                cmdGrabarCliente.Enabled = true;
            }
            else
            {
                cmdGrabarCliente.Enabled = false;
            }
        }
        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo clientes = new clsArchivo();
            clientes.NomArchi = "Clientes.csv";
            clientes.BorrarTodo();
            clientes.Recorrer(dgvClientes);
            MessageBox.Show("Datos Borrados");
            mtbCodigoCliente.Clear();
            txtNombreCliente.Clear();
            txtDeuda.Clear(); 
        }

        private void mtbCodigoCliente_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Validar();
        }

        private void txtDeuda_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }
    }
}
