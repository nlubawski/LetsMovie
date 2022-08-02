using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsMovie.Presentation
{
    public static class SeriesMenus
    {
        public static void RegistrationTitle()
        {
            Console.WriteLine("##   Cadastro de Série   ##");
            Console.WriteLine("Digite o título da série:");
        }

        public static void RegistrationSeason()
        {
            Console.WriteLine("Digite a temporada que será adicionada:");
        }

        public static void RegistrationNumberEpisodes()
        {
            Console.WriteLine("Digite a quantidade de episódios da temporada:");
        }

        public static void SearchSerie()
        {
            Console.WriteLine("Digite o nome da série que deseja assistir:");
        }
    }
}
