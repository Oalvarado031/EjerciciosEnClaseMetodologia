using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazClaseViernes11Nov
{
    internal class Empleado
    {
        public int NumEmpleado { get; set; }
        public string NombreEmplado { get; set; }   
        public int DiasLab { get; set; }
        public Decimal SalDia { get; set; }

        public Decimal CalcularSalario(int DiasLab, Decimal SalDia)
        {
            return DiasLab * SalDia;
        }

    }
}
