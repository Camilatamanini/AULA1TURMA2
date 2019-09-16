using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantidadeCaracteresNoTexto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira o texto abaixo");
            var textoLength = Console.ReadLine();

            Console.WriteLine($"O número de caracteres deste texto é: {textoLength.Replace(" ", " ").Length}");

            Console.ReadKey();
        }
    }
}
