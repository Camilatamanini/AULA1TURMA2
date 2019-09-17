using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista2
{
    class Program
    {
        static void Main(string[] args)
        {
            var minhasLista = new List<string>();

            minhasLista.Add("XIAOMI");
            minhasLista.Add("IPHONE APLLE");
            minhasLista.Add("SAMSUNG");
            minhasLista.Add("NOKIA");
            minhasLista.Add("MOTOROLA");

            foreach (var item in minhasLista)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
