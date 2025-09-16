using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_de_pilas
{
    public class Nodo
    {
        public Cliente datos;
        public Nodo next;

        public Nodo(Cliente datos)
        {
            this.datos = datos;
            next = null;
        }
    }
}
