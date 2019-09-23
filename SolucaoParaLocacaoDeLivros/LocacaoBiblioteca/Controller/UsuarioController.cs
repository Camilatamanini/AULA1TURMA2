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
        /// <summary>
        /// Criando privado para impedir o programador adc um ID ou alterar fora da classe
        /// </summary>
        private int IdContador = 0;
        public UsuarioController()
        {
            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Model.Usuario()
            {
                Id = IdContador++,
                Login = "admin",
                Senha = "admin"
            });
            ListaDeUsuarios.Add(new Model.Usuario()
            {
                Id = IdContador++,
                Login = "cami",
                Senha = "cami"
            });

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
            return RetornaListaDeUsuarios().Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);

        }
        private List<Usuario> ListaDeUsuarios { get; set; }
        /// <summary>
        /// Metodo usado para adicionar um novo usuario no sistema
        /// </summary>
        /// <param name="usuario">Novo usuario que sera adicinado a lista</param>
        public void AdicionarUsuario(Usuario usuario)
        {
            usuario.Id = IdContador++;
            //Adicionamos o usuário em nossa lista
            ListaDeUsuarios.Add(usuario);
        }
        /// <summary>
        /// Metodo que retorna nossa lista interna de usuários ativos
        /// </summary>
        /// <returns>Lista contendo usuários</returns>
        public List <Usuario> RetornaListaDeUsuarios()
        {
            //Retorna agora somente lista de usuários ativos com a expressão "Where(x=>x.Ativo)"
            return ListaDeUsuarios.Where(x=>x.Ativo).ToList<Usuario>();
        }
        /// <summary>
        /// Metodo que desativa um registro de usuário cadastrado em nossa lista 
        /// </summary>
        /// <param name="identificadoID">Parametro que identifica o usuario que será desativado</param>
        public void RemoverUsuarioPorId(int identificadoID)
        {
            //Aqui usamos o metodo FirstOrDefault para localizar nosso usuario dentro da lista 
            //com isso conseguimos acessar as propriedades dele e desativar o registro 
            ListaDeUsuarios.FirstOrDefault(x => x.Id == identificadoID).Ativo = false;
        }
    }

}
