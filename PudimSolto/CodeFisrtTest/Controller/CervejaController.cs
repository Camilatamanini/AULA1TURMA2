using CodeFisrtTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFisrtTest.Controller
{
   public class CervejaController
   {
        CervejaContextDB contextDB = new CervejaContextDB(@"data source=(localdb)\MSSQLLocalDB;initial catalog=RevisaoEntity.Model.CervejaContextDB;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework");

        public void AddCerveja(Cervejas item)
        {
            contextDB.Cervejas.Add(item);
            contextDB.SaveChanges();
        }
   }
}
