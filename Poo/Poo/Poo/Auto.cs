using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poo
{
    internal class Auto
    {
        public string marca { get; set; } /* crean los atributos */

        public string modelo { get; set; }

        public int anio { get; set; }

        //Constructor 

        public Auto(string marca, string modelo, int anio)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = anio;
        }

        //Crear metodos

        public void MostrarInfo() // Metodo para mostrar la informacion del auto
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Año: " + anio);
        }
        //Crear los objetos 

       
       


        
    }
}
