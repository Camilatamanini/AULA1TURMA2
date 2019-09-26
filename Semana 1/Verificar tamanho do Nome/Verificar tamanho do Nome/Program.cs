using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verificar_tamanho_do_Nome
{
    class Program
    {
        static void Main(string[] args)

            //Aqui você informa o nome a ser calculado
        {
            Console.WriteLine("Informar o nome a ser calculado:");
            var nomeLenght = Console.ReadLine();

           //Aqui acontece o cálculo da variável
           // O estilo {nomeLenght.Lenght} calcula também os espaços
           //{nomeLenght.Replace(" "," ").Lenght} calcula somente as letras
            Console.WriteLine($"O tamanho deste nome é: {nomeLenght.Length}");
            Console.ReadKey();
                       
        }
    }
}
