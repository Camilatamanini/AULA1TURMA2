using SistemaRelatorioCarros.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaRelatorioCarros.Model;

namespace InterfaceSistemaRelatorio
{
    class Program
    {
        static VendasController vendasController = new VendasController();
        static void Main(string[] args)
        {
            MostraMenuRelatorio();
            Console.WriteLine("Informações das vendas realizadas durante o ano de 2019");
            vendasController.GetVendas().ForEach(i => ImprimeInformacoes(i));
            

            Console.ReadKey();
        }
        private static void MostraMenuRelatorio()
        {
            Console.Clear();

            Console.WriteLine("---Menu de relatórios---");
            Console.WriteLine("1 - Relatório por período mensal");
            Console.WriteLine("2 - Relatório anual");
            Console.WriteLine("0 - Sair");

            var menuEscolhido = int.MinValue;

            while(menuEscolhido !=0)
            {
                menuEscolhido = int.Parse(Console.ReadLine());
                switch(menuEscolhido)
                {
                    case 1:
                        {
                            Console.WriteLine("Informe o mês para realizar o filtro");
                            //Obtemos a informação do mês
                            var mesEscolhido = int.Parse(Console.ReadLine());

                            var listaDoPeriodoEscolhido = vendasController.GetVendas(mesEscolhido);
                            //Passamos o mês na mesma função para obter as vendas
                            listaDoPeriodoEscolhido                                                                                                                                                                                           
                                //Aqui imprimimos as informações para o usuário
                                .ForEach(i => ImprimeInformacoes(i));

                            var totalMes = listaDoPeriodoEscolhido
                                //Somamos todos os registros multiplicando o valor "venda" vezes a "quantidade"
                                .Sum(x => x.Valor * x.Quantidade);

                            var mediaPeriodo = listaDoPeriodoEscolhido
                                .Average(x => x.Valor * x.Quantidade);

                            //Mostramos o mês escolhido e o valor total do mês
                            Console.WriteLine($"O total do mês {mesEscolhido} é {totalMes}");
                            //Mostramos a média das vendas do mês escolhido
                            Console.WriteLine($"A média do mês {mesEscolhido} é {totalMes.ToString("C")}");

                            Console.ReadKey();
                        }
                        break;
                }
            }
        }
        public static void ImprimeInformacoes (Venda venda)
        {
            //esse "-3" é para o texto começar da esquerda para a direita
            Console.WriteLine(
                string.Format("ID: {0,-3}  Carro: {1,-20}  Valor: {2,-10}  Quantidade: {3,-3}  Data: {4,-12}"
                ,venda.Id
                ,venda.Carro
                ,venda.Valor.ToString("C")
                ,venda.Quantidade
                ,venda.Data.ToShortDateString()));
        }
        
    }
}
