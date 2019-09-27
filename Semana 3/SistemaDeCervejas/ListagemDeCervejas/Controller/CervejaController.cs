using ListagemDeCervejas.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListagemDeCervejas.Controller
{

    class CervejaController
    {

        static SistemaCervejaContext cervejaContext = new SistemaCervejaContext();
        static CervejaController cervejaController = new CervejaController();

        public List<Cerveja> GetCerveja()
        {
            //Retornamos nossa lista de vendas sem nenhum filtro neste momento
            return cervejaContext.ListaCervejaPublica.ToList<Cerveja>();
        }
        /// <summary>
        /// Método que utilizamos para adicionar uma cerveja na lista
        /// </summary>
        /// <param name="parametroCerveja"></param>
        public void AdicionarCerveja(Cerveja parametroCerveja)
        {
            parametroCerveja.Id = cervejaContext.IdContadorCerveja++;
            //Adicionamos a cerveja em nossa lista
            cervejaContext.ListaCervejaPublica.Add(parametroCerveja);
        }
        /// <summary>
        /// Método que faz a soma dos valores em minha lista de Cervejas
        /// </summary>
        public double SomaDasVendas(Cerveja somaValores)
        {
            return cervejaContext.ListaCervejaPublica.Sum(x => x.Valor);
        }
        /// <summary>
        /// Método que faz a soma total de L das cervejas.
        /// </summary>
        /// <param name="somaLitros"></param>
        /// <returns></returns>
        public double SomaDosLitros (Cerveja somaLitros)
        {
            return cervejaContext.ListaCervejaPublica.Sum(x => x.Litros);
        }
    }

}
