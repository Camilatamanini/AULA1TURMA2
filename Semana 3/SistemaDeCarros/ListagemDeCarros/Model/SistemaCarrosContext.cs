using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCarros.Model
{
    class SistemaCarrosContext
    {
        private List<Carro> ListaDeCarros { get; set; }
        public SistemaCarrosContext()
        {
            ListaDeCarros = new List<Carro>();

            ListaDeCarros.Add(new Carro() { ID = 1,  Marca = "Volkswagen,", Modelo = "Polo",             Ano = 2017, Cilindrada = 1.0, Portas = 4 });
            ListaDeCarros.Add(new Carro() { ID = 2,  Marca = "Citroën,   ", Modelo = "C3 Start",         Ano = 2016, Cilindrada = 1.2, Portas = 4 });
            ListaDeCarros.Add(new Carro() { ID = 3,  Marca = "Fiat,      ", Modelo = "Argo"    ,         Ano = 2017, Cilindrada = 1.3, Portas = 4 });
            ListaDeCarros.Add(new Carro() { ID = 4,  Marca = "Volkswagen,", Modelo = "Jetta TSI",        Ano = 2019, Cilindrada = 1.4, Portas = 4 });
            ListaDeCarros.Add(new Carro() { ID = 5,  Marca = "Hyundai,   ", Modelo = "New Tucson GL",    Ano = 2016, Cilindrada = 1.6, Portas = 4 });
            ListaDeCarros.Add(new Carro() { ID = 6,  Marca = "Fiat,      ", Modelo = "Cronos Precision", Ano = 2018, Cilindrada = 2.0, Portas = 4 });
            ListaDeCarros.Add(new Carro() { ID = 7,  Marca = "Volkswagen,", Modelo = "Amarok Highline",  Ano = 2015, Cilindrada = 2.0, Portas = 4 });
            ListaDeCarros.Add(new Carro() { ID = 8,  Marca = "Nissan,    ", Modelo = "Frontier",         Ano = 2019, Cilindrada = 2.3, Portas = 4 });
            ListaDeCarros.Add(new Carro() { ID = 9,  Marca = "Audi,      ", Modelo = "TT"      ,         Ano = 2017, Cilindrada = 2.5, Portas = 4 });
            ListaDeCarros.Add(new Carro() { ID = 10, Marca = "Ferrari,   ", Modelo = "California",       Ano = 2014, Cilindrada = 3.8, Portas = 4 });

        }
        public List<Carro> ListaPublicaCarros { get { return ListaDeCarros; } }
    }    
}
