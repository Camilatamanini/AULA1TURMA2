using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    class LocacaoContext
    {
        /// <summary>
        /// Propriedade que armazena o ID dos livros adicionados ao sistema
        /// </summary>
        public int IdContadorLivros { get; set; } = 1;
        public int IdContadorUsuario { get; set; } = 1;
        /// <summary>
        /// Metodo construtor que repara nossa classe LOCACAOCONTEXT
        /// </summary>
        public LocacaoContext()
        {
            ListaDeLivros = new List<Livro>();
            //Criamos um lista de usuários em memória
            ListaDeUsuarios = new List<Usuario>();

            
            //Add os livros
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Meu Primeiro Livro"
            });
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Meu Segundo Livro"
            });
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContadorLivros++,
                Nome = "Meu Terceiro Livro"
            });

            //Adcionamos o usuario
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuario++,
                Login = "adm",
                Senha = "adm"
            });
            ListaDeUsuarios.Add(new Usuario()
            {
                Id = IdContadorUsuario++,
                Login = "adm",
                Senha = "123"
            });
        }
             public List<Livro> ListaDeLivros { get; set; }
             public List<Usuario> ListaDeUsuarios { get; set; }


    }
}
