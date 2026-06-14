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
    public partial class frmGrafo : Form
    {
        public frmGrafo()
        {
            InitializeComponent();
        }
        clsGrafo objGrafo = new clsGrafo();
        private void cmdCargar_Click(object sender, EventArgs e)
        {
            int origen = cbOrigen.SelectedIndex;
            int destino = cbDestino.SelectedIndex;
            decimal precio = Convert.ToDecimal(txtPrecio.Text);

            objGrafo.Agregar(origen, destino, precio);
            MessageBox.Show("Ruta cargada exitosamente.");
            objGrafo.MostrarTodo(dgvGrilla);
            txtPrecio.Clear();
        }

        

        private void frmGrafo_Load(object sender, EventArgs e)
        {
            objGrafo.MostrarCiudades(cbOrigen);
            objGrafo.MostrarCiudades(cbDestino);

            objGrafo.MostrarCiudades(cbOrigen2);
            objGrafo.MostrarCiudades(cbDestino2);

          
            objGrafo.MostrarCiudades(cbDesde);
            objGrafo.MostrarCiudades(cbHasta);
            objGrafo.MostrarTodo(dgvGrilla);
        }

        private void cmdListarDestinos_Click(object sender, EventArgs e)
        {
            int origen = cbDesde.SelectedIndex;
            
            objGrafo.MostrarDestinos(origen, dgvGrilla);
        }

        private void cmdListarOrigenes_Click(object sender, EventArgs e)
        {
            
            int origenIdx = cbDesde.SelectedIndex;
            int destinoIdx = cbHasta.SelectedIndex;

            decimal precio = objGrafo.Consultar(origenIdx, destinoIdx);

            dgvGrilla.Rows.Clear();
            dgvGrilla.Columns.Clear();

            dgvGrilla.Columns.Add("ColOrigen", "Origen");
            dgvGrilla.Columns.Add("ColDestino", "Destino");
            dgvGrilla.Columns.Add("ColPrecio", "Precio");

            string ciudadOrigen = cbDesde.Text;
            string ciudadDestino = cbHasta.Text;

            // 6. Agregamos la fila con la información detallada
            dgvGrilla.Rows.Add(ciudadOrigen, ciudadDestino, precio);
        }

        private void cmdVerTodo_Click(object sender, EventArgs e)
        {
            objGrafo.MostrarTodo(dgvGrilla);
        }

        private void cmdBorrarTodo_Click(object sender, EventArgs e)
        {
            objGrafo.BorrarTodo();
            MessageBox.Show("Todos los datos del grafo han sido borrados.");
            objGrafo.MostrarTodo(dgvGrilla);
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            int origen = cbOrigen2.SelectedIndex;
            int destino = cbDestino2.SelectedIndex;

            objGrafo.Eliminar(origen, destino);

            MessageBox.Show("La ruta seleccionada fue eliminada exitosamente.");
            objGrafo.MostrarTodo(dgvGrilla);
        }
    }
    
}
