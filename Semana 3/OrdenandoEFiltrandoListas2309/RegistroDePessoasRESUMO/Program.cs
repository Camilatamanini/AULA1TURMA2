using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroDePessoasRESUMO.Controller;
using RegistroDePessoasRESUMO.Model;

namespace RegistroDePessoasRESUMO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui carregamos nossa caixa de ferramentas de pessoas podemos agora listar e demais funcionalidades

            PessoaController pessoaController
                //Nessa parte ao iniciar em memoria
                //Iniciamos o construtor
                = new PessoaController();

            //Aqui acessamos nossa lista de pessoas
            pessoaController.ListaDePessoasPublica
                //Usamos o Foreach do linq para percorrer a lista
                .ForEach(i => MostraInformacoes(i)); //=> criamos a variavel i para receber o item da nossa lista
                                                     //Imprimimos a informação de cada item em nossa lista

             MostraIdentificador("LISTA ORDENADA POR NOME");
            pessoaController.GetPessoasOrdenadaAsce()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador("------LISTA ORDENADA POR DATA------");
            pessoaController
                .GetPessoasOrdenadaDescPelaDataNascimento()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador("LISTA ORDENADA POR VALOR NA CARTEIRA");
            pessoaController
                .GetPessoasComMaisPilaNaCarteira(500)
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador($"-LISTA ORDENADA PESSOAS MAIOR A {18}-");
            pessoaController
                .GetPessoasComIdantidadeMaiorA()
                .ForEach(i => MostraInformacoes(i));

            MostraIdentificador($"-LISTA ORDENADA PESSOAS MENOR A {16}-");
            pessoaController
                .GetPessoasComIdadeMenorQue()
                .ForEach(i => MostraInformacoes(i));



            Console.ReadKey();

        }
        /// <summary>
        /// Metodo para mostrar informação inicial de cada listagem
        /// </summary>
        /// <param name="nomeAcao">Identificador da listagem</param>
        private static void MostraIdentificador(string nomeAcao)
        {
            Console.WriteLine(string.Format("-----------------{0,20}---------------------", nomeAcao));
        }
        private static void MostraInformacoes (Pessoas pessoas)
        {
            //Nosso template que apresenta as informações bonitinhas
            string template = "Id: {0,-3} - Nome: {1,-10} - Nascimento: {2,-10} - Carteira: {3,-5}";
            //Recebemos as informações bonitinhas com o string format

            string textoFormatado = 
                //string.Format é usado para formatar as string deixando nosso texto padrão e apresentável
                string.Format(
                    //Nosso primeiro parametro é o templante que usamos
                    template, 
                    //Após informar o templante, temos o parametro
                    //esse método espera um array de parametros ou seja
                    //podemos passar muitos parametros nele
                    pessoas.Id, 
                    pessoas.Nome,
                    //Formatamos a data de nascimento para apresentar a informação reduzida
                    pessoas.DataNascimento.ToShortDateString(), 
                    //Aqui apresenta em valor monetario de acordo com as config local da maquina
                    pessoas.Carteira.ToString("C"));

            Console.WriteLine(textoFormatado);
        }
    }
}
