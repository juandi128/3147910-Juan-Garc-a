using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE BIBLIOTECA DIGITAL ===\n");

            // Crear objetos de tipo Libro y LibroDigital
            libro libro1 = new libro("Cien Años de Soledad", "Gabriel García Márquez", 417);
            LibroDigital libro2 = new LibroDigital("1984", "George Orwell", 328, 1.8);

            // Mostrar información
            Console.WriteLine("📗 Libro físico:");
            libro1.MostrarDatos();

            Console.WriteLine("\n📘 Libro digital:");
            libro2.MostrarResumenDigital();

            // Modificar número de páginas (solo personal autorizado)
            Console.WriteLine("\n🔧 Modificación de páginas del libro físico...");
            libro1.ModificarPaginasBiblioteca(420);
            libro1.MostrarDatos();

            Console.ReadKey();
        }
    }
}
