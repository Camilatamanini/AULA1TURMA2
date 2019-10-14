using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevisaoEntity.Model
{
    //Inicialmente devemos deixar a classe pública
    public class Cerveja
    {
        [Key] //Chave primária, auto incrementada que é chamada pelo ("ctrl" + ".")
        public int Id { get; set; }
        [StringLength(50)]// para nosso campo "Nome" dentro do banco de dados
        [Required]//Identifica que este campo é obrigatório = not null
        public string Nome { get; set; }
        [StringLength(30)]
        public string Tipo { get; set; }
        public double Teor { get; set; }
    }
}
