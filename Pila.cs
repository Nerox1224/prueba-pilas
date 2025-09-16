using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prueba_de_pilas
{
    public class Pila
    {
        Nodo header, tail;
        int limit, cant;
        public Pila()
        {
            header = tail = null;
            cant = 1;
            limit = 10;
        }
        public Pila(int limit)
        {
            header = tail = null;
            cant = 1;
            this.limit = limit;
        }

        bool vacio()
        {
            if (cant == 0) return true;
            else return false;
        }
        bool lleno()
        {
            if (cant == limit) return true;
            else return false;
        }
        public void Apilar(Cliente datos)
        {
            if (lleno()) { MessageBox.Show("Pila llena"); return; }

            Nodo nuevo = new Nodo(datos);
            if (header == null) { header = tail = nuevo; return; }

            nuevo.next = tail;
            tail = nuevo;
            cant++;
            return;
        }
        public Cliente Desapilar()
        {
            if (vacio()) { MessageBox.Show("Pila vacia"); return null; }

            Cliente datos = tail.datos;
            tail = tail.next;
            cant--;
            return datos;
        }

        public void Imprimir(DataGridView dataG)
        {
            dataG.Rows.Clear();
            Nodo print = tail;
            while (print != null)
            {
                dataG.Rows.Add(print.datos.codigo, print.datos.nombre, print.datos.apellido, print.datos.precio);
                print = print.next;
            }
        }
        public void Buscar(int codigo, DataGridView dataG)
        {
            bool encontrado = false;
            dataG.Rows.Clear();
            Nodo buscar = tail;
            while (buscar != null)
            {
                if (buscar.datos.codigo == codigo)
                {
                    dataG.Rows.Add(buscar.datos.codigo, buscar.datos.nombre, buscar.datos.apellido, buscar.datos.precio);
                    encontrado = true;
                }
                buscar = buscar.next;
            }
            if (encontrado == false) MessageBox.Show("No se encontro el cliente en la pila");
        }
        public decimal Promedio()
        {
            if (!vacio())
            {
                decimal total = 0;
                long cant = 0;
                Nodo valor = tail;
                while (valor != null)
                {
                    total += valor.datos.precio;
                    cant++;
                    valor = valor.next;
                }
                return total / cant;
            }
            return 0;
        }
        public void Eliminar(int codigo)
        {
            if (vacio()) { MessageBox.Show("Pila vacia"); return; }
            Pila aux = new Pila();
            while (!vacio())
            {
                Cliente datos = Desapilar();
                if (datos.codigo != codigo) aux.Apilar(datos);
            }

            while (!aux.vacio()) Apilar(aux.Desapilar());
        }
    }
}
