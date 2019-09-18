using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaBiblioteca
{
    public class CalculosDeArea
    {
        /// <summary>
        /// Metodo para retornar a área de um quadrado
        /// </summary>
        /// <param name="ladoDoQuadrado">Lado do quadrado com a precisão interira</param>
        /// <returns>Retorno a área total do quadrado</returns>
        public double CAreaQuadrado(int ladoDoQuadrado)
        {
            return ladoDoQuadrado*ladoDoQuadrado;
        }
    }
}
