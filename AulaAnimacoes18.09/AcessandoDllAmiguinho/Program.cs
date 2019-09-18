using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MinhaBiBlioteca;

namespace AcessandoDllAmiguinho
{
    class Program
    {
        static void Main(string[] args)
        {
            MetroQuadradoDoColeguinha();
        }
        /// <summary>
        /// Aqui acessamos a árvore de um colega
        /// </summary>

        static void ArvoreDoAmiguinho()
        {
            AnimacoesEmFrames.Arvoree();
            Console.ReadKey();
        }
        /// <summary>
        /// Aqui acessamos a lista de cervejas escolhidas pelo colega
        /// </summary>
        static void CervejasDoAmiguinho()
        {
            listaDeCervejas.listaAmbev();
            Console.ReadKey();
        }
        /// <summary>
        /// Aqui acessamos a lista de carros escolhidas pelo colega
        /// </summary>
        static void CarrosDoAmiguinho()
        {
            ListaDeCarros.Listacar();
            Console.ReadKey();
        }
        /// <summary>
        /// Aqui se Deus quiser calculamos o Metro Quadrado com o código do colega
        /// </summary>
        static void MetroQuadradoDoColeguinha()
        {
            var dllDoAmiguinho = new MinhaBiBlioteca.CalculosDeArea();

            Console.WriteLine(dllDoAmiguinho.CalculaAreaDoQuadrado(int.Parse(Console.ReadLine())));
            
            Console.ReadKey();
        }
    }
}
