using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades17._09MetroQuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoMQuadrado();
        }
        /// <summary>
        /// Calculo do metro quadrado 
        /// </summary>
        private static void CalculoMQuadrado()
        {
            Console.WriteLine("informe o valor em m do comprimento:");
            var comprimento = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Agora informe o valor em m da largura:");
            var largura = Convert.ToDouble(Console.ReadLine());

            var resultado = comprimento * largura;

            Console.WriteLine($"A área em m² é {resultado}");

            Console.ReadKey();
        }
    }
}
