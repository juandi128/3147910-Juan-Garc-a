using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace Estructura_de_control
//{
//internal class Program
//{
//static void Main(string[] args)

//{
//    Console.WriteLine("Ingrese un numero");
//    int numero = int.Parse(Console.ReadLine());



//    if (numero % 2 == 0)
//    {
//        Console.WriteLine("El numero es par");
//    }
//    else
//    {
//        Console.WriteLine("El numero es impar");
//    }


//ejercicio 2 
//using System;

//class Program
//{
//    static void Main()
//    {
//        double nota1, nota2, nota3, definitiva;

//        Console.Write("Ingrese la primera nota (20%): ");
//        while (!double.TryParse(Console.ReadLine(), out nota1) || nota1 < 1 || nota1 > 5)
//        {
//            Console.Write("Nota inválida. Ingrese un valor numérico entre 1 y 5: ");
//        }

//        Console.Write("Ingrese la segunda nota (30%): ");
//        while (!double.TryParse(Console.ReadLine(), out nota2) || nota2 < 1 || nota2 > 5)
//        {
//            Console.Write("Nota inválida. Ingrese un valor numérico entre 1 y 5: ");
//        }

//        Console.Write("Ingrese la tercera nota (50%): ");
//        while (!double.TryParse(Console.ReadLine(), out nota3) || nota3 < 1 || nota3 > 5)
//        {
//            Console.Write("Nota inválida. Ingrese un valor numérico entre 1 y 5: ");
//        }

//        definitiva = (nota1 * 0.2) + (nota2 * 0.3) + (nota3 * 0.5);

//        Console.WriteLine($"\nLa nota definitiva es: {definitiva:F2}");

//        if (definitiva >= 3.0)
//            Console.WriteLine("El estudiante APROBÓ.");
//        else
//            Console.WriteLine("El estudiante NO APROBÓ.");
//    }
//}


//Ejercicio 3 

//using System;

//class Program
//{
//    static void Main()
//    {
//        // Pedir al usuario el precio del producto
//        Console.Write("Ingrese el precio del producto: ");
//        double precio = double.Parse(Console.ReadLine());

//        // Calcular el precio final con el descuento
//        double precioFinal = precio;
//        if (precio >= 100000)
//        {
//            double descuento = precio * 0.2;
//            precioFinal = precio - descuento;
//        }

//        // Mostrar el precio final
//        Console.WriteLine($"El precio final del producto es: ${precioFinal:N2}");
//    }
//}


Ejercicos practios del taller 
    //Ejercicio 1

    using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el monto del préstamo: ");
        double monto = double.Parse(Console.ReadLine());
        double tasa = 0.05; // 5% anual
        int años = 5;

        double interesAnual = monto * tasa;
        double interesTrimestre = interesAnual / 4;
        double interesMensual = interesAnual / 12;
        double totalPagar = monto + (interesAnual * años);

        Console.WriteLine($"\nInterés en un año: ${interesAnual:F2}");
        Console.WriteLine($"Interés en el tercer trimestre: ${interesTrimestre:F2}");
        Console.WriteLine($"Interés en el primer mes: ${interesMensual:F2}");
        Console.WriteLine($"Total a pagar con intereses: ${totalPagar:F2}");
    }
}

Ejercicio 2
    using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el salario del empleado: ");
        double salario = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el valor de ahorro mensual programado: ");
        double ahorro = double.Parse(Console.ReadLine());

        double salud = salario * 0.125;
        double pension = salario * 0.16;
        double totalDeducciones = salud + pension + ahorro;
        double totalRecibir = salario - totalDeducciones;

        Console.WriteLine("\n--- COLILLA DE PAGO ---");
        Console.WriteLine($"Salario base: ${salario:F2}");
        Console.WriteLine($"Ahorro programado: ${ahorro:F2}");
        Console.WriteLine($"Descuento por salud (12.5%): ${salud:F2}");
        Console.WriteLine($"Descuento por pensión (16%): ${pension:F2}");
        Console.WriteLine($"Total a recibir: ${totalRecibir:F2}");
    }
}

