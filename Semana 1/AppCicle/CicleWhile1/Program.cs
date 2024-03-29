﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicleWhile1
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowInitAppText();
            int idade = 0;
            string nome = string.Empty;
            
            
            while(AskToContinue() == 1)
            {
               nome = AskToName();
               idade= AskToAge(nome);
            }

            Console.WriteLine($"Suas informações: Nome{nome} e sua idade{idade}");
            Console.ReadKey();
            
        }
        /// <summary>
        /// Metodo para mostrar o texto inicial do sistema alone
        /// </summary>

        private static void ShowInitAppText()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("--Seja bem vindo!--");
            Console.WriteLine("-------------------");
        }
        /// <summary>
        /// Metodo para realizar a perunta se deseja continuar
        /// </summary>
        /// <returns>retorna o valor que foi inserido</returns>
        private static int AskToContinue()
        {
            Console.WriteLine("Vamos conversar? sim (1) não (2)");
            return int.Parse(Console.ReadKey().KeyChar.ToString());

        }
        private static int AskToAge(string nome)
        {
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
                Console.WriteLine($"{nome}, você pode beber");
            else
                Console.WriteLine($"{nome}, tem leite na geladeira");

            return idade;     
        }
      
        private static string  AskToName()
        {
            Console.WriteLine("Qual seu nome?");
            return Console.ReadLine();

        }
    }
}
