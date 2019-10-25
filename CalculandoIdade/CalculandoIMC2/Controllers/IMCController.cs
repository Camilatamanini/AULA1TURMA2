using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIMC.Controllers
{
    public class IMCController : ApiController
    {
        public string Get(int peso, double altura, string nomeUsuario = default)
        {
            var imc = peso / (altura * altura);

            return $"Olá {nomeUsuario} seu IMC é {imc} e ele foi calculado de acordo com sua altura {altura} e seu peso {peso}";
        }
    }
}
