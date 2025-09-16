using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Prueba_de_pilas
{
    public class Cliente
    {
        public int codigo { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public decimal precio { get; set; }
        public Cliente()
        {
            this.codigo = 0;
            this.nombre = "";
            this.apellido = "";
            this.precio = 0;
        }
        public Cliente(int codigo,string nombre,string apellido,decimal precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.apellido = apellido;
            this.precio = precio;
        }
    }
}
