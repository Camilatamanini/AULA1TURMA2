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
        public UsuarioController()
        {
            ListaDeUsuarios = new List<Usuario>();

            ListaDeUsuarios.Add(new Model.Usuario()
            {
                Login = "admin",
                Senha = "admin"
            });
            ListaDeUsuarios.Add(new Model.Usuario()
            {
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
            return ListaDeUsuarios.Exists(x => x.Login == usuarios.Login && x.Senha == usuarios.Senha);

        }
        public List<Usuario> ListaDeUsuarios { get; set; }

    }
}
