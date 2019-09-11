using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //iniciando uma constante de um número inteiro
        const int testeConst = 999;

        static void Main(string[] args)
        {

            string testePrimitivo = string.Empty;
            String outroTestePrimitivo;
            bool testeComp;
            Boolean testComp;

            //O "?" permique que os valores que forem para ele sejam nulo - VALOR ANULAVEL 

            bool? testeNoolNull;

            int numeroInteiro = 999;
            long numeroInteiroLongo = 646547;



            var testeFora = string.Empty;
            testeFora = testeFora = "teste";

            var test1 = "String"; //Texto
            var test2 = 'A'; //Char
            var test3 = 8; //Int
            var test4 = 3.8; //Double
            var test5 = 0x0F; //Hex
            //Apresentando a Const
            Console.WriteLine(testeConst);
            Console.ReadKey();


        }
    }
}
