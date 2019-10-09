using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Model
{
    public class Usuario : ControleDB
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(30)]
        [Required]
        public string Login { set; get; }
        [MaxLength(30)]
        [Required]
        public string Senha{set ; get; }
        [MaxLength(50)]
        public string Nome { get; set; }
    }
}
