using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoCelulares.Model
{
    public class NewCelularesContextDB : DbContext // ":" definimos nossa herança --- "DbContext" define que vamos herdar toda a caixa de ferramentas do EntityFraework
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Celular> Celulares { get; set; }

    }
}
