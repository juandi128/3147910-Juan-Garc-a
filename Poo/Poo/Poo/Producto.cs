using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Producto
    {
        internal void CreateProducto()
        {
            throw new NotImplementedException();
        }

        internal void ReadProducto()
        {
            throw new NotImplementedException();
        }
    }

    namespace ProgramacionOrientadaaObjetos
    {
        internal class Producto
        {
            public int _id { get; set; }

            public string _nombre { get; set; }

            public decimal _precio { get; set; }

            public Producto(int id, string nombre, decimal precio)
            {
                _id = id;
                _nombre = nombre;
                _precio = precio;
            }

            public class ProductoCRUD
            {
                public List<Producto> producto = new List<Producto>();
                public int siguienteid;

                public void CreateProducto()
                {
                    Console.WriteLine("Ingrese el nombre del producto:");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el precio del producto:");
                    decimal precio = decimal.Parse(Console.ReadLine());

                    Producto nuevoProducto = new Producto(siguienteid++, nombre, precio); //incrementa el id automaticamente
                    producto.Add(nuevoProducto);
                }

                public void ReadProducto()
                {
                    foreach (var producto in producto)
                    {
                        Console.WriteLine($"ID: {producto._id}, Nombre: {producto._nombre}, Precio: {producto._precio}");
                    }
                }
            }
        }
    }
}
                    
