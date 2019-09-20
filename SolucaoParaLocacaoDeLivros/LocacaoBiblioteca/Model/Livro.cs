using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { set; get; }
        public bool Ativo { set; get; }
        public int UsuarioCriacao { set; get; }
        public int UsuarioAlteracao { set; get; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { set; get; }
    }
}
