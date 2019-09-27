using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DllPastaWin;

namespace ListagemDePastas
{
    class Program
    {
        /// <summary>
        /// Instanciamos nossa classe principal
        /// </summary>
        static DocumentsAutoGenerate documents = new DocumentsAutoGenerate();
        static void Main(string[] args)
        {
            var menu = int.MinValue;

            while(menu !=0)
            {
                Console.Clear();
                Console.WriteLine("Sistema de pastas");
                Console.WriteLine("1 - Criar pastas em MeusDocumentos");
                Console.WriteLine("2 - Deletar pastas em MeusDocumentos");
                Console.WriteLine("3 - Listar MeusDocumentos");
                Console.WriteLine("0 - Sair.");

                menu = int.Parse(Console.ReadLine());

                switch(menu)
                {
                    //Informo para o usuário que ele deverá informar um nome para a pasta
                    case 1:
                        Console.WriteLine("Informe o nome:");
                        //Aqui obtemos o nome da pasta
                        var nomePasta = Console.ReadLine();
                        //Esse método como mostra na documentação cria a pasta com base no nome que passamos
                        documents.CriarPastaMeusDocumentos(nomePasta);
                        break;

                    case 2:
                        Console.WriteLine("Informar o nome da pasta para excluir:");
                        var nomePastaD = Console.ReadLine();
                        documents.DeletarPastaMeusDocumentos(nomePastaD, true);
                        break;

                    case 3:
                        //Obtemos a lista completa de pasta dentro dos meus documentos
                        documents.ObterPastasDiretorioMeuDocumentos()
                            //Apresentamos esta lista para o usuário
                            .ForEach(x => Console.WriteLine(x));
                        break;
                }
                Console.ReadKey();
            }
            documents.CriarPastaMeusDocumentos("CamilaPasta");

            documents.DeletarPastaMeusDocumentos("CamilaPasta", true);

            documents.ObterPastasDiretorioMeuDocumentos();
           
        }
    }
}
