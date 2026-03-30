using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Crear una libreria
using System.IO;

namespace pryEdDelgadoS
{
    internal class clsArchivo
    {
        //Campo
        public string NomArchi="Colores.txt";
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
    }

}

