using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApiListaDeNomes.Models;

namespace WebApiListaDeNomes.Controllers
{
    public class PessoaController : ApiController
    {
        List<Pessoa> Pessoas = new List<Pessoa>()
        {
            new Pessoa() {Nome = "Camila", Idade= 19},
            new Pessoa() {Nome = "Cristoffer", Idade= 22},
            new Pessoa() {Nome = "Tito", Idade= 22},
            new Pessoa() {Nome = "Peralta", Idade= 3},
            new Pessoa() {Nome = "Belinha", Idade= 7},
            new Pessoa() {Nome = "Neusa", Idade= 59},
            new Pessoa() {Nome = "João", Idade= 59},
            new Pessoa() {Nome = "Maicon", Idade= 40},
            new Pessoa() {Nome = "Suzana", Idade= 40},
            new Pessoa() {Nome = "Princesa", Idade= 2},
        };

        public List<Pessoa> Get()
        {
            return Pessoas;
        }

        public Pessoa Post(Pessoa item)
        {
            Pessoas.Add(item);

                return item;
        }
    }
}