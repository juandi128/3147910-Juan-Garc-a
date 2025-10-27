using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_biblioteca
{
    internal class libro
    {
        // Atributos privados (encapsulación)
        private string titulo;
        private string autor;
        private int paginas;

        // Constructor
        public libro(string titulo, string autor, int paginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }

        // Métodos públicos para consultar la información del libro
        public void MostrarDatos()
        {
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Páginas: {paginas}");
        }

        // Método privado para actualizar el número de páginas (solo personal autorizado)
        private void ActualizarPaginas(int nuevasPaginas)
        {
            paginas = nuevasPaginas;
        }

        // Método protegido: genera un resumen del libro
        protected string GenerarResumen()
        {
            return $"'{titulo}' de {autor}, con {paginas} páginas.";
        }

        // Método público que simula la modificación desde el personal autorizado
        public void ModificarPaginasBiblioteca(int nuevasPaginas)
        {
            Console.WriteLine("Actualizando número de páginas...");
            ActualizarPaginas(nuevasPaginas);
        }
    }
}
