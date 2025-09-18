using System.Diagnostics;

namespace Prueba_de_pilas
{
    public partial class Form1 : Form
    {
        Pila pila = new Pila(10);
        public Form1()
        {
            InitializeComponent();
            pila.Apilar(new Cliente(1, "grsbs", "gsrg", 15));
            pila.Apilar(new Cliente(2, "grsbs", "gsrg", 10));
            pila.Apilar(new Cliente(3, "grsbs", "gsrg", 16));
            pila.Apilar(new Cliente(4, "grsbs", "gsrg", 56));
            pila.Apilar(new Cliente(5, "grsbs", "gsrg", 65));
            pila.Apilar(new Cliente(6, "grsbs", "gsrg", 12));
            pila.Apilar(new Cliente(7, "grsbs", "gsrg", 98));
            pila.Apilar(new Cliente(8, "grsbs", "gsrg", 30));
            pila.Apilar(new Cliente(9, "grsbs", "gsrg", 089));
            pila.Apilar(new Cliente(10, "grsbs", "gsrg", 0.56m));
            pila.Imprimir(tabla);
        }

        private void Apilar_Click(object sender, EventArgs e)
        {
            int.TryParse(txtCodigo?.Text, out var code);
            decimal.TryParse(txtPrecio?.Text, out var price);
            pila.Apilar(new Cliente(code, txtNombre?.Text, txtApellido?.Text, price));
            pila.Imprimir(tabla);
        }

        private void Desapilar_Click(object sender, EventArgs e)
        {
            pila.Desapilar();
            pila.Imprimir(tabla);
        }

        private void Promedio_Click(object sender, EventArgs e)
        {
            decimal promedio = pila.Promedio();
            txtPromedio.Text = promedio.ToString("N2");
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            int.TryParse(txtBusqueda?.Text, out var code);
            pila.Imprimir(tabla, pila.Buscar(code));
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            if (tabla.Rows.Count == 0) return;
            int.TryParse(tabla.CurrentRow.Cells["Codigo"]?.Value.ToString(), out var code);
            pila.Eliminar(code);
            pila.Imprimir(tabla);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void Imprimir_Click(object sender, EventArgs e)
        {
            pila.Imprimir(tabla);
        }
    }
}
