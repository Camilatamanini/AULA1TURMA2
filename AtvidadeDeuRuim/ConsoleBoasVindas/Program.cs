using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBoasVindas
{
    class Program
    {
        static void Main(string[] args)
        {
            var Text = (@"Hernán Cattáneo nasceu em Buenos Aires, Argentina, onde cresceu ouvindo bandas como Simply Red, Level 42, Depeche Mode e New Order enquanto estudava carinhosamente a revista Billboard, única fonte de importação sobre música disponível na época. Em 1987, um amigo visitou a mostra Vinylmania, em Chicago, e lhe trouxe alguns discos de vinil, os primeiros que Hernán teve contato. Neste período, Frankie Knuckles, que viria a ser uma das maiores fontes de inspiração do argentino, começava a se firmar como um dos ícones da música eletrônica. Hernán Cattáneo considera que além de Frankie, outros artistas como Inner City e Derrick May combinaram a energia da música eletrônica européia com o soul da música americana, caracterizando as influências do argentino no começo de sua carreira.

Em 1994, Hernán Cattáneo passou a ser DJ residente do clube Clubland de Buenos Aires, local que recebia alguns dos músicos mais conceituados do mundo, como Sasha, John Digweed, Danny Tenaglia e Paul Oakenfold. Foi justamente com Paul Oakenfold que Hernán Cattáneo começou a ter seu trabalho divulgado a nível mundial. Com o inglês, percorreu os Estados Unidos nos anos de 1998 e 1999 apresentando-se em clubes famosos e prestigiosos festivais. Rapidamente, passou a ser residente nos clubes Cream de Liverpool e Ibiza e logo passou a fazer turnês ao redor do mundo.

Em 2004, Hernán lançou seu primeiro álbum, Renaissance Master Series. Passou a escrever como crítico especializado e colunista mensal na revista Rolling Stone latino-americana. No ano seguinte, lançou Renaissance Master Series - Volume 2 e promoveu o álbum dividindo o palco com artistas renomados como Chemical Brothers, The Prodigy, Coldplay, Nine Inch Nails e Kasabian.

Em Maio de 2006, através do próprio selo Renaissance, lançou o primeiro álbum da série Sequential, que rapidamente converteu-se em grande sucesso ganhando reconhecimento e prêmios de revistas como DJ Mag e M8, do Reino Unido. Em 2007, lançou o segundo disco da série, que também foi recebido com satisfação pela crítica.

Hernán Cattáneo demonstra suas habilidades nas mixagens através do seu programa semanal Resident na rádio FM Delta 90.3 de Buenos Aires e sua podcast e iTunes. O programa é transmitido todos os sábados, das 22h à 23h, horário local.");


            Console.WriteLine(@"Olá, seja bem vindo!
");
            Console.WriteLine($"Aqui temos a história do maravilhoso Hernan Cattaneo: {Text}");
            Console.WriteLine(@"
Pressione qualquer tecla para sair");

            Console.ReadKey();                             
        }

    }
}
