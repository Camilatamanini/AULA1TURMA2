using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.MODEL
{
    class SistemaCervejaContext
    {
        public int IdContadorCerveja { get; set; } = 1;
        private List<Cerveja> ListaDeCerveja { get; set; }

        public SistemaCervejaContext()
        {
            ListaDeCerveja = new List<Cerveja>();

            ListaDeCerveja.Add(new Cerveja() { Id = 1, Nome = "Goose Island Honkers,",Litros = 355, Alcool = 4.3, Valor = 1.0});
            ListaDeCerveja.Add(new Cerveja() { Id = 2, Nome = "Patagonia Bohemian,  ",Litros = 710, Alcool = 5.2, Valor = 1.2});
            ListaDeCerveja.Add(new Cerveja() { Id = 3, Nome = "Três Fidalgas,       ",Litros = 600, Alcool = 5.2, Valor = 1.3});
            ListaDeCerveja.Add(new Cerveja() { Id = 4, Nome = "Caracu,              ",Litros = 300, Alcool = 5.4, Valor = 1.4});
            ListaDeCerveja.Add(new Cerveja() { Id = 5, Nome = "Antarctica Original, ",Litros = 300, Alcool = 4.9, Valor = 1.6});
        }

        public List<Cerveja> ListaCervejaPublica { get { return ListaDeCerveja; } }

    }
}
