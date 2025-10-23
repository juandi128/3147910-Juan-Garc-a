using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //                int[] numeros = new int[3];
            //                for (int i = 0; i< 3; i++)
            //                {
            //                    Console.WriteLine("Ingrese un numero:" + (i + 1) + ": ");
            //                    numeros[i] = int.Parse(Console.ReadLine());
            //}
            //                for (int i = 0; i< 3; i++)
            //                {
            //                    Console.WriteLine("Numero" + (i + 1) + ": " + numeros[i]);
            //                }



            //        //Ejericio 2
            //        //------EJERCICIO DE ARRAY------
            //        int[] numeros = new int[3];
            //        for (int i = 0; i < 3; i++)
            //        {
            //            Console.WriteLine("Ingrese el numero " + (i + 1) + ": ");
            //            numeros[i] = int.Parse(Console.ReadLine());
            //        }
            //        //Imprimir los numeros ingresados
            //        Console.WriteLine("Los numeros ingresados son:");
            //        for (int i = 0; i < 3; i++)
            //        {
            //            Console.WriteLine("Numero " + (i + 1) + ": " + numeros[i]);
            //        }

            //        //------EJERCICIO DE LISTA------
            //        List<int> numero = new List<int>();

            //        numero.Add(10);
            //        numero.Add(20);
            //        numero.Add(30);

            //        Console.WriteLine("Los numeros de la lista son:");
            //        foreach (int i in numero)
            //        {
            //            Console.WriteLine(i);
            //        }
            //        //Acceder a un elemento por su indice
            //        int segundoNumero = numero[1];
            //        Console.WriteLine("El segundo numero de la lista es: " + segundoNumero);

            //        //Modificar un elemento por su indice
            //        numero[1] = 25;
            //        Console.WriteLine("La lista despues de modificar el segundo numero:");
            //        foreach (int i in numero)
            //        {
            //            Console.WriteLine(i);
            //        }
            //        //Insertar un elemento en una posicion especifica
            //        numero.Insert(1, 15);//Insertar 15 en la posicion 1
            //        Console.WriteLine("La lista despues de insertar 15 en la posicion 1:");
            //        foreach (int i in numero)
            //        {
            //            Console.WriteLine(i);
            //        }
            //        //Eliminar un elemento por su valor
            //        numero.Remove(30);
            //        Console.WriteLine("La lista despues de eliminar el numero 30:");
            //        foreach (int i in numero)
            //        {
            //            Console.WriteLine(i);
            //        }
            //        //ordenar la lista
            //        numero.Sort();
            //        Console.WriteLine("La lista despues de ordenar:");
            //        foreach (int i in numero)
            //        {
            //            Console.WriteLine(i);
            //        }
            //    }
            //    //Ejerccio 3
            //    class product
            //    {
            //        //public string Name { get; set; }
            //        //public double Price { get; set; }

            //        //public product(string name, decimal price)
            //        //    {
            //        //    Name = name;
            //        //    Price = Price;

            //-------------------------AUTOS-----------------------------

            //Auto coche = new Auto("Toyota", "Corolla", 2020);
            //Auto coche2 = new Auto("Honda", "Civic", 2019);

            //coche.MostrarInfo();
            //coche2.MostrarInfo();
            //coche.anio = 2021; // Modificar el año del coche
            //coche.MostrarInfo(); // Mostrar la informacion actualizada del coche    

            //-------------------------APRENDIZ-----------------------------
            //        Console.WriteLine("Ingrese el nombre del aprendiz: ");
            //        string nombre = Console.ReadLine();
            //        Console.WriteLine("Ingrese la edad del aprendiz: ");
            //        int edad = int.Parse(Console.ReadLine());
            //        Console.WriteLine("Ingrese la direccion del aprendiz: ");
            //        string direccion = Console.ReadLine();

            //        // Crear el objeto aprendiz
            //        Aprendiz estudiante = new Aprendiz(nombre, edad, direccion);

            //        estudiante.VerificarEdad(); // Verificar si es mayor de edad
            //    }
            //}


            //-------------------------PRODUCTO CRUD----------------------------
            Producto productoCRUD = new Producto();
            bool continuar = true;

            while (true)
            {
                Console.WriteLine("Seleccione una opcion:");
                Console.WriteLine("1. Crear Producto");
                Console.WriteLine("2. Listar Producto");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        productoCRUD.CreateProducto();
                        break;
                    case 2:
                        productoCRUD.ReadProducto();
                        break;
                }
            }
        }
    }
}








