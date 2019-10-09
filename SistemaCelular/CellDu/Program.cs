using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalagoCelulares.Model;
using CatalagoCelulares.Controller;


namespace CellDu
{
    class Program
    {
        // 1 - Colocar console app para startar o projeto
        // 2 - Adicionar referência CatalogoCelulares
        // 3 - Adicionar Entity em nosso projeto
        static CelularesController celulares = new CelularesController();
        static void Main(string[] args)
        {
            var opcao = int.MinValue;

            while (opcao != 0)
            {
                Console.WriteLine("Escolha um menu");
                Console.WriteLine("1 - Inserir Celular");
                Console.WriteLine("2 - Atualizar Celular");
                Console.WriteLine("3 - Remover Celular");
                Console.WriteLine("4 - Listar Celular");
                Console.WriteLine("0 - Sair");

                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        InserirCelular();                                     //Inserir
                        break;
                    case 2:
                        AtualizarCelular();
                        break;
                    case 3:
                        RemoverCelular();
                        break;
                    case 4:
                        ListarCelular();
                        break;
                    case 0:
                        Console.WriteLine("Saindo do sistema...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu inicial");
                Console.ReadKey(true);
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void InserirCelular()
        {
            Console.WriteLine("---Insirir Celular---");
            Console.WriteLine("Informe a marca do celular:");


            var marca = Console.ReadLine();

            Console.WriteLine("Informe o modelo do celular:");

            var modelo = Console.ReadLine();

            Console.WriteLine("Informe o preço do aparelho:");

            var preco = double.Parse(Console.ReadLine());

            var resultado = celulares
                .InserirCelular(new Celular()
                {
                    Marca = marca,
                    Modelo = modelo,
                    Preco = preco

                });

            if (resultado)
                Console.WriteLine("Celular cadastrado com sucesso!");
            else
                Console.WriteLine("Erro ao cadastrar aparelho!");


        }
        //ATUALIZAR
        public static void AtualizarCelular()
        {
            Console.WriteLine("---Atualizar Celular---");

            celulares.GetCelulares()                                                                            //Obtemos a lista de celulares
                .ToList<Celular>()                                                                              //Convertesmo para uma lista
                .ForEach(x =>                                                                                   //Laço de repetição para mostrar cada celular
                Console.WriteLine($"Id: {x.Id} - Marca: {x.Marca} - Modelo: {x.Modelo} - Preço: {x.Preco}"));   //Mostramos no console do celular

            Console.WriteLine("Informe O ID para alteraração de registro");                                     //Informamos ao usuário que ele precisa colocar o ID para realizar a alt
            var celularId = int.Parse(Console.ReadLine());                                                      //Obtemos o ID informado

            var celular = celulares                              //Obtemos do banco o ítem completo para atualizar
                .GetCelulares()  
                .FirstOrDefault( 
                x => x.Id == celularId);

            if (celular == null)
                Console.WriteLine("ID informado é inválido!");                 //Informamos que essa ID não consta no sistema


            celular.Marca = Console.ReadLine();                                //Obtemos a marca do aparelho

            Console.WriteLine("Informe o modelo do celular:");               

            celular.Modelo = Console.ReadLine();                              //Obtemos o modelo do aparelho

            Console.WriteLine("Informe o preço do aparelho:");

            celular.Preco = double.Parse(Console.ReadLine());                //Obtemos o valor do aparelho

            var resultado = celulares
                .AtualizarCelular(celular);
            if (resultado)
                Console.WriteLine("Celular atualizado com sucesso");
            else
                Console.WriteLine("A atualização não foi concluida!");
        }
        //REMOVER
        public static void RemoverCelular()
        {
            //Apresentamos a tela em que estamos
            Console.WriteLine("-- Remover Celular --");

            //Listamos aqui para identificar o item que vamos alterar
            celulares.GetCelulares()//Obtemos a lista de celulares
                .ToList<Celular>()//Convertemos para uma lista em memória
                .ForEach//Laço de repetição para mostrar cada celular
                (x => Console.WriteLine(//Mostramos no console nosso celular
                    $"Id: {x.Id}; Marca {x.Marca}; Modelo{x.Modelo}; Preço {x.Preco}"));

            //Informamos ao usuário que ele precisa colocar o id para realizar alteração
            Console.WriteLine("Informe o Id para alteração de registro:");
            //Obtemos o Id informado
            var celularId = int.Parse(Console.ReadLine());

            //Método que 'remove' o celular de nosso sistema
            var resultado = celulares.RemoverCelular(celularId);


            if (resultado)//Apresentação do resultado da operação
                Console.WriteLine("Celular Removido Com Sucesso!");
            else
                Console.WriteLine("Erro ao Remover Aparelho");
        }
        //LISTAR
        public static void ListarCelular()
        {
            //Apresentamos a tela em que estamos
            Console.WriteLine("-- Listar Celular --");

            //Listamos aqui para identificar o item que vamos alterar
            celulares.GetCelulares()//Obtemos a lista de celulares
                .ToList<Celular>()//Convertemos para uma lista em memória
                .ForEach//Laço de repetição para mostrar cada celular
                (x => Console.WriteLine(//Mostramos no console nosso celular
                    $"Id: {x.Id}; Marca {x.Marca}; Modelo{x.Modelo}; Preço {x.Preco}"));

        }
    }
}
