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
        static LivrosController livros = new LivrosController();
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
                Console.WriteLine("0 - Sair");

                menuEscolhido = int.Parse(Console.ReadKey().KeyChar.ToString());

                switch (menuEscolhido)
                {
                    case 4:

                        while (!RealizaLoginSistema())
                            Console.WriteLine("Login e senha inválidos!");
                        break;

                 
                    case 2:
                        MostrarLivro();
                        break;

                    case 1:
                        MostraUsuarios();
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
        private static void MostraUsuarios()
        {
            usuarioController.ListaDeUsuarios.ForEach(i => Console.WriteLine($"Login usuário:{i.Login}"));

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

            UsuarioController usuarioController = new UsuarioController();

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
            livros.Livros.ForEach(i => Console.WriteLine($"Nome do livro: {i.Nome}"));
            Console.ReadKey();
        }
    }
}
