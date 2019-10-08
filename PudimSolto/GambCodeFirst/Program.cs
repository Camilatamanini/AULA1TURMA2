using CodeFisrtTest.Controller;
using CodeFisrtTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GambCodeFirst
{
    class Program
    {
        static CervejaController cerveja = new CervejaController();
        static void Main(string[] args)
        {
            cerveja.AddCerveja(new Cervejas() { Nome = "Skol" });

            Console.ReadKey();
        }
    }
}
