using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosPublicos
{

    public class Program
    {
        static void Main(string[] args)
        {
        
        }
        /// <summary>
        /// Metodo principal para a inicialização do programa
        /// </summary>
        public static void ConversorMonetarioSis()
        {
            Console.WriteLine("***Sistema conversor de moedas***");
            Console.WriteLine("Informe um valor a ser convertido:");

            var valorASerConvertido = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe uma moeda para a conversão");
            Console.WriteLine("** DOLAR ** EURO ** YEN ** BTC **");

            var moedaAlvoParaConverter = Console.ReadLine();

            ConvertMoeda(valorASerConvertido, moedaAlvoParaConverter);

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que converte moeda em real para um alvo especifico
        /// Para converter, digite os alvos:
        /// - "EURO"
        /// - "YEN"
        /// - "BTC"
        /// - "DOLAR"
        /// </summary>
        /// <param name="minhaMoeda">Meu número em reais</param>
        /// <param name="moedaAlvo">Alvo em que a moeda será convertida</param>
        public static void ConvertMoeda (double minhaMoeda, string moedaAlvo)
        {
            
            switch(moedaAlvo)
            {
                case "DOLAR":
                    Console.WriteLine(FormataNumeroDecimalEmDolar(minhaMoeda));
                    break;
                case "EURO":
                    Console.WriteLine(FormatarNumeroDecimalEmEuro(minhaMoeda));
                    break;
                case "YEN":
                    Console.WriteLine(FormatarNumeroDecimalEmYen(minhaMoeda));
                    break;
                case "BTC":
                    Console.WriteLine(FormatarNumeroDecimalEmBitcoins(minhaMoeda));
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Método que converte meu número em real para DÓLARES
        /// </summary>
        /// <param name="minhaMoeda">Meu número em reais</param>
        /// <param name="moedaAlvo">Retorna o  valor formatado em DÓLARES</param>
        private static string FormataNumeroDecimalEmDolar(double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C2", CultureInfo.CreateSpecificCulture("en-US"));
        }
        /// <summary>
        /// Método que converte meu número em real para EURO
        /// </summary>
        /// <param name="minhaMoeda">Meu número em reais</param>
        /// <param name="moedaAlvo">Retorna o  valor formatado em EURO</param>
        private static string FormatarNumeroDecimalEmEuro(double meuNumero1)
        {
            return (meuNumero1 / 4.53).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
            .Replace("$", "Euro: ");
        }
        /// <summary>
        /// Método que converte meu número em real para YEN
        /// </summary>
        /// <param name="minhaMoeda">Meu número em reais</param>
        /// <param name="moedaAlvo">Retorna o  valor formatado em YEN</param>
        private static string FormatarNumeroDecimalEmYen (double meuNumero2)
        {
            return (meuNumero2 / 0.038).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
        }
        /// <summary>
        /// Método que converte meu número em real para BTC
        /// </summary>
        /// <param name="minhaMoeda">Meu número em reais</param>
        /// <param name="moedaAlvo">Retorna o  valor formatado em BTC</param>
        private static string FormatarNumeroDecimalEmBitcoins(double meuNumero3)
        {
            return (meuNumero3 / 41.946).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
            .Replace("$", "BTC: ");
        }

    }
}
