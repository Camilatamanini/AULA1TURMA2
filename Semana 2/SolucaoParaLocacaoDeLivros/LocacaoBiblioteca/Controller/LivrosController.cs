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
        LocacaoContext contextDB = new LocacaoContext();
        public IQueryable<Livro> GetLivros()
        {
            return contextDB                       //Acesso ao banco de dados
                .ListaDeLivros                     //Nossa tabela de banco de dados
                .Where(x => x.Ativo == true);      // As condições do filtro
        }

        public bool AdicionarLivro(Livro parametroLivro)
        {
            if (string                      //Nosso tipo que contem vários metodos prontos para string
                .IsNullOrWhiteSpace         //Método que identifica espaços em branco ou Valor null -- "IsNullOrWhiteSpace" verifica/impede cadastros em espaços totalmente brancos
                (parametroLivro.Nome))       //Campo que vamos validar
                return false;
                   
            contextDB.ListaDeLivros.Add(parametroLivro);          
            contextDB.SaveChanges();                

            return true;
        }
        public bool RemoverLivroPorId(int id)
        {
            var livro = contextDB.ListaDeLivros.FirstOrDefault(x => x.Id == id);

            if (livro == null)
                return false;
            livro.Ativo = false;

            contextDB.SaveChanges();
            return true;
        }                              
    }                                 
}                 
