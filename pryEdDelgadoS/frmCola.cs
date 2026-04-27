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
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }
        clsCola ColaEspera = new clsCola();
        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            clsNodo Persona = new clsNodo();
            Persona.Codigo = Convert.ToInt32(txtCodigo.Text);
            Persona.Nombre = txtNombre.Text;
            Persona.Tramite = txtTramite.Text;

            ColaEspera.Agregar(Persona);
            ColaEspera.Recorrer(dgvGrilla);
            ColaEspera.Recorrer("Cola.csv");
            ColaEspera.Recorrer(lstLista);

            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtTramite.Text = "";


        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            if (ColaEspera.Primero != null)
            {
                lblCod.Text = Convert.ToString(ColaEspera.Primero.Codigo);
                lblNom.Text = ColaEspera.Primero.Nombre;
                lblTram.Text = ColaEspera.Primero.Tramite;

                ColaEspera.Eliminar();
                ColaEspera.Recorrer(dgvGrilla);
                ColaEspera.Recorrer("Cola.csv");
                ColaEspera.Recorrer(lstLista);
            }
             else
             {
                lblCod.Text = "";
                lblNom.Text = "";
                lblTram.Text = "";
                MessageBox.Show("No hay personas para eliminar en la cola");
             }
        }

        private void frmCola_Load(object sender, EventArgs e)
        {

        }
    }
}
