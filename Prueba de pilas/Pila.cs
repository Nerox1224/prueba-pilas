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
        Nodo tail;
        int limit, cant;
        public Pila()
        {
            tail = null;
            cant = 0;
            limit = 10;
        }
        public Pila(int limit)
        {
            tail = null;
            cant = 0;
            this.limit = limit;
        }

        bool vacio() => cant == 0;
        bool lleno() => cant == limit;

        public void Apilar(Cliente datos)
        {
            if (lleno()) { MessageBox.Show("Pila llena"); return; }

            Nodo nuevo = new Nodo(datos);
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
        public void Imprimir(DataGridView dataG, Cliente datos)
        {
            dataG.Rows.Clear();
            if (datos == null) { MessageBox.Show("Cliente no encontrado en lista"); return; }
            dataG.Rows.Add(datos?.codigo, datos?.nombre, datos?.apellido, datos?.precio);
        }

        public Cliente Buscar(int codigo)
        {
            Nodo buscar = tail;
            while (buscar != null)
            {
                if (buscar.datos.codigo == codigo) return buscar.datos;
                buscar = buscar.next;
            }
            return null;
        }
        public decimal Promedio()
        {
            if (vacio()) return 0;
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
        public void Eliminar(int codigo)
        {
            if (vacio()) { MessageBox.Show("Pila vacia"); return; }

            if (tail.datos.codigo == codigo) { Desapilar(); return; }
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
