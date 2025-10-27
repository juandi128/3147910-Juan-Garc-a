using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mascota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA DE GESTIÓN DE MASCOTAS");
            Console.WriteLine("===============================\n");

            // Crear primer objeto Mascota
            mascota mascota1 = new mascota();

            // Asignar valores usando métodos SET
            mascota1.SetNombre("Max");
            mascota1.SetEdad(3);
            mascota1.SetTipo("perro");
            mascota1.SetPeso(15.5);

            // Crear segundo objeto Mascota
            mascota mascota2 = new mascota();

            // Asignar valores usando métodos SET
            mascota2.SetNombre("Luna");
            mascota2.SetEdad(2);
            mascota2.SetTipo("gato");
            mascota2.SetPeso(4.2);

            // Mostrar información de la primera mascota
            Console.WriteLine("PRIMERA MASCOTA:");
            mascota1.MostrarInformacion();
            int edadHumana1 = mascota1.CalcularEdadHumana();
            Console.WriteLine($"Edad en años humanos: {edadHumana1} años\n");

            // Mostrar información de la segunda mascota
            Console.WriteLine("SEGUNDA MASCOTA:");
            mascota2.MostrarInformacion();
            int edadHumana2 = mascota2.CalcularEdadHumana();
            Console.WriteLine($"Edad en años humanos: {edadHumana2} años\n");

            // Ejemplo adicional con otro tipo de mascota
            mascota mascota3 = new mascota();
            mascota3.SetNombre("Paco");
            mascota3.SetEdad(5);
            mascota3.SetTipo("loro");
            mascota3.SetPeso(0.3);

            Console.WriteLine("TERCERA MASCOTA (ejemplo adicional):");
            mascota3.MostrarInformacion();
            int edadHumana3 = mascota3.CalcularEdadHumana();
            Console.WriteLine($"Edad en años humanos: {edadHumana3} años");

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
