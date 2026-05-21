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
    public partial class frmArbol : Form
    {
        public frmArbol()
        {
            InitializeComponent();
        }

        private void frmArbol_Load(object sender, EventArgs e)
        {

        }
        clsArbolBinario objArbol = new clsArbolBinario();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
           
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            // Pasar el nodo al método Agregar
            objArbol.Agregar(Persona);

            //GRILLA
            objArbol.Recorrer(dgvListado);

            //ARBOL
            objArbol.Recorrer(trvArbol);

            //COMBOBOX
            objArbol.Recorrer(cbCodigo);

            //VECTOR
            int[] Vec = new int[10];
            objArbol.Recorrer(Vec);


            //LIMPIAR
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";
            txtCodigo.Focus();//Vuelve el cursor a la caja de texto codigo
        }

        private void rbInOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rbInOrden.Checked)
                objArbol.Recorrer(dgvListado);
        }

        private void rbPreOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPreOrden.Checked)
                objArbol.RecorrerPreOrden(dgvListado);
        }

        private void rbPostOrden_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPostOrden.Checked)
                objArbol.RecorrerPostOrden(dgvListado);
        }
    }
}
