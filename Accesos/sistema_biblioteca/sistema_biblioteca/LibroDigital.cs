using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_biblioteca
{
    internal class LibroDigital : libro
    {
        private double tamanoArchivo; // en MB

        public LibroDigital(string titulo, string autor, int paginas, double tamanoArchivo)
            : base(titulo, autor, paginas)
        {
            this.tamanoArchivo = tamanoArchivo;
        }

        public void MostrarResumenDigital()
        {
            string resumen = GenerarResumen();
            Console.WriteLine($"{resumen} Tamaño del archivo: {tamanoArchivo} MB.");
        }
    }
}
