using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRelatorioCarros.Model
{
    public class Venda
    {
        public int Id { get; set; } // ID é composto por números inteiros, por isso utilizamos o "INT"
        public string Carro { set; get; } // CARRO é um nome, por isso utilizamos a "STRING"
        public double Valor { get; set; } // VALOR possui números com "," e por isso utilizamos o "DOUBLE"
        public int Quantidade { get; set; } // QUANTIDADE possui somente números inteiros, por isso utilizamos o "INT"
        public DateTime Data { get; set; } // DATA é, como já conhecemos, uma data. Pois isso utilizamos o "DATETIME"
    }
}
