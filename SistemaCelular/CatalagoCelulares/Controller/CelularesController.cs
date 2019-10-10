using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatalagoCelulares.Model;

namespace CatalagoCelulares.Controller
{
    //1 - Usar nossa pasta model
    //2 - Criar uma instância nova da nossa Context
    public class CelularesController
    {
        NewCelularesContextDB contextDB = new NewCelularesContextDB();
        //LISTAGEM
        /// <summary>
        /// Metodo que retorna apenas nossa lista de celulares ativos
        /// </summary>
        /// <returns></returns>
        public IQueryable<Celular> GetCelulares()
        {
            return contextDB                       //Acesso ao banco de dados
                .Celulares                         //Nossa tabela de banco de dados
                .Where(x => x.Ativo == true);      // As condições do filtro
        }
        //ATUALIZAÇÃO
        /// <summary>
        /// Metodo que atualiza um registro válido do nosso sistema
        /// </summary>
        /// <param name="item">Item que vamos atualizar</param>
        /// <returns>Retorna veridadeiro, caso o item exista</returns>
        public bool AtualizarCelular (Celular item)
        {
            var celular =                    // Definimos uma variável para o celular
                contextDB                    // Usamos o banco de dados
                .Celulares                   //Nossa tabela que tem os celulares
                .FirstOrDefault              //Buscamos em nossa tabela o celular
                (x=>x.Id == item.Id);        //Regra para realizar a busca
            if (celular == null)             //Verificamos se ele encontrou um celular
                return false;                //Caso não tenha encontrado, retorna falso
            else
            {
                item.DataAlteracao = DateTime.Now;
            }
            contextDB.SaveChanges();         //Salvamos a informação no banco 
            return true;                     //Retornamos que foi atualizado
        }
        /// <summary>
        /// Metodo que valida e insere os registros dentro do nosso sistema
        /// </summary> 
        /// <param name="item"></param>
        /// <returns></returns>
        //INSERÇÃO
        public bool InserirCelular (Celular item)
        {
            if (string                      //Nosso tipo que contem vários metodos prontos para string
                .IsNullOrWhiteSpace         //Método que identifica espaços em branco ou Valor null -- "IsNullOrWhiteSpace" verifica/impede cadastros em espaços totalmente brancos
                (item.Marca))               //Campo que vamos validar
                return false;

            if (string
                .IsNullOrWhiteSpace
                (item.Modelo))
                return false;

            if (item.Preco <= 0)                      //Verificamos se o valor informado é maior a 0
                return false;                         //Caso não seja, reotna para fora do método
            contextDB.Celulares.Add(item);            //Salvamos nosso item dentro de nossa tabela em memoria
            contextDB.SaveChanges();                  // Retornamos verdadeiro para identificat na insersão do registro

            return true;
        }

        //"REMOÇÃO"
        /// <summary>
        /// Método utilizado para apenas desativar o item dentro de nosso sistema
        /// </summary>
        /// <param name="id"> Id que vamos desativar</param>
        /// <returns>Retorna verdadeiro em caso de sucesso!</returns>
        public bool RemoverCelular(int id)
        {
            var celular =                                   //Nossa variável
                contextDB                                   //Nosa base de dados
                .Celulares                                  //Tabela de celular
                .FirstOrDefault(x => x.Id == id);           //Buscamos o item para desativar
                                    
            if (celular == null)                            //Verificamos se este tem existe
                return false;                               //Caso não, ele sai de nosso método

            celular.Ativo = false;                          //Desativamos o item

            contextDB.SaveChanges();                        //Salvamos em nosso banco
            return true;                                    //Retorna verdadeiro
        }
    }
}
