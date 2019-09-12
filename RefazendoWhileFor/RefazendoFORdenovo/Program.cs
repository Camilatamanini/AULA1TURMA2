using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefazendoFORdenovo
{
    class Program
    {
        static void Main(string[] args)
         
        {
            Console.WriteLine("Digite a palavra que deseja buscar no texto");
            var Camila = (Console.ReadLine());

            Console.WriteLine($"Encontados:{Camila}");
            Console.ReadKey();
        }
       
    }
}
