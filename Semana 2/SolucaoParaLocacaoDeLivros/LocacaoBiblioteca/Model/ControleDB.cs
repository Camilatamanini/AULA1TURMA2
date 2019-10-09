using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class ControleDB
    {
        public bool Ativo { set; get; } = true;
        public int UsuarioCriacao { set; get; } = 0;
        public int UsuarioAlteracao { set; get; } = 0;
        public DateTime DataCriacao { get; set; } = DateTime.Now;
        public DateTime DataAlteracao { set; get; } = DateTime.Now;
    }
}
