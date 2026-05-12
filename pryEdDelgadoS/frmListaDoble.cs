using System;
using System.Collections;
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
    public partial class frmListaDoble : Form
    {
        public frmListaDoble()
        {
            InitializeComponent();
        }
        clsListaDoble objListaD = new clsListaDoble();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x = new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;

            objListaD.Agregar(x);
            objListaD.Recorrer(dgvGrilla);
            objListaD.Recorrer(cbCodigo);
            objListaD.Recorrer(lstLista);
            objListaD.Recorrer("clsListaDoble.csv");

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();
        }

        private void frmListaDoble_Load(object sender, EventArgs e)
        {

        }
        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text != "" && txtTramite.Text != "")
            {
                cmdAgregar.Enabled = true;
            }
            else
            {
                cmdAgregar.Enabled = false;
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            ValidarDatos();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (objListaD.Primero != null)
            {
                Int32 x = Convert.ToInt32(cbCodigo.Text);
                objListaD.Eliminar(x);
                objListaD.Recorrer(dgvGrilla);
                objListaD.Recorrer(lstLista);
                objListaD.Recorrer(cbCodigo);
                objListaD.Recorrer("clsListaDoble.csv");
            }
            else
            {
                MessageBox.Show("No hay elementos para eliminar");
            }
            cmdEliminar.Enabled = false;
            cbCodigo.Text = "";
        }

        private void cbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCodigo.Text != "")
            {
                cmdEliminar.Enabled = true;
            }
            else
            {
                cmdEliminar.Enabled = false;
            }
        }

        private void rbAscendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAscendente.Checked == true)
            {
                objListaD.RecorrerAsc(dgvGrilla);
            }
           
        }

        private void rbDescendente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDescendente.Checked == true)
            {
                objListaD.RecorrerDes(dgvGrilla);
            }
        }
    }
}
