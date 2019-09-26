using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDePessoas
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------PESSOAS CADASTRADAS---------------------------------");
            Console.WriteLine(" ");

            var cadastroPessoas = new List<Pessoas>();

            //SPEARS
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 0,
                Nome = "Spears",
                DataNascimento = DateTime.Parse("09/07/2011"),
                Carteira = 846.96
            });
            //SWANSON
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Swanson",
                DataNascimento = DateTime.Parse("20/06/2003"),
                Carteira = 233.09
            });
            //GAY
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 2,
                Nome = "Gay",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92
            });
            //GREGORY
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 3,
                Nome = "Gregory",
                DataNascimento = DateTime.Parse("02/01/2000"),
                Carteira = 469.01
            });
            //OSLON
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 4,
                Nome = "Olson",
                DataNascimento = DateTime.Parse("18/07/2001"),
                Carteira = 261.90
            });
            //GARZA
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 5,
                Nome = "Garza",
                DataNascimento = DateTime.Parse("01/04/2000"),
                Carteira = 360.41
            });
            //SWEET
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 6,
                Nome = "Sweet",
                DataNascimento = DateTime.Parse("12/03/2003"),
                Carteira = 312.76
            });
            //CLINE
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 7,
                Nome = "Cline",
                DataNascimento = DateTime.Parse("26/03/2002"),
                Carteira = 484.51
            });
            //OLIVER
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 8,
                Nome = "Oliver",
                DataNascimento = DateTime.Parse("05/07/2004"),
                Carteira = 513.76
            });
            //VANG
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 9,
                Nome = "Vang",
                DataNascimento = DateTime.Parse("10/07/2000"),
                Carteira = 271.05
            });
            //MADDOX
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 10,
                Nome = "Maddox",
                DataNascimento = DateTime.Parse("29/05/2004"),
                Carteira = 783.97
            });
            //GARRET
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 11,
                Nome = "Garret",
                DataNascimento = DateTime.Parse("03/06/2006"),
                Carteira = 154.11
            });
            //MCINTOSH
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 12,
                Nome = "Mcintosh",
                DataNascimento = DateTime.Parse("06/07/2006"),
                Carteira = 902.80
            });
            //YANG
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 13,
                Nome = "Yang",
                DataNascimento = DateTime.Parse("29/04/2005"),
                Carteira = 550.48
            });
            //HENDRICKS
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 14,
                Nome = "Hendricks",
                DataNascimento = DateTime.Parse("05/09/2003"),
                Carteira = 410.56
            });
            //CAIN
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 15,
                Nome = "Cain",
                DataNascimento = DateTime.Parse("12/01/2002"),
                Carteira = 221.13
            });
            //BLACKBURN
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 16,
                Nome = "Blackburn",
                DataNascimento = DateTime.Parse("10/05/2000"),
                Carteira = 135.67
            });
            //HOWE
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 17,
                Nome = "Howe",
                DataNascimento = DateTime.Parse("27/09/2005"),
                Carteira = 360.14
            });
            //PRATT
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 18,
                Nome = "Pratt",
                DataNascimento = DateTime.Parse("18/09/2000"),
                Carteira = 991.83

            });
            //SHERMANN
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 19,
                Nome = "Sherman",
                DataNascimento = DateTime.Parse("20/02/2003"),
                Carteira = 667.00

            });
            //ANA
            cadastroPessoas.Add(new Pessoas()
            {
                Id = 20,
                Nome = "Anna",
                DataNascimento = DateTime.Parse("15/09/1998"),
                Carteira = 900.00

            });




            #region LISTA EM ORDEM CRESCENTE PELO NOME

            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------ORDEM CRESCENTE PELO NOME------------------------------");
            Console.WriteLine(" ");
            //Apresetando a lista em ordem crescente pelo NOME
            cadastroPessoas.
                OrderBy(x => x.Nome).ToList<Pessoas>().
                ForEach(i =>
                Console.WriteLine($"Id: {i.Id} - Nome: {i.Nome} - Data de nascimento: {i.DataNascimento.ToShortDateString()} - Carteira: {i.Carteira}."));
            #endregion

            #region LISTA EM ORDEM DECRESCENTE PELA ID 
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------------ORDEM DECRESCENTE PELA ID------------------------------");
            Console.WriteLine(" ");
            //Apresentando a lista em ordem descrescente pelo ID
            cadastroPessoas.
                OrderByDescending(x => x.DataNascimento).ToList<Pessoas>().
                ForEach(i =>
                Console.WriteLine($"Id: {i.Id} - Nome: {i.Nome} - Data de nascimento: {i.DataNascimento.ToShortDateString()} - Carteira: {i.Carteira}."));
            #endregion

            #region LISTA DE PESSOAS COM MAIS DE 500,00 NA CARTEIRA
            Console.WriteLine(" ");
            Console.WriteLine("-----------------------------PESSOAS COM MAIS DE 500 REAIS-----------------------------");
            Console.WriteLine(" ");

            var filtroPessoas = cadastroPessoas
                //Aqui filtramos as pessoas que possuem mais de 500,00 na carteira
                .Where(x => x.Carteira > 500)
                //Ordenamos estes valores em ordem crescente dos NOMES
                .OrderBy(x => x.Nome);
            filtroPessoas.ToList<Pessoas>()
                .ForEach(i => Console.WriteLine($"Nome: {i.Nome} - Carteira: {i.Carteira}."));
            #endregion

            #region LISTA DE PESSOAS QUE POSSUEM MAIS DE 18 ANOS
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------MAIOR DE IDADE--------------------------------------");
            Console.WriteLine(" ");

            (from maiorIdade in cadastroPessoas
             where (DateTime.Today.Year - maiorIdade.DataNascimento.Year) >= 18 
             select maiorIdade).ToList<Pessoas>()
                              .ForEach(i => Console.WriteLine($"Nome: {i.Nome} - Data nascimento: {i.DataNascimento.ToShortDateString()}"));


            #endregion

            #region LISTA DE PESSOAS QUE POSSUEM MENOS DE 16 ANOS
            Console.WriteLine(" ");
            Console.WriteLine("---------------------------------MENOR DE 16 ANOS-------------------------------------");
            Console.WriteLine(" ");

            (from maiorIdade in cadastroPessoas
             where (DateTime.Today.Year - maiorIdade.DataNascimento.Year) <= 16 //Diminui a data atual das datas cadastradas
             select maiorIdade).ToList<Pessoas>()
                              .ForEach(i => Console.WriteLine($"Nome: {i.Nome} - Data nascimento: {i.DataNascimento.ToShortDateString()}"));


            #endregion

            Console.ReadKey();
        }


    }
}