using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryEdDelgadoS
{
    internal class clsArbolBinario
    {
        private clsNodo Pri;

        public clsNodo Raiz
        {
            get { return Pri; }
            set {Pri =value; }
        }

        public void Agregar(clsNodo Nvo)
        {
            if (Raiz == null)
            {
                Raiz = Nvo;
            }
            else
            {
                clsNodo P = Raiz;//ant
                clsNodo Aux = Raiz;
                while (Aux != null)
                {
                    P = Aux;
                    if (Nvo.Codigo < Aux.Codigo)
                    {
                        Aux = Aux.Izquierdo;
                    }
                    else
                    {
                        Aux = Aux.Derecho;
                    }
                }

                if (Nvo.Codigo < P.Codigo)
                {
                    P.Izquierdo = Nvo;
                }
                else
                {
                    P.Derecho = Nvo;
                }
            }
        }
        

        //Cargar en la grilla
        public void Recorrer(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            InOrdenAsc(Grilla, Raiz);
        }

        private void InOrdenAsc(DataGridView Dgv, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Dgv, R.Izquierdo);
            }
            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);
            if (R.Derecho != null)
            {
                InOrdenAsc(Dgv, R.Derecho);
            }
        }
        private void PreOrden(DataGridView Dgv, clsNodo R)
        {
            if (R == null) return;

            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);  // primero el nodo

            if (R.Izquierdo != null)
            {
                PreOrden(Dgv, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PreOrden(Dgv, R.Derecho);
            }
        }

        private void PostOrden(DataGridView Dgv, clsNodo R)
        {
            if (R == null) return;

            if (R.Izquierdo != null)
            {
                PostOrden(Dgv, R.Izquierdo);
            }
            if (R.Derecho != null)
            {
                PostOrden(Dgv, R.Derecho);
            }

            Dgv.Rows.Add(R.Codigo, R.Nombre, R.Tramite);  // último el nodo
        }
        //RECORRER GRILLA PRE-ORDEN Y POST-ORDEN
        public void RecorrerPreOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PreOrden(Grilla, Raiz);
        }

        public void RecorrerPostOrden(DataGridView Grilla)
        {
            Grilla.Rows.Clear();
            PostOrden(Grilla, Raiz);
        }



        //Mostrar en el TreeView/Arbol
        private void PreOrden(clsNodo R, TreeNode nodoTreeView)
        {
            TreeNode NodoPadre = new TreeNode(R.Codigo.ToString());
            nodoTreeView.Nodes.Add(NodoPadre);
            if(R.Izquierdo != null)
            {
                PreOrden(R.Izquierdo, NodoPadre);
            }
            if(R.Derecho != null)
            {
                PreOrden(R.Derecho, NodoPadre);
            }

        }

        public void Recorrer(TreeView tree)
        {
            tree.Nodes.Clear();
            TreeNode NodoPadre = new TreeNode("Árbol");
            tree.Nodes.Add(NodoPadre);
            PreOrden(Raiz,NodoPadre);
            tree.ExpandAll();
        }




        //Sobrecarga para combobox
        public void Recorrer(ComboBox Lista)
        {
            Lista.Items.Clear();
            InOrdenAsc(Lista, Raiz);
        }
        private void InOrdenAsc(ComboBox Lst, clsNodo R)
        {
            if (R.Izquierdo != null)
            {
                InOrdenAsc(Lst, R.Izquierdo);
            }
            Lst.Items.Add(R.Codigo);
            if (R.Derecho != null)
            {
                InOrdenAsc(Lst, R.Derecho);
            }
        }




        //Sobrecarga a un vector
        private void InOrdenAsc(int[] Vec, clsNodo R, ref int i)
        {
            //ref: Evita que se pisen los datos, compartiendo el mismo i e incrementandolo
           
            if(R.Izquierdo !=null)
            {
                InOrdenAsc(Vec, R.Izquierdo, ref i);
            }
            Vec[i] = R.Codigo;
            i++;
            if(R.Derecho !=null)
            {
                InOrdenAsc(Vec, R.Derecho, ref i);
            }
        }   
        public void Recorrer(int[] Vector)
        {
            int indice = 0;
            InOrdenAsc(Vector, Raiz, ref indice);
        }
    }
}

    
