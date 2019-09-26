using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CestoDeFrutas
{
    class Program
    {
        static void Main(string[] args)
        {
            FrutasNaCesta();
        }
        /// <summary>
        /// Aqui temos um código inteeeeiro de frutas na cesta em diversas formas
        /// </summary>
        static void FrutasNaCesta()
        {
            Console.WriteLine(" ");
            Console.WriteLine("---------CESTA DE FRUTAS--------");
            Console.WriteLine(" ");

            var cestaDeFrutas = new List<Fruta>();

            //Tomate
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 0,
                Nome = "Tomate",
                Cor = "Vermelho",
                Peso = 212
            });
            //Uva
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 1,
                Nome = "Uva",
                Cor = "Roxa",
                Peso = 4
            });
            //Banana
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 2,
                Nome = "Banana",
                Cor = "Amarelo",
                Peso = 86
            });
            //Melão
            cestaDeFrutas.Add(new Fruta()
            {
                Id = 3,
                Nome = "Melão",
                Cor = "Amarelo",
                Peso = 1000
            });

            #region Valores Decrescente Lista1

            //Neste ponto ordenamos os valores de forma decrescente pelo ID utilizando o "OrderByDescending"
            cestaDeFrutas.
                OrderByDescending(x => x.Id).ToList<Fruta>().
                ForEach(i =>
                Console.WriteLine($"Id: {i.Id} - Nome: {i.Nome} - Peso: {i.Peso}"));
            #endregion

            #region Valores Crescentes Lista2

            //Neste ponto ordenamos os valores de forma crescente pelo ID utilizando o "OrderBy"
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" ");

            cestaDeFrutas.
                OrderBy(x => x.Id).ToList<Fruta>().
                ForEach(i =>
                Console.WriteLine($"Id: {i.Id} - Nome: {i.Nome} - Peso: {i.Peso}"));

            #endregion

            #region Filtro de Pesos Lista3

            Console.WriteLine(" ");
            Console.WriteLine("---------FILTRO PESO-----------");
            Console.WriteLine(" ");


            var filtroCesta = cestaDeFrutas
                //Aqui filtramos os registros maiores de 100g
                .Where(x => x.Peso > 100)
                //Ordenamos estes valores pelos nomes
                .OrderBy(x => x.Nome);
            filtroCesta.ToList<Fruta>()
                .ForEach(i => Console.WriteLine($"Id: {i.Id} - Nome: {i.Nome} - Peso: {i.Peso}"));

            #endregion

            #region Escolhendo a Fruta Lista4

            Console.WriteLine(" ");
            Console.WriteLine("------ESCOLHENDO A FRUTA-------");
            Console.WriteLine(" ");
            (from frutinha in cestaDeFrutas
             where frutinha.Nome == "Tomate"
             select frutinha).ToList<Fruta>()
                              .ForEach(i => Console.WriteLine($"Fruta escolhida {i.Nome}"));

            #endregion

            #region Fruta > 100g Lista5

            Console.WriteLine(" ");
            Console.WriteLine("---------FRUTA>100G------------");
            Console.WriteLine(" ");
            //Frutinha recebe cada fruta de nossa cesta
            (from frutinha in cestaDeFrutas // Aqui temos a coleção de frutas
             where frutinha.Peso > 100 // Aqui escolhemos somente a fruta com mais de 100g
             select frutinha).ToList<Fruta>() //Aqui juntamos a informação filtrada e retorno
                              .ForEach(i => Console.WriteLine($"Fruta escolhida {i.Nome}")); // 
            #endregion

            #region Escolhendo a cor Lista6

            Console.WriteLine(" ");
            Console.WriteLine("-------ESCOLHENDO A COR--------");
            Console.WriteLine(" ");
            //Aqui criamos uma variavl que recebera o valor buscado
            var mostrandoFind = cestaDeFrutas.
                //Aqui é feito o filtro de informações por uma "ou --> || <---" outra cor
                //Esse escolhe somente uma cor - esse método retorna somente o primeiro que ele encontrou
                Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");

            Console.WriteLine($"Id: {mostrandoFind.Id} - Nome: {mostrandoFind.Nome}");
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" ");
            //Aqui criamos uma variavel que recebera a coleção que estamos buscando
            //Aqui ele retorna todas as cores que você solicitou
            var mostrandoFindAll = cestaDeFrutas.
                //FindAll com esta condição traz frutas de cor amarelha "ou" vermelhas
                FindAll(X => X.Cor == "Amarelo" || X.Cor == "Vermelho");
            mostrandoFindAll.ForEach(i => Console.WriteLine($"Id: {i.Id} - Nome: {i.Nome}"));

            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" ");
            //Aqui ordenamos a lista pelo nome 
            var listaOrdenada = mostrandoFindAll.OrderBy(x => x.Nome);
            //Como agora não é mais um List<Fruta> usamos o foreach para apresentar os valores 
            foreach (var item in listaOrdenada)
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome}");

            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(" ");
            var cestaDeFrutasFindOrder = cestaDeFrutas
                //Ordenei minha lista
                .OrderBy(x => x.Nome)
                //Converti para lista de frutas 
                .ToList<Fruta>()
                //busco minha informação
                .Find(x => x.Cor == "Amarelo" || x.Cor == "Vermelho");
            Console.WriteLine($"Id: {cestaDeFrutasFindOrder.Id} - Nome: {cestaDeFrutasFindOrder.Nome}");

            #endregion

            Console.ReadKey();

        }
    }
}
