using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaListaPulgmatica
{
    class Program
    {
        private static List<string> minhaListaPulgmatica01 = new List<string>()
            {
                "Camila",
                "Belinha",
                "Peralta",
                "Cristofer"
            };
        
        static void Main(string[] args)
        {
            AdicionarItensALista();

            ListaInformacoes();
           
           Console.ReadKey();
        }
        /// <summary>
        /// Metodo que adiciona um item na lista
        /// </summary>
        private static void AdicionarItensALista()
        {
            Console.Clear();
            Console.WriteLine("Informe um nome:");
            minhaListaPulgmatica01.Add(Console.ReadLine());
            Console.Clear();


            Console.WriteLine("Deseja informar mais valores? sim(S) não (N)");

            if (Console.ReadKey().KeyChar.ToString().ToLower() == "s")
                
                AdicionarItensALista();
        }

    /// <summary>
    /// Metodo que mostra a lista
    /// </summary>
        private static void ListaInformacoes()
        {
            Console.Clear();
            Console.WriteLine("Nomes adicionados a lista:");
            foreach (var item in minhaListaPulgmatica01)
                Console.WriteLine($"Nome: {item} foi adicionado a lista");
        }

    }

}
