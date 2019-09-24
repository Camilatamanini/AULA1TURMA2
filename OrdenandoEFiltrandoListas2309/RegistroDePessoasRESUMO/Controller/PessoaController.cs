using RegistroDePessoasRESUMO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDePessoasRESUMO.Controller
{
    public class PessoaController
    {
        private List<Pessoas> listaDePessoas { get; set; }
        /// <summary>
        /// O método construtor ajuda a iniciar nossa classe para utilizarrmos de maneira correta correta as informações internas,
        /// com issso podemos iniciar nossa lista de pessoas sem depender do usuario ou programador na parte da interface  
        /// </summary>
        public PessoaController()
        {
            //iniciamos a lista dentro  do nosso método construtor
           listaDePessoas = new List<Pessoas>();
            #region LISTA DE PESSOAS CADASTRADAS
            //SPEARS
            listaDePessoas.Add(new Pessoas()
            {
                Id = 0,
                Nome = "Spears",
                DataNascimento = DateTime.Parse("09/07/2011"),
                Carteira = 846.96
            });
            //SWANSON
            listaDePessoas.Add(new Pessoas()
            {
                Id = 1,
                Nome = "Swanson",
                DataNascimento = DateTime.Parse("20/06/2003"),
                Carteira = 233.09
            });
            //GAY
            listaDePessoas.Add(new Pessoas()
            {
                Id = 2,
                Nome = "Gay",
                DataNascimento = DateTime.Parse("03/12/2001"),
                Carteira = 911.92
            });
            //GREGORY
            listaDePessoas.Add(new Pessoas()
            {
                Id = 3,
                Nome = "Gregory",
                DataNascimento = DateTime.Parse("02/01/2000"),
                Carteira = 469.01
            });
            //OSLON
            listaDePessoas.Add(new Pessoas()
            {
                Id = 4,
                Nome = "Olson",
                DataNascimento = DateTime.Parse("18/07/2001"),
                Carteira = 261.90
            });
            //GARZA
            listaDePessoas.Add(new Pessoas()
            {
                Id = 5,
                Nome = "Garza",
                DataNascimento = DateTime.Parse("01/04/2000"),
                Carteira = 360.41
            });
            //SWEET
            listaDePessoas.Add(new Pessoas()
            {
                Id = 6,
                Nome = "Sweet",
                DataNascimento = DateTime.Parse("12/03/2003"),
                Carteira = 312.76
            });
            //CLINE
            listaDePessoas.Add(new Pessoas()
            {
                Id = 7,
                Nome = "Cline",
                DataNascimento = DateTime.Parse("26/03/2002"),
                Carteira = 484.51
            });
            //OLIVER
            listaDePessoas.Add(new Pessoas()
            {
                Id = 8,
                Nome = "Oliver",
                DataNascimento = DateTime.Parse("05/07/2004"),
                Carteira = 513.76
            });
            //VANG
            listaDePessoas.Add(new Pessoas()
            {
                Id = 9,
                Nome = "Vang",
                DataNascimento = DateTime.Parse("10/07/2000"),
                Carteira = 271.05
            });
            //MADDOX
            listaDePessoas.Add(new Pessoas()
            {
                Id = 10,
                Nome = "Maddox",
                DataNascimento = DateTime.Parse("29/05/2004"),
                Carteira = 783.97
            });
            //GARRET
            listaDePessoas.Add(new Pessoas()
            {
                Id = 11,
                Nome = "Garret",
                DataNascimento = DateTime.Parse("03/06/2006"),
                Carteira = 154.11
            });
            //MCINTOSH
            listaDePessoas.Add(new Pessoas()
            {
                Id = 12,
                Nome = "Mcintosh",
                DataNascimento = DateTime.Parse("06/07/2006"),
                Carteira = 902.80
            });
            //YANG
            listaDePessoas.Add(new Pessoas()
            {
                Id = 13,
                Nome = "Yang",
                DataNascimento = DateTime.Parse("29/04/2005"),
                Carteira = 550.48
            });
            //HENDRICKS
            listaDePessoas.Add(new Pessoas()
            {
                Id = 14,
                Nome = "Hendricks",
                DataNascimento = DateTime.Parse("05/09/2003"),
                Carteira = 410.56
            });
            //CAIN
            listaDePessoas.Add(new Pessoas()
            {
                Id = 15,
                Nome = "Cain",
                DataNascimento = DateTime.Parse("12/01/2002"),
                Carteira = 221.13
            });
            //BLACKBURN
            listaDePessoas.Add(new Pessoas()
            {
                Id = 16,
                Nome = "Blackburn",
                DataNascimento = DateTime.Parse("10/05/2000"),
                Carteira = 135.67
            });
            //HOWE
            listaDePessoas.Add(new Pessoas()
            {
                Id = 17,
                Nome = "Howe",
                DataNascimento = DateTime.Parse("27/09/2005"),
                Carteira = 360.14
            });
            //PRATT
            listaDePessoas.Add(new Pessoas()
            {
                Id = 18,
                Nome = "Pratt",
                DataNascimento = DateTime.Parse("18/09/2000"),
                Carteira = 991.83

            });
            //SHERMANN
            listaDePessoas.Add(new Pessoas()
            {
                Id = 19,
                Nome = "Sherman",
                DataNascimento = DateTime.Parse("20/02/2003"),
                Carteira = 667.00

            });
            //ANA
            listaDePessoas.Add(new Pessoas()
            {
                Id = 20,
                Nome = "Anna",
                DataNascimento = DateTime.Parse("15/09/1998"),
                Carteira = 900.00

            });
        }
        #endregion

        /// <summary>
        /// Temos uma propriedade agora que nos retorna nossa lista com essa propriedade temos a lista completa e sem regras da lista
        /// de pessoas, mas ao liberar somente o GET não damos acesso para alterar fora de classe a lista apenas visualização
        /// </summary>
        public List<Pessoas> ListaDePessoasPublica
        {
            //No GET podemos retornar propriedade privada e calculo de metodos quando necessario
            get { return listaDePessoas; }
        }
        /// <summary>
        /// Método que retorna nossa lista de pessoas ordenada de forma asc pelo nome de cada uma
        /// </summary>
        /// <returns>Retornamos o valor já ordenado de nossa lista</returns>
        public List<Pessoas> GetPessoasOrdenadaAsce()
        {
            return listaDePessoas.OrderBy(x => x.Nome)
                .ToList<Pessoas>();
        }
        /// <summary>
        /// Método público que retorna a lista orenada pela data de nascimento da maior data para a menor data
        /// </summary>
        /// <returns>Lista ordenada</returns>
        public List<Pessoas> GetPessoasOrdenadaDescPelaDataNascimento()
        {
            return listaDePessoas.OrderByDescending(x => x.DataNascimento.ToLongDateString())
                .ToList<Pessoas>();
        }
        /// <summary>
        /// Metodo que retorna as pessoas com determinado valor dentro da carteira
        /// </summary>
        /// <param name="valor">Valor informado para o filtro</param>
        /// <returns></returns>
        public List<Pessoas> GetPessoasComMaisPilaNaCarteira(
            //Em caso de não informams o valor, ele fica 500 se ele não passar o valor informado pelo programador
            double valor = 500)
        {
            return listaDePessoas
                //Realizamos o filtro de busca
                .FindAll(x => x.Carteira > valor)
                //Ordenamos as informações
                //Convertemos para uma lista do tipo pessoa
                .ToList<Pessoas>();
        }
        public List<Pessoas>GetPessoasComIdantidadeMaiorA(int idade = 18)
        {
            return listaDePessoas
                .FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) >= idade);
        }
        public List<Pessoas> GetPessoasComIdadeMenorQue(int idade =16)
        {
            return listaDePessoas
                .FindAll(x => (DateTime.Now.Year - x.DataNascimento.Year) < idade);
        }
    }
}
