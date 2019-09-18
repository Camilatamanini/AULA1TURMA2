using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades17._09ListaCarros
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaCarros();
        }

        private static void ListaCarros()
        {
            var listaCarros = new List<string>();

            Console.WriteLine("Bibibibi - bibi - bibibibi - bibi - bibibibibibibibibbibibi");

            listaCarros.Add("A5");
            listaCarros.Add("Fusca");
            listaCarros.Add("Alfa Romeu");
            listaCarros.Add("HB20");
            listaCarros.Add("Santana");
            listaCarros.Add("Golf");
            listaCarros.Add("Uno");

            listaCarros.ForEach(item => Console.WriteLine(item));

            Console.ReadKey();
        }
    }
}
