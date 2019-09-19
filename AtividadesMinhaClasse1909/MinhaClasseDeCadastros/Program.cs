using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaClasseDeCadastros.Model;

namespace MinhaClasseDeCadastros
{
    class Program
    {
        static void Main(string[] args)
        {
            var cadastroPessoas = new List<Pessoas>();
            var objetoPessoa = new Pessoas();

            Console.WriteLine("Insira seu nome completo:");
            objetoPessoa.Nome = Console.ReadLine();

            Console.WriteLine($"Quantos anos você tem, {objetoPessoa.Nome}?");
            objetoPessoa.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual seu sexo? Feminino (F) ou Masculino (M)");
            objetoPessoa.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Para finalizar, me diga sua altrura:");
            objetoPessoa.Altura = double.Parse(Console.ReadLine());

            cadastroPessoas.Add(objetoPessoa);

            cadastroPessoas.ForEach(i=> Console.WriteLine($@"Agora vamos confirmar seus dados:
Nome: {i.Nome}
Idade: {i.Idade}
Sexo: {i.Sexo}
Altura: {i.Altura}"));

            Console.WriteLine(@"Cadastro realizado com sucesso!
Aperte qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
