using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compactar_Texto
{
    class Program
    {
        static void Main(string[] args)

            //Aqui eu calculo a quantidade de carcteres que há em meu texto.
        {
            var primeiroTexto = "Oi meu nome é Camila e eu Camila amo meus cachorros Peralta e Belinha que desobedecem muito a Camila e mordem muito a Camila porque o Peralta e a Belinha são doidos.";

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contém: {primeiroTexto.Length} caracteres.");

            //Aqui vamos calcular o mesmo texto, porém com a transformação de "Camila" em "1"

            primeiroTexto = primeiroTexto.Replace("Camila", "1");

            //Aqui calculamos o mesmo texto acima, porem com os nomes "Belinha" e "Peralta" trocados pelos números "3" e "2".

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contém: {primeiroTexto.Length} caracteres.");

            primeiroTexto = primeiroTexto.Replace("Belinha", "2")
                .Replace("Peralta", "3");


            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contém: {primeiroTexto.Length} caracteres.");

            //AGORA VAMOS FAZER TUDO AO CONTRÁRIO 

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contém: {primeiroTexto.Length} caracteres.");

            primeiroTexto = primeiroTexto.Replace("1", "Camila")
                .Replace("2", "Belinha")
                .Replace("3", "Peralta");

            Console.WriteLine(primeiroTexto);
            Console.WriteLine($"Texto contém: {primeiroTexto.Length} caracteres.");



            Console.ReadKey();

        }
    }
}
