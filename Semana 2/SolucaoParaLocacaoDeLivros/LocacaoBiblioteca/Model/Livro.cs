using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class Livro : ControleDB
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)] //Delimitamos o tamanho do campo
        [Required]
        public string Nome { set; get; }

    }
}
