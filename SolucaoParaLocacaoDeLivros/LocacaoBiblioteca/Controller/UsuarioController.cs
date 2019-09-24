using LocacaoBiblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocacaoBiblioteca.Controller

{
    
    
    /// <summary>
    ///  Classe que contem os métodos de usuários do sistema
    /// </summary>
    public class UsuarioController
    {
        private LocacaoContext contextDB = new LocacaoContext();
        /// <summary>
        /// Criando privado para impedir o programador adc um ID ou alterar fora da classe
        /// </summary>

        public UsuarioController()
        {
            
        }

        /// <summary>
        /// Metodo que realiza o login dentro do nosso sistema
        /// Para realizar o login padrão. usa-se:
        /// -Login: Admin
        /// -Senha: Admin
        /// 
        /// Usamos o BOOL para saber se conseguimos entrar, ou não no computador.
        /// o BOOL segue somente a lógica do SIM ou NÃO.
        /// </summary>
        /// <param name="Usuário">Passamos um obj de nome Usuário para o parametro</param>
        /// <returns>Retorna verdadeiro quando existir o usuário com este login e senha</returns>
        public bool LoginSistema(Usuario usuarios)
        {
            //Metodo que já está validade por ativo ou inativo
            return RetornaListaDeUsuarios().Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);
        }
        
        public void AdicionarUsuario(Usuario usuario)
        {
            usuario.Id = contextDB.IdContadorUsuario++;
            //Adicionamos o usuário em nossa lista
            contextDB.ListaDeUsuarios.Add(usuario);
        }
        /// <summary>
        /// Metodo que retorna nossa lista interna de usuários ativos
        /// </summary>
        /// <returns>Lista contendo usuários</returns>
        public List <Usuario> RetornaListaDeUsuarios()
        {
            //Retorna agora somente lista de usuários ativos com a expressão "Where(x=>x.Ativo)"
            return contextDB.ListaDeUsuarios.Where(x=>x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// Metodo que desativa um registro de usuário cadastrado em nossa lista 
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorId(int identificadoID)
        {
            //Aqui usamos o metodo FirstOrDefault para localizar nosso usuario dentro da lista 
            //com isso conseguimos acessar as propriedades dele e desativar o registro 
            contextDB.ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }
        
    }

}
