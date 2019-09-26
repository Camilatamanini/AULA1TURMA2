using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade17._09ListaCervejas
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaCerveja();
        }
        private static void ListaCerveja ()
        {
            
            var minhaLista = new List<string>();

            Console.WriteLine("Bora tomar uma?");

            minhaLista.Add("Patagônia");
            minhaLista.Add("Skol");
            minhaLista.Add("Original");
            minhaLista.Add("Colorado");
            minhaLista.Add("Polar");
            minhaLista.Add("Nossa");
            minhaLista.Add("Leffe");

            minhaLista.ForEach(item => Console.WriteLine(item));

            Console.ReadKey();
        }
    }
}
