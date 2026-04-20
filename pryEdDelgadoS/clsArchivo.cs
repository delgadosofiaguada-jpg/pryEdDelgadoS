using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear una libreria
using System.IO;
using System.Windows.Forms;

namespace pryEdDelgadoS
{
    internal class clsArchivo
    {
        //Campo
        public string NomArchi = "Colores.txt";

        public void BorrarTodo()
        {
            StreamWriter AD = new StreamWriter(NomArchi, false);
            AD.Close();
        }

        public void Grabar()
        {
            StreamWriter AD = new StreamWriter(NomArchi);
            AD.WriteLine("Hola");
            AD.Close();
        }
        public void Grabar(string Dato)
        {
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.WriteLine(Dato);
            AD.Close();
        }
        public void Grabar(String cod, String nom, String deu)
        {
            StreamWriter AD = new StreamWriter(NomArchi, true);
            AD.Write(cod);
            AD.Write(";");
            AD.Write(nom);
            AD.Write(";");
            AD.WriteLine(deu);
            AD.Close();
        }

        public void Recorrer(ListBox lstDatos)
        {
            lstDatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                lstDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(DataGridView Grilla)
        {

            String DatoLeido = "";
            Grilla.Rows.Clear();
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                Grilla.Rows.Add(DatoLeido.Split(';'));
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

        public void Recorrer(ComboBox cboDatos)
        {
            cboDatos.Items.Clear();
            String DatoLeido = "";
            StreamReader AD = new StreamReader(NomArchi);
            DatoLeido = AD.ReadLine();
            while (DatoLeido != null)
            {
                cboDatos.Items.Add(DatoLeido);
                DatoLeido = AD.ReadLine();
            }
            AD.Close();
        }

    }}



