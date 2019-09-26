using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDePessoasRESUMO.Model
{
    public class Pessoas
    {
        public string Nome { set; get; }
        public int Id { set; get; }
        public DateTime DataNascimento { set; get; }
        public double Carteira { set; get; }
    }
}

