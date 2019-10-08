using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RevisaoEntity.Model;
using RevisaoEntity.Controller;

namespace AplicacaoVisual
{
    class Program
    {
        //1 - Setar a aplicação visual para startar o projeto
        //2 - Vamos add EntityFraeWork ao nosso projeto
        //3 - Colocar em nosso 'using' o "using System.Data.Entity;"
        //4 - Adicionar a referência da nossa ClassLibrary

        static CervejaController cerveja = new CervejaController(); 

        static void Main(string[] args)
        {
            //cerveja.Cervejas.Add(new Cerveja() {Nome = "Camila"});
            // cerveja.SaveChanges();

            // cerveja.Cervejas.ToList<Cerveja>()
            //.ForEach(x => Console.WriteLine(x.Nome));

            cerveja.AddFCerveja(new Cerveja() { Nome = "Tônico Guaraná" });

            cerveja.GetCervejas()
                .ToList<Cerveja>()
                .ForEach(x => Console.WriteLine(x.Nome));

            Console.ReadKey();

        }
    }
}
