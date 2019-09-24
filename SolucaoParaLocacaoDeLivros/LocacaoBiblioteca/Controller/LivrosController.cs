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
        private LocacaoContext contextDB = new LocacaoContext();
        public LivrosController()
        {
            

        }
        /// <summary>
        /// Método que adiciona livros em nossa lista já "instanciada" criada dentro do construtor
        /// </summary>
        
        public void AdicionarLivro(Livro parametroLivro)
        {
            parametroLivro.Id = contextDB.IdContadorLivros++;
            //Adicionamos o livro em nossa lista
            contextDB.ListaDeLivros.Add(parametroLivro);
        }
        public List<Livro> RetornaListaDeLivros()
        {
            return contextDB.ListaDeLivros.Where(x => x.Ativo).ToList<Livro>();
        }
        /// <summary>
        /// Metodo para desativar o registro de livros pela ID
        /// </summary>
        /// <param name="identificandoId">ID do livro que vamos desativar</param>
        public void RemoverLivroPorId(int identificandoId)
        {
            var livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == identificandoId);

            if (livro != null)
                livro.Ativo = false;
        }
    }
}
