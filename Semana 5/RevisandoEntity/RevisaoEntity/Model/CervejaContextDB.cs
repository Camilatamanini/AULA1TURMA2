using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RevisaoEntity.Model
{
    public class CervejaContextDB : 
        DbContext // Herdamos nossa classe  DbContext que faz toda a parte de banco de dados 
    {
        public DbSet<Cerveja> Cervejas { get; set; }
    }
}
