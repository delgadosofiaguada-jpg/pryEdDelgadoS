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
    public partial class frmListaSimple : Form
    {
        public frmListaSimple()
        {
            InitializeComponent();
        }
        clsListaSimple objLista = new clsListaSimple();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x= new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;
             
            objLista.Agregar(x);
            objLista.Recorrer(dgvGrilla);
            objLista.Recorrer(cmbCodigo);
            objLista.Recorrer(lstLista);
            //objLista.Recorrer("clsListaSimple.csv");

            txtCodigo.Clear();
            txtNombre.Clear();
            txtTramite.Clear();


        }

        private void ValidarDatos()
        {
            if (txtCodigo.Text != "" && txtNombre.Text !="" && txtTramite.Text!="")
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
    }
}

