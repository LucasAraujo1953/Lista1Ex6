using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double mg;
            Console.WriteLine("Para calcular a média geométrica é necessário de dois valores");
            Console.Write("Informe o Primeiro valor: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Informe o Segundo valor: ");
            b = double.Parse(Console.ReadLine());

            // Operação
            mg = Math.Sqrt(a * b);

            Console.WriteLine("O resultado da média geométrica dos dois valores dados é {0}",mg);
        }
    }
}
