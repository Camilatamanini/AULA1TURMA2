using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoCelulares.Model
{
    public class Usuario : ControleUsuario
    {
        [Key] // Definindo como primary key e identity (1,1)
        public int Id { get; set; }
        [MaxLength(50)] //Delimitamos um tamanho máximo para o campo string
        public string Nome { get; set; }
        [MaxLength(30)] //Delimitamos o tamanho do campo
        [Required]
        public string Login { get; set; }
        [MaxLength(30)]//Delimitamos o tamanho do campo
        [Required]
        public string Senha { get; set; }
    }
}
