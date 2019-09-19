using AtividadesMinhaClasse1909.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaClasseDeAmigos
{
    class Program
    {
        static void Main(string[] args)
        {
            var meusAmigos = new List<Amigos>();

            meusAmigos.Add(new Amigos()
            {
                Nome = "Alexandre ",
                TempoDeAmizade = 3285 

            });
            meusAmigos.Add(new Amigos()
            {
                Nome = "Caroline  ",
                TempoDeAmizade = 10
            });
            meusAmigos.Add(new Amigos()
            {
                Nome = "Cristoffer",
                TempoDeAmizade = 2555
            });

            meusAmigos.ForEach(i => Console.WriteLine(
               $"Nome: {i.Nome} " +
               " *** " +
               $"  Tempo de amizade: {i.TempoDeAmizade}"));

            Console.ReadKey();
        }
    }
}
