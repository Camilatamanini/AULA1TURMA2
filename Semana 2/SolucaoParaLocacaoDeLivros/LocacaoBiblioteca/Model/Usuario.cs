using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Login { set; get; }
        public string Senha{set ; get; }
        public bool Ativo { set; get; } = true;
        public int UsuarioCriacao { set; get; }
        public int UsuarioAlteracao { set; get; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataAlteracao { set; get; }
        public string Nome { get; set; }
    }
}
