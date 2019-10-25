﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CalculandoIdade.Controllers
{
    public class CalculoIdadeController : ApiController
    {
        /// <summary>
        /// Retorna nome da aplicação
        /// </summary>
        /// <returns>Retorna o que nosso app faz</returns>
        public string Get()
        {
            return "App para poder beber hoje";
        }
        public string Get(int anoNascimento, string nomeUsuario = default)
        {
            if((DateTime.Now.Year - anoNascimento) >=18)
            {
                return $"Olá {nomeUsuario}, de acordo com os calculos realizados em nosso servidor, o nosso sistema" + 
                    "identifica que você poderá desfrutar de recursos hídricos alcóolicos";
            }
            else
            {
                return $"Olá {nomeUsuario} felizmnte as fazendas em nosso território possui leite e sucos naturais para você desfrutar";
            }
        }
    }
}
