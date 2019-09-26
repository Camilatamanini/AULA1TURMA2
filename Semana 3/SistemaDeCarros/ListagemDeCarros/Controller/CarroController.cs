using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListagemDeCarros.Model;

namespace ListagemDeCarros.Controller
{
    class CarroController
    {
        SistemaCarrosContext carrosContext = new SistemaCarrosContext();

        public List<Carro> GetCarros()
        {
            //Retornamos nossa lista de vendas sem nenhum filtro neste momento
                return carrosContext.ListaPublicaCarros;
        }
    }
}
