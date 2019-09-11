using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrizArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayLinear = new string[3] { "Peralta", "Belinha", "Tito" };

            List<string> listaLinear = new List<string>
            {
                "Peralta",
                "Belinha",
                "Tito"
            };

            Console.WriteLine(arrayLinear[0]);
            Console.WriteLine(listaLinear[0]);
            var keypress = Console.ReadKey().KeyChar.ToString();


        }
    }
}


