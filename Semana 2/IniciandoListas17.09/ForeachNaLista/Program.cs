using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachNaLista
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaDecimais();
        }
        /// <summary>
        /// Mostra lista de datas definidas
        /// </summary>
        private static void ListaDateTime()
        {
            var minhasLista = new List<DateTime>();

            minhasLista.Add(new DateTime(2019, 9, 17));
            minhasLista.Add(new DateTime(2019, 9, 18));
            minhasLista.Add(new DateTime(2019, 9, 19));
            minhasLista.Add(new DateTime(2019, 9, 20).AddDays(99));

            minhasLista.ForEach(minhaData => Console.WriteLine(minhaData
                .ToLongDateString()));

            Console.ReadKey();
        }
        /// <summary>
        /// Mostra lista de String definidas
        /// </summary>
        private static void ListaString()
        {
            var minhasLista = new List<string>();

            minhasLista.Add("XIAOMI");
            minhasLista.Add("IPHONE APLLE");
            minhasLista.Add("SAMSUNG");
            minhasLista.Add("NOKIA");
            minhasLista.Add("MOTOROLA");

            minhasLista.ForEach(item => Console.WriteLine(item));

            Console.ReadKey();           
        }
        /// <summary>
        /// Mostra lista de números inteiros até o número 20
        /// </summary>
        private static void ListaNumerosInteiros()
        {
            var listaNumeros = new List<int>();
            listaNumeros.Add(1);
            listaNumeros.Add(2);
            listaNumeros.Add(3);
            listaNumeros.Add(4);
            listaNumeros.Add(5);
            listaNumeros.Add(6);
            listaNumeros.Add(7);
            listaNumeros.Add(8);
            listaNumeros.Add(9);
            listaNumeros.Add(10);
            listaNumeros.Add(11);
            listaNumeros.Add(12);
            listaNumeros.Add(13);
            listaNumeros.Add(14);
            listaNumeros.Add(15);
            listaNumeros.Add(16);
            listaNumeros.Add(17);
            listaNumeros.Add(18);
            listaNumeros.Add(19);
            listaNumeros.Add(20);

            listaNumeros.ForEach(meuNumero => Console.WriteLine(meuNumero));

            Console.ReadKey();
        }
        /// <summary>
        /// Mostra lista de números decimais
        /// </summary>
        private static void ListaDecimais()
        {
            var minhaLista = new List<double>();

            minhaLista.Add(1.00);
            minhaLista.Add(2.98);
            minhaLista.Add(3.87);
            minhaLista.Add(4.76);
            minhaLista.Add(5.65);
            minhaLista.Add(6.54);
            minhaLista.Add(7.43);
            minhaLista.Add(8.32);
            minhaLista.Add(9.21);

            minhaLista.ForEach(meuDecimal => Console.WriteLine(meuDecimal
                .ToString("C")
                + "     " + FormatarNumeroDecimalEmDolar(meuDecimal)
                + "     " + FormatarNumeroDecimalEmEuro(meuDecimal)
                + "     " + FormatarNumeroDecimalEmBitcoins(meuDecimal)
                + "     " + FormatarNumeroDecimalEmYen(meuDecimal)));




            Console.ReadKey();
        }
        /// <summary>
        /// Formatação de números decimais em dólares 
        /// </summary>
        /// <param name="meuNumero"></param> Meu número em reais
        /// <returns></returns> Retorna o número formatado em Dólares
        private static string FormatarNumeroDecimalEmDolar (double meuNumero)
        {
            return (meuNumero / 4.5008).ToString("C", CultureInfo.CreateSpecificCulture ("en-US"));
        }
        /// <summary>
        /// Metodo para converter Decimal em Euro
        /// </summary>
        /// <param name="meuNumero1"></param> Meu número em real
        /// <returns></returns> Retorna meu meu número formatado em Euro
        private static string FormatarNumeroDecimalEmEuro (double meuNumero1)
        {
            return (meuNumero1 / 4.53).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
            .Replace("$", "Euro: ");
        }
        /// <summary>
        /// Metodo para converter número decimal em BitCoin
        /// </summary>
        /// <param name="meuNumero2"></param> Meu número em Real
        /// <returns></returns> Retorna meu número formatado em BitCoin
        private static string FormatarNumeroDecimalEmBitcoins (double meuNumero2)
        {
            return (meuNumero2 / 41.946).ToString("C", CultureInfo.CreateSpecificCulture("en-US"))
            .Replace("$", "BTC: ");
        }
        /// <summary>
        /// Metodo para converter número decimal em Yel
        /// </summary>
        /// <param name="meuNumero3"></param> Meu número Real
        /// <returns></returns> Retorna meu número formatado em Yen
        private static string FormatarNumeroDecimalEmYen(double meuNumero3)
        {
            return (meuNumero3 / 0.038).ToString("C", CultureInfo.CreateSpecificCulture("ja-JP"));
        }

    }
}
