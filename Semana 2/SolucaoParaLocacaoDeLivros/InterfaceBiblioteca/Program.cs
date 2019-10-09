using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LocacaoBiblioteca.Controller;
using LocacaoBiblioteca.Model;


namespace InterfaceBiblioteca
{
    class Program
    {
        static LivrosController livrosController = new LivrosController();
        static UsuarioController usuarioController = new UsuarioController();
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

            while (!RealizaLoginSistema())
                Console.WriteLine("Login e senha inválidos!");

            MostraMenuSistema();

            Console.ReadKey();
        }
        /// <summary>
        /// Mostra no console do menu disponível no istema.
        /// </summary>
        private static void MostraMenuSistema()
        {
           
            var menuEscolhido = int.MinValue;

            while(menuEscolhido !=0)
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE LOCAÇÃO DE LIVRO 1.0");

                Console.WriteLine("Menu Sistema");
                Console.WriteLine("1 - Listar usuários");
                Console.WriteLine("2 - Listar Livros");
                Console.WriteLine("3 - Cadastrar Livro");
                Console.WriteLine("4 - Trocar de Usuário");
                Console.WriteLine("5 - Cadastrar ID");
                Console.WriteLine("6 - Desativar usuário");
                Console.WriteLine("7 - Desativar livro");
                Console.WriteLine("0 - Sair");

                //menuEscolhido = int.Parse(Console.ReadKey().KeyChar.ToString());
                int.TryParse(Console.ReadKey().KeyChar.ToString(), out menuEscolhido);

                switch (menuEscolhido)
                {


                    case 7:
                        RemoverLivroPeloId();
                        break;

                    //Metodo que remove o usuario pela ID
                    case 6:
                        RemoverUsuarioPeloID();

                        break;

                    case 5:

                        AdicionarUsuario();
                        break;

                    case 4:

                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos!");
                        break;

                    case 3:
                        AdicionarLivro();
                        break;
                 
                    case 2:
                        MostrarLivro();
                        break;

                    case 1:
                        MostrarUsuarios();
                        break;
                            
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Saindo... até a próxima ");
                        break;

                        
                }

            }

            //Aqui vamos pegar número digitadado
            //Executar proxima função
        }
        private static void RemoverUsuarioPeloID()
        {
            Console.WriteLine("Remover um usuário pelo ID no sistema.");
            //Metodo que mostra os usuários criados anteriormente
            //o usuario informa o ID correto para desativar
            MostrarUsuarios();

            Console.WriteLine("Informe o ID para desativar do sistema:");
            var usuarioID = int.Parse(Console.ReadLine());

            //Aqui chamamos RemoverUsuarioPorID da nossa classe que controla os usuários do sistema
            usuarioController.RemoverUsuarioPorId(usuarioID);

            //Informamos que o usuario foi desativado
            Console.WriteLine("Usuário desativado.");
            Console.ReadKey();
        }
        private static void RemoverLivroPeloId()
        {
            Console.WriteLine("Remover um livro pela ID no sistema.");
            livrosController.GetLivros()
              .ToList<Livro>()
              .ForEach
              (x => Console.WriteLine(
                  $"Id: {x.Id} - Nome: {x.Nome}."));

            //Informamos ao usuário que ele precisa colocar o id para realizar alteração
            Console.WriteLine("Informe o Id para alteração de registro:");
            //Obtemos o Id informado
            var celularId = int.Parse(Console.ReadLine());

            //Método que 'remove' o celular de nosso sistema
            ////var resultado = livrosController.RemoverLivroPorId (); ////////////////// parei aqui


           /// if (resultado)//Apresentação do resultado da operação
             //   Console.WriteLine("Celular Removido Com Sucesso!");
          ///  else
             //   Console.WriteLine("Erro ao Remover Aparelho");
        }
        /// <summary>
        /// Metodo que adiciona dentro de nossa lista um novo registro de livro
        /// </summary>
        private static void AdicionarLivro()
        {
            //Identificamos que o mesmo está na parte de cadastro de livros do sistema
            Console.WriteLine("Cadastrar livro dentro do sistema:");
            //Informamos que para dar continuidade ele deve indormar um nome para o livro
            Console.WriteLine("Nome do livro para cadastro:");
            //Obtemos essa informação do usuário
            var nomeDoLivro = Console.ReadLine();

            //"livrosControllet" livros controle e nosso "objeto" em memoria
            //como  isso temos disponível nele ferramentas que nos ajudam a realizar as tarefas
            //como adicionar um item a nossa lista de livros
            livrosController.AdicionarLivro(new Livro()
            {
                //Aqui "atribuimos" o nome que demos ao livro na propriedade Nome de nosso livro
                //com o sinal de apenas "=" temos atribuição. passagem de valor
                Nome = nomeDoLivro
            });
            //Indico que finalizamos o processo de cadastro do livro, assim o usuario já sabe que o mesmo foi realizado e sem erros
            Console.WriteLine("Livro cadastrado com sucesso!");
            //ReadKey apenas para que ee visualiza esta informação
            Console.ReadKey();
        }
        private static void MostrarUsuarios()
        {
            usuarioController.RetornaListaDeUsuarios().ForEach(i => Console.WriteLine($"Id: {i.Id}  Login usuário:{i.Login}"));

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que realiza procedimento completo de login dentro dod sistema como colicitação de login e senha pelo console assim como a 
        /// respectiva validações que o mesmo precisa para entrar no sistema
        /// </summary>
        /// <returns>Retorna verdadeiro quando o login e senha informados stiverem corretos.</returns>
        private static bool RealizaLoginSistema()
        {
            Console.WriteLine("Informe seu login e senha para acessar o sistema:");

            Console.WriteLine("Login:");
            var loginDoUsuario = Console.ReadLine();

            Console.WriteLine("Senha:");
            var senhaDoUsuario = Console.ReadLine();

            Usuario usuario = new Usuario();


            usuario.Login = loginDoUsuario;
            usuario.Senha = senhaDoUsuario;


            return usuarioController.LoginSistema(new LocacaoBiblioteca.Model.Usuario()
            {
                Login = loginDoUsuario,
                Senha = senhaDoUsuario
            });

           
        }
        private static void MostrarLivro()
        {
            livrosController
                .RetornaListaDeLivros()
                .ForEach(i => Console.WriteLine($"ID:{i.Id} Nome do livro: {i.Nome}"));

            Console.ReadKey();
        }
        private static void AdicionarUsuario()
        {
            Console.WriteLine("Cadastrar usuário dentro do sistema!");
            Console.WriteLine("Informe o Login:");
            var loginUsuario = Console.ReadLine();

            Console.WriteLine("Informe uma senha:");
            var senhaUsuario = Console.ReadLine();

            usuarioController.AdicionarUsuario(new Usuario()
            {
                Login = loginUsuario,
                Senha = senhaUsuario
            });

            Console.WriteLine("Show, seu cadastro está feito!");
            Console.ReadKey();
        }
        
    }
}
