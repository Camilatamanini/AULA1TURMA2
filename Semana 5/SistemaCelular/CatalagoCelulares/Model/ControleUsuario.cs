using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatalagoCelulares.Model
{
    public class ControleUsuario
    {
        public bool Ativo { get; set; } = true; // Definimos o campo com  valor default 'true' paa nossos registros
        public int UsuarioCriacao { get; set; } = 0; // Definimos 0 para o usuário criado pelo sistema sem usuario logado
        public int UsuarioAlteracao { get; set; } = 0; // Definimos para alteração do sistema quando não logado usuário 0
        public DateTime DataCriacao { get; set; } = DateTime.Now; // Setamos nossa data de criação para a data atual pela DateTime
        public DateTime DataAlteracao { get; set; } = DateTime.Now; //Aqui definimos quando não informado para data de alteração a data atual
    }
}
