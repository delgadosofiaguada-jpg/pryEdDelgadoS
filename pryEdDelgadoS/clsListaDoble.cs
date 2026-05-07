using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdDelgadoS
{
    internal class clsListaDoble
    {
        private clsNodo pri;
        private clsNodo ult;

        public clsNodo Primero
            {
                get { return pri; }
                set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        public void Agregar(clsNodo Nvo)
        {
            if (Primero == null)
            {
                Primero = Nvo;
                Ultimo = Nvo;
            }
            else
            {
                if (Nvo.Codigo < Primero.Codigo)
                {
                    Nvo.Siguiente = Primero;
                    Primero.Anterior = Nvo;
                    Primero = Nvo;
                }
                else
                {
                    if (Nvo.Codigo > Ultimo.Codigo)
                    {
                        Ultimo.Siguiente = Nvo;
                        Nvo.Anterior = Ultimo;
                        Ultimo = Nvo;
                    }
                    else
                    { 
                        clsNodo aux = Primero;
                        clsNodo ant = null;
                        while (aux.Codigo > Nvo.Codigo)
                        {
                            ant = aux;
                            aux = aux.Siguiente;
                        }
                        ant.Siguiente = Nvo;
                        Nvo.Siguiente = aux;
                        aux.Anterior = Nvo;
                        Nvo.Anterior = ant;
                    }
                }
            }
        }
        public void Recorrer(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.Codigo, aux.Nombre, aux.Tramite);
                aux = aux.Anterior;
            }
        }
        public void Eliminar(Int32 Codigo)
        {
            if (Primero.Codigo==Codigo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                 if (Primero.Codigo == Codigo)
                 {
                        Primero = Primero.Siguiente;
                        Primero.Anterior = null;
                 }
                 else
                 {
                        if (Ultimo.Codigo == Codigo)
                        {
                            Ultimo = Ultimo.Anterior;
                            Ultimo.Siguiente = null;
                        }
                        else
                        {
                            clsNodo aux = Primero;
                            clsNodo ant = Primero;
                            while (aux.Codigo < Codigo)
                            {
                                ant = aux;
                                aux = aux.Siguiente;
                            }
                            aux= aux.Siguiente;
                            ant.Siguiente = aux;
                            aux.Anterior = ant;
                        }
                 }
            }

            
        }
    }
}

