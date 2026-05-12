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
    public partial class frmPila : Form
    {
        public frmPila()
        {
            InitializeComponent();
        }
        clsPila objPila = new clsPila();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo x= new clsNodo();
            x.Codigo = Convert.ToInt32(txtCodigo.Text);
            x.Nombre = txtNombre.Text;
            x.Tramite = txtTramite.Text;
           
            objPila.Agregar(x);
            objPila.Recorrer(dgvGrilla);
            objPila.Recorrer("Pila.csv");
            objPila.Recorrer(lstPila);
            

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";

        }
        private void Validar()
        {

            if (txtCodigo.Text != "" &&
                txtNombre.Text != "" &&
                txtTramite.Text != "")
            {
                cmdAgregar.Enabled = true;
            }
            else
            {
                cmdAgregar.Enabled = false;
            }
        }
        private void frmPila_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void gbNuevoElemento_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtTramite_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (objPila.Primero != null)
            {
                lblCod.Text = Convert.ToString(objPila.Primero.Codigo);
                lblNom.Text = objPila.Primero.Nombre;
                lblTram.Text = objPila.Primero.Tramite;

                objPila.Eliminar();
                objPila.Recorrer(dgvGrilla);
                objPila.Recorrer("Pila.csv");
                objPila.Recorrer(lstPila);
                
            }
            else
            {
                lblCod.Text = "";
                lblNom.Text = "";
                lblTram.Text = "";
                MessageBox.Show("No hay personas para eliminar en la cola");
            }
        }
    }
}
