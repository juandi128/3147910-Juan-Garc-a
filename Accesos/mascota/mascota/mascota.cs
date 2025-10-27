using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mascota
{
    internal class mascota
    {
        // Atributos privados
        private string nombre;
        private int edad;
        private string tipo;
        private double peso;

        // Métodos SET (establecer valores)
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetEdad(int edad)
        {
            this.edad = edad;
        }

        public void SetTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public void SetPeso(double peso)
        {
            this.peso = peso;
        }

        // Métodos GET (obtener valores)
        public string GetNombre()
        {
            return nombre;
        }

        public int GetEdad()
        {
            return edad;
        }

        public string GetTipo()
        {
            return tipo;
        }

        public double GetPeso()
        {
            return peso;
        }

        // Método para mostrar información completa
        public void MostrarInformacion()
        {
            Console.WriteLine("=== INFORMACIÓN DE LA MASCOTA ===");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Edad: {edad} años");
            Console.WriteLine($"Tipo: {tipo}");
            Console.WriteLine($"Peso: {peso} kg");
            Console.WriteLine("=================================");
        }

        // Método para calcular edad en años humanos
        public int CalcularEdadHumana()
        {
            if (tipo.ToLower() == "perro")
            {
                return edad * 7;
            }
            else if (tipo.ToLower() == "gato")
            {
                return edad * 6;
            }
            else
            {
                return edad;
            }
        }
    }
}
