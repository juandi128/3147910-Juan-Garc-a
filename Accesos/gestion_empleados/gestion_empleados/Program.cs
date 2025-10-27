using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_empleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== SISTEMA DE GESTIÓN DE EMPLEADOS ===\n");

            // Instanciar varios empleados
            Empleado emp1 = new Empleado("Juan Pérez", "Desarrollador", 3500000);
            Empleado emp2 = new Empleado("María López", "Diseñadora", 3000000);
            Gerente gerente1 = new Gerente("Carlos Ruiz", "Gerente General", 7000000, 1500000);

            // Mostrar datos
            Console.WriteLine("Empleado 1:");
            emp1.MostrarDatos();

            Console.WriteLine("\nEmpleado 2:");
            emp2.MostrarDatos();

            Console.WriteLine("\nGerente:");
            gerente1.MostrarDatos();
            gerente1.MostrarSalarioConBono();

            Console.ReadKey();
        }
    }
}
