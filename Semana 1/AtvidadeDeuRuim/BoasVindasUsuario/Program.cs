using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoasVindasUsuario
{
    class Program
    {
        static void Main(string[] args)
        {
            var usuario = SolicitaNome();
            Console.WriteLine($"Legal, {usuario}! Seja bem vindo.");
            var idade = SolicitaIdade();
            Console.WriteLine($"Que nome bonito, {usuario}, nem parece que tem {idade} anos");
            Console.ReadKey();
        }

        private static string SolicitaIdade()
        {
            Console.WriteLine("Informe sua idade");
            return (Console.ReadLine());
        }

        private static string SolicitaNome()
        {
            Console.WriteLine("Olá, como você se chama?");
            return (Console.ReadLine());
        }
   
    }
}
