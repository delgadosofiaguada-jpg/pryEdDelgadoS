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
    public partial class frmBdOperaciones : Form
    {
        public frmBdOperaciones()
        {
            InitializeComponent();
        }
        clsBaseDatos bd = new clsBaseDatos();
        private void cmdProySimple_Click(object sender, EventArgs e)
        {
            String varSQL="SELECT TITULO " +
                          "FROM LIBRO " +
                          "ORDER BY 1 DESC";
            bd.Listar( dgvBaseDatos, varSQL);
        }

        private void cmdProyMulti_Click(object sender, EventArgs e)
        {
            String varSQL = "SELECT TITULO, AÑO " +
                          "FROM LIBRO " +
                          "ORDER BY TITULO ASC";
            bd.Listar(dgvBaseDatos, varSQL);
        }
    }
}
