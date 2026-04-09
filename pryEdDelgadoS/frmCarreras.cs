using System;
using System.Windows.Forms;

namespace pryEdDelgadoS
{
    public partial class frmCarreras : Form
    {
        public frmCarreras()
        {
            InitializeComponent();
        }

        private void frmCarreras_Load(object sender, EventArgs e)
        {

        }
 
        private void cmdGrabarCarrera_Click(object sender, EventArgs e)
        {
            clsArchivo carrera = new clsArchivo();
            carrera.NomArchi = "Carrera.csv";
            carrera.Grabar(txtCarrera.Text);
            MessageBox.Show("Datos Grabados");
            carrera.Recorrer(lstCarreras);
            txtCarrera.Text = "";

        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            clsArchivo carrera = new clsArchivo();
            carrera.NomArchi = "Carrera.csv";
            carrera.BorrarTodo();
            MessageBox.Show("Datos Eliminados");
            carrera.Recorrer(lstCarreras);
            txtCarrera.Text = "";
        }
    }
}
