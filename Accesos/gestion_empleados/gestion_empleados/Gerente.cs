using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_empleados
{
    internal class Gerente : Empleado
    {
        private double bono;

        public Gerente(string nombre, string cargo, double salario, double bono)
            : base(nombre, cargo, salario)
        {
            this.bono = bono;
        }

        public void MostrarSalarioConBono()
        {
            double salarioTotal = ConsultarSalario() + bono;
            Console.WriteLine($"Salario con bono: ${salarioTotal}");
        }
    }
}
