using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MinhaBiblioteca;

namespace AcessandoInformacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuSistema();   
        }
        private static void MenuSistema()
        {
            Console.WriteLine("Escolha uma das opções do menu");
            Console.WriteLine("1 - Cálculo de área");
            Console.WriteLine("2 - Animação");
            Console.WriteLine("3 - Cervejas Ambev");
            Console.WriteLine("4 - Carangos");
            Console.WriteLine("5 - Sair do sistema");

            var menuEscolhido = int.Parse(Console.ReadLine());

            switch(menuEscolhido)
            {
                case 1:
                    {
                         CalculaArea();
                         MenuSistema();
                    }
                    break;

                case 2:
                    {
                        AnimacoesEmFrame.MinhaAnimacaoArvore();
                        MenuSistema();
                    }
                    break;

                case 3:
                    {
                        ListaAmbev.ListaCerveja();
                        MenuSistema();
                    }
                    break;
                case 4:
                    {
                        ListaCarangos.ListaCarros();
                        MenuSistema();
                    }
                    break;
                case 5:
                    {
                        Console.WriteLine("Escrevi e sai correndo....");
                        Thread.Sleep(500);
                        return;
                    }
                default:
                    break;

            }
        }
        public static void CalculaArea()
        {
            Console.WriteLine("Informe o lado do quadrado:");
            var ladoDoQuadrado = int.Parse(Console.ReadLine());

            var bibliotecaCalculos = new CalculosDeArea();

            Console.WriteLine($"Minha área é {bibliotecaCalculos.CAreaQuadrado(ladoDoQuadrado)}");
            Console.ReadKey();
        }
  
    }
}
