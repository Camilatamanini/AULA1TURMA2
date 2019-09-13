using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioMaiorMenorDeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = (NomeUsuario());
            int idade;

            Console.WriteLine($"Legal, {nome}! Me chamo Compiuter.");
            


        }
        private static string NomeUsuario()
        {
            Console.WriteLine("Olá, como você se chama?");
            return (Console.ReadLine());
        }
        private static int IdadeUsuario(string nome)
        {
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine($"{nome}, você pode beber");
            else
                Console.WriteLine($"{nome}, tem leite na geladeira");

            return idade;
        }
    }
}
