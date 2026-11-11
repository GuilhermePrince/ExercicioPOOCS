using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExercicioPOOCS
{
    public class Funcionario
    {
        public string? Nome { get; set; }
        public string? Cargo { get; set; }
        public decimal Salario { get; private set; }

        public decimal AumentarSalario(decimal aumentoPercentual)
        {
            Salario = Salario * (1 + aumentoPercentual);
        }
        public decimal ConsultarSalario()
        {
            Console.WriteLine($"Salário: {Salario}");
            return Salario;
        }
    }
}