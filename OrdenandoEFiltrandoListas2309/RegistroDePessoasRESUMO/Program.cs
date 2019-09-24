using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroDePessoasRESUMO.Controller;

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

            pessoaController.ListaDePessoasPublica
                .ForEach(i => Console.WriteLine(
                    $"Id: {i.Id} - " +
                    $"Nome: {i.Nome} - " +
                    $"Data de Nascimento: {i.DataNascimento.ToShortDateString()} - " +
                    $"Carteira:: {i.Carteira.ToString("N2")}"));

            Console.ReadKey();

        }
    }
}
