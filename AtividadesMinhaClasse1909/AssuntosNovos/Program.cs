using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaClasseDeCadastros.Model;

namespace AssuntosNovos
{
    class Program
    {
             
        static void Heberficar(out int idade)
        {
            idade = 16000;
        }
        static void Main(string[] args)
        {

            List<Pessoas> pessoas = new List<Pessoas>();

            Pessoas p1 = new Pessoas();
            p1.Nome = "Camila";
            p1.Sexo = 'F';
            p1.Altura = 1.60;
            p1.Idade = 19;
            pessoas.Add(p1);

            Pessoas p2 = new Pessoas();
            p2.Nome = "Carol";
            p2.Sexo = 'F';
            p2.Altura = 1.63;
            p2.Idade = 23;
            pessoas.Add(p2);

            Pessoas p3 = new Pessoas();
            p3.Nome = "Peralta";
            p3.Sexo = 'M';
            p3.Altura = 1;
            p3.Idade = 3;
            pessoas.Add(p3);

            List<Pessoas> menoresIdade = new List<Pessoas>();

            foreach (Pessoas p in pessoas)
            {
                if(p.Idade<18)
                {
                    menoresIdade.Add(p);
                }

            }

            ///Ordem da lista (altura, idade, outros...)

            pessoas.Where(c => c.Altura > 2 && c.Nome.ToUpper
              ().StartsWith("E"));

            List<Pessoas> pessoasOrdernadasPorAltura = pessoas.OrderByDescending(p => p.Altura).ThenBy(c => c.Idade).ToList();





            List<int> numeros = new List<int>();

            Random rdm = new Random();

            

            for (int w = 0; w < 10; w++)
            {
                ///Gera um número aleatório de 0-100
                int valorGeradoAleatoriamente = rdm.Next(100);

                ///Verifica se a lista não contém este número gerado
                if(!numeros.Contains(valorGeradoAleatoriamente))
                {
                    ///Adiciona o número gerado pelo random (que não seja repetido)
                    numeros.Add(valorGeradoAleatoriamente);
                }
                else
                {
                    w--;
                }
            }
            Console.ReadKey();
        }
        static void Exercicios1()
        {
            {
                int ii = 30;
                Heberficar(out ii);
                Console.WriteLine(ii);

                int resultadodaConversao = 0;
                if (int.TryParse("kkk", out resultadodaConversao))
                {
                    Console.WriteLine("Show funcionou");
                }
                else
                {
                    Console.WriteLine("Puts, não funcionou");
                }


                List<string> nomes = new
                    List<string>();
            }
        }

    }
}
