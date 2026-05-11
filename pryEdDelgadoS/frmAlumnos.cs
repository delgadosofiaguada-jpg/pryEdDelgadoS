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
    public partial class frmAlumnos : Form
    {
        public frmAlumnos()
        {
            InitializeComponent();
        }

        private void cmdGrabar_Click(object sender, EventArgs e)
        {
            clsArchivo alumnos = new clsArchivo();
            alumnos.NomArchi = "Alumnos.csv";

            // Solo grabamos y actualizamos la grilla
            alumnos.Grabar(mtbCodigoAlumno.Text, txtNombreAlumno.Text, cmbCarrera.Text);
            alumnos.Recorrer(dgvAlumnos);
            mtbCodigoAlumno.Clear();
            txtNombreAlumno.Clear();
            cmbCarrera.SelectedIndex = -1;

        }
        

        private void frmAlumnos_Load(object sender, EventArgs e)
        {
            dgvAlumnos.Rows.Clear();
            clsArchivo carreras = new clsArchivo();
            carreras.NomArchi = "Carrera.csv";
            carreras.Recorrer(cmbCarrera);
        }

        private void Validar()
        {

            if (mtbCodigoAlumno.Text != "" &&
                txtNombreAlumno.Text != "" &&
                cmbCarrera.Text != "")
            {
                cmdGrabar.Enabled = true;
            }
            else
            {
                cmdGrabar.Enabled = false;
            }
        }

        private void cmbCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            Validar();
        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            
            clsArchivo x = new clsArchivo();
            x.NomArchi = "Alumnos.csv";
            x.BorrarTodo();
            x.Recorrer(dgvAlumnos);
            MessageBox.Show("Datos Borrados");
            mtbCodigoAlumno.Clear();
            txtNombreAlumno.Clear();
            cmbCarrera.SelectedIndex = -1;

        }

        private void mtbCodigoAlumno_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Validar();
        }

        private void txtNombreAlumno_TextChanged(object sender, EventArgs e)
        {
            Validar();
        }
    }
}
