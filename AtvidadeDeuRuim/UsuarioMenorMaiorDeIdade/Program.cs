using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioMenorMaiorDeIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            var nome = (UserName());
            Console.WriteLine($"Legal, {nome}. Meu nome é Compiuter.");
            Console.WriteLine("Qual a sua idade?");
            int idade = InformeIdade(nome);
            Console.ReadKey();
        }
        private static string UserName()
        {
            Console.WriteLine("Olá, como você se chama?");
            return (Console.ReadLine());
        }
        private static int InformeIdade(string nome)
        {
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)

                Console.WriteLine($"Legal, {nome}! Você já é maior de idade.");

            else

                Console.WriteLine($"Legal, {nome}, você ainda não pode ser preso!");
            return idade;
         }


    }
}
