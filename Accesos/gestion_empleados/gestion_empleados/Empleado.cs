using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_empleados
{
    internal class Empleado
        {
            // Atributos privados (encapsulación)
            private string nombre;
            private string cargo;
            private double salario;

            // Constructor
            public Empleado(string nombre, string cargo, double salario)
            {
                this.nombre = nombre;
                this.cargo = cargo;
                this.salario = salario;
            }

            // Métodos públicos para mostrar información general
            public void MostrarDatos()
            {
                Console.WriteLine($"Nombre: {nombre}");
                Console.WriteLine($"Cargo: {cargo}");
            }

            // Método privado para modificar salario (solo área administrativa)
            private void ModificarSalario(double nuevoSalario)
            {
                salario = nuevoSalario;
            }

            // Método protegido: permite que una subclase consulte el salario
            protected double ConsultarSalario()
            {
                return salario;
            }
        }
}
