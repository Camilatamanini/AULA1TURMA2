using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoWhile
    //Como se fosse um hífen fazendo uma comparação
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = 0;

            while (count < 100001)
            {
                Console.WriteLine($"Número{count}");
                //count++ está incrementando de 1 em 1
                //count+=1 da o mesmo resultado que o count++ (basicamente na mesma velocidade); 
                //pode por para encrementar de 2 em 2 ou em 5 em 5...
                count+=10;

            }
            Console.WriteLine("Terminou o loop");
            Console.ReadKey();
        }
    }
}
