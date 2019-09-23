using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller
{
    public class LivrosController
    {
        private int IdContador = 0;
        public LivrosController()
        {
            ListaDeLivros = new List<Livro>();

            ListaDeLivros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Meu Primeiro Livro"
            });
            ListaDeLivros.Add(new Livro()
            {
                Id = IdContador++,
                Nome = "Meu Segundo Livro"
            });

        }
        /// <summary>
        /// Método que adiciona livros em nossa lista já "instanciada" criada dentro do construtor
        /// </summary>
        private List<Livro> ListaDeLivros { get; set; }
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = IdContador++;
            //Adicionamos o livro em nossa lista
            ListaDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return ListaDeLivros;
        }
    }
}
