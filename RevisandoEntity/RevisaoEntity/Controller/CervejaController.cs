using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevisaoEntity.Model;

namespace RevisaoEntity.Controller
{
    //Primeiro passo é deixar a classe pública
    public class CervejaController
    {
        CervejaContextDB contextDB = new CervejaContextDB();
        public void AddFCerveja(Cerveja item)
        {
            if (item.Nome.Contains("Cerveja"))
            {
                contextDB.Cervejas.Add(item);
                contextDB.SaveChanges();
            }
            contextDB.SaveChanges();
        }

        public IQueryable<Cerveja> GetCervejas()
        {
            return contextDB
                .Cervejas
                .Where(x => x.Nome.Contains("Cerveja"));
        }


    }
}
