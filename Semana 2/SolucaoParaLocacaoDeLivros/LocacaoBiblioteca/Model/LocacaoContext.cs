using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    class LocacaoContext: DbContext 
    {
        public DbSet<Livro> ListaDeLivros { get; set; }
        public DbSet<Usuario> ListaDeUsuarios { get; set; }
    }
}
