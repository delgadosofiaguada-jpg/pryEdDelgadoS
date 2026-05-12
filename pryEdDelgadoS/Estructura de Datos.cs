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
    public partial class EstructuradeDatos : Form
    {
        public EstructuradeDatos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void estructurasLinealesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void datosDelDesarrolladorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDatosdelDesarrollador v = new frmDatosdelDesarrollador();
            v.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmColores v = new frmColores();
            v.ShowDialog();
        }

        private void mesesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMeses v = new frmMeses();
            v.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes v = new frmClientes();
            v.ShowDialog();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlumnos v = new frmAlumnos();
            v.ShowDialog();
        }

        private void carrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void carrerasToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmCarreras v = new frmCarreras();
            v.ShowDialog();
        }

        private void colaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola v = new frmCola();
            v.ShowDialog();
        }

        private void pilaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form v = new frmPila();
            v.ShowDialog();
        }

        private void listaSimpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form v = new frmListaSimple();
            v.ShowDialog();
        }

        private void listaDobleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form v = new frmListaDoble();
            v.ShowDialog();
        }
    }
}
